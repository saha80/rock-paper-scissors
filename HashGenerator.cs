using System;
using System.Text;
using System.Security.Cryptography;

namespace task3
{
    public class HashGenerator
    {
        public readonly byte[] Key = new byte[16];
        readonly HMACSHA256 _hmac;

        public HashGenerator()
        {
            RandomNumberGenerator.Create().GetBytes(Key);
            _hmac = new HMACSHA256(Key);
        }

        public static int GenerateInt32(int toExclusive)
        {
            return RandomNumberGenerator.GetInt32(toExclusive);
        }

        public string GetHMAC(string message)
        {
            var hash = _hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
            return BitConverter.ToString(hash).Replace("-", "");
        }
    }
}