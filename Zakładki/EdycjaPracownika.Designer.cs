namespace ProjektZUS.Zakładki
{
    partial class EdycjaPracownika
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
            this.DeleteWorker = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DowodTextBox = new System.Windows.Forms.TextBox();
            this.BruttoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.PeselTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteWorker
            // 
            this.DeleteWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteWorker.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteWorker.ForeColor = System.Drawing.Color.White;
            this.DeleteWorker.Location = new System.Drawing.Point(821, 603);
            this.DeleteWorker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteWorker.Name = "DeleteWorker";
            this.DeleteWorker.Size = new System.Drawing.Size(267, 68);
            this.DeleteWorker.TabIndex = 89;
            this.DeleteWorker.Text = "USUŃ";
            this.DeleteWorker.UseVisualStyleBackColor = false;
            this.DeleteWorker.Click += new System.EventHandler(this.DeleteWorker_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(570, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 31);
            this.label6.TabIndex = 88;
            this.label6.Text = "Wynagrodzenie Brutto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(570, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(471, 31);
            this.label7.TabIndex = 87;
            this.label7.Text = "Numer dowodu osobistego/ paszportu";
            // 
            // DowodTextBox
            // 
            this.DowodTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DowodTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DowodTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DowodTextBox.Location = new System.Drawing.Point(570, 120);
            this.DowodTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DowodTextBox.MaxLength = 20;
            this.DowodTextBox.Name = "DowodTextBox";
            this.DowodTextBox.Size = new System.Drawing.Size(518, 47);
            this.DowodTextBox.TabIndex = 86;
            // 
            // BruttoTextBox
            // 
            this.BruttoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BruttoTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BruttoTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BruttoTextBox.Location = new System.Drawing.Point(570, 231);
            this.BruttoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BruttoTextBox.MaxLength = 20;
            this.BruttoTextBox.Name = "BruttoTextBox";
            this.BruttoTextBox.Size = new System.Drawing.Size(518, 47);
            this.BruttoTextBox.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(19, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 84;
            this.label5.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(19, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 31);
            this.label4.TabIndex = 83;
            this.label4.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 82;
            this.label2.Text = "Imie";
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImieTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImieTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ImieTextBox.Location = new System.Drawing.Point(19, 120);
            this.ImieTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImieTextBox.MaxLength = 20;
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(518, 47);
            this.ImieTextBox.TabIndex = 81;
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NazwiskoTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwiskoTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NazwiskoTextBox.Location = new System.Drawing.Point(19, 231);
            this.NazwiskoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NazwiskoTextBox.MaxLength = 20;
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(518, 47);
            this.NazwiskoTextBox.TabIndex = 80;
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PeselTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeselTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PeselTextBox.Location = new System.Drawing.Point(19, 351);
            this.PeselTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PeselTextBox.MaxLength = 11;
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.ReadOnly = true;
            this.PeselTextBox.Size = new System.Drawing.Size(518, 47);
            this.PeselTextBox.TabIndex = 79;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(532, 603);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 68);
            this.button1.TabIndex = 90;
            this.button1.Text = "ZAPISZ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // EdycjaPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1113, 736);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteWorker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DowodTextBox);
            this.Controls.Add(this.BruttoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.PeselTextBox);
            this.Name = "EdycjaPracownika";
            this.Text = "EdycjaPracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DeleteWorker;
        private Label label6;
        private Label label7;
        private TextBox DowodTextBox;
        private TextBox BruttoTextBox;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox ImieTextBox;
        private TextBox NazwiskoTextBox;
        private TextBox PeselTextBox;
        private Button button1;
    }
}