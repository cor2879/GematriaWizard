namespace GematriaWizard.Utility.Validation
{
    public class GematriaValidator
    {
        public static bool ValidateCharacter(char character)
        {
            character = char.ToLower(character);

            return character >= 'a' && character <= 'z';
        }
    }
}
