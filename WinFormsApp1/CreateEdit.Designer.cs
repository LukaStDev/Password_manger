namespace WinFormsApp1
{
    partial class CreateEdit
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
            labelTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxTitle = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxAddr = new TextBox();
            textBoxDescription = new TextBox();
            numericCharCount = new NumericUpDown();
            label7 = new Label();
            sliderCharWordCount = new TrackBar();
            checkBoxSpecialChar = new CheckBox();
            radioRandomPassword = new RadioButton();
            radioDiceware = new RadioButton();
            textBoxStrengthCheck = new TextBox();
            buttonCreateEdit = new Button();
            buttonReset = new Button();
            buttonGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)numericCharCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sliderCharWordCount).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, -2);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(763, 60);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Add New / Edit Password";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 53);
            label2.Name = "label2";
            label2.Size = new Size(132, 43);
            label2.TabIndex = 1;
            label2.Text = "Title:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 95);
            label3.Name = "label3";
            label3.Size = new Size(132, 43);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 139);
            label4.Name = "label4";
            label4.Size = new Size(137, 43);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 287);
            label5.Name = "label5";
            label5.Size = new Size(132, 43);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(68, 330);
            label6.Name = "label6";
            label6.Size = new Size(132, 43);
            label6.TabIndex = 5;
            label6.Text = "Description:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(211, 64);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(360, 27);
            textBoxTitle.TabIndex = 6;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(211, 106);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(360, 27);
            textBoxUsername.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(211, 150);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(360, 27);
            textBoxPassword.TabIndex = 8;
            // 
            // textBoxAddr
            // 
            textBoxAddr.Location = new Point(211, 298);
            textBoxAddr.Name = "textBoxAddr";
            textBoxAddr.Size = new Size(360, 27);
            textBoxAddr.TabIndex = 9;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(211, 341);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(360, 127);
            textBoxDescription.TabIndex = 10;
            // 
            // numericCharCount
            // 
            numericCharCount.Location = new Point(211, 237);
            numericCharCount.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            numericCharCount.Name = "numericCharCount";
            numericCharCount.Size = new Size(49, 27);
            numericCharCount.TabIndex = 11;
            numericCharCount.TextAlign = HorizontalAlignment.Center;
            numericCharCount.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(211, 210);
            label7.Name = "label7";
            label7.Size = new Size(138, 23);
            label7.TabIndex = 12;
            label7.Text = "Password Length";
            // 
            // sliderCharWordCount
            // 
            sliderCharWordCount.Location = new Point(266, 237);
            sliderCharWordCount.Maximum = 64;
            sliderCharWordCount.Name = "sliderCharWordCount";
            sliderCharWordCount.Size = new Size(250, 56);
            sliderCharWordCount.TabIndex = 13;
            sliderCharWordCount.Value = 32;
            sliderCharWordCount.Scroll += SynchronizeScroll;
            // 
            // checkBoxSpecialChar
            // 
            checkBoxSpecialChar.AutoSize = true;
            checkBoxSpecialChar.Location = new Point(522, 238);
            checkBoxSpecialChar.Name = "checkBoxSpecialChar";
            checkBoxSpecialChar.Size = new Size(152, 24);
            checkBoxSpecialChar.TabIndex = 14;
            checkBoxSpecialChar.Text = "Special Characters";
            checkBoxSpecialChar.UseVisualStyleBackColor = true;
            // 
            // radioRandomPassword
            // 
            radioRandomPassword.AutoSize = true;
            radioRandomPassword.Checked = true;
            radioRandomPassword.Location = new Point(211, 183);
            radioRandomPassword.Name = "radioRandomPassword";
            radioRandomPassword.Size = new Size(151, 24);
            radioRandomPassword.TabIndex = 15;
            radioRandomPassword.TabStop = true;
            radioRandomPassword.Text = "Random Password";
            radioRandomPassword.UseVisualStyleBackColor = true;
            // 
            // radioDiceware
            // 
            radioDiceware.AutoSize = true;
            radioDiceware.Location = new Point(399, 183);
            radioDiceware.Name = "radioDiceware";
            radioDiceware.Size = new Size(172, 24);
            radioDiceware.TabIndex = 16;
            radioDiceware.TabStop = true;
            radioDiceware.Text = "Memorable Password";
            radioDiceware.UseVisualStyleBackColor = true;
            // 
            // textBoxStrengthCheck
            // 
            textBoxStrengthCheck.Location = new Point(593, 150);
            textBoxStrengthCheck.Name = "textBoxStrengthCheck";
            textBoxStrengthCheck.Size = new Size(182, 27);
            textBoxStrengthCheck.TabIndex = 17;
            textBoxStrengthCheck.Text = "Strength";
            textBoxStrengthCheck.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCreateEdit
            // 
            buttonCreateEdit.BackColor = Color.FromArgb(176, 219, 241);
            buttonCreateEdit.FlatStyle = FlatStyle.Flat;
            buttonCreateEdit.Location = new Point(313, 483);
            buttonCreateEdit.Name = "buttonCreateEdit";
            buttonCreateEdit.Size = new Size(160, 64);
            buttonCreateEdit.TabIndex = 18;
            buttonCreateEdit.Text = "Create/Edit";
            buttonCreateEdit.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.FromArgb(176, 219, 241);
            buttonReset.Enabled = false;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new Point(593, 483);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(125, 64);
            buttonReset.TabIndex = 19;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Visible = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.FromArgb(176, 219, 241);
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Location = new Point(113, 222);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(87, 54);
            buttonGenerate.TabIndex = 21;
            buttonGenerate.Text = "Generate password";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // CreateEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 227, 237);
            ClientSize = new Size(787, 559);
            Controls.Add(buttonGenerate);
            Controls.Add(buttonReset);
            Controls.Add(buttonCreateEdit);
            Controls.Add(textBoxStrengthCheck);
            Controls.Add(radioDiceware);
            Controls.Add(radioRandomPassword);
            Controls.Add(checkBoxSpecialChar);
            Controls.Add(sliderCharWordCount);
            Controls.Add(label7);
            Controls.Add(numericCharCount);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxAddr);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxTitle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Name = "CreateEdit";
            Text = "CreateEdit";
            ((System.ComponentModel.ISupportInitialize)numericCharCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)sliderCharWordCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxTitle;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxAddr;
        private TextBox textBoxDescription;
        private NumericUpDown numericCharCount;
        private Label label7;
        private TrackBar sliderCharWordCount;
        private CheckBox checkBoxSpecialChar;
        private RadioButton radioRandomPassword;
        private RadioButton radioDiceware;
        private TextBox textBoxStrengthCheck;
        private Button buttonCreateEdit;
        private Button buttonReset;
        private Button buttonGenerate;
    }
}