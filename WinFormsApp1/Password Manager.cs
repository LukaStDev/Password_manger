using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoHandler;
using PasswordHandler;


namespace WinFormsApp1
{
    public partial class PasswordForm : Form
    {
        Service S;
        string password;
        VaultStorage Vault;
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public PasswordForm(Service S, string Password)
        {
            this.S = S;
            this.password = Password;


            InitializeComponent();
            FillDiag();
        }

        private void FillDiag()
        {
            this.TitleBox.Text = S.Title;
            this.UsernameBox.Text = S.Username;
            this.AddressBox.Text = S.Address;
            this.NoteBox.Text = S.Description;

            this.AccountPassword.Text = password;
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            //myTimer.Interval = 1;

            if (this.buttonShowPassword.Text == "Show Password")
            {
                this.AccountPassword.UseSystemPasswordChar = false;
                this.buttonShowPassword.Text = "Hide Password";
                return;
            }

            if (this.buttonShowPassword.Text == "Hide Password")
            {
                this.AccountPassword.UseSystemPasswordChar = true;
                this.buttonShowPassword.Text = "Show Password";
                return;
            }

        }

        private void RenameClipboardButton(Object myObject, EventArgs myEventArgs)
        {
            this.buttonCopyClipboard.Text = "Copy to Clipboard";
            myTimer.Stop();
        }

        private void buttonCopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.AccountPassword.Text);
            this.buttonCopyClipboard.Text = "Copied!";
            myTimer.Tick += new EventHandler(RenameClipboardButton);
            myTimer.Interval = 1000;
            myTimer.Start();
        }

        /*private void buttonChangePassword_Click(object sender, EventArgs e)
        {

            Service Selected = this.AccountList.SelectedItem as Service;
            Vault.ChangePassword(Selected.ServiceID, AES, this.checkBox1.Checked);
            Vault.StoreVault();
            FillVault();
            FillAccountList();
            this.AccountList.SelectedItem = Selected;

        }*/

        private void AccountName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
