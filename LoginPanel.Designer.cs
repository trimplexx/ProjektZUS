namespace ProjektZUS
{
    partial class LoginPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.GoToSingUp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GoToSingUp
            // 
            this.GoToSingUp.AutoSize = true;
            this.GoToSingUp.BackColor = System.Drawing.Color.Transparent;
            this.GoToSingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoToSingUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.GoToSingUp.Location = new System.Drawing.Point(54, 598);
            this.GoToSingUp.Name = "GoToSingUp";
            this.GoToSingUp.Size = new System.Drawing.Size(108, 20);
            this.GoToSingUp.TabIndex = 24;
            this.GoToSingUp.Text = "Zajerestruj się";
            this.GoToSingUp.Click += new System.EventHandler(this.GoToSingUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(30, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nie posiadasz konta?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(144, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LoginButton);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(405, 357);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(98, 20);
            this.ShowPasswordCheckBox.TabIndex = 20;
            this.ShowPasswordCheckBox.Text = "Pokaż hasło";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PasswordTextBox.Location = new System.Drawing.Point(80, 302);
            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(423, 45);
            this.PasswordTextBox.TabIndex = 19;
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.BackColor = System.Drawing.Color.Transparent;
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.haslo.ForeColor = System.Drawing.Color.DimGray;
            this.haslo.Location = new System.Drawing.Point(30, 275);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(67, 25);
            this.haslo.TabIndex = 18;
            this.haslo.Text = "Hasło";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LoginTextBox.Location = new System.Drawing.Point(80, 211);
            this.LoginTextBox.MaxLength = 20;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(423, 45);
            this.LoginTextBox.TabIndex = 16;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.DimGray;
            this.login.Location = new System.Drawing.Point(30, 184);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(65, 25);
            this.login.TabIndex = 15;
            this.login.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(122, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 57);
            this.label1.TabIndex = 14;
            this.label1.Text = "Logowanie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjektZUS.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(30, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProjektZUS.Properties.Resources.pngkit_png_png_2354885;
            this.pictureBox2.Location = new System.Drawing.Point(30, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(536, 662);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GoToSingUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Panel";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GoToSingUp;
        private Label label2;
        private Button button1;
        private CheckBox ShowPasswordCheckBox;
        private TextBox PasswordTextBox;
        private Label haslo;
        private Label login;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public TextBox LoginTextBox;
    }
}