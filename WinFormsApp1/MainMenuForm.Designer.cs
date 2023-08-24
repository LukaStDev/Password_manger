namespace WinFormsApp1
{
    partial class MainMenuForm
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
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelLogo = new Panel();
            btnCloseChildForm = new Button();
            panelMenu = new Panel();
            PasswordList = new ListBox();
            panelDesktopPane = new Panel();
            buttonNew = new Button();
            button4 = new Button();
            buttonEdit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelTitleBar.SuspendLayout();
            panelLogo.SuspendLayout();
            panelMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(37, 61, 161);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(188, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(782, 93);
            panelTitleBar.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(782, 93);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Password Manager";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(2, 25, 139);
            panelLogo.Controls.Add(btnCloseChildForm);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(188, 93);
            panelLogo.TabIndex = 0;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.BackColor = Color.FromArgb(0, 0, 2, 25);
            btnCloseChildForm.Dock = DockStyle.Fill;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloseChildForm.ForeColor = Color.Gainsboro;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(188, 93);
            btnCloseChildForm.TabIndex = 0;
            btnCloseChildForm.Text = "RETURN";
            btnCloseChildForm.UseVisualStyleBackColor = false;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 61, 161);
            panelMenu.Controls.Add(PasswordList);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(188, 736);
            panelMenu.TabIndex = 2;
            // 
            // PasswordList
            // 
            PasswordList.BackColor = Color.FromArgb(37, 61, 161);
            PasswordList.BorderStyle = BorderStyle.None;
            PasswordList.Dock = DockStyle.Top;
            PasswordList.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordList.ForeColor = Color.White;
            PasswordList.FormattingEnabled = true;
            PasswordList.ItemHeight = 37;
            PasswordList.Location = new Point(0, 93);
            PasswordList.Name = "PasswordList";
            PasswordList.RightToLeft = RightToLeft.No;
            PasswordList.Size = new Size(188, 629);
            PasswordList.TabIndex = 1;
            PasswordList.SelectedIndexChanged += SelectService;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BackColor = Color.FromArgb(193, 227, 237);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(188, 93);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(782, 643);
            panelDesktopPane.TabIndex = 4;
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.None;
            buttonNew.BackColor = Color.FromArgb(176, 219, 241);
            buttonNew.FlatStyle = FlatStyle.Flat;
            buttonNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNew.Location = new Point(44, 11);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(171, 56);
            buttonNew.TabIndex = 3;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonAddNew_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(176, 219, 241);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(565, 11);
            button4.Name = "button4";
            button4.Size = new Size(171, 56);
            button4.TabIndex = 2;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.None;
            buttonEdit.BackColor = Color.FromArgb(176, 219, 241);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(304, 11);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(171, 56);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEditPassword_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(37, 61, 161);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(buttonNew, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonEdit, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(188, 658);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(782, 78);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 736);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MaximizeBox = false;
            Name = "MainMenuForm";
            Text = "Password Manager";
            panelTitleBar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelLogo;
        private Panel panelMenu;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private Button buttonNew;
        private Button button4;
        private Button buttonEdit;
        private ListBox PasswordList;
        private TableLayoutPanel tableLayoutPanel1;
    }
}