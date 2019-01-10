using System;
using System.Text.RegularExpressions;

namespace LeoPetri.Common.Domain
{
    public class Email
    {
        public string Address { get; private set; }
        public readonly string LocalPart;
        public readonly string Domain;

        public Email(string address)
        {
            if (!IsValid(address))
            {
                throw new FormatException("Not a valid email address format.");
            }

            var atIndex = address.IndexOf("@");
            this.Address = address;
            this.LocalPart = address.Substring(0, address.IndexOf("@"));
            this.Domain = address.Substring(address.IndexOf("@") + 1);
        }

        public static bool IsValid(string emailAddress)
        {
            return Regex.IsMatch(emailAddress,
                @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }
    }
}
