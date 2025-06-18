using System;
using System.Numerics;
using System.Security.Cryptography;

namespace Lab_24
{
    internal class OngSchnorrShamir
    {
        private BigInteger p;
        private BigInteger q;
        private BigInteger g;
        private BigInteger x;
        private BigInteger y;
        private BigInteger k;

        public OngSchnorrShamir()
        {
            p = BigInteger.Parse("32416190071");
            q = BigInteger.Parse("32416190067");
            g = BigInteger.Parse("32416190068");
            x = BigInteger.Parse("1234567890");
            y = BigInteger.ModPow(g, x, p);    
            k = GenerateRandomK();
        }

        // Метод, що шифрує текст
        public byte[] Encrypt(byte[] plaintext)
        {
            BigInteger m = new BigInteger(plaintext);

            BigInteger r = BigInteger.ModPow(g, k, p);

            BigInteger kInv = ModInverse(k, p);
            BigInteger e = (m - x * r) * kInv % p;
            if (e < 0)
            {
                e += p;
            }

            byte[] rBytes = r.ToByteArray();
            byte[] eBytes = e.ToByteArray();

            // Combine r and e into ciphertext
            byte[] ciphertext = new byte[rBytes.Length + eBytes.Length];
            Array.Copy(rBytes, ciphertext, rBytes.Length);
            Array.Copy(eBytes, 0, ciphertext, rBytes.Length, eBytes.Length);

            return ciphertext;
        }


        // Допоміжний метод для генерації випадкового числа k такого, що gcd(k, p-1) = 1
        private BigInteger GenerateRandomK()
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] bytes = new byte[q.ToByteArray().Length];
                rng.GetBytes(bytes);
                BigInteger k = new BigInteger(bytes);
                // Ensure k is within the range [1, p-1] and gcd(k, p-1) = 1
                k = BigInteger.Abs(k) % (p - 1) + 1;
                if (BigInteger.GreatestCommonDivisor(k, p - 1) == 1)
                    return k;
                else
                    return GenerateRandomK(); // Retry if gcd condition fails
            }
        }

        // Допоміжний метод для обчислення модуля, оберненого до mod m
        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0, x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                // q is quotient
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += m0;

            return x;
        }
    }
}

