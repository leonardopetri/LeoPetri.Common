using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeoPetri.Common.Functions.UnitTest
{
    public class AddressFunctionsTest
    {
        [Theory]
        [InlineData(CaseFormat.None, "", null, "", "", "", "", "", "")]
        [InlineData(CaseFormat.None, "rua aimberê", null, "", "", "", "", "", "rua aimberê")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "", "", "", "", "", "rua aimberê, 2")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "Apto. 72", "", "", "", "", "rua aimberê, 2, Apto. 72")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "", "", "", "rua aimberê, 2, Apto. 72, Vila Curuça")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "Santo André", "", "", "rua aimberê, 2, Apto. 72, Vila Curuça, Santo André")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "Santo André", "SP", "", "rua aimberê, 2, Apto. 72, Vila Curuça, Santo André - SP")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "Santo André", "São Paulo", "", "rua aimberê, 2, Apto. 72, Vila Curuça, Santo André - São Paulo")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "Santo André", "São Paulo", "09080-320", "rua aimberê, 2, Apto. 72, Vila Curuça, Santo André - São Paulo, 09080-320")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "Santo André", "São Paulo", "09080320", "rua aimberê, 2, Apto. 72, Vila Curuça, Santo André - São Paulo, 09080-320")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "", "Vila Curuça", "Santo André", "São Paulo", "09080320", "rua aimberê, 2, Vila Curuça, Santo André - São Paulo, 09080-320")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "", "Vila Curuça", "", "", "09080320", "rua aimberê, 2, Vila Curuça, 09080-320")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "", "Vila Curuça", "", "SP", "09080320", "rua aimberê, 2, Vila Curuça, SP, 09080-320")]
        [InlineData(CaseFormat.None, "rua aimberê", 2, "", "Vila Curuça", "", "SP", "80320", "rua aimberê, 2, Vila Curuça, SP, 00080-320")]
        [InlineData(CaseFormat.ToLower, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "Santo André", "São Paulo", "09080320", "rua aimberê, 2, apto. 72, vila curuça, santo andré - são paulo, 09080-320")]
        [InlineData(CaseFormat.ToUpper, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "Santo André", "São Paulo", "09080320", "RUA AIMBERÊ, 2, APTO. 72, VILA CURUÇA, SANTO ANDRÉ - SÃO PAULO, 09080-320")]
        [InlineData(CaseFormat.ToNameCase, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "Santo André", "São Paulo", "09080320", "Rua Aimberê, 2, Apto. 72, Vila Curuça, Santo André - São Paulo, 09080-320")]
        [InlineData(CaseFormat.ToNameCase, "rua aimberê", 2, "Apto. 72", "Vila Curuça", "Santo André", "SP", "09080320", "Rua Aimberê, 2, Apto. 72, Vila Curuça, Santo André - SP, 09080-320")]
        public void ToBrazilianFormatTest(
           CaseFormat caseFormat,
           string street,
           int? number,
           string complement,
           string district,
           string city,
           string state,
           string zipCode,
           string value)
        {
            var formatedValue = AddressFunctions.ToBrazilianFormat(street, number, complement, district, city, state, zipCode, caseFormat);

            Assert.Equal(value, formatedValue);
        }
    }
}
