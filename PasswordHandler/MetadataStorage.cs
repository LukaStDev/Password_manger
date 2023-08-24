using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CryptoHandler;

namespace PasswordHandler
{
    public class MetadataStorage
    {
        public Int32 AvailableID;
        public string MetadataTitle;

        public IList<Service> Services;

        //public MetadataStorage(AESVaultEncryptor Decryptor, string metadataPath = "AccountInfo.bin", string vaultPath = "PasswordStorage.bin")
        //{
        //    MetadataPath = metadataPath;
        //    VaultPath = vaultPath;
            
        //    if(File.Exists(MetadataPath))
        //    {
        //        byte[] MetadataEncrypted = File.ReadAllBytes(MetadataPath);

                
        //        string MetadataJson = Encoding.Unicode.GetString(Decryptor.SinglePassDecrypt(MetadataEncrypted));
        //        Console.WriteLine(MetadataJson);

        //        Services = JsonSerializer.Deserialize<IList<Service>>(MetadataJson);

        //        AvailableID = Services.OrderByDescending(x => x.ServiceID).FirstOrDefault().ServiceID;
        //    }
        //    else
        //    {
        //        throw new InstallException("Metadata File not present, installation required");
        //    }
        //}

        public static MetadataStorage OpenMetadata(AESVaultEncryptor Decryptor, byte[] MetadataEncrypted)
        {
            using (var BinaryMetadata = new MemoryStream(Decryptor.SinglePassDecrypt(MetadataEncrypted)))
            {
                using (var MetadataReader = new BinaryReader(BinaryMetadata))
                {
                    if (MetadataReader.ReadInt32() == 0)
                    {

                        var JsonSize = MetadataReader.ReadInt32();
                        var MetadataJson = Encoding.Unicode.GetString(
                                MetadataReader.ReadBytes(JsonSize));

                        var MetadataTitleSize = MetadataReader.ReadInt32();
                        var MetadataTitle = Encoding.Unicode.GetString(MetadataReader.ReadBytes(MetadataTitleSize));

                        var Services = JsonSerializer.Deserialize<IList<Service>>(MetadataJson);

                        var AvailableID = Services.OrderByDescending(x => x.ServiceID).First().ServiceID + 1;

                        return new MetadataStorage(AvailableID, MetadataTitle, Services);
                    }

                    var MetadataTitleSize1 = MetadataReader.ReadInt32();
                    var MetadataTitle1 = Encoding.Unicode.GetString(MetadataReader.ReadBytes(MetadataTitleSize1));

                    MetadataReader.BaseStream.Position = 0;
                    return new MetadataStorage(MetadataTitle1);
                }
            }

        }

        public MetadataStorage(string metadataTitle, string ServiceTitle, string ServiceUsername, string ServiceAddress, string ServiceNote)
        {
            this.MetadataTitle= metadataTitle;
            this.AvailableID = 1;
            this.Services = new List<Service>();
            this.Services.Add(new Service(0, ServiceTitle, ServiceUsername, ServiceAddress, ServiceNote));
        }

        public MetadataStorage(string metadataTitle)
        {
            MetadataTitle = metadataTitle;
            this.Services= new List<Service>();
            this.AvailableID = 0;
        }

        public MetadataStorage(int availableID, string metadataTitle, IList<Service> services)
        {
            AvailableID = availableID;
            MetadataTitle = metadataTitle;
            Services = services;
        }

        public int AddService(string ServiceTitle, string ServiceUsername, string ServiceAddress, string ServiceNote)
        {
            foreach(Service service in Services)
            {
                if (service.Title == ServiceTitle)
                {
                    throw new ArgumentException("Invalid title. Another password with the same title exists. Please choose another title");
                }
            }

            this.Services.Add(new Service(AvailableID, ServiceTitle, ServiceUsername, ServiceAddress, ServiceNote));
            this.AvailableID++;
            return AvailableID - 1;
        }

        public int AddService(Service Service)
        {
            foreach (Service Current in Services)
            {
                if (Current.Title == Service.Title)
                {
                    throw new ArgumentException("Invalid title. Another password with the same title exists. Please choose another title");
                }
            }
            
            this.Services.Add(Service);
            this.AvailableID++;
            return 0;
        }

        public int RemoveService(Int32 ServiceID)
        {
            if (this.Services.Remove(Services.FirstOrDefault<Service>(c => c.ServiceID == ServiceID)))
                return 0;

            return -1;
        }
        public int EditService(Int32 ServiceID, string ServiceTitle, string ServiceUsername, string ServiceAddress, string ServiceNote)
        {

            if (this.Services.Remove(Services.FirstOrDefault<Service>(c => c.ServiceID == ServiceID)))
            {
                this.Services.Add(new Service(ServiceID, ServiceTitle, ServiceUsername, ServiceAddress, ServiceNote));
                return 0;
            }

            return -1;
        }


        //public int StoreMetadata(AESVaultEncryptor Encryptor)
        //{
        //    foreach(Service s in Services)
        //    {
        //        Console.WriteLine(s.ToString());
        //    }

        //    var Options = new JsonSerializerOptions { WriteIndented = true};
        //    string ServiceData = JsonSerializer.Serialize(this.Services, Options);
        //    Console.WriteLine(ServiceData);
        //    byte[] EncryptedServiceData = Encryptor.SinglePassEncrypt(Encoding.Unicode.GetBytes(ServiceData));

        //    File.WriteAllBytes(this.MetadataPath, EncryptedServiceData);
        //    return 0;
        //}

        public byte[] ReturnMetadataForStorage(AESVaultEncryptor Encryptor)
        {
            foreach (Service s in Services)
            {
                Console.WriteLine(s.ToString());
            }

            var Options = new JsonSerializerOptions { WriteIndented = true };
            var ServiceData = JsonSerializer.Serialize(this.Services, Options);
            Console.WriteLine(ServiceData);

            using (var Storage = new MemoryStream())
            {
                using (var Writer = new BinaryWriter(Storage))
                {
                    if (this.Services.Any())
                    {
                        Writer.Write(0);

                        var EncodedJson = Encoding.Unicode.GetBytes(ServiceData);
                        Writer.Write(EncodedJson.Length);
                        Writer.Write(EncodedJson);

                        var EncodedTitle = Encoding.Unicode.GetBytes(this.MetadataTitle);
                        Writer.Write(EncodedTitle.Length);
                        Writer.Write(EncodedTitle);

                    }
                    else
                    {
                        Writer.Write(-1);

                        var EncodedTitle = Encoding.Unicode.GetBytes(this.MetadataTitle);
                        Writer.Write(EncodedTitle.Length);
                        Writer.Write(EncodedTitle);
                    }




                    byte[] Testing = Storage.ToArray();
                    return Encryptor.SinglePassEncrypt(Testing);
                }
            }

        }

        public byte[] MetadataHash()
        {
            using (SHA512 shaM = new SHA512Managed())
            {
                return shaM.ComputeHash(JsonSerializer.SerializeToUtf8Bytes(this.Services));
            }
        }
    }
}
