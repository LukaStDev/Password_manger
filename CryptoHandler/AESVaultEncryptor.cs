using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoHandler
{
    public class AESVaultEncryptor
    {
        
        
        private static int KeyLength = 32; //AES Key (bytes)
        private static int IVSize = 12; //AES IV nonce (bytes)
        private static int MACSize = 16; //Atuhentication MAC size (bytes)

        private AesGcm AesCryptor;

        public AESVaultEncryptor(byte[] key)
        {
            AesCryptor = new AesGcm(key);
        }

        public byte[] SinglePassEncrypt(byte[] PlainText)
        {
            byte[] IVNonce = RandomNumberGenerator.GetBytes(IVSize);
            byte[] MACStore = new byte[MACSize];
            byte[] Cyphertext = new byte[PlainText.Length];

            AesCryptor.Encrypt(IVNonce, PlainText, Cyphertext, MACStore);

            byte[] CyphertextMetadata = new byte[IVNonce.Length + MACStore.Length + Cyphertext.Length];     //Concateniram sva byte polja u jedan
            System.Buffer.BlockCopy(IVNonce, 0, CyphertextMetadata, 0, IVNonce.Length);
            System.Buffer.BlockCopy(MACStore, 0, CyphertextMetadata, IVNonce.Length, MACStore.Length);      //Nije osobito elegantno al je brzo i funkcionira
            System.Buffer.BlockCopy(Cyphertext, 0, CyphertextMetadata, IVNonce.Length + MACStore.Length, Cyphertext.Length);

            return CyphertextMetadata; //Format = IV(12) + MAC(16) + Cyphertext
        }
        public byte[] SinglePassDecrypt(byte[] CyphertextMetadata) { 
            Span<byte> Cyphertext = new Span<byte>(CyphertextMetadata);

            byte[] Plaintext = new byte[Cyphertext.Length - IVSize - MACSize];


            AesCryptor.Decrypt(Cyphertext.Slice(0, IVSize)
                , Cyphertext.Slice(IVSize + MACSize, Cyphertext.Length - IVSize - MACSize)
                , Cyphertext.Slice(IVSize, MACSize)
                , Plaintext);

            return Plaintext;
        
        }
       
    }
}
