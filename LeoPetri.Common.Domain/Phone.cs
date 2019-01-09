using LeoPetri.Common.Function;

namespace LeoPetri.Common.Domain
{
    public class Phone
    {
        public short Ddi { get; private set; } = 55;
        public short Ddd { get; private set; }
        public long Number { get; private set; }

        public Phone(string number, bool hasDdi = false)
        {
            var numberStr = number.NumbersOnly();

            if (hasDdi)
            {
                if ("00".Equals(numberStr.Substring(0, 2)))
                {
                    this.Ddi = short.Parse(numberStr.Substring(2, 2));
                    this.Ddd = short.Parse(numberStr.Substring(4, 2));
                    this.Number = long.Parse(numberStr.Substring(6));
                }
                else
                {
                    this.Ddi = short.Parse(numberStr.Substring(0, 2));
                    this.Ddd = short.Parse(numberStr.Substring(2, 2));
                    this.Number = long.Parse(numberStr.Substring(4));
                }
            }
            else
            {
                this.Ddd = short.Parse(numberStr.Substring(0, 2));
                this.Number = long.Parse(numberStr.Substring(2));
            }
        }

        public Phone(string ddi, string ddd, string number)
        {
            this.Ddi = short.Parse(ddi.NumbersOnly());
            this.Ddd = short.Parse(ddd.NumbersOnly());
            this.Number = long.Parse(number.NumbersOnly());
        }

        public Phone(string ddd, string number)
        {
            this.Ddd = short.Parse(ddd.NumbersOnly());
            this.Number = long.Parse(number.NumbersOnly());
        }

        public Phone (short ddd, long number)
        {
            this.Ddd = ddd;
            this.Number = number;
        }

        public Phone(short ddi, short ddd, long number)
        {
            this.Ddi = ddi;
            this.Ddd = ddd;
            this.Number = number;
        }

        public override string ToString()
        {
            if (this.Number.ToString().Length > 8)
            {
                return this.Ddd.ToString("00") + this.Number.ToString("000000000");
            }

            return this.Ddd.ToString("00") + this.Number.ToString("00000000");
        }

        public string ToStringWithDdi()
        {
            if (this.Number.ToString().Length > 8)
            {
                return this.Ddi.ToString("#0") + this.Ddd.ToString("00") + this.Number.ToString("000000000");
            }

            return this.Ddi.ToString("#0") + this.Ddd.ToString("00") + this.Number.ToString("00000000");
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

            return "(+" + ddi.ToString("#0") + ") (" + ddd.ToString("00") + ") " + numberPart.ToString("0000-0000");
        }
    }
}
