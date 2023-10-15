using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GematriaWizard.Utility.Extensions;

namespace GematriaWizard.Dictionary
{
    public class Phrase : IList<Character>, IGematriaPhrase, IHebrewGematriaPhrase, IEnglishGematriaPhrase, ISimpleGematriaPhrase
    {
        private List<Character> phrase = new List<Character>();

        #region Constructors

        public Phrase() { }

        public Phrase(IEnumerable<Character> expression)
        {
            foreach (var character in expression)
            {
                phrase.Add(character);
            }
        }

        #endregion

        public string Value
        {
            get
            {
                if (!this.phrase.Any())
                {
                    return String.Empty; ;
                }

                var stringBuilder = new StringBuilder(this.phrase.First().Value);

                foreach (var character in this.phrase.Skip(1))
                {
                    stringBuilder.Append(character.Value);
                }

                return stringBuilder.ToString();
            }
        }

        public static Phrase CreatePhrase(string text)
        {
            var phrase = new Phrase();

            foreach (var c in text)
            {
                phrase.Add(CharacterMap.GetCharacter(c));
            }

            return phrase;
        }

        #region ICollection<Character>

        public Character this[int index] 
        { 
            get => this.phrase[index];
            set => this.phrase[index] = value;
        }

        public int Count => phrase.Count;

        public bool IsReadOnly => false;

        public void Add(Character item)
        {
            this.phrase.Add(item);
        }

        public void Clear()
        {
            this.phrase.Clear();
        }

        public bool Contains(Character item)
        {
            return this.phrase.Contains(item);
        }

        public void CopyTo(Character[] array, int arrayIndex)
        {
            this.phrase.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Character> GetEnumerator()
        {
            return this.phrase.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.phrase.GetEnumerator();
        }

        public int IndexOf(Character item)
        {
            return this.phrase.IndexOf(item);
        }

        public void Insert(int index, Character item)
        {
            this.phrase.Insert(index, item);
        }

        public bool Remove(Character item)
        {
            return this.phrase.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this.phrase.RemoveAt(index);
        }

        #endregion

        #region IGematriaPhrase

        public short NumericValue => (short)phrase.Sum(character => character.NumericValue);

        int IComparable<IGematriaPhrase>.CompareTo(IGematriaPhrase? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            return this.NumericValue - other.NumericValue;
        }

        bool IEquatable<IGematriaPhrase>.Equals(IGematriaPhrase? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            return this.NumericValue.Equals(other.NumericValue);
        }

        #endregion

        #region IHebrewGematriaPhrase

        public short HebrewGematria => (short)phrase.Sum(character => character.HebrewGematria);

        int IComparable<IHebrewGematriaPhrase>.CompareTo(IHebrewGematriaPhrase? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return this.HebrewGematria.CompareTo(other.HebrewGematria);
        }

        bool IEquatable<IHebrewGematriaPhrase>.Equals(IHebrewGematriaPhrase? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return this.HebrewGematria.Equals(other.HebrewGematria);
        }

        #endregion

        #region IEnglishGematriaPhrase

        public short EnglishGematria => (short)this.phrase.Sum(character => character.EnglishGematria);

        int IComparable<IEnglishGematriaPhrase>.CompareTo(IEnglishGematriaPhrase? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return this.EnglishGematria.CompareTo(other.EnglishGematria);
        }

        bool IEquatable<IEnglishGematriaPhrase>.Equals(IEnglishGematriaPhrase? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return this.EnglishGematria.Equals(other.EnglishGematria);
        }

        #endregion

        #region ISimpleGematriaPhrase

        public short SimpleGematria => (short)this.phrase.Sum(character => character.SimpleGematria);

        int IComparable<ISimpleGematriaPhrase>.CompareTo(ISimpleGematriaPhrase? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return this.SimpleGematria.CompareTo(other.SimpleGematria);
        }

        bool IEquatable<ISimpleGematriaPhrase>.Equals(ISimpleGematriaPhrase? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return this.SimpleGematria.Equals(other.SimpleGematria);
        }

        #endregion
    }
}
