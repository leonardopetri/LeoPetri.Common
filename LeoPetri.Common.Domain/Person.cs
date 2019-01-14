using LeoPetri.Common.Function;

namespace LeoPetri.Common.Domain
{
    public abstract class Person
    {
        private string _countryId;
        private string _name;

        public string Name { get { return _name; } set { _name = value.ToUpperFirstLetterName(); } }
        public string CountryId { get { return _countryId; } set { _countryId = value.NoSpecialChar(); } }
        public PersonType Type { get; private set; }

        public Person(PersonType type) => this.Type = type;

        public Person(string name, PersonType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public Person(string name, string countryId, PersonType type)
        {
            this.Name = name;
            this.CountryId = countryId;
            this.Type = type;
        }

        public override string ToString() => this.Name;
    }
}
