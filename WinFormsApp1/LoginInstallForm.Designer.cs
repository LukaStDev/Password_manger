namespace WinFormsApp1
{
    partial class LoginInstallForm
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
            labelInformation = new Label();
            buttonImport = new Button();
            buttonCreateNew = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonLogin = new Button();
            panel1 = new Panel();
            buttonShowPassword = new Button();
            selectVault = new ComboBox();
            label2 = new Label();
            openFileDialog2 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(499, 48);
            label1.TabIndex = 0;
            label1.Text = "Password Manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInformation
            // 
            labelInformation.Dock = DockStyle.Top;
            labelInformation.Location = new Point(0, 48);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(499, 134);
            labelInformation.TabIndex = 1;
            labelInformation.Text = "Something";
            labelInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonImport
            // 
            buttonImport.Anchor = AnchorStyles.None;
            buttonImport.Location = new Point(58, 19);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(133, 65);
            buttonImport.TabIndex = 2;
            buttonImport.Text = "Import Vault and Metadata";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonCreateNew
            // 
            buttonCreateNew.Anchor = AnchorStyles.None;
            buttonCreateNew.Location = new Point(307, 19);
            buttonCreateNew.Name = "buttonCreateNew";
            buttonCreateNew.Size = new Size(133, 65);
            buttonCreateNew.TabIndex = 3;
            buttonCreateNew.Text = "Create new Password Store";
            buttonCreateNew.UseVisualStyleBackColor = true;
            buttonCreateNew.Click += buttonCreateNew_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonImport, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonCreateNew, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 182);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(499, 103);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // labelUsername
            // 
            labelUsername.Location = new Point(41, 339);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 27);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(138, 339);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(251, 27);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(138, 381);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(251, 27);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.Location = new Point(41, 380);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(91, 24);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(182, 15);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(139, 60);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Login/Create";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLogin);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 433);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 87);
            panel1.TabIndex = 10;
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.Location = new Point(405, 380);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(82, 29);
            buttonShowPassword.TabIndex = 11;
            buttonShowPassword.Text = "Show";
            buttonShowPassword.UseVisualStyleBackColor = true;
            buttonShowPassword.MouseDown += ShowPassword;
            buttonShowPassword.MouseUp += HidePassword;
            // 
            // selectVault
            // 
            selectVault.DropDownStyle = ComboBoxStyle.DropDownList;
            selectVault.FormattingEnabled = true;
            selectVault.Location = new Point(138, 293);
            selectVault.Name = "selectVault";
            selectVault.Size = new Size(151, 28);
            selectVault.TabIndex = 10;
            // 
            // label2
            // 
            label2.Location = new Point(25, 293);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 12;
            label2.Text = "Vault";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // openFileDialog2
            // 
            openFileDialog2.AddExtension = false;
            openFileDialog2.FileName = "openFileDialog";
            openFileDialog2.ReadOnlyChecked = true;
            openFileDialog2.ShowReadOnly = true;
            openFileDialog2.SupportMultiDottedExtensions = true;
            // 
            // LoginInstallForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 520);
            Controls.Add(label2);
            Controls.Add(selectVault);
            Controls.Add(buttonShowPassword);
            Controls.Add(panel1);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelInformation);
            Controls.Add(label1);
            Name = "LoginInstallForm";
            Text = "LoginInstallForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelInformation;
        private Button buttonImport;
        private Button buttonCreateNew;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonLogin;
        private Panel panel1;
        private Button buttonShowPassword;
        private ComboBox selectVault;
        private Label label2;
        private OpenFileDialog openFileDialog2;
    }
}