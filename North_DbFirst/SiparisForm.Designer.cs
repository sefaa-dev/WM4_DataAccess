
namespace North_DbFirst
{
    partial class SiparisForm
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
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lstCard = new System.Windows.Forms.ListView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnArttır = new System.Windows.Forms.Button();
            this.cmbEmployes = new System.Windows.Forms.ComboBox();
            this.cmbShippers = new System.Windows.Forms.ComboBox();
            this.dtpRDate = new System.Windows.Forms.DateTimePicker();
            this.txtShipAdress = new System.Windows.Forms.TextBox();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtShipRagion = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.nFreight = new System.Windows.Forms.NumericUpDown();
            this.lbToplam = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nFreight)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 15;
            this.lstProducts.Location = new System.Drawing.Point(26, 75);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(193, 244);
            this.lstProducts.TabIndex = 0;
            // 
            // lstCard
            // 
            this.lstCard.HideSelection = false;
            this.lstCard.Location = new System.Drawing.Point(239, 75);
            this.lstCard.Name = "lstCard";
            this.lstCard.Size = new System.Drawing.Size(193, 244);
            this.lstCard.TabIndex = 1;
            this.lstCard.UseCompatibleStateImageBehavior = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(26, 348);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(193, 43);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(266, 348);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(59, 43);
            this.btnAzalt.TabIndex = 3;
            this.btnAzalt.Text = "AZALT";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnArttır
            // 
            this.btnArttır.Location = new System.Drawing.Point(346, 348);
            this.btnArttır.Name = "btnArttır";
            this.btnArttır.Size = new System.Drawing.Size(59, 43);
            this.btnArttır.TabIndex = 4;
            this.btnArttır.Text = "ARTTIR";
            this.btnArttır.UseVisualStyleBackColor = true;
            this.btnArttır.Click += new System.EventHandler(this.btnArttır_Click);
            // 
            // cmbEmployes
            // 
            this.cmbEmployes.FormattingEnabled = true;
            this.cmbEmployes.Location = new System.Drawing.Point(457, 75);
            this.cmbEmployes.Name = "cmbEmployes";
            this.cmbEmployes.Size = new System.Drawing.Size(191, 23);
            this.cmbEmployes.TabIndex = 5;
            // 
            // cmbShippers
            // 
            this.cmbShippers.FormattingEnabled = true;
            this.cmbShippers.Location = new System.Drawing.Point(457, 104);
            this.cmbShippers.Name = "cmbShippers";
            this.cmbShippers.Size = new System.Drawing.Size(191, 23);
            this.cmbShippers.TabIndex = 6;
            // 
            // dtpRDate
            // 
            this.dtpRDate.Location = new System.Drawing.Point(457, 211);
            this.dtpRDate.Name = "dtpRDate";
            this.dtpRDate.Size = new System.Drawing.Size(200, 23);
            this.dtpRDate.TabIndex = 7;
            // 
            // txtShipAdress
            // 
            this.txtShipAdress.Location = new System.Drawing.Point(470, 252);
            this.txtShipAdress.Name = "txtShipAdress";
            this.txtShipAdress.Size = new System.Drawing.Size(86, 23);
            this.txtShipAdress.TabIndex = 9;
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(470, 281);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(86, 23);
            this.txtShipCountry.TabIndex = 9;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(470, 310);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(86, 23);
            this.txtPostalCode.TabIndex = 9;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(562, 252);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(86, 23);
            this.txtShipCity.TabIndex = 9;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(562, 281);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(86, 23);
            this.txtShipName.TabIndex = 9;
            // 
            // txtShipRagion
            // 
            this.txtShipRagion.Location = new System.Drawing.Point(562, 310);
            this.txtShipRagion.Name = "txtShipRagion";
            this.txtShipRagion.Size = new System.Drawing.Size(86, 23);
            this.txtShipRagion.TabIndex = 9;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(26, 34);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(193, 23);
            this.txtAra.TabIndex = 11;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // nFreight
            // 
            this.nFreight.DecimalPlaces = 2;
            this.nFreight.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nFreight.Location = new System.Drawing.Point(528, 339);
            this.nFreight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nFreight.Name = "nFreight";
            this.nFreight.Size = new System.Drawing.Size(120, 27);
            this.nFreight.TabIndex = 12;
            this.nFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbToplam
            // 
            this.lbToplam.AutoSize = true;
            this.lbToplam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbToplam.Location = new System.Drawing.Point(251, 37);
            this.lbToplam.Name = "lbToplam";
            this.lbToplam.Size = new System.Drawing.Size(134, 20);
            this.lbToplam.TabIndex = 13;
            this.lbToplam.Text = "TOPLAM  :  0.00 ₺";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(448, 412);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(209, 43);
            this.btnOnayla.TabIndex = 14;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(457, 133);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(191, 23);
            this.cmbCustomers.TabIndex = 15;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.lbToplam);
            this.Controls.Add(this.nFreight);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtShipRagion);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtShipCountry);
            this.Controls.Add(this.txtShipAdress);
            this.Controls.Add(this.dtpRDate);
            this.Controls.Add(this.cmbShippers);
            this.Controls.Add(this.cmbEmployes);
            this.Controls.Add(this.btnArttır);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstCard);
            this.Controls.Add(this.lstProducts);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFreight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ListView lstCard;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnArttır;
        private System.Windows.Forms.ComboBox cmbEmployes;
        private System.Windows.Forms.ComboBox cmbShippers;
        private System.Windows.Forms.DateTimePicker dtpRDate;
        private System.Windows.Forms.TextBox txtShipAdress;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.TextBox txtShipRagion;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.NumericUpDown nFreight;
        private System.Windows.Forms.Label lbToplam;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.ComboBox cmbCustomers;
    }
}