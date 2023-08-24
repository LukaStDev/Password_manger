using CryptoHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHandler
{
    public class VaultStorage
    {
        private Int32 PasswordCount;
        public byte[] MetadataHash;
        private Dictionary<Int32, byte[]> EncryptedPasswords;

        public VaultStorage(byte[] metadataHash, Dictionary<Int32, byte[]>? encryptedPasswords)
        {
            if(encryptedPasswords == null)
            {
                PasswordCount = 0;
                EncryptedPasswords = new Dictionary<Int32, byte[]>();
            } else
            {
                PasswordCount = encryptedPasswords.Count;
                EncryptedPasswords = encryptedPasswords;
            }
            MetadataHash = metadataHash;

        }

        public static VaultStorage OpenVault(byte[] MetadatHash, byte[] VaultData)
        {
            
            MemoryStream DataStream = new MemoryStream(VaultData);


            using (var Reader = new BinaryReader(DataStream))
            {
                Int32 PasswordCount = Reader.ReadInt32();
                byte[] HashValid = Reader.ReadBytes(MetadatHash.Length);

                if(HashValid.SequenceEqual(MetadatHash) == false)
                {
                    throw new InstallException("Metadata hashes do not match");
                }
                Dictionary<Int32, byte[]> Passwords = null;
                if (Reader.ReadInt32() == 0)
                {
                    Passwords = new Dictionary<Int32, byte[]>();
                    for (int i = 0; i < PasswordCount; i++)
                    {
                        Int32 ServiceID = Reader.ReadInt32();
                        Int32 PasswordLength = Reader.ReadInt32();
                        byte[] EncryptedPassword = Reader.ReadBytes((int)PasswordLength);
                        Passwords.Add(ServiceID, EncryptedPassword);
                    }
                }

                return new VaultStorage(MetadatHash, Passwords);
            }
              
        }

        public int AddPassword(Int32 ServiceID, byte[] Password)
        {
            this.EncryptedPasswords.Add(ServiceID, Password);
            this.PasswordCount++;
            return PasswordCount;
        }

        public int RemovePassword(Int32 ServiceID)
        {
            if(this.EncryptedPasswords.Remove(ServiceID))
                this.PasswordCount--;
            return PasswordCount;
        }

        public int ChangePassword(Int32 ServiceID, byte[] Password)
        {
            RemovePassword(ServiceID);
            AddPassword(ServiceID, Password);
            return ServiceID;
        }

        public string GetPassword(Int32 ServiceID, AESVaultEncryptor Decryptor)
        {

            return Encoding.Unicode.GetString(Decryptor.SinglePassDecrypt(this.EncryptedPasswords[ServiceID]));
        }

        public static bool ValidateVault(string VaultPath)
        {
            if(File.Exists(VaultPath))
            {
                return true;
            }

            return false;
        }

        //public int StoreVault()
        //{
        //    using (var Stream = File.Open(this.VaultPath, FileMode.Create))
        //    {
        //        using (var Writer = new BinaryWriter(Stream))
        //        {
        //            Writer.Write(this.PasswordCount);
        //            Writer.Write(this.MetadataHash);
                    
        //            foreach(var KP in this.EncryptedPasswords)
        //            {
        //                Writer.Write(KP.Key);
        //                Writer.Write(KP.Value.Length);
        //                Writer.Write(KP.Value);
        //            }
                   
        //        }
        //    }

        //    return 0;
        //}

        public byte[] StoreVaultToMemory(byte[] NewMetadataHash)
        {
            using (var Stream = new MemoryStream())
            {
                using (var Writer = new BinaryWriter(Stream))
                {
                    Writer.Write(this.PasswordCount);
                    Writer.Write(NewMetadataHash);
                    
                    if (this.EncryptedPasswords.Count > 0)
                    {
                        Writer.Write(0);
                        foreach (var KP in this.EncryptedPasswords)
                        {
                            Writer.Write(KP.Key);
                            Writer.Write(KP.Value.Length);
                            Writer.Write(KP.Value);
                        }
                    } else
                    {
                        Writer.Write(-1);
                    }

                }

                return Stream.ToArray();
            }
        }
        public List<string> ReturnAllPasswords(AESVaultEncryptor Decryptor)
        {
            throw new NotImplementedException();
        }
    }
}


/*
byte[] rv = new byte[a1.Length + a2.Length + a3.Length];
System.Buffer.BlockCopy(a1, 0, rv, 0, a1.Length);
System.Buffer.BlockCopy(a2, 0, rv, a1.Length, a2.Length);
System.Buffer.BlockCopy(a3, 0, rv, a1.Length + a2.Length, a3.Length);
*/