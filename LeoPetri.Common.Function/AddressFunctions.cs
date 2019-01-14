using System.Text;

namespace LeoPetri.Common.Function
{
    public static class AddressFunctions
    {
        public static string ToBrazilianFormat(
           string street,
           int? number,
           string complement,
           string district,
           string city,
           string state,
           string zipCode)
        {
            var sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(street))
            {
                sb.Append(street);
            }

            if (number.HasValue && !string.IsNullOrWhiteSpace(number?.ToString()))
            {
                if (!string.IsNullOrWhiteSpace(sb.ToString()))
                {
                    sb.Append(", ");
                }

                sb.Append(number);
            }
            
            if (!string.IsNullOrWhiteSpace(complement))
            {
                if (!string.IsNullOrWhiteSpace(sb.ToString()))
                {
                    sb.Append(", ");
                }

                sb.Append(complement);
            }

            if (!string.IsNullOrWhiteSpace(district))
            {
                if (!string.IsNullOrWhiteSpace(sb.ToString()))
                {
                    sb.Append(", ");
                }

                sb.Append(district);
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                if (!string.IsNullOrWhiteSpace(sb.ToString()))
                {
                    sb.Append(", ");
                }

                sb.Append(city);
            }

            if (!string.IsNullOrWhiteSpace(state))
            {
                if (!string.IsNullOrWhiteSpace(sb.ToString()))
                {
                    sb.Append(" - ");
                }

                sb.Append(state);
            }

            if (!string.IsNullOrWhiteSpace(zipCode))
            {
                if (!string.IsNullOrWhiteSpace(sb.ToString()))
                {
                    sb.Append(", ");
                }

                sb.Append(long.Parse(zipCode.NumbersOnly()).ToString("00000-000"));
            }
            
            return sb.ToString();
        }
    }
}
