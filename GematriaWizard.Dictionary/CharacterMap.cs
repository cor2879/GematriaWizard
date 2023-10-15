#pragma warning disable CS8600, CS8618, CS8605
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GematriaWizard.Dictionary
{
    public class CharacterMap
    {
        public static readonly CharacterMap instance = CreateCharacterMap();
        private Dictionary<char, Character> characterMap = new Dictionary<char,Character>();
        
        private CharacterMap() { }

        public Character this[char hash]
        {
            get { return this.characterMap[hash]; }
        }

        public static Character GetCharacter(char hash)
        {
            return instance[hash];
        }

        private void Add(char hash, Character value)
        {
            this.characterMap[hash] = value;
        }

        private void Clear()
        {
            this.characterMap.Clear();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder($"{{{Environment.NewLine}");

            foreach (var hash in this.characterMap.Keys.Take(1))
            {
                stringBuilder.AppendLine($"'{hash}': {characterMap[hash]}");
            }

            foreach (var hash in this.characterMap.Keys.Skip(1))
            {
                stringBuilder.AppendLine($",'{hash}': {characterMap[hash]}");
            }

            stringBuilder.AppendLine("}");
            return stringBuilder.ToString();
        }

        public static string ToText()
        {
            return CharacterMap.instance.ToString();
        }

        private static CharacterMap CreateCharacterMap()
        {
            var characterMap = new CharacterMap();

            var constants = typeof(Constants);

            var fields = constants.GetFields(BindingFlags.Static | BindingFlags.Public);

            foreach (var field in fields)
            {
                var character = (Character)field.GetValue(null);

                characterMap.Add(character.Value, character);
                characterMap.Add(char.ToUpper(character.Value), character);
            }

            return characterMap;

            /*
            characterMap.Add('a', Constants.A);
            characterMap.Add('A', Constants.A);
            characterMap.Add('b', Constants.B);
            characterMap.Add('B', Constants.B);
            characterMap.Add('c', Constants.C);
            characterMap.Add('C', Constants.C);
            characterMap.Add('d', Constants.D);
            characterMap.Add('D', Constants.D);
            characterMap.Add('e', Constants.E);
            characterMap.Add('E', Constants.E);
            characterMap.Add('f', Constants.F);
            characterMap.Add('F', Constants.F);
            characterMap.Add('g', Constants.G);
            characterMap.Add('G', Constants.G);
            characterMap.Add('h', Constants.H);
            characterMap.Add('H', Constants.H);
            characterMap.Add('i', Constants.I);
            characterMap.Add('I', Constants.I);
            characterMap.Add('j', Constants.J);
            characterMap.Add('J', Constants.J);
            characterMap.Add('k', Constants.K);
            characterMap.Add('K', Constants.K);
            characterMap.Add('l', Constants.L);
            characterMap.Add('L', Constants.L);
            characterMap.Add('m', Constants.M);
            characterMap.Add('M', Constants.M);
            characterMap.Add('n', Constants.N);
            characterMap.Add('N', Constants.N);
            characterMap.Add('o', Constants.O);
            characterMap.Add('O', Constants.O);
            characterMap.Add('p', Constants.P);
            characterMap.Add('P', Constants.P);
            characterMap.Add('q', Constants.Q);
            characterMap.Add('Q', Constants.Q);
            characterMap.Add('r', Constants.R);
            characterMap.Add('R', Constants.R);
            characterMap.Add('s', Constants.S);
            characterMap.Add('S', Constants.S);
            characterMap.Add('t', Constants.T);
            characterMap.Add('T', Constants.T);
            characterMap.Add('u', Constants.U);
            characterMap.Add('U', Constants.U);
            characterMap.Add('v', Constants.V);
            characterMap.Add('V', Constants.V);
            characterMap.Add('w', Constants.W);
            characterMap.Add('')
            */
        }
    }
}
