namespace LoginModulForm
{
    partial class TakvimZamanDilimiAraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakvimZamanDilimiAraForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtpAraTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAraDonemTipi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_geri = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.dtpAraTarih);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbAraDonemTipi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(98, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(378, 251);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Takvim Zaman Ara";
            // 
            // btnAra
            // 
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Location = new System.Drawing.Point(106, 188);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(155, 26);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dtpAraTarih
            // 
            this.dtpAraTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpAraTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAraTarih.Location = new System.Drawing.Point(192, 115);
            this.dtpAraTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAraTarih.Name = "dtpAraTarih";
            this.dtpAraTarih.Size = new System.Drawing.Size(134, 20);
            this.dtpAraTarih.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(55, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tarih..:";
            // 
            // cmbAraDonemTipi
            // 
            this.cmbAraDonemTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAraDonemTipi.FormattingEnabled = true;
            this.cmbAraDonemTipi.Items.AddRange(new object[] {
            "Güz - Vize,",
            "Güz - Final,",
            "Bahar - Vize,",
            "Bahar - Final"});
            this.cmbAraDonemTipi.Location = new System.Drawing.Point(192, 74);
            this.cmbAraDonemTipi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAraDonemTipi.Name = "cmbAraDonemTipi";
            this.cmbAraDonemTipi.Size = new System.Drawing.Size(134, 21);
            this.cmbAraDonemTipi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(55, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dönem Tipi..:";
            // 
            // label_geri
            // 
            this.label_geri.AutoSize = true;
            this.label_geri.BackColor = System.Drawing.Color.Transparent;
            this.label_geri.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_geri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_geri.Location = new System.Drawing.Point(12, 9);
            this.label_geri.Name = "label_geri";
            this.label_geri.Size = new System.Drawing.Size(34, 26);
            this.label_geri.TabIndex = 23;
            this.label_geri.Text = "←";
            this.label_geri.Click += new System.EventHandler(this.label_geri_Click);
            // 
            // TakvimZamanDilimiAraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 371);
            this.Controls.Add(this.label_geri);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Name = "TakvimZamanDilimiAraForm";
            this.Text = "TakvimZamanDilimiAraForm";
            this.Load += new System.EventHandler(this.TakvimZamanDilimiAraForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dtpAraTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAraDonemTipi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_geri;
    }
}