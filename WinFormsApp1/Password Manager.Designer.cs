namespace WinFormsApp1
{
    partial class PasswordForm
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
            label2 = new Label();
            UsernameBox = new TextBox();
            label3 = new Label();
            buttonCopyClipboard = new Button();
            buttonShowPassword = new Button();
            TitleBox = new TextBox();
            panel1 = new Panel();
            NoteBox = new TextBox();
            label5 = new Label();
            AddressBox = new TextBox();
            label4 = new Label();
            AccountPassword = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 18);
            label2.Name = "label2";
            label2.Size = new Size(154, 40);
            label2.TabIndex = 4;
            label2.Text = "Title";
            // 
            // UsernameBox
            // 
            UsernameBox.BackColor = Color.White;
            UsernameBox.Location = new Point(201, 74);
            UsernameBox.MaxLength = 0;
            UsernameBox.Name = "UsernameBox";
            UsernameBox.ReadOnly = true;
            UsernameBox.Size = new Size(418, 27);
            UsernameBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 70);
            label3.Name = "label3";
            label3.Size = new Size(136, 36);
            label3.TabIndex = 6;
            label3.Text = "Username";
            // 
            // buttonCopyClipboard
            // 
            buttonCopyClipboard.BackColor = Color.FromArgb(176, 219, 241);
            buttonCopyClipboard.FlatStyle = FlatStyle.Flat;
            buttonCopyClipboard.Location = new Point(525, 353);
            buttonCopyClipboard.Name = "buttonCopyClipboard";
            buttonCopyClipboard.Size = new Size(94, 51);
            buttonCopyClipboard.TabIndex = 9;
            buttonCopyClipboard.Text = "Copy to Clipboard";
            buttonCopyClipboard.UseVisualStyleBackColor = false;
            buttonCopyClipboard.Click += buttonCopyClipboard_Click;
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.BackColor = Color.FromArgb(176, 219, 241);
            buttonShowPassword.FlatStyle = FlatStyle.Flat;
            buttonShowPassword.Location = new Point(201, 353);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(94, 51);
            buttonShowPassword.TabIndex = 10;
            buttonShowPassword.Text = "Show Password";
            buttonShowPassword.UseVisualStyleBackColor = false;
            buttonShowPassword.Click += buttonShowPassword_Click;
            // 
            // TitleBox
            // 
            TitleBox.BackColor = Color.White;
            TitleBox.Location = new Point(201, 22);
            TitleBox.MaxLength = 32;
            TitleBox.Name = "TitleBox";
            TitleBox.ReadOnly = true;
            TitleBox.Size = new Size(418, 27);
            TitleBox.TabIndex = 13;
            TitleBox.TextChanged += AccountName_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(NoteBox);
            panel1.Controls.Add(buttonShowPassword);
            panel1.Controls.Add(buttonCopyClipboard);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(AddressBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(AccountPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TitleBox);
            panel1.Controls.Add(UsernameBox);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 418);
            panel1.TabIndex = 16;
            // 
            // NoteBox
            // 
            NoteBox.BackColor = Color.White;
            NoteBox.Location = new Point(201, 234);
            NoteBox.MaxLength = 0;
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.ReadOnly = true;
            NoteBox.Size = new Size(418, 95);
            NoteBox.TabIndex = 19;
            NoteBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 230);
            label5.Name = "label5";
            label5.Size = new Size(154, 40);
            label5.TabIndex = 18;
            label5.Text = "Note";
            // 
            // AddressBox
            // 
            AddressBox.BackColor = Color.White;
            AddressBox.Location = new Point(201, 182);
            AddressBox.MaxLength = 0;
            AddressBox.Name = "AddressBox";
            AddressBox.ReadOnly = true;
            AddressBox.Size = new Size(418, 27);
            AddressBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 178);
            label4.Name = "label4";
            label4.Size = new Size(154, 40);
            label4.TabIndex = 16;
            label4.Text = "Address";
            // 
            // AccountPassword
            // 
            AccountPassword.BackColor = Color.White;
            AccountPassword.Location = new Point(201, 128);
            AccountPassword.MaxLength = 0;
            AccountPassword.Name = "AccountPassword";
            AccountPassword.ReadOnly = true;
            AccountPassword.Size = new Size(418, 27);
            AccountPassword.TabIndex = 15;
            AccountPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 124);
            label1.Name = "label1";
            label1.Size = new Size(154, 40);
            label1.TabIndex = 14;
            label1.Text = "Password";
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 227, 237);
            ClientSize = new Size(723, 461);
            Controls.Add(panel1);
            Name = "PasswordForm";
            Text = "Password Manager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox UsernameBox;
        private Label label3;
        private Button buttonCopyClipboard;
        private Button buttonShowPassword;
        private TextBox TitleBox;
        private Panel panel1;
        private Label label1;
        private TextBox AccountPassword;
        private TextBox NoteBox;
        private Label label5;
        private TextBox AddressBox;
        private Label label4;
    }
}