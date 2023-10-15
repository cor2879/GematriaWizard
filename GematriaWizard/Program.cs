#pragma warning disable CS8600, CS8618, CS8605
using System;
using static System.Console;

using GematriaWizard.Dictionary;

namespace GematriaWizard
{
    public class Program
    {
        private static readonly string header = @"*********************************************************************" +
                          $@"{Environment.NewLine}*********************************************************************" +
                          $@"{Environment.NewLine}**                                                                 **" +
                          $@"{Environment.NewLine}**                    *** Gematria Wizard ***                      **" +
                          $@"{Environment.NewLine}**             The Ultimate Gematria Phrase Builder                **" +
                          $@"{Environment.NewLine}**                                                                 **" +
                          $@"{Environment.NewLine}*********************************************************************" +
                          $@"{Environment.NewLine}*********************************************************************";

         private static readonly string informationPanel =
                                                @"*********************************************************************" +
                          $@"{Environment.NewLine}*********************************************************************" +
                                             "\r\n** Phrase: {0}" +
                                             "\r\n** Unicode Value: {1}" +
                                             "\r\n** Hebrew Gematria: {2}" +
                                             "\r\n** English Gematria: {3}" +
                                             "\r\n** Simple Gematria {4}" +
                                             "\r\n*********************************************************************" +
                                             "\r\n*********************************************************************";

        private static bool running = false;

        public static void Main(string[] args)
        {
            Title = Constants.ApplicationTitle;

            Run();
        }

        private static void Run()
        {
            running = true;
            var currentInput = string.Empty;
            IGematriaPhrase phrase = null;
            var expression = string.Empty;

            while (running)
            {
                try
                {
                    Console.Clear();
                    WriteLine(header);

                    if (currentInput != null && currentInput.Any())
                    {
                        expression = currentInput;
                        phrase = CalculateGematria(expression);

                    }

                    WriteLine(
                        informationPanel,
                        expression,
                        phrase?.NumericValue,
                        (phrase as IHebrewGematriaPhrase)?.HebrewGematria,
                        (phrase as IEnglishGematriaPhrase)?.EnglishGematria,
                        (phrase as ISimpleGematriaPhrase)?.SimpleGematria);

                    currentInput = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Pause();
                    currentInput = string.Empty;
                }
            }
        }

        private static IGematriaPhrase CalculateGematria(string text)
        {
            var phrase = new Phrase();

            foreach (var c in text)
            {
                phrase.Add(CharacterMap.GetCharacter(c));
            }

            return phrase;
        }

        public static void Pause()
        {
            WriteLine("Press [Enter] to continue.");
            ReadLine();
        }
    }
}