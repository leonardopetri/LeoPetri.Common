namespace LeoPetri.Common.Function
{
    public static class PhoneFunctions
    {

        public static string ToBrazilianFormat(long number)
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

        public static string ToBrazilianFormatWithDdi(long number)
        {
            return ToBrazilianFormatWithDdi(number.ToString());
        }

        public static string ToBrazilianFormatWithDdi(string number)
        {
            short ddi, ddd;
            long numberPart;

            var numberStr = number.NumbersOnly();

            if ("00".Equals(numberStr.Substring(0, 2)))
            {
                ddi = short.Parse(numberStr.Substring(2, 2));
                ddd = short.Parse(numberStr.Substring(4, 2));
                numberPart = long.Parse(numberStr.Substring(6));
            }
            else
            {
                ddi = short.Parse(numberStr.Substring(0, 2));
                ddd = short.Parse(numberStr.Substring(2, 2));
                numberPart = long.Parse(numberStr.Substring(4));
            }

            if (numberPart.ToString().Length > 8)
            {
                return "(+" + ddi.ToString("#0") + ") (" + ddd.ToString("00") + ") " + numberPart.ToString("00000-0000");
            }

            return "+" + ddi.ToString("#0") + " (" + ddd.ToString("00") + ") " + numberPart.ToString("0000-0000");
        }
        
        public static string ToNorthAmericanFormat(long number)
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

        public static string ToNorthAmericanFormatWithDdi(long number)
        {
            return ToNorthAmericanFormatWithDdi(number.ToString());
        }

        public static string ToNorthAmericanFormatWithDdi(string number)
        {
            short ddi, ddd;
            long numberPart;

            var numberStr = number.NumbersOnly();

            if ("00".Equals(numberStr.Substring(0, 2)))
            {
                ddi = short.Parse(numberStr.Substring(2, 2));
                ddd = short.Parse(numberStr.Substring(4, 3));
                numberPart = long.Parse(numberStr.Substring(7));
            }
            else
            {
                ddi = short.Parse(numberStr.Substring(0, 2));
                ddd = short.Parse(numberStr.Substring(2, 3));
                numberPart = long.Parse(numberStr.Substring(6));
            }

            return "+" + ddi.ToString("#0") + " (" + ddd.ToString("00") + ") " + numberPart.ToString("0000-0000");
        }
    }
}
