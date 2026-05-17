namespace LoginModulForm
{
    partial class AkademikTakvimArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkademikTakvimArama));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.cmb_snvtipara = new System.Windows.Forms.ComboBox();
            this.cmb_donemara = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2_bolum = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_ara);
            this.groupBox2.Controls.Add(this.cmb_snvtipara);
            this.groupBox2.Controls.Add(this.cmb_donemara);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(76, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ara";
            // 
            // btn_ara
            // 
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ara.Location = new System.Drawing.Point(106, 187);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(155, 26);
            this.btn_ara.TabIndex = 10;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // cmb_snvtipara
            // 
            this.cmb_snvtipara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_snvtipara.FormattingEnabled = true;
            this.cmb_snvtipara.Items.AddRange(new object[] {
            "Vize",
            "Final",
            "Büt",
            "Mazeret"});
            this.cmb_snvtipara.Location = new System.Drawing.Point(189, 110);
            this.cmb_snvtipara.Name = "cmb_snvtipara";
            this.cmb_snvtipara.Size = new System.Drawing.Size(150, 21);
            this.cmb_snvtipara.TabIndex = 11;
            // 
            // cmb_donemara
            // 
            this.cmb_donemara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_donemara.FormattingEnabled = true;
            this.cmb_donemara.Items.AddRange(new object[] {
            "Güz ",
            "Bahar"});
            this.cmb_donemara.Location = new System.Drawing.Point(189, 73);
            this.cmb_donemara.Name = "cmb_donemara";
            this.cmb_donemara.Size = new System.Drawing.Size(150, 21);
            this.cmb_donemara.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(47, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dönem Adı..:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(47, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sınav Tipi..:";
            // 
            // label2_bolum
            // 
            this.label2_bolum.AutoSize = true;
            this.label2_bolum.BackColor = System.Drawing.Color.Transparent;
            this.label2_bolum.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2_bolum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2_bolum.Location = new System.Drawing.Point(12, 9);
            this.label2_bolum.Name = "label2_bolum";
            this.label2_bolum.Size = new System.Drawing.Size(34, 26);
            this.label2_bolum.TabIndex = 27;
            this.label2_bolum.Text = "←";
            this.label2_bolum.Click += new System.EventHandler(this.label2_bolum_Click);
            // 
            // AkademikTakvimArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 348);
            this.Controls.Add(this.label2_bolum);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Name = "AkademikTakvimArama";
            this.Text = "AkademikTakvimArama";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.ComboBox cmb_snvtipara;
        private System.Windows.Forms.ComboBox cmb_donemara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2_bolum;
    }
}