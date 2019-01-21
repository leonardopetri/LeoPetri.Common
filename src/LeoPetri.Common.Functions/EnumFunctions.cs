using System;
using System.ComponentModel;
using System.Linq;

namespace LeoPetri.Common.Functions
{
    public class EnumFunctions
    {
        public static TEnum ToEnumFromDefaulValue<TEnum>(object defaultValue) where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            if (!typeof(TEnum).IsEnum)
                throw new ArgumentException("Not an Enum.");

            foreach (TEnum eValor in Enum.GetValues(typeof(TEnum)))
            {
                var attribute = (DefaultValueAttribute)typeof(TEnum).GetField(eValor.ToString()).GetCustomAttributes(typeof(DefaultValueAttribute), false).FirstOrDefault();

                if (attribute != null && attribute.Value.Equals(defaultValue))
                    return eValor;
                else if (attribute == null && eValor.ToString().Equals(defaultValue.ToString()))
                    return eValor;
            }

            throw new ArgumentException("Default value does not match any enum value.");
        }

        public static TEnum ToEnumFromDescription<TEnum>(string description) where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            if (!typeof(TEnum).IsEnum)
                throw new ArgumentException("Not an Enum.");

            foreach (TEnum eValor in Enum.GetValues(typeof(TEnum)))
            {
                var attribute = (DescriptionAttribute)typeof(TEnum).GetField(eValor.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

                if (attribute != null && attribute.Description.Equals(description))
                    return eValor;
                else if (attribute == null && eValor.ToString().Equals(description))
                    return eValor;
            }

            throw new ArgumentException("Description does not match any enum value.");
        }
    }
}
