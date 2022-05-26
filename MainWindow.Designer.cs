namespace ProjektZUS
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AddWorker = new System.Windows.Forms.Button();
            this.PracownicyButton = new System.Windows.Forms.Button();
            this.ProfilButton = new System.Windows.Forms.Button();
            this.StronaGlownaButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OknoPanel = new System.Windows.Forms.Panel();
            this.MenuPracownikow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.AddWorker);
            this.panel1.Controls.Add(this.PracownicyButton);
            this.panel1.Controls.Add(this.ProfilButton);
            this.panel1.Controls.Add(this.StronaGlownaButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 657);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::ProjektZUS.Properties.Resources.próba3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 70);
            this.button1.TabIndex = 13;
            this.button1.Text = "   Podsumowanie";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PodsumowanieButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOutButton.ForeColor = System.Drawing.Color.Transparent;
            this.LogOutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.Image")));
            this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.Location = new System.Drawing.Point(0, 599);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(190, 58);
            this.LogOutButton.TabIndex = 12;
            this.LogOutButton.Text = "Wyloguj";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AddWorker
            // 
            this.AddWorker.BackColor = System.Drawing.Color.Transparent;
            this.AddWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddWorker.FlatAppearance.BorderSize = 0;
            this.AddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWorker.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddWorker.ForeColor = System.Drawing.Color.Transparent;
            this.AddWorker.Image = global::ProjektZUS.Properties.Resources.Bez_nazwy;
            this.AddWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddWorker.Location = new System.Drawing.Point(0, 380);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(190, 70);
            this.AddWorker.TabIndex = 11;
            this.AddWorker.Text = "Dodaj    Pracownika";
            this.AddWorker.UseVisualStyleBackColor = false;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // PracownicyButton
            // 
            this.PracownicyButton.BackColor = System.Drawing.Color.Transparent;
            this.PracownicyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PracownicyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PracownicyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PracownicyButton.FlatAppearance.BorderSize = 0;
            this.PracownicyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PracownicyButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PracownicyButton.ForeColor = System.Drawing.Color.Transparent;
            this.PracownicyButton.Image = global::ProjektZUS.Properties.Resources.próba2;
            this.PracownicyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PracownicyButton.Location = new System.Drawing.Point(0, 314);
            this.PracownicyButton.Name = "PracownicyButton";
            this.PracownicyButton.Size = new System.Drawing.Size(190, 66);
            this.PracownicyButton.TabIndex = 10;
            this.PracownicyButton.Text = "       Pracownicy     ";
            this.PracownicyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PracownicyButton.UseVisualStyleBackColor = false;
            this.PracownicyButton.Click += new System.EventHandler(this.PracownicyButton_Click);
            // 
            // ProfilButton
            // 
            this.ProfilButton.BackColor = System.Drawing.Color.Transparent;
            this.ProfilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfilButton.FlatAppearance.BorderSize = 0;
            this.ProfilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfilButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProfilButton.ForeColor = System.Drawing.Color.Transparent;
            this.ProfilButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfilButton.Image")));
            this.ProfilButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfilButton.Location = new System.Drawing.Point(0, 247);
            this.ProfilButton.Name = "ProfilButton";
            this.ProfilButton.Size = new System.Drawing.Size(190, 67);
            this.ProfilButton.TabIndex = 9;
            this.ProfilButton.Text = "      Profil";
            this.ProfilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfilButton.UseVisualStyleBackColor = false;
            this.ProfilButton.Click += new System.EventHandler(this.ProfilButton_Click);
            // 
            // StronaGlownaButton
            // 
            this.StronaGlownaButton.BackColor = System.Drawing.Color.Transparent;
            this.StronaGlownaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StronaGlownaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StronaGlownaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StronaGlownaButton.FlatAppearance.BorderSize = 0;
            this.StronaGlownaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StronaGlownaButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StronaGlownaButton.ForeColor = System.Drawing.Color.Transparent;
            this.StronaGlownaButton.Image = ((System.Drawing.Image)(resources.GetObject("StronaGlownaButton.Image")));
            this.StronaGlownaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StronaGlownaButton.Location = new System.Drawing.Point(0, 177);
            this.StronaGlownaButton.Name = "StronaGlownaButton";
            this.StronaGlownaButton.Size = new System.Drawing.Size(190, 70);
            this.StronaGlownaButton.TabIndex = 8;
            this.StronaGlownaButton.Text = "Strona główna";
            this.StronaGlownaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StronaGlownaButton.UseVisualStyleBackColor = false;
            this.StronaGlownaButton.Click += new System.EventHandler(this.StronaGlownaButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 177);
            this.panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(53)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.HideSelection = false;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.textBox1.Location = new System.Drawing.Point(3, 130);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(182, 32);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(24, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 115);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProjektZUS.Properties.Resources.user_2861;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(315, 54);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Strona Główna";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.titleLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(190, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(990, 66);
            this.panel4.TabIndex = 9;
            // 
            // OknoPanel
            // 
            this.OknoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OknoPanel.Location = new System.Drawing.Point(190, 66);
            this.OknoPanel.Name = "OknoPanel";
            this.OknoPanel.Size = new System.Drawing.Size(990, 591);
            this.OknoPanel.TabIndex = 10;
            // 
            // MenuPracownikow
            // 
            this.MenuPracownikow.BackColor = System.Drawing.Color.Silver;
            this.MenuPracownikow.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuPracownikow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPracownikow.Name = "contextMenuStrip1";
            this.MenuPracownikow.Size = new System.Drawing.Size(61, 4);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1180, 657);
            this.Controls.Add(this.OknoPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button StronaGlownaButton;
        private Button AddWorker;
        private Button PracownicyButton;
        private Button ProfilButton;
        private Label titleLabel;
        private Panel panel4;
        private Panel OknoPanel;
        private Button LogOutButton;
        private TextBox textBox1;
        private ContextMenuStrip MenuPracownikow;
        private Button button1;
    }
}