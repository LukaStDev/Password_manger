using CryptoHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHandler
{
    public class VaultDataFileManager
    {
        string Path = "Vault.bin";
        public MetadataStorage Meta { get; set; }
        public VaultStorage  Vault { get; set; }

        public VaultDataFileManager(string path, MetadataStorage meta, VaultStorage vault)
        {
            Path = path;
            Meta = meta;
            Vault = vault;
        }

        public VaultDataFileManager(string path, AESVaultEncryptor AES)
        {
            Path = path;

            using(var ReadStream = File.OpenRead(Path))
            {
                using (var Reader = new BinaryReader(ReadStream))
                {
                    Int32 MetaByteLength = Reader.ReadInt32();
                    Meta = MetadataStorage.OpenMetadata(AES, Reader.ReadBytes(MetaByteLength));

                    Int32 VaultByteLength = Reader.ReadInt32();
                    Vault = VaultStorage.OpenVault(Meta.MetadataHash(), Reader.ReadBytes(VaultByteLength));
                }
            }
        }

        public int StoreData(AESVaultEncryptor AES)
        {
            byte[] Metadata = Meta.ReturnMetadataForStorage(AES);
            byte[] PasswordData = Vault.StoreVaultToMemory(Meta.MetadataHash());
            using (var Stream = File.Open(this.Path, FileMode.Create))
            {
                using (var Writer = new BinaryWriter(Stream))
                {
                    Writer.Write(Metadata.Length);
                    Writer.Write(Metadata);

                    Writer.Write(PasswordData.Length);
                    Writer.Write(PasswordData);
                }
            }

            return 0;
        }

        public int StoreData(AESVaultEncryptor AES, FileStream fs)
        {
            byte[] Metadata = Meta.ReturnMetadataForStorage(AES);
            byte[] PasswordData = Vault.StoreVaultToMemory(Meta.MetadataHash());
            
            using (var Writer = new BinaryWriter(fs))
            {
                Writer.Write(Metadata.Length);
                Writer.Write(Metadata);

                Writer.Write(PasswordData.Length);
                Writer.Write(PasswordData);
            }
            

            return 0;
        }
    }
}
