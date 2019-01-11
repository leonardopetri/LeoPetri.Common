using LeoPetri.Common.Function;
using System;

namespace LeoPetri.Common.Domain
{
    public class LegalEntity : Person
    {
        public LegalEntity() : base(PersonType.LegalEntity) { }

        public LegalEntity(string name) : base(name, PersonType.NaturalPerson) { }

        public LegalEntity(string name, string countryId) : base(name, countryId, PersonType.LegalEntity)
        {
            if (!CountryIdFunctions.IsCnpjValid(this.CountryId))
            {
                throw new FormatException("Not a valid CNPJ.");
            }
        }
    }
}
