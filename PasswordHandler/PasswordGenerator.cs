using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordHandler
{
    public static class PasswordGenerator
    {
        //private static int PasswordLengthStandard = 32; //Password charcter lengths
        private static int DicewareDiceRolls = 5; //Koliko puta se kocka baca

        public static string GeneratePasswordStandard(bool SpecialCharacters = false, int PasswordLength = 32) //Klasicni nacin, duga lozinka sa brojevima i posebnim znakovima
        {
            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"; //Alfabet
            

            StringBuilder PasswordBuilder = new StringBuilder(PasswordLength);

            for(int i = 0; i < PasswordLength; i++)
            {
                PasswordBuilder.Append(Alphabet[RandomNumberGenerator.GetInt32(0, Alphabet.Length)]); //Puni lozinku alphabetom
            }

            int NumberCount =  1 + RandomNumberGenerator.GetInt32((int)(PasswordLength * 0.2f), (int)(PasswordLength * 0.9f));
            
            for (int i = 0; i < NumberCount; i++) //Dodaje brojeve
            {
                int Position = RandomNumberGenerator.GetInt32(0, PasswordBuilder.Length);
                PasswordBuilder.Remove(Position, 1).Insert(Position, RandomNumberGenerator.GetInt32(0,10)); //Remove pa insert, fugly
            }

            if(SpecialCharacters) //Ako treba posebnih znakova tu se dodaju
            {
                string SpecialCharSet = "!#$%&'()*+,-./:;<=>?@[]^_`{|}~";
                float PercentOfPasswordSpecialChar = 0.1f;

                for (int i = 0; i < 1 + (int)(PasswordLength * PercentOfPasswordSpecialChar); i++)
                {

                    int Position = RandomNumberGenerator.GetInt32(0, PasswordBuilder.Length);
                    while (!Regex.IsMatch(PasswordBuilder[Position].ToString(), "[A-Za-z]"))
                    {
                        System.Console.WriteLine("Ooooppsss wanted to replace: {0} but cannot", PasswordBuilder[Position].ToString());
                        Position = RandomNumberGenerator.GetInt32(0, PasswordBuilder.Length);   //Ovaj while loop osigura da se posebni znak
                    }                                                                           //ne ubaci umjesto broja nego samo slova
                    PasswordBuilder.Remove(Position, 1).Insert(Position, SpecialCharSet[RandomNumberGenerator.GetInt32(0, SpecialCharSet.Length)]);
                }
            }

            return PasswordBuilder.ToString();  //Sigurnost lozinke pada cim postoje pravila o brojevima i znakovima
                                                //Brojevi i znakovi sluze da podrzavaju pravila na internetu
        }

        public static string GeneratePasswordDiceWare(int WordCount = 5) //Diceware nacin strvaranja lozinke guglati diceware
        {
            const int DiceRolls = 5;
            const char Delim = '.'; //posebni znak između rijeci

            StringBuilder DicewareNumber = new StringBuilder(DiceRolls);
            StringBuilder DicePass = new StringBuilder();
            for (int i = 0; i < WordCount; i++)
            {
                for (int j = 0; j < DiceRolls; j++)
                {
                    DicewareNumber.Append(RandomNumberGenerator.GetInt32(1, 7)); //Bacanje kocke
                }


                foreach (var Line in File.ReadAllLines("eff_large_wordlist.txt")) //Rijecnik za diceware
                {
                    if (Line.Contains(DicewareNumber.ToString())) //Trazi broj rijeci dobiven bacanjem kocke 5 puta
                    {
                        /*Console.WriteLine(Line);*/
                        DicePass.Append(Line.Substring(6)); //Prva 5 znakova su broj rijeci, 6 je \t, dalje je rijec
                        if(i != WordCount - 1)
                        {
                            DicePass.Append(Delim);
                        }
                    }
                }

                DicewareNumber.Clear();
            }

            return DicePass.ToString();
        }
    }


}