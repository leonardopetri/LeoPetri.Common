using System.ComponentModel;

namespace LeoPetri.Common
{
    public enum PersonTypes
    {
        [DefaultValue("Pessoa Física")]
        NaturalPerson = 1,
        [DefaultValue("Pessoa Jusrídica")]
        LegalEntity = 2
    }
}
