using System;
using System.ComponentModel;
using System.Linq;

namespace LeoPetri.Common.Function
{
    public static class EnumExtensions
    {
        public static object GetDefaultValue(this Enum value)
        {
            var attribute = (DefaultValueAttribute)value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DefaultValueAttribute), false).FirstOrDefault();

            if (attribute != null)
                return attribute.Value;
            else
                return value.ToString();
        }
        
        public static string GetDescription(this Enum value)
        {
            var attribute = (DescriptionAttribute)value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

            if (attribute != null)
                return attribute.Description;
            else
                return value.ToString();
        }
    }
}
