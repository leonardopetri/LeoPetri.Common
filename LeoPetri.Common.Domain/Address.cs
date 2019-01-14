using LeoPetri.Common.Function;

namespace LeoPetri.Common.Domain
{
    public class Address
    {
        private string _street;
        private string _complement;
        private string _district;
        private string _city;
        private string _country;
        private string _zipCode;

        public string Street
        {
            get { return _street; }
            set { _street = value.ToUpperFirstLetterName(); }
        }

        public int? Number { get; set; }

        public string Complement
        {
            get { return _complement; }
            set { _complement = value.ToUpperFirstLetterName(); }
        }

        public string District
        {
            get { return _district; }
            set { _district = value.ToUpperFirstLetterName(); }
        }

        public string City
        {
            get { return _city; }
            set { _city = value.ToUpperFirstLetterName(); }
        }

        public State State { get; set; }

        public string Country
        {
            get { return _country; }
            set { _country = value.ToUpperFirstLetterName(); }
        }

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value.ToUpperFirstLetterName(); }
        }

        public override string ToString()
        {
            return AddressFunctions.ToBrazilianFormat(this.Street, this.Number, this.Complement, this.District, this.City, (string.IsNullOrWhiteSpace(this.State.Abbreviation) ? this.State.Name : this.State.Abbreviation), this.ZipCode);
        }
    }
}
