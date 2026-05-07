namespace LoginModulForm
{
    partial class SeviyeArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeviyeArama));
            this.lbl_klytm = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nmup_mevcud = new System.Windows.Forms.NumericUpDown();
            this.cmb_seviyebolum = new System.Windows.Forms.ComboBox();
            this.cmb_seviyeno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_seviyeara = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmup_mevcud)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_klytm
            // 
            this.lbl_klytm.AutoSize = true;
            this.lbl_klytm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_klytm.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_klytm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_klytm.Location = new System.Drawing.Point(12, 9);
            this.lbl_klytm.Name = "lbl_klytm";
            this.lbl_klytm.Size = new System.Drawing.Size(30, 23);
            this.lbl_klytm.TabIndex = 6;
            this.lbl_klytm.Text = "←";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.nmup_mevcud);
            this.groupBox3.Controls.Add(this.cmb_seviyebolum);
            this.groupBox3.Controls.Add(this.cmb_seviyeno);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_seviyeara);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(120, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 239);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınıf Seviyesi Ara";
            // 
            // nmup_mevcud
            // 
            this.nmup_mevcud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmup_mevcud.Location = new System.Drawing.Point(135, 138);
            this.nmup_mevcud.Name = "nmup_mevcud";
            this.nmup_mevcud.Size = new System.Drawing.Size(136, 20);
            this.nmup_mevcud.TabIndex = 29;
            // 
            // cmb_seviyebolum
            // 
            this.cmb_seviyebolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_seviyebolum.FormattingEnabled = true;
            this.cmb_seviyebolum.Location = new System.Drawing.Point(135, 46);
            this.cmb_seviyebolum.Name = "cmb_seviyebolum";
            this.cmb_seviyebolum.Size = new System.Drawing.Size(136, 21);
            this.cmb_seviyebolum.TabIndex = 28;
            // 
            // cmb_seviyeno
            // 
            this.cmb_seviyeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_seviyeno.FormattingEnabled = true;
            this.cmb_seviyeno.Items.AddRange(new object[] {
            "Hazırlık",
            "1",
            "2",
            "3",
            "4",
            ""});
            this.cmb_seviyeno.Location = new System.Drawing.Point(135, 90);
            this.cmb_seviyeno.Name = "cmb_seviyeno";
            this.cmb_seviyeno.Size = new System.Drawing.Size(136, 21);
            this.cmb_seviyeno.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sınıf Mevcudu...:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(28, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sınıf Seviyesi...:";
            // 
            // btn_seviyeara
            // 
            this.btn_seviyeara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_seviyeara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_seviyeara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seviyeara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_seviyeara.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_seviyeara.Location = new System.Drawing.Point(51, 196);
            this.btn_seviyeara.Name = "btn_seviyeara";
            this.btn_seviyeara.Size = new System.Drawing.Size(205, 23);
            this.btn_seviyeara.TabIndex = 23;
            this.btn_seviyeara.Text = "Ara";
            this.btn_seviyeara.UseVisualStyleBackColor = true;
            this.btn_seviyeara.Click += new System.EventHandler(this.btn_seviyeara_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(28, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bölüm Adı...:";
            // 
            // SeviyeArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_klytm);
            this.DoubleBuffered = true;
            this.Name = "SeviyeArama";
            this.Text = "SeviyeArama";
            this.Load += new System.EventHandler(this.SeviyeArama_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmup_mevcud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_klytm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nmup_mevcud;
        private System.Windows.Forms.ComboBox cmb_seviyebolum;
        private System.Windows.Forms.ComboBox cmb_seviyeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_seviyeara;
        private System.Windows.Forms.Label label9;
    }
}