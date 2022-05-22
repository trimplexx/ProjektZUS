namespace ProjektZUS.Zakładki
{
    partial class StronaGlowna
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
            this.OknoPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OknoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OknoPanel
            // 
            this.OknoPanel.BackColor = System.Drawing.Color.LightGray;
            this.OknoPanel.Controls.Add(this.label5);
            this.OknoPanel.Controls.Add(this.label3);
            this.OknoPanel.Controls.Add(this.label4);
            this.OknoPanel.Controls.Add(this.label2);
            this.OknoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OknoPanel.Location = new System.Drawing.Point(0, 0);
            this.OknoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OknoPanel.Name = "OknoPanel";
            this.OknoPanel.Size = new System.Drawing.Size(1113, 736);
            this.OknoPanel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(1016, 734);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Filip Habryn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(986, 756);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Łukasz Krawczyk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(254, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 60);
            this.label4.TabIndex = 10;
            this.label4.Text = "zarządzania składkami ZUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(282, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 60);
            this.label2.TabIndex = 9;
            this.label2.Text = "Witamy w programie do";
            // 
            // StronaGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 736);
            this.Controls.Add(this.OknoPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StronaGlowna";
            this.Text = "StronaGlowna";
            this.OknoPanel.ResumeLayout(false);
            this.OknoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel OknoPanel;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
    }
}