using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoHandler;
using PasswordHandler;

namespace WinFormsApp1
{
    public partial class MainMenuForm : Form
    {
        //Fields
        private int tempIndex;
        private Form activeForm;

        

        AESVaultEncryptor One;
        VaultDataFileManager Data;
        //Constructor
        public MainMenuForm(AESVaultEncryptor One, VaultDataFileManager Vault)
        {
            this.One = One;
            this.Data = Vault;
            
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            //this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //MessageBox.Show(Data.Meta.AvailableID.ToString());
            try
            {
                PopulatePasswordList();
            }
            catch (InstallException ex)
            {

            }



        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods

        private void Install()
        {

        }

        private void ImportPasswords()
        {
            throw new NotImplementedException();
        }
        private void PopulatePasswordList()
        {
            try
            {
                this.PasswordList.Items.Clear();
                foreach (var s in Data.Meta.Services)
                {
                    PasswordList.Items.Add(s);
                }
                this.PasswordList.Refresh();
            } catch
            {
                Application.Exit();
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.btnCloseChildForm.Visible = true;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Reset();
        }
        private void Reset()
        {
            lblTitle.Text = "Password Manager";
            DeselectPassword();
            btnCloseChildForm.Visible = false;
        }



        private void SelectService(object sender, EventArgs e)
        {
            if (this.PasswordList.SelectedItem != null)
            {
                var ActiveService = this.PasswordList.SelectedItem as Service;

                OpenChildForm(new PasswordForm(ActiveService, Data.Vault.GetPassword(ActiveService.ServiceID, One)), sender);
                
            }
        }

        private void DeselectPassword()
        {
            this.PasswordList.SelectedIndexChanged -= SelectService;
            this.PasswordList.SelectedItem = null;
            this.PasswordList.SelectedIndexChanged += SelectService;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(this.PasswordList.SelectedItem == null)
            {
                MessageBox.Show("Please select the password you wish to delete!");
                return;
            }
            
            Service ActiveService = this.PasswordList.SelectedItem as Service;

            btnCloseChildForm.PerformClick();

            Data.Meta.RemoveService(ActiveService.ServiceID);
            Data.Vault.RemovePassword(ActiveService.ServiceID);

            Data.StoreData(One);

            DeselectPassword();

            this.PasswordList.Items.Remove(ActiveService);
            this.PasswordList.Refresh();

        }


        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateEdit(this), sender);

            DeselectPassword();
        }

        private void buttonEditPassword_Click(object sender, EventArgs e)
        {
            if (this.PasswordList.SelectedItems.Count < 1)
            {
                return;
            }

            var ActiveService = this.PasswordList.SelectedItem as Service;
            OpenChildForm(new CreateEdit(this, ActiveService, Data.Vault.GetPassword(ActiveService.ServiceID, One)), sender);

            DeselectPassword();
        }

        public void AddNewPassword(string ServiceTitle, string ServiceUsername, string ServiceAddress, string ServiceNote, string NewPassword)
        {
            //MessageBox.Show(Data.Meta.AvailableID.ToString());
            try
            {
                var ServiceID = Data.Meta.AddService(ServiceTitle, ServiceUsername, ServiceAddress, ServiceNote);
                Data.Vault.AddPassword(ServiceID, One.SinglePassEncrypt(Encoding.Unicode.GetBytes(NewPassword)));

                Data.StoreData(One);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            btnCloseChildForm.PerformClick();
            PopulatePasswordList();
        }

        public void EditPassword(Service S, string EditedPassword)
        {
            //MessageBox.Show(Data.Meta.AvailableID.ToString());
            try
            {
                Data.Meta.EditService(S.ServiceID, S.Title, S.Username, S.Address, S.Description);
                Data.Vault.ChangePassword(S.ServiceID, One.SinglePassEncrypt(Encoding.Unicode.GetBytes(EditedPassword)));

                Data.StoreData(One);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            btnCloseChildForm.PerformClick();
            PopulatePasswordList();
        }
    }
}
