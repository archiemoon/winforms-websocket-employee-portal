using System;
using System.Linq;

namespace Moon_Archie_Winforms_NEA
{
    public class Data_Validation_Functions_Class
    {
        public static bool IsEmpty(string String)
        {
            return String.IsNullOrWhiteSpace(String);
        }
        public static bool IsBellowMaxLength(string String, int Length)
        {
            if (String.IsNullOrEmpty(String)) return false;

            return String.Length <= Length;
        }
        public static bool IsAboveMinLength(string String, int Length)
        {
            if (String.IsNullOrEmpty(String)) return false;

            return String.Length >= Length;
        }
        public static bool IsBetweenLength(string String, int Min, int Max)
        {
            if (String.IsNullOrEmpty(String)) return false;

            return String.Length >= Min && String.Length <= Max;
        }
        public static bool IsValidEmial(string String)
        {
            if (String.IsNullOrEmpty(String)) return false;

            return String.Contains("@") && String.Contains(".");
        }
        public static bool IsValidPhoneNumber(string String)
        {
            if (String.IsNullOrEmpty(String)) return false;

            return String.Substring(0, 3) == "+44" && IsBetweenLength(String, 13, 13);
        }
        public static bool IsValidPassword(string String, int Min, int Max)
        {
            if (String.IsNullOrEmpty(String)) return false;

            bool ContainsSpecialCharacter = String.Any(char.IsPunctuation);
            bool ContainsNumber = String.Any(char.IsDigit);
            bool ContainsUppercase = String.Any(char.IsUpper);
            bool BetweenLength = IsBetweenLength(String, Min, Max);

            return ContainsSpecialCharacter && ContainsUppercase && ContainsNumber && BetweenLength;
        }
        public static bool IsNumberOfWords(string String, int NumberOfWords)
        {
            if (String.IsNullOrEmpty(String)) return false;

            string[] NameParts = String.Split(' ');
            return NameParts.Length == NumberOfWords; ;
        }
    }
}
