using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using PasswordHandler;
using CryptoHandler;
using System.Runtime.CompilerServices;

namespace WinFormsApp1
{
    public partial class LoginInstallForm : Form
    {
        static string SettingsPath = "config.json";
        int InstalledLevel; //0 No settings no vault, 1 settings no vault, 2 settings and vault
        public List<string> Config;


        public LoginInstallForm()
        {
            InitializeComponent();
            this.labelInformation.Text = "Welcome, please select a vault and log in";
            ImportAllVaults();


        }

        private void FirstInstallDisableLogin()
        {
            this.labelInformation.Text = "Welcome to my password manager! Password vault could not be found! If you've used my application before and already have a password vault click on Import Vault and Metadata. If you're using this application for the first time, click on Create New Password Store and then we can get started!";
            this.textBoxPassword.Enabled = false;
            this.textBoxUsername.Enabled = false;
            this.labelUsername.Enabled = false;
            this.labelPassword.Enabled = false;
            this.buttonLogin.Enabled = false;
            this.selectVault.Enabled = false;
        }

        private void EnableLogin()
        {
            this.labelInformation.Text = "Welcome, please select a vault and log in";
            this.textBoxPassword.Enabled = true;
            this.textBoxUsername.Enabled = true;
            this.labelUsername.Enabled = true;
            this.labelPassword.Enabled = true;
            this.buttonLogin.Enabled = true;
            this.selectVault.Enabled = true;
        }

        private void ImportAllVaults()
        {
            try
            {
                string Load = File.ReadAllText(Program.ExePath + SettingsPath);
                Config = JsonSerializer.Deserialize<List<string>>(Load);
                Config.RemoveAll(c => !File.Exists(Program.ExePath + c));
                ImportConfigToCombo();
            }
            catch (Exception ex) when (ex is JsonException || ex is IOException)
            {
                Config = new List<string>();
                FirstInstallDisableLogin();
                InstalledLevel = 0;
            }
        }

        private void ImportConfigToCombo()
        {

            if (!Config.Any())
            {
                FirstInstallDisableLogin();
                return;
            }

            this.selectVault.Items.Clear();
            this.selectVault.Items.AddRange(Config.ToArray());
        }

        private void ShowPassword(object sender, MouseEventArgs e)
        {
            this.textBoxPassword.UseSystemPasswordChar = false;
        }

        private void HidePassword(object sender, MouseEventArgs e)
        {
            this.textBoxPassword.UseSystemPasswordChar = true;
        }



        private void buttonImport_Click(object sender, EventArgs e)
        {

            var ImportSuccessfull = this.openFileDialog2.ShowDialog();

            if (ImportSuccessfull == DialogResult.OK)
            {
                var Location = this.openFileDialog2.FileName;

                File.WriteAllBytes(Program.ExePath + Path.GetFileName(Location), File.ReadAllBytes(Location));

                this.selectVault.Items.Add(Path.GetFileName(Location));
                this.Config.Add(Path.GetFileName(Location));

                ImportConfigToCombo();
                EnableLogin();
                SaveConfig();
            }

        }

        public void SaveConfig()
        {
            if (Config.Any())
            {
                var Store = JsonSerializer.Serialize<List<string>>(Config);
                File.WriteAllText(Program.ExePath + SettingsPath, Store);
            }
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {

            this.Enabled = false;
            this.Visible = false;

            Form Form = new Form1(this);
            Form.ShowDialog();


            this.Close();



        }

        private void Authenticate(object sender, EventArgs e)
        {
            if(this.selectVault.SelectedItem == null)
            {
                MessageBox.Show("Please select a vault from the drop down menu");
                return;
            }
            if (this.textBoxUsername.Text == String.Empty || this.textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Please enter a username and/or password");
                return;
            }


            PBKDF2KeyGen KeyGenerator = new PBKDF2KeyGen(this.textBoxPassword.Text, this.textBoxUsername.Text);

            AESVaultEncryptor Cryptor = new AESVaultEncryptor(KeyGenerator.DeriveKey());

            //try
            //{
            VaultDataFileManager Existing = new VaultDataFileManager(Program.ExePath + this.selectVault.Text, Cryptor);

            Program.Cryptor = Cryptor;
            Program.Vault = Existing;

            this.Close();
            //}
            //catch (Exception ex)
            //{


            //this.textBox1.Text = String.Empty;
            //this.textBox2.Text = String.Empty;
            //this.textBoxUsername.Text = "Luka Glavočić";
            //this.textBoxPassword.Text = "UbicaLuka10";
            return;

            //}
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Authenticate(sender, e);
        }


    }
}
