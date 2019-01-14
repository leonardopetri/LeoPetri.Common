using LeoPetri.Common.Function;

namespace LeoPetri.Common.Domain
{
    public class State
    {
        private string _name;
        private string _abbreviation;

        public string Name
        {
            get { return _name; }
            set { _name = value.ToUpperFirstLetterName(); }
        }

        public string Abbreviation
        {
            get { return _abbreviation; }
            set { _abbreviation = value.ToUpper(); }
        }
    }
}
