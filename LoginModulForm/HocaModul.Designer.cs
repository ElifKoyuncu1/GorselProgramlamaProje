namespace LoginModulForm
{
    partial class HocaModul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HocaModul));
            this.btn_programolustur = new System.Windows.Forms.Button();
            this.btn_programım = new System.Windows.Forms.Button();
            this.btn_derslerim = new System.Windows.Forms.Button();
            this.label2_bolum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_programolustur
            // 
            this.btn_programolustur.BackColor = System.Drawing.Color.Transparent;
            this.btn_programolustur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_programolustur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_programolustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_programolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.btn_programolustur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_programolustur.Location = new System.Drawing.Point(296, 99);
            this.btn_programolustur.Name = "btn_programolustur";
            this.btn_programolustur.Size = new System.Drawing.Size(238, 70);
            this.btn_programolustur.TabIndex = 9;
            this.btn_programolustur.Text = "Sınav Programı Oluştur";
            this.btn_programolustur.UseVisualStyleBackColor = false;
            this.btn_programolustur.Click += new System.EventHandler(this.btn_programolustur_Click);
            // 
            // btn_programım
            // 
            this.btn_programım.BackColor = System.Drawing.Color.Transparent;
            this.btn_programım.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_programım.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_programım.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_programım.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.btn_programım.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_programım.Location = new System.Drawing.Point(151, 206);
            this.btn_programım.Name = "btn_programım";
            this.btn_programım.Size = new System.Drawing.Size(238, 70);
            this.btn_programım.TabIndex = 8;
            this.btn_programım.Text = "Programım";
            this.btn_programım.UseVisualStyleBackColor = false;
            this.btn_programım.Click += new System.EventHandler(this.btn_programım_Click);
            // 
            // btn_derslerim
            // 
            this.btn_derslerim.BackColor = System.Drawing.Color.Transparent;
            this.btn_derslerim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_derslerim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_derslerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_derslerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.btn_derslerim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_derslerim.Location = new System.Drawing.Point(17, 99);
            this.btn_derslerim.Name = "btn_derslerim";
            this.btn_derslerim.Size = new System.Drawing.Size(238, 70);
            this.btn_derslerim.TabIndex = 7;
            this.btn_derslerim.Text = "Derslerim";
            this.btn_derslerim.UseVisualStyleBackColor = false;
            this.btn_derslerim.Click += new System.EventHandler(this.btn_derslerim_Click);
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
            this.label2_bolum.TabIndex = 30;
            this.label2_bolum.Text = "←";
            this.label2_bolum.Click += new System.EventHandler(this.label2_bolum_Click);
            // 
            // HocaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 387);
            this.Controls.Add(this.label2_bolum);
            this.Controls.Add(this.btn_programolustur);
            this.Controls.Add(this.btn_programım);
            this.Controls.Add(this.btn_derslerim);
            this.DoubleBuffered = true;
            this.Name = "HocaModul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_programolustur;
        private System.Windows.Forms.Button btn_programım;
        private System.Windows.Forms.Button btn_derslerim;
        private System.Windows.Forms.Label label2_bolum;
    }
}