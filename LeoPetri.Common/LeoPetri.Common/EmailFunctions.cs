using System.Text;
using System.Text.RegularExpressions;

namespace LeoPetri.Common
{
    public static class EmailFunctions
    {
        public static bool IsValid(string email)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(email,
                @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }
    }
}
