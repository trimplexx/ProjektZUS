namespace ProjektZUS
{
    partial class SingUpPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingUpPanel));
            this.GoToLogin = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PeselTextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoToLogin
            // 
            this.GoToLogin.BackColor = System.Drawing.Color.Transparent;
            this.GoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.GoToLogin.Location = new System.Drawing.Point(32, 614);
            this.GoToLogin.Name = "GoToLogin";
            this.GoToLogin.Size = new System.Drawing.Size(157, 24);
            this.GoToLogin.TabIndex = 35;
            this.GoToLogin.Text = "Wróć do logowania";
            this.GoToLogin.Click += new System.EventHandler(this.GoToLogin_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpButton.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(150, 542);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(234, 51);
            this.SignUpButton.TabIndex = 33;
            this.SignUpButton.Text = "SIGN UP";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(391, 500);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(98, 20);
            this.ShowPasswordCheckBox.TabIndex = 31;
            this.ShowPasswordCheckBox.Text = "Pokaż hasło";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PasswordTextBox.Location = new System.Drawing.Point(43, 458);
            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(454, 39);
            this.PasswordTextBox.TabIndex = 30;
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.BackColor = System.Drawing.Color.Transparent;
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.haslo.ForeColor = System.Drawing.Color.DimGray;
            this.haslo.Location = new System.Drawing.Point(43, 431);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(67, 25);
            this.haslo.TabIndex = 29;
            this.haslo.Text = "Hasło";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.DimGray;
            this.login.Location = new System.Drawing.Point(43, 349);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(65, 25);
            this.login.TabIndex = 26;
            this.login.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(92, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 57);
            this.label1.TabIndex = 25;
            this.label1.Text = "Rejestracja";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LoginTextBox.Location = new System.Drawing.Point(43, 375);
            this.LoginTextBox.MaxLength = 20;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(454, 39);
            this.LoginTextBox.TabIndex = 36;
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PeselTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeselTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PeselTextBox.Location = new System.Drawing.Point(43, 285);
            this.PeselTextBox.MaxLength = 11;
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.Size = new System.Drawing.Size(454, 39);
            this.PeselTextBox.TabIndex = 37;
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NazwiskoTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwiskoTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NazwiskoTextBox.Location = new System.Drawing.Point(43, 195);
            this.NazwiskoTextBox.MaxLength = 20;
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(454, 39);
            this.NazwiskoTextBox.TabIndex = 38;
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImieTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImieTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ImieTextBox.Location = new System.Drawing.Point(43, 112);
            this.ImieTextBox.MaxLength = 20;
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(454, 39);
            this.ImieTextBox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Imie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(43, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nazwisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(43, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Pesel";
            // 
            // SingUpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(536, 662);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.PeselTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.GoToLogin);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SingUpPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sing Up Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GoToLogin;
        private Button SignUpButton;
        private CheckBox ShowPasswordCheckBox;
        private TextBox PasswordTextBox;
        private Label haslo;
        private Label login;
        private Label label1;
        private TextBox LoginTextBox;
        private TextBox PeselTextBox;
        private TextBox NazwiskoTextBox;
        private TextBox ImieTextBox;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}