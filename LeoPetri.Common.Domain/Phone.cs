using LeoPetri.Common.Function;

namespace LeoPetri.Common.Domain
{
    public class Phone
    {
        public ushort Ddi { get; private set; } = 55;
        public ushort Ddd { get; private set; }
        public ulong Number { get; private set; }

        public Phone(ulong number) : this(number.ToString()) { }

        public Phone(string number)
        {
            var numberStr = number.NumbersOnly();

            this.Ddd = ushort.Parse(numberStr.Substring(0, 2));
            this.Number = ulong.Parse(numberStr.Substring(2));
        }

        public Phone(string ddi, string ddd, string number)
        {
            this.Ddi = ushort.Parse(ddi.NumbersOnly());
            this.Ddd = ushort.Parse(ddd.NumbersOnly());
            this.Number = ulong.Parse(number.NumbersOnly());
        }

        public Phone(string ddd, string number)
        {
            this.Ddd = ushort.Parse(ddd.NumbersOnly());
            this.Number = ulong.Parse(number.NumbersOnly());
        }

        public Phone (ushort ddd, ulong number)
        {
            this.Ddd = ddd;
            this.Number = number;
        }

        public Phone(ushort ddi, ushort ddd, ulong number)
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
                return this.Ddi.ToString("##0") + this.Ddd.ToString("00") + this.Number.ToString("000000000");
            }

            return this.Ddi.ToString("##0") + this.Ddd.ToString("00") + this.Number.ToString("00000000");
        }
    }
}
