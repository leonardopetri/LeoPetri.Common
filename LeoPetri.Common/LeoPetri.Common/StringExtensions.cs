using System.Text.RegularExpressions;
using System.Linq;

namespace LeoPetri.Common
{
    public static class StringExtensions
    {
        public static string NumbersOnly(this string str)
        {
            return string.IsNullOrWhiteSpace(str) ? (str == null ? null : string.Empty) : Regex.Replace(str, @"[^0-9]", string.Empty);
        }

        public static string TextOnly(this string str)
        {
            return string.IsNullOrWhiteSpace(str) ? (str == null ? null : string.Empty) : Regex.Replace(str, @"[^a-zA-Z\s]", string.Empty);
        }

        public static string NoSpecialChar(this string str)
        {
            return string.IsNullOrWhiteSpace(str) ? (str == null ? null : string.Empty) : Regex.Replace(str, @"[^a-zA-Z0-9\s]", string.Empty);
        }

        public static string FirstWord(this string str)
        {
            var array = str.Split(' ');
            return array.Length > 0 ? array[0] : str;
        }

        public static string TrimLineBreaks(this string str)
        {
            return string.IsNullOrWhiteSpace(str) ? (str == null ? null : string.Empty) : Regex.Replace(str, @"\t|\n|\r", string.Empty);
        }

        public static string ToUpperFirstLetter(this string str)
        {
            var array = str.ToLower().Trim().Split(' ');
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Trim();

                if (!string.IsNullOrWhiteSpace(array[i]))
                    array[i] = array[i].FirstOrDefault().ToString().ToUpper() + array[i].Remove(0,1);
            }

            return string.Join(" ", array);
        }

        public static string ToUpperNamesFirstLetter(this string str)
        {
            var array = str.ToLower().Trim().Split(' ');

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Trim();

                if (!string.IsNullOrWhiteSpace(array[i]) && array[i].Length > 2)
                    array[i] = array[i].FirstOrDefault().ToString().ToUpper() + array[i].Remove(0, 1);
            }

            return string.Join(" ", array);
        }

        public static bool ToBoolean(this string str)
        {
            if (str == null)
                return false;

            switch (str.ToUpper())
            {
                case "SIM":
                case "S":
                case "YES":
                case "VERDADEIRO":
                case "V":
                case "1":
                    return true;
            }

            bool.TryParse(str, out bool aux);

            return aux;
        }
    }
}
