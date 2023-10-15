#pragma warning disable CS8602
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

using GematriaWizard.Utility;
using GematriaWizard.Utility.Exceptions;
using GematriaWizard.Utility.Validation;

namespace GematriaWizard.Dictionary
{
    public struct Character : IEquatable<Character>, IComparable<Character>, IGematriaPhrase, IHebrewGematriaPhrase, IEnglishGematriaPhrase, ISimpleGematriaPhrase
    {
        private char value;

        public Character(char value, short hebrewGemaatria, byte englishGematria, byte simpleGematria)
        {
            this.value = value;
            this.HebrewGematria = hebrewGemaatria;
            this.EnglishGematria = englishGematria;
            this.SimpleGematria = simpleGematria;
        }

        public char Value 
        {
            get { return this.value; }
            private set
            {
                if (GematriaValidator.ValidateCharacter(value))
                {
                    this.value = value;
                }
                else
                {
                    throw new GematriaException($"{value} is not a value Gematria character");
                }
            } 
        }

        public short NumericValue { get { return (short)this.Value; } }

        public short HebrewGematria { get; private set; }

        public short EnglishGematria { get; private set; }

        public short SimpleGematria { get; private set; }

        public override int GetHashCode()
        {
            return this.SimpleGematria;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder($"{{{Environment.NewLine}");

            var properties = typeof(Character).GetProperties();

            if (properties.Any())
            {
                var prop = properties.First();
                stringBuilder.AppendLine($"\t{prop.Name}: {prop.GetValue(this)}");

                foreach (var property in properties.Skip(1))
                {
                    stringBuilder.AppendLine($"\t,{property.Name}: '{property.GetValue(this)}'");
                }
            }

            stringBuilder.AppendLine("}");

            return stringBuilder.ToString();
        }

        public override bool Equals(object? obj)
        {
            try
            {
#pragma warning disable CS8605 // Unboxing a possibly null value.
                return Equals((Character)obj);
#pragma warning restore CS8605 // Unboxing a possibly null value.
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Equals(Character other)
        {
            return this.Value.Equals(other.Value);
        }

        public int CompareTo(Character other)
        {
            return this.Value.CompareTo(other.Value);
        }

        int IComparable<IGematriaPhrase>.CompareTo(IGematriaPhrase? other)
        {
            return this.NumericValue.CompareTo(other.NumericValue);
        }

        bool IEquatable<IGematriaPhrase>.Equals(IGematriaPhrase? other)
        {
            return this.NumericValue.Equals(other.NumericValue);
        }

        int IComparable<IHebrewGematriaPhrase>.CompareTo(IHebrewGematriaPhrase? other)
        {
            return this.HebrewGematria.CompareTo(other.HebrewGematria);
        }

        bool IEquatable<IHebrewGematriaPhrase>.Equals(IHebrewGematriaPhrase? other)
        {
            return this.HebrewGematria.Equals(other.HebrewGematria);
        }

        int IComparable<IEnglishGematriaPhrase>.CompareTo(IEnglishGematriaPhrase? other)
        {
            return this.EnglishGematria.CompareTo(other.EnglishGematria);
        }

        bool IEquatable<IEnglishGematriaPhrase>.Equals(IEnglishGematriaPhrase? other)
        {
            return this.EnglishGematria.Equals(other.EnglishGematria);
        }

        int IComparable<ISimpleGematriaPhrase>.CompareTo(ISimpleGematriaPhrase? other)
        {
            return this.SimpleGematria.CompareTo(other.SimpleGematria);
        }

        bool IEquatable<ISimpleGematriaPhrase>.Equals(ISimpleGematriaPhrase? other)
        {
            return this.SimpleGematria.Equals(other.SimpleGematria);
        }
    }
}