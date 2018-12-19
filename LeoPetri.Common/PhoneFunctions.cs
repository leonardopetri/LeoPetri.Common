using System;
using System.Text;

namespace LeoPetri.Common
{
    public static class PhoneFunctions
    {
        //public static void Part(string phone, out int ddd, out long number)
        //{
        //    phone = phone.NumbersOnly();

        //    number = 0;

        //    if (phone.Length <= 2)
        //    {
        //        ddd = NumberFunctions.GetShort(phone);
        //    }
        //    else
        //    {
        //        ddd = NumberFunctions.GetShort(phone.Substring(0, 2));
        //        number = NumberFunctions.GetLong(phone.Substring(2, phone.Length -2));
        //    }
        //}

        //public static void Part(string phone, out int? ddd, out long? number)
        //{
        //    phone = phone.NumbersOnly();

        //    number = null;

        //    if (phone.Length <= 2)
        //    {
        //        ddd = NumberFunctions.GetShortNull(phone);
        //    }
        //    else
        //    {
        //        ddd = NumberFunctions.GetShortNull(phone.Substring(0, 2));
        //        number = NumberFunctions.GetLongNull(phone.Substring(2, phone.Length -2));
        //    }
        //}

        //public static short GetDdd(string phone)
        //{
        //    try
        //    {
        //        if (phone == null)
        //            return 0;

        //        phone = phone.NumbersOnly();

        //        return NumberFunctions.GetShort(phone.Length <= 2 ? phone : phone.Substring(0, 2));
        //    }
        //    catch (Exception)
        //    {

        //        return 0;
        //    }
         
        //}

        //public static long GetNumber(string phone)
        //{
        //    try
        //    {
        //        if (phone == null)
        //            return 0;

        //        phone = phone.NumbersOnly();

        //        return NumberFunctions.GetLong(phone.Length <= 2 ? phone : phone.Substring(2, phone.Length - 2));
        //    }
        //    catch (Exception)
        //    {

        //        return 0;
        //    }

            
        //}

        //public static PhoneResult GetPhone(string phone)
        //{
        //    try
        //    {
        //        if (phone == null)
        //            return new PhoneResult();

        //        var result = new PhoneResult
        //        {
        //            Ddd = GetDdd(phone),
        //            Number = GetNumber(phone)
        //        };

        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        return new PhoneResult();
        //    }
            

        //}

        //public static string Join(int ddd, long number)
        //{
        //    if (number.ToString().Length > 8)
        //    {
        //        return ddd.ToString("00") + number.ToString("000000000");
        //    }

        //    return ddd.ToString("00") + number.ToString("00000000");

        //}

        //public static string Join(int? ddd, long? number)
        //{
        //    if (ddd.HasValue && number.HasValue)
        //        return Join((short) ddd, (long) number);

        //    return String.Empty;
        //}

        //public static string Format(int? ddd, long? number, string type)
        //{
        //    var sb = new StringBuilder();

        //    if (ddd.HasValue)
        //    {
        //        sb.Append("(" + ddd + ")");
        //    }

        //    if (number.HasValue)
        //    {
        //        if (number.ToString().Length > 8)
        //        {
        //            sb.Append(" " + ((long)number).ToString("00000-0000"));
        //        }
        //        else
        //        {
        //            sb.Append(" " + ((long)number).ToString("0000-0000"));
        //        }
        //    }

        //    if (!String.IsNullOrWhiteSpace(type))
        //    {
        //        sb.Append(" (" + type.ToUpper() + ")");
        //    }


        //    return sb.ToString();
        //}

        //public static string Format(int? ddd, long? number)
        //{
        //    var sb = new StringBuilder();

        //    if (ddd.HasValue)
        //    {
        //        sb.Append("(" + ddd + ")");
        //    }

        //    if (number.HasValue)
        //    {
        //        if (number.ToString().Length > 8)
        //        {
        //            sb.Append(" " + ((long)number).ToString("00000-0000"));
        //        }
        //        else
        //        {
        //            sb.Append(" " + ((long)number).ToString("0000-0000"));
        //        }
        //    }

        //    return sb.ToString();
        //}

        //public static bool IsValid(int? ddd, long? number)
        //{
        //    if (ddd == null || number == null)
        //        return false;

        //    if (ddd < 11 || ddd > 99)
        //        return false;

        //    if (number < 9999999 || number > 999999999)
        //        return false;

        //    return true;
        //}

        //public static bool IsValid(string phone)
        //{
        //    return IsValid(GetPhone(phone));
        //}

        //public static bool IsValid(PhoneResult phone)
        //{
        //    return IsValid(phone.Ddd, phone.Number);
        //}
    }
}
