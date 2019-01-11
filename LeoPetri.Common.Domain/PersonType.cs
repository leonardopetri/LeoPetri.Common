using System.ComponentModel;

namespace LeoPetri.Common.Domain
{
    public enum PersonType
    {
        [DefaultValue("Pessoa Física")]
        NaturalPerson = 1,
        [DefaultValue("Pessoa Jusrídica")]
        LegalEntity = 2
    }
}
