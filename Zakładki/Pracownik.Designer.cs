﻿namespace ProjektZUS.Zakładki
{
    partial class Pracownik
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
            this.AddNewWorker = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // AddNewWorker
            // 
            this.AddNewWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.AddNewWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNewWorker.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewWorker.ForeColor = System.Drawing.Color.White;
            this.AddNewWorker.Location = new System.Drawing.Point(824, 620);
            this.AddNewWorker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddNewWorker.Name = "AddNewWorker";
            this.AddNewWorker.Size = new System.Drawing.Size(267, 68);
            this.AddNewWorker.TabIndex = 78;
            this.AddNewWorker.Text = "DODAJ";
            this.AddNewWorker.UseVisualStyleBackColor = false;
            this.AddNewWorker.Click += new System.EventHandler(this.AddNewWorker_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(573, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 31);
            this.label6.TabIndex = 76;
            this.label6.Text = "Wynagrodzenie Brutto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(573, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(471, 31);
            this.label7.TabIndex = 75;
            this.label7.Text = "Numer dowodu osobistego/ paszportu";
            // 
            // DowodTextBox
            // 
            this.DowodTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DowodTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DowodTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DowodTextBox.Location = new System.Drawing.Point(573, 130);
            this.DowodTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DowodTextBox.MaxLength = 20;
            this.DowodTextBox.Name = "DowodTextBox";
            this.DowodTextBox.Size = new System.Drawing.Size(518, 47);
            this.DowodTextBox.TabIndex = 74;
            // 
            // BruttoTextBox
            // 
            this.BruttoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BruttoTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BruttoTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BruttoTextBox.Location = new System.Drawing.Point(573, 241);
            this.BruttoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BruttoTextBox.MaxLength = 20;
            this.BruttoTextBox.Name = "BruttoTextBox";
            this.BruttoTextBox.Size = new System.Drawing.Size(518, 47);
            this.BruttoTextBox.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(22, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 71;
            this.label5.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(22, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 31);
            this.label4.TabIndex = 70;
            this.label4.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 69;
            this.label2.Text = "Imie";
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImieTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImieTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ImieTextBox.Location = new System.Drawing.Point(22, 130);
            this.ImieTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImieTextBox.MaxLength = 20;
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(518, 47);
            this.ImieTextBox.TabIndex = 68;
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NazwiskoTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwiskoTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NazwiskoTextBox.Location = new System.Drawing.Point(22, 241);
            this.NazwiskoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NazwiskoTextBox.MaxLength = 20;
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(518, 47);
            this.NazwiskoTextBox.TabIndex = 67;
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PeselTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeselTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PeselTextBox.Location = new System.Drawing.Point(22, 361);
            this.PeselTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PeselTextBox.MaxLength = 11;
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.Size = new System.Drawing.Size(518, 47);
            this.PeselTextBox.TabIndex = 66;
            // 
            // Pracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1113, 736);
            this.Controls.Add(this.AddNewWorker);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pracownik";
            this.Text = "Pracownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AddNewWorker;
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
    }
}