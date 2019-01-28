using System;

namespace LeoPetri.Common.Extensions
{
    public static class RandomExtensions
    {
        public static string NextCpf(this Random rnd)
        {
            var n = 9;
            var n1 = rnd.Next(0, n);
            var n2 = rnd.Next(0, n);
            var n3 = rnd.Next(0, n);
            var n4 = rnd.Next(0, n);
            var n5 = rnd.Next(0, n);
            var n6 = rnd.Next(0, n);
            var n7 = rnd.Next(0, n);
            var n8 = rnd.Next(0, n);
            var n9 = rnd.Next(0, n);
            var d1 = n9 * 2 + n8 * 3 + n7 * 4 + n6 * 5 + n5 * 6 + n4 * 7 + n3 * 8 + n2 * 9 + n1 * 10;
            d1 = 11 - d1 % 11;
            if (d1 >= 10) d1 = 0;
            var d2 = d1 * 2 + n9 * 3 + n8 * 4 + n7 * 5 + n6 * 6 + n5 * 7 + n4 * 8 + n3 * 9 + n2 * 10 + n1 * 11;
            d2 = 11 - d2 % 11;
            if (d2 >= 10) d2 = 0;
            var result = n1.ToString() +
                n2.ToString() +
                n3.ToString() +
                n4.ToString() +
                n5.ToString() +
                n6.ToString() +
                n7.ToString() +
                n8.ToString() +
                n9.ToString() +
                d1.ToString() +
                d2.ToString();

            return result;
        }

        public static string NextCnpj(this Random rnd)
        {
            var n = 9;

            var n1 = rnd.Next(0, n);
            var n2 = rnd.Next(0, n);
            var n3 = rnd.Next(0, n);
            var n4 = rnd.Next(0, n);
            var n5 = rnd.Next(0, n);
            var n6 = rnd.Next(0, n);
            var n7 = rnd.Next(0, n);
            var n8 = rnd.Next(0, n);
            var n9 = 0; //r.Next(0,n);
            var n10 = 0; //r.Next(0,n);
            var n11 = 0; //r.Next(0,n);
            var n12 = 1; //r.Next(0,n);
            var d1 = n12 * 2 + n11 * 3 + n10 * 4 + n9 * 5 + n8 * 6 + n7 * 7 + n6 * 8 + n5 * 9 + n4 * 2 + n3 * 3 + n2 * 4 + n1 * 5;
            d1 = 11 - d1 % 11;
            if (d1 >= 10) d1 = 0;
            var d2 = d1 * 2 + n12 * 3 + n11 * 4 + n10 * 5 + n9 * 6 + n8 * 7 + n7 * 8 + n6 * 9 + n5 * 2 + n4 * 3 + n3 * 4 + n2 * 5 + n1 * 6;
            d2 = 11 - d2 % 11;
            if (d2 >= 10) d2 = 0;
            var result = n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() +
                n6.ToString() + n7.ToString() + n8.ToString() + n9.ToString() + n10.ToString() + n11.ToString() + n12.ToString() + d1.ToString() + d2.ToString();
            return result;
        }
    }
}
