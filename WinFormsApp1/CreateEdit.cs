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

    public partial class CreateEdit : Form
    {
        MainMenuForm MainReference;

        private static List<string> StrengthColours = new List<string>() { "#ff0000", "#ffb300", "#ffff00", "#a7ff00", "#00ff00" };
        private static List<string> StrengthNames = new List<string>() { "Very Weak", "Weak", "Passable", "Strong", "Very Strong" };

        private Service? S;
        private string? Password;

        public CreateEdit(MainMenuForm Main, Service? S = null, string Password = "")
        {
            InitializeComponent();

            this.textBoxPassword.TextChanged += PasswordChangeEval;
            MainReference = Main;
            if (S != null)
            {
                this.S = S;
                this.Password = Password;

                FillTextEdit();
                MakeTextBoxHighlight();

                this.labelTitle.Text = "Edit Password";
                this.buttonCreateEdit.Text = "Commit Edit";
                this.buttonCreateEdit.Click += EditPassword;
                this.buttonReset.Enabled = true;
                this.buttonReset.Visible = true;
            }
            else
            {
                this.labelTitle.Text = "Add New Password";
                this.buttonReset.Enabled = false;
                this.buttonReset.Visible = false;
                this.buttonCreateEdit.Text = "Create New";
                this.buttonCreateEdit.Click += CreatePassword;
                this.buttonCreateEdit.PerformClick();
            }

        }

        private void CreatePassword(object sender, EventArgs e)
        {
            if (this.textBoxTitle.Text == String.Empty
                || this.textBoxAddr.Text == String.Empty
                || this.textBoxDescription.Text == String.Empty
                || this.textBoxUsername.Text == String.Empty)
            {
                MessageBox.Show("All fields must contain text");
                return;
            }

            if (this.textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Password field is empty");
                return;
            }

            MainReference.AddNewPassword(this.textBoxTitle.Text, this.textBoxUsername.Text, this.textBoxAddr.Text, this.textBoxDescription.Text, this.textBoxPassword.Text);
        }

        private void EditPassword(object sender, EventArgs e)
        {
            if (this.textBoxTitle.Text == String.Empty
                || this.textBoxAddr.Text == String.Empty
                || this.textBoxDescription.Text == String.Empty
                || this.textBoxUsername.Text == String.Empty)
            {
                MessageBox.Show("All fields must contain text");
                return;
            }

            if (this.textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Password field is empty");
                return;
            }

            MainReference.EditPassword(new Service(
                S.ServiceID,
                textBoxTitle.Text,
                textBoxUsername.Text,
                textBoxAddr.Text,
                textBoxDescription.Text), this.textBoxPassword.Text);
        }

        private void FillTextEdit()
        {
            this.textBoxTitle.Text = S.Title;
            this.textBoxUsername.Text = S.Username;
            this.textBoxPassword.Text = this.Password;
            this.textBoxAddr.Text = S.Address;
            this.textBoxDescription.Text = S.Description;

            this.sliderCharWordCount.Value = this.Password.Length;
        }

        private void MakeTextBoxHighlight() //Make sure this is only called once in constructor
        {
            this.textBoxTitle.TextChanged += HighlightChanges;
            this.textBoxUsername.TextChanged += HighlightChanges;
            this.textBoxPassword.TextChanged += HighlightChanges;
            this.textBoxAddr.TextChanged += HighlightChanges;
            this.textBoxDescription.TextChanged += HighlightChanges;
        }

        private void SetTextBoxFontRegular()
        {
            this.textBoxTitle.Font = new Font(this.textBoxTitle.Font, FontStyle.Regular);
            this.textBoxUsername.Font = new Font(this.textBoxUsername.Font, FontStyle.Regular);
            this.textBoxPassword.Font = new Font(this.textBoxPassword.Font, FontStyle.Regular);
            this.textBoxAddr.Font = new Font(this.textBoxAddr.Font, FontStyle.Regular);
            this.textBoxDescription.Font = new Font(this.textBoxDescription.Font, FontStyle.Regular);
        }

        private void HighlightChanges(object sender, EventArgs e)
        {
            TextBox TextBoxReference = (TextBox)sender;
            TextBoxReference.Font = new Font(TextBoxReference.Font, FontStyle.Bold);
        }

        private void SynchronizeScroll(object sender, EventArgs e)
        {
            this.numericCharCount.Value = this.sliderCharWordCount.Value;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            FillTextEdit();
            SetTextBoxFontRegular();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (radioRandomPassword.Checked)
            {
                this.textBoxPassword.Text = PasswordGenerator.GeneratePasswordStandard(checkBoxSpecialChar.Checked, ((int)numericCharCount.Value));

                UpdateStrength();
            }
            else if (radioDiceware.Checked)
            {
                this.textBoxPassword.Text = PasswordGenerator.GeneratePasswordDiceWare();
            }
        }

        private void PasswordChangeEval(object sender, EventArgs e)
        {
            UpdateStrength();
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
    }
}
