namespace LeoPetri.Common.Function
{
    public static class PhoneFunctions
    {
        public static string ToBrazilianFormat(ulong number)
        {
            return ToBrazilianFormat(number.ToString());
        }

        public static string ToBrazilianFormat(string number)
        {
            var numberStr = number.NumbersOnly();

            var ddd = short.Parse(numberStr.Substring(0, 2));
            var numberPart = long.Parse(numberStr.Substring(2));

            if (numberPart.ToString().Length > 8)
            {
                return "(" + ddd.ToString("00") + ") " + numberPart.ToString("00000-0000");
            }

            return "(" + ddd.ToString("00") + ") " + numberPart.ToString("0000-0000");
        }

        public static string ToBrazilianFormatWithDdi(ulong number)
        {
            return ToBrazilianFormatWithDdi(number.ToString());
        }

        public static string ToBrazilianFormatWithDdi(string number)
        {
            short ddd;
            long numberPart;

            var numberStr = number.NumbersOnly();

            if ("00".Equals(numberStr.Substring(0, 2)))
            {
                ddd = short.Parse(numberStr.Substring(4, 2));
                numberPart = long.Parse(numberStr.Substring(6));
            }
            else
            {
                ddd = short.Parse(numberStr.Substring(2, 2));
                numberPart = long.Parse(numberStr.Substring(4));
            }

            if (numberPart.ToString().Length > 8)
            {
                return "+55 (" + ddd.ToString("00") + ") " + numberPart.ToString("00000-0000");
            }

            return "+55 (" + ddd.ToString("00") + ") " + numberPart.ToString("0000-0000");
        }
        
        public static string ToNorthAmericanFormat(ulong number)
        {
            return ToNorthAmericanFormat(number.ToString());
        }

        public static string ToNorthAmericanFormat(string number)
        {
            var numberStr = number.NumbersOnly();

            var ddd = short.Parse(numberStr.Substring(0, 3));
            var numberPart = long.Parse(numberStr.Substring(3));

            return "(" + ddd.ToString("000") + ") " + numberPart.ToString("000-0000");
        }

        public static string ToNorthAmericanFormatWithDdi(ulong number)
        {
            return ToNorthAmericanFormatWithDdi(number.ToString());
        }

        public static string ToNorthAmericanFormatWithDdi(string number)
        {
            short ddd;
            long numberPart;

            var numberStr = number.NumbersOnly();

            if ("00".Equals(numberStr.Substring(0, 2)))
            {
                ddd = short.Parse(numberStr.Substring(3, 3));
                numberPart = long.Parse(numberStr.Substring(6));
            }
            else
            {
                ddd = short.Parse(numberStr.Substring(1, 3));
                numberPart = long.Parse(numberStr.Substring(4));
            }

            return "+1 (" + ddd.ToString("000") + ") " + numberPart.ToString("000-0000");
        }
    }
}
