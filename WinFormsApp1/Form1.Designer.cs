namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label4 = new Label();
            button1 = new Button();
            buttonGenerate = new Button();
            radioDiceware = new RadioButton();
            radioRandomPassword = new RadioButton();
            checkBoxSpecialChar = new CheckBox();
            sliderCharWordCount = new TrackBar();
            labelLength = new Label();
            numericCharCount = new NumericUpDown();
            button2 = new Button();
            textBoxConfirmPassword = new TextBox();
            label5 = new Label();
            textBoxStrengthCheck = new TextBox();
            textBoxVault = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)sliderCharWordCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCharCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(718, 52);
            label1.TabIndex = 0;
            label1.Text = "Password Manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 250);
            label2.Name = "label2";
            label2.Size = new Size(127, 27);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(12, 307);
            label3.Name = "label3";
            label3.Size = new Size(127, 27);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(145, 250);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(369, 27);
            textBoxUsername.TabIndex = 3;
            textBoxUsername.Text = "Luka Glavočić";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(145, 307);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(369, 27);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.Text = "UbicaLuka10";
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += PasswordStrength;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Location = new Point(12, 52);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 2, 20, 2);
            label4.Size = new Size(694, 122);
            label4.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(283, 509);
            button1.Name = "button1";
            button1.Size = new Size(153, 75);
            button1.TabIndex = 6;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.FromArgb(176, 219, 241);
            buttonGenerate.FlatStyle = FlatStyle.System;
            buttonGenerate.Location = new Point(54, 386);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(87, 81);
            buttonGenerate.TabIndex = 30;
            buttonGenerate.Text = "Generate password";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // radioDiceware
            // 
            radioDiceware.AutoSize = true;
            radioDiceware.Location = new Point(340, 386);
            radioDiceware.Name = "radioDiceware";
            radioDiceware.Size = new Size(172, 24);
            radioDiceware.TabIndex = 29;
            radioDiceware.TabStop = true;
            radioDiceware.Text = "Memorable Password";
            radioDiceware.UseVisualStyleBackColor = true;
            radioDiceware.CheckedChanged += DisableOptions;
            // 
            // radioRandomPassword
            // 
            radioRandomPassword.AutoSize = true;
            radioRandomPassword.Checked = true;
            radioRandomPassword.Location = new Point(152, 386);
            radioRandomPassword.Name = "radioRandomPassword";
            radioRandomPassword.Size = new Size(151, 24);
            radioRandomPassword.TabIndex = 28;
            radioRandomPassword.TabStop = true;
            radioRandomPassword.Text = "Random Password";
            radioRandomPassword.UseVisualStyleBackColor = true;
            radioRandomPassword.CheckedChanged += EnableOptions;
            // 
            // checkBoxSpecialChar
            // 
            checkBoxSpecialChar.AutoSize = true;
            checkBoxSpecialChar.Location = new Point(463, 441);
            checkBoxSpecialChar.Name = "checkBoxSpecialChar";
            checkBoxSpecialChar.Size = new Size(152, 24);
            checkBoxSpecialChar.TabIndex = 27;
            checkBoxSpecialChar.Text = "Special Characters";
            checkBoxSpecialChar.UseVisualStyleBackColor = true;
            // 
            // sliderCharWordCount
            // 
            sliderCharWordCount.Location = new Point(207, 440);
            sliderCharWordCount.Maximum = 64;
            sliderCharWordCount.Name = "sliderCharWordCount";
            sliderCharWordCount.Size = new Size(250, 56);
            sliderCharWordCount.TabIndex = 26;
            sliderCharWordCount.Value = 32;
            sliderCharWordCount.Scroll += UpdateNumber;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelLength.Location = new Point(152, 413);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(138, 23);
            labelLength.TabIndex = 25;
            labelLength.Text = "Password Length";
            // 
            // numericCharCount
            // 
            numericCharCount.Location = new Point(152, 440);
            numericCharCount.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            numericCharCount.Name = "numericCharCount";
            numericCharCount.Size = new Size(49, 27);
            numericCharCount.TabIndex = 24;
            numericCharCount.TextAlign = HorizontalAlignment.Center;
            numericCharCount.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(176, 219, 241);
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(524, 307);
            button2.Name = "button2";
            button2.Size = new Size(95, 27);
            button2.TabIndex = 31;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(145, 340);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(369, 27);
            textBoxConfirmPassword.TabIndex = 33;
            textBoxConfirmPassword.Text = "UbicaLuka10";
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Location = new Point(0, 340);
            label5.Name = "label5";
            label5.Size = new Size(139, 27);
            label5.TabIndex = 32;
            label5.Text = "Confirm Password:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxStrengthCheck
            // 
            textBoxStrengthCheck.Location = new Point(524, 340);
            textBoxStrengthCheck.Name = "textBoxStrengthCheck";
            textBoxStrengthCheck.Size = new Size(182, 27);
            textBoxStrengthCheck.TabIndex = 34;
            textBoxStrengthCheck.Text = "Strength";
            textBoxStrengthCheck.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVault
            // 
            textBoxVault.Location = new Point(145, 192);
            textBoxVault.Name = "textBoxVault";
            textBoxVault.Size = new Size(369, 27);
            textBoxVault.TabIndex = 36;
            // 
            // label6
            // 
            label6.Location = new Point(12, 192);
            label6.Name = "label6";
            label6.Size = new Size(127, 27);
            label6.TabIndex = 35;
            label6.Text = "Vault Name:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 607);
            Controls.Add(textBoxVault);
            Controls.Add(label6);
            Controls.Add(textBoxStrengthCheck);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(buttonGenerate);
            Controls.Add(radioDiceware);
            Controls.Add(radioRandomPassword);
            Controls.Add(checkBoxSpecialChar);
            Controls.Add(sliderCharWordCount);
            Controls.Add(labelLength);
            Controls.Add(numericCharCount);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += OpenLoginScreen;
            ((System.ComponentModel.ISupportInitialize)sliderCharWordCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCharCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label4;
        private Button button1;
        private Button buttonGenerate;
        private RadioButton radioDiceware;
        private RadioButton radioRandomPassword;
        private CheckBox checkBoxSpecialChar;
        private TrackBar sliderCharWordCount;
        private Label labelLength;
        private NumericUpDown numericCharCount;
        private Button button2;
        private TextBox textBoxConfirmPassword;
        private Label label5;
        private TextBox textBoxStrengthCheck;
        private TextBox textBoxVault;
        private Label label6;
    }
}