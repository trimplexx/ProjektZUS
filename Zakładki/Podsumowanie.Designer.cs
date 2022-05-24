namespace ProjektZUS.Zakładki
{
    partial class Podsumowanie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surrname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emerytalna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rentowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chorobowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wypadkowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zdrowotne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunduszPracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToOrderColumns = true;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Surrname,
            this.Pesel,
            this.Brutto,
            this.Emerytalna,
            this.Rentowa,
            this.Chorobowa,
            this.Wypadkowa,
            this.Zdrowotne,
            this.FunduszPracy});
            this.dgv1.Location = new System.Drawing.Point(2, 10);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 82;
            this.dgv1.RowTemplate.Height = 41;
            this.dgv1.ShowEditingIcon = false;
            this.dgv1.Size = new System.Drawing.Size(973, 477);
            this.dgv1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "ImiePrac";
            this.Name.HeaderText = "Imie";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // Surrname
            // 
            this.Surrname.DataPropertyName = "NazwiskoPrac";
            this.Surrname.HeaderText = "Nazwisko";
            this.Surrname.MinimumWidth = 10;
            this.Surrname.Name = "Surrname";
            this.Surrname.ReadOnly = true;
            this.Surrname.Width = 200;
            // 
            // Pesel
            // 
            this.Pesel.DataPropertyName = "PeselPrac";
            this.Pesel.HeaderText = "Pesel";
            this.Pesel.MinimumWidth = 10;
            this.Pesel.Name = "Pesel";
            this.Pesel.ReadOnly = true;
            this.Pesel.Width = 200;
            // 
            // Brutto
            // 
            this.Brutto.DataPropertyName = "BruttoPrac";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Brutto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Brutto.HeaderText = "Brutto";
            this.Brutto.MinimumWidth = 10;
            this.Brutto.Name = "Brutto";
            this.Brutto.ReadOnly = true;
            this.Brutto.Width = 200;
            // 
            // Emerytalna
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Emerytalna.DefaultCellStyle = dataGridViewCellStyle2;
            this.Emerytalna.HeaderText = "Emerytalna";
            this.Emerytalna.MinimumWidth = 10;
            this.Emerytalna.Name = "Emerytalna";
            this.Emerytalna.ReadOnly = true;
            this.Emerytalna.Width = 200;
            // 
            // Rentowa
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Rentowa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Rentowa.HeaderText = "Rentowa";
            this.Rentowa.MinimumWidth = 10;
            this.Rentowa.Name = "Rentowa";
            this.Rentowa.ReadOnly = true;
            this.Rentowa.Width = 200;
            // 
            // Chorobowa
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Chorobowa.DefaultCellStyle = dataGridViewCellStyle4;
            this.Chorobowa.HeaderText = "Chorobowa";
            this.Chorobowa.MinimumWidth = 10;
            this.Chorobowa.Name = "Chorobowa";
            this.Chorobowa.ReadOnly = true;
            this.Chorobowa.Width = 200;
            // 
            // Wypadkowa
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Wypadkowa.DefaultCellStyle = dataGridViewCellStyle5;
            this.Wypadkowa.HeaderText = "Wypadkowa";
            this.Wypadkowa.MinimumWidth = 10;
            this.Wypadkowa.Name = "Wypadkowa";
            this.Wypadkowa.ReadOnly = true;
            this.Wypadkowa.Width = 200;
            // 
            // Zdrowotne
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Zdrowotne.DefaultCellStyle = dataGridViewCellStyle6;
            this.Zdrowotne.HeaderText = "Zdrowotne";
            this.Zdrowotne.MinimumWidth = 10;
            this.Zdrowotne.Name = "Zdrowotne";
            this.Zdrowotne.ReadOnly = true;
            this.Zdrowotne.Width = 200;
            // 
            // FunduszPracy
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.FunduszPracy.DefaultCellStyle = dataGridViewCellStyle7;
            this.FunduszPracy.HeaderText = "Fundusz Pracy";
            this.FunduszPracy.MinimumWidth = 10;
            this.FunduszPracy.Name = "FunduszPracy";
            this.FunduszPracy.ReadOnly = true;
            this.FunduszPracy.Width = 200;
            // 
            // Podsumowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(974, 497);
            this.Controls.Add(this.dgv1);
            this.Name.Name = "Podsumowanie";
            this.Text = "Podsumowanie";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Surrname;
        private DataGridViewTextBoxColumn Pesel;
        private DataGridViewTextBoxColumn Brutto;
        private DataGridViewTextBoxColumn Emerytalna;
        private DataGridViewTextBoxColumn Rentowa;
        private DataGridViewTextBoxColumn Chorobowa;
        private DataGridViewTextBoxColumn Wypadkowa;
        private DataGridViewTextBoxColumn Zdrowotne;
        private DataGridViewTextBoxColumn FunduszPracy;
        private DataGridView dgv1;
    }
}