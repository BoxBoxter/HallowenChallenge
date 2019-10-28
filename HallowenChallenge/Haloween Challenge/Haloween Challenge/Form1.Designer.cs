namespace Haloween_Challenge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SearchBox = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.login = new System.Windows.Forms.TabPage();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.WrongText = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.films = new System.Windows.Forms.TabPage();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.staff = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.pictureStaff = new System.Windows.Forms.PictureBox();
            this.TabControl.SuspendLayout();
            this.login.SuspendLayout();
            this.films.SuspendLayout();
            this.staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.AutoSize = true;
            this.SearchBox.Location = new System.Drawing.Point(6, 17);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(41, 13);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(69, 14);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(460, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(535, 14);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl.Controls.Add(this.login);
            this.TabControl.Controls.Add(this.films);
            this.TabControl.Controls.Add(this.staff);
            this.TabControl.Location = new System.Drawing.Point(12, 110);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(705, 328);
            this.TabControl.TabIndex = 3;
            // 
            // login
            // 
            this.login.Controls.Add(this.LogoutButton);
            this.login.Controls.Add(this.WrongText);
            this.login.Controls.Add(this.LoginButton);
            this.login.Controls.Add(this.PasswordTextBox);
            this.login.Controls.Add(this.UserTextBox);
            this.login.Controls.Add(this.label3);
            this.login.Controls.Add(this.label2);
            this.login.Location = new System.Drawing.Point(23, 4);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(678, 320);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(305, 172);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // WrongText
            // 
            this.WrongText.AutoSize = true;
            this.WrongText.ForeColor = System.Drawing.Color.Red;
            this.WrongText.Location = new System.Drawing.Point(169, 237);
            this.WrongText.Name = "WrongText";
            this.WrongText.Size = new System.Drawing.Size(0, 13);
            this.WrongText.TabIndex = 5;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(305, 172);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(169, 90);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(365, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(169, 49);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(365, 20);
            this.UserTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            // 
            // films
            // 
            this.films.Controls.Add(this.FilmsListBox);
            this.films.Controls.Add(this.SearchBox);
            this.films.Controls.Add(this.FindButton);
            this.films.Controls.Add(this.SearchTextBox);
            this.films.Location = new System.Drawing.Point(23, 4);
            this.films.Name = "films";
            this.films.Padding = new System.Windows.Forms.Padding(3);
            this.films.Size = new System.Drawing.Size(678, 320);
            this.films.TabIndex = 1;
            this.films.Text = "Films";
            this.films.UseVisualStyleBackColor = true;
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.Location = new System.Drawing.Point(69, 54);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(460, 173);
            this.FilmsListBox.TabIndex = 3;
            this.FilmsListBox.DoubleClick += new System.EventHandler(this.FilmsListBox_DoubleClick);
            // 
            // staff
            // 
            this.staff.Controls.Add(this.pictureStaff);
            this.staff.Controls.Add(this.ChangeButton);
            this.staff.Controls.Add(this.EmailTextBox);
            this.staff.Controls.Add(this.EmailLabel);
            this.staff.Location = new System.Drawing.Point(23, 4);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(678, 320);
            this.staff.TabIndex = 2;
            this.staff.Text = "Staff";
            this.staff.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sakila Films";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(131, 48);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(201, 48);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(328, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(453, 208);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 3;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // pictureStaff
            // 
            this.pictureStaff.Image = ((System.Drawing.Image)(resources.GetObject("pictureStaff.Image")));
            this.pictureStaff.Location = new System.Drawing.Point(0, 103);
            this.pictureStaff.Name = "pictureStaff";
            this.pictureStaff.Size = new System.Drawing.Size(420, 262);
            this.pictureStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureStaff.TabIndex = 4;
            this.pictureStaff.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.films.ResumeLayout(false);
            this.films.PerformLayout();
            this.staff.ResumeLayout(false);
            this.staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage login;
        private System.Windows.Forms.TabPage films;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label WrongText;
        private System.Windows.Forms.TabPage staff;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox pictureStaff;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
    }
}

