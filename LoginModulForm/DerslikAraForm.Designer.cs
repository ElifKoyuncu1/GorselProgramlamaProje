namespace LoginModulForm
{
    partial class DerslikAraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DerslikAraForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.num_kapasite = new System.Windows.Forms.NumericUpDown();
            this.txtDerslikAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_kapasite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.num_kapasite);
            this.groupBox1.Controls.Add(this.txtDerslikAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(125, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Derslik Güncelle";
            // 
            // btn_ara
            // 
            this.btn_ara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ara.Location = new System.Drawing.Point(66, 151);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(246, 23);
            this.btn_ara.TabIndex = 4;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // num_kapasite
            // 
            this.num_kapasite.Location = new System.Drawing.Point(213, 94);
            this.num_kapasite.Name = "num_kapasite";
            this.num_kapasite.Size = new System.Drawing.Size(120, 20);
            this.num_kapasite.TabIndex = 3;
            // 
            // txtDerslikAdi
            // 
            this.txtDerslikAdi.Location = new System.Drawing.Point(213, 46);
            this.txtDerslikAdi.Name = "txtDerslikAdi";
            this.txtDerslikAdi.Size = new System.Drawing.Size(120, 20);
            this.txtDerslikAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kapasite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Derslik Adı..:";
            // 
            // DerslikAraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 366);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "DerslikAraForm";
            this.Text = "DerslikAraForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_kapasite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txtDerslikAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown num_kapasite;
    }
}