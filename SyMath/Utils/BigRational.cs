﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace SyMath
{
    /// <summary>
    /// Represent a rational number with System.Numerics.BigInteger as the numerator and denominator.
    /// </summary>
    public struct BigRational : IComparable<BigRational>, IEquatable<BigRational>, IFormattable
    {
        private BigInteger n, d;

        private void Reduce()
        {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(n, d);
            n /= gcd;
            d /= gcd;
            if (n == 0)
                d = 1;
            if (d < 0)
            {
                n = -n;
                d = -d;
            }
        }

        public BigRational(int Integer) { n = Integer; d = 1; }
        public BigRational(int Numerator, int Denominator) { n = Numerator; d = Denominator; Reduce();  }
        public BigRational(long Integer) { n = Integer; d = 1; }
        public BigRational(long Numerator, long Denominator) { n = Numerator; d = Denominator; Reduce(); }
        public BigRational(BigInteger Integer) { n = Integer; d = 1; }
        public BigRational(BigInteger Numerator, BigInteger Denominator) { n = Numerator; d = Denominator; Reduce(); }
        public BigRational(double Double)
        {
            // http://stackoverflow.com/questions/389993/extracting-mantissa-and-exponent-from-double-in-c-sharp

            // Translate the double into sign, exponent and mantissa.
            long bits = BitConverter.DoubleToInt64Bits(Double);
            // Note that the shift is sign-extended, hence the test against -1 not 1
            int sign = (bits < 0) ? -1 : 1;
            int exponent = (int)((bits >> 52) & 0x7ffL);
            long mantissa = bits & 0xfffffffffffffL;

            // Subnormal numbers; exponent is effectively one higher,
            // but there's no extra normalisation bit in the mantissa
            if (exponent == 0)
            {
                exponent++;
            }
            // Normal numbers; leave exponent as it is but add extra
            // bit to the front of the mantissa
            else
            {
                mantissa = mantissa | (1L << 52);
            }

            // Bias the exponent. It's actually biased by 1023, but we're
            // treating the mantissa as m.0 rather than 0.m, so we need
            // to subtract another 52 from it.
            exponent -= 1023 + 52; // 1075;
            
            if (mantissa > 0)
            {
                /* Normalize */
                while ((mantissa & 1) == 0)
                {    /*  i.e., Mantissa is even */
                    mantissa >>= 1;
                    exponent++;
                }
            }
            
            if (exponent > 0)
            {
                n = new BigInteger(sign * mantissa) << exponent;
                d = 1;
            }
            else
            {
                n = new BigInteger(sign * mantissa);
                d = new BigInteger(1) << -exponent;
                Reduce();
            }
        }

        private static BigInteger DecimalBase = 1L << 32;
        public BigRational(decimal Decimal)
        {
            int[] Bits = decimal.GetBits(Decimal);
            
            int Sign = (Bits[3] & (1 << 31)) != 0 ? -1 : 1;
            int Exponent = (Bits[3] >> 16) & ((1 << 7) - 1);

            n = Sign * (Bits[0] + Bits[1] * DecimalBase + Bits[2] * DecimalBase * DecimalBase);
            d = BigInteger.Pow(10, Exponent);

            Reduce();
        }

        public string ToLaTeX()
        {
            string ns = n.ToString();
            if (d == 1) return ns;

            string nd = d.ToString();

            if (ns.Length <= 2 && nd.Length <= 2)
                return "^{" + ns + "}_{" + nd + "}";
            else
                return @"\frac{" + ns + "}{" + nd + "}";
        }

        // IEquatable interface.
        public bool Equals(BigRational x) { return d == x.d && n == x.n; }

        // IComparable interface.
        public int CompareTo(BigRational x) 
        {
            if (Equals(x))
                return 0;
            return (n * x.d - x.n * d).Sign; 
        }

        // IFormattable interface.
        public string ToString(string format, IFormatProvider formatProvider) { return ((double)this).ToString(format); }
        public string ToString(string format) { return ToString(format, null); }

        // object interface.
        public override bool Equals(object obj)
        {
            if (obj is BigRational)
                return Equals((BigRational)obj);
            else
                return base.Equals(obj);
        }
        public override int GetHashCode() { return n.GetHashCode() ^ d.GetHashCode(); }
        public override string ToString()
        {
            if (d != 1)
                return n.ToString() + "/" + d.ToString();
            else
                return n.ToString();
        }

        // Arithmetic operators.
        public static BigRational operator -(BigRational a) { return new BigRational(-a.n, a.d); }
        public static BigRational operator *(BigRational a, BigRational b) { return new BigRational(a.n * b.n, a.d * b.d); }
        public static BigRational operator /(BigRational a, BigRational b) { return new BigRational(a.n * b.d, a.d * b.n); }
        public static BigRational operator +(BigRational a, BigRational b) { return new BigRational(a.n * b.d + b.n * a.d, a.d * b.d); }
        public static BigRational operator -(BigRational a, BigRational b) { return new BigRational(a.n * b.d - b.n * a.d, a.d * b.d); }
        public static BigRational operator ^(BigRational a, int b) 
        {
            if (b < 0)
                return new BigRational(BigInteger.Pow(a.d, -b), BigInteger.Pow(a.n, -b));
            else
                return new BigRational(BigInteger.Pow(a.n, b), BigInteger.Pow(a.d, b));
        }
        public static BigRational operator ^(BigRational a, BigRational b) 
        {
            if (b.d != 1)
                return new BigRational(Math.Pow((double)a, (double)b));
            else
                return a ^ (int)b.n; 
        }
        public static BigRational operator %(BigRational a, BigRational b) { return a - Floor(a / b) * b; }

        // Relational operators.
        public static bool operator ==(BigRational a, BigRational b) { return a.Equals(b); }
        public static bool operator !=(BigRational a, BigRational b) { return !a.Equals(b); }
        public static bool operator <(BigRational a, BigRational b) { return a.CompareTo(b) < 0; }
        public static bool operator <=(BigRational a, BigRational b) { return a.CompareTo(b) <= 0; }
        public static bool operator >(BigRational a, BigRational b) { return a.CompareTo(b) > 0; }
        public static bool operator >=(BigRational a, BigRational b) { return a.CompareTo(b) >= 0; }

        // Conversions.
        public static implicit operator BigRational(BigInteger x) { return new BigRational(x); }
        public static implicit operator BigRational(long x) { return new BigRational(x); }
        public static implicit operator BigRational(int x) { return new BigRational(x); }
        public static implicit operator BigRational(double x) { return new BigRational(x); }
        public static explicit operator BigInteger(BigRational x) { return x.n / x.d; }
        public static explicit operator decimal(BigRational x) { return (decimal)x.n / (decimal)x.d; }
        public static explicit operator long(BigRational x) { return (long)(x.n / x.d); }
        public static explicit operator int(BigRational x) { return (int)(x.n / x.d); }
        public static explicit operator double(BigRational x) { return (double)x.n / (double)x.d; }

        // Useful functions.
        public static BigRational Abs(BigRational x) { return new BigRational(BigInteger.Abs(x.n), BigInteger.Abs(x.d)); }
        public static BigRational Sign(BigRational x) { return new BigRational(x < 0 ? -1 : 1); }
        
        public static BigRational Floor(BigRational x) 
        {
            BigInteger i = x.n / x.d;
            if (i == x)
                return x;
            else if (x < 0)
                return i - 1;
            else
                return i;
        }
        public static BigRational Ceiling(BigRational x) { return Floor(new BigRational(x.n + x.d - 1, x.d)); }
        public static BigRational Round(BigRational x) { return Floor(new BigRational(x.n + (x.d >> 1), x.d)); }
    }
}
