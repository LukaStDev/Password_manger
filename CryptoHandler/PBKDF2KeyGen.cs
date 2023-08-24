using System.Security.Cryptography;
using System.Text;

namespace CryptoHandler
{
    public class PBKDF2KeyGen
    {
        private static int IterationCount = 600000; //All the constant values for PBKDF2 Algo
        private static HashAlgorithmName HashingAlgorithm = new HashAlgorithmName("SHA512");
        private static int OutputLength = 32; //AES Key size (bytes)

        private byte[] Password; //These values are filled in the constructor by converting them from bytes
        private byte[] Salt;

        public PBKDF2KeyGen(string password, string salt)   //The password and salt are passed in as strings in UTF8 encoding and
                                                            //converted to byte[]
        {
            this.Password = Encoding.UTF8.GetBytes(password);
            this.Salt = Encoding.UTF8.GetBytes(salt);
        }

        public byte[] DeriveKey() //Simple key derivation, no error handling
        {
            return Rfc2898DeriveBytes.Pbkdf2(this.Password, this.Salt, IterationCount, HashingAlgorithm, OutputLength);
        }
    }
}