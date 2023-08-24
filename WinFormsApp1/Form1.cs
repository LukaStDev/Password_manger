using CryptoHandler;
using PasswordHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static List<string> StrengthColours = new List<string>() { "#ff0000", "#ffb300", "#ffff00", "#a7ff00", "#00ff00" };
        private static List<string> StrengthNames = new List<string>() { "Very Weak", "Weak", "Passable", "Strong", "Very Strong" };

        bool PasswordVisible = false;
        bool ForceClose = true;
        LoginInstallForm FatherForm;
        public Form1(LoginInstallForm form)
        {
            InitializeComponent();

            this.label4.Text = "Please choose your Username and Master Password. " +
                "The Username is used as a salt to make the Password harder to crack. " +
                "Make sure that your Master Password is strong and that you remember it. " +
                "A weak Master Password will reduce security of this application but if you forget your " +
                "master password you will no longer be able to log in to that vault and all the passwords in " +
                "the vault will be lost. Choose wisely";
            UpdateStrength();
            FatherForm = form;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (radioRandomPassword.Checked)
            {

                var Generated = PasswordGenerator.GeneratePasswordStandard(checkBoxSpecialChar.Checked, ((int)numericCharCount.Value));
                this.textBoxPassword.Text = Generated;
                this.textBoxConfirmPassword.Text = Generated;

                UpdateStrength();
            }
            else if (radioDiceware.Checked)
            {
                var Generated = PasswordGenerator.GeneratePasswordDiceWare();
                this.textBoxPassword.Text = Generated;
                this.textBoxConfirmPassword.Text = Generated;
            }

            UpdateStrength();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PasswordVisible)
            {
                PasswordVisible = false;
                this.textBoxPassword.UseSystemPasswordChar = true;
                this.textBoxConfirmPassword.UseSystemPasswordChar = true;
                this.button2.Text = "Show";
            }
            else
            {
                PasswordVisible = true;
                this.textBoxPassword.UseSystemPasswordChar = false;
                this.textBoxConfirmPassword.UseSystemPasswordChar = false;
                this.button2.Text = "Hide";
            }
        }

        private void UpdateStrength()
        {
            if (this.textBoxPassword.Text.Length > 0)
            {
                Zxcvbn.Result PassStrength = Zxcvbn.Core.EvaluatePassword(this.textBoxPassword.Text);
                this.textBoxStrengthCheck.Text = StrengthNames[PassStrength.Score];
                this.textBoxStrengthCheck.BackColor = ColorTranslator.FromHtml(StrengthColours[PassStrength.Score]);
            }
            else
            {
                this.textBoxStrengthCheck.Text = "Strength";
                this.textBoxStrengthCheck.BackColor = SystemColors.Control;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.textBoxVault.Text))
            {
                MessageBox.Show("A vault with that name already exists");
                return;
            }
            if (this.textBoxVault.Text == String.Empty)
            {
                MessageBox.Show("Please enter a vault name");
                return;
            }
            if (this.textBoxUsername.Text == String.Empty)
            {
                MessageBox.Show("Please enter a username");
                return;
            }
            if (!this.textBoxPassword.Text.Equals(this.textBoxConfirmPassword.Text))
            {
                MessageBox.Show("Passwords have to match");
                return;
            }

            var KeyGen = new PBKDF2KeyGen(this.textBoxPassword.Text, this.textBoxUsername.Text);
            var AES = new AESVaultEncryptor(KeyGen.DeriveKey());

            var Meta = new MetadataStorage(this.textBoxVault.Text);
            var Passwords = new VaultStorage(Meta.MetadataHash(), null);

            var Vault = new VaultDataFileManager(Program.ExePath + this.textBoxVault.Text, Meta, Passwords);

            FatherForm.Config.Add(this.textBoxVault.Text);
            FatherForm.SaveConfig();


            Vault.StoreData(AES);

            Program.Vault = Vault;
            Program.Cryptor = AES;

            this.ForceClose = false;
            this.Close();

        }

        private void UpdateNumber(object sender, EventArgs e)
        {
            this.numericCharCount.Value = this.sliderCharWordCount.Value;
        }

        private void DisableOptions(object sender, EventArgs e)
        {
            if (this.radioDiceware.Checked)
            {
                this.labelLength.Enabled = false;
                this.numericCharCount.Enabled = false;
                this.sliderCharWordCount.Enabled = false;
                this.checkBoxSpecialChar.Enabled = false;
            }
        }

        private void EnableOptions(object sender, EventArgs e)
        {
            if (this.radioDiceware.Checked)
            {
                this.labelLength.Enabled = true;
                this.numericCharCount.Enabled = true;
                this.sliderCharWordCount.Enabled = true;
                this.checkBoxSpecialChar.Enabled = true;
            }
        }

        private void PasswordStrength(object sender, EventArgs e)
        {
            UpdateStrength();
        }

        private void OpenLoginScreen(object sender, FormClosedEventArgs e)
        {
            if (this.ForceClose)
                Application.Restart();
        }
    }
}
