namespace LoginModulForm
{
    partial class TumProgramlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TumProgramlar));
            this.cmb_programlar = new System.Windows.Forms.ComboBox();
            this.dgw_programlar = new System.Windows.Forms.DataGridView();
            this.btn_dosya_indir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_programlar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_programlar
            // 
            this.cmb_programlar.FormattingEnabled = true;
            this.cmb_programlar.Location = new System.Drawing.Point(155, 12);
            this.cmb_programlar.Name = "cmb_programlar";
            this.cmb_programlar.Size = new System.Drawing.Size(472, 21);
            this.cmb_programlar.TabIndex = 0;
            // 
            // dgw_programlar
            // 
            this.dgw_programlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_programlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_programlar.Location = new System.Drawing.Point(0, 0);
            this.dgw_programlar.Name = "dgw_programlar";
            this.dgw_programlar.Size = new System.Drawing.Size(804, 452);
            this.dgw_programlar.TabIndex = 1;
            // 
            // btn_dosya_indir
            // 
            this.btn_dosya_indir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dosya_indir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosya_indir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dosya_indir.Location = new System.Drawing.Point(271, 6);
            this.btn_dosya_indir.Name = "btn_dosya_indir";
            this.btn_dosya_indir.Size = new System.Drawing.Size(271, 23);
            this.btn_dosya_indir.TabIndex = 2;
            this.btn_dosya_indir.Text = "İndir";
            this.btn_dosya_indir.UseVisualStyleBackColor = true;
            this.btn_dosya_indir.Click += new System.EventHandler(this.btn_dosya_indir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.cmb_programlar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 51);
            this.panel1.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(12, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 26);
            this.label25.TabIndex = 47;
            this.label25.Text = "←";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_dosya_indir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 42);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dgw_programlar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 452);
            this.panel3.TabIndex = 5;
            // 
            // TumProgramlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TumProgramlar";
            this.Text = "TumProgramlar";
            this.Load += new System.EventHandler(this.TumProgramlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_programlar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_programlar;
        private System.Windows.Forms.DataGridView dgw_programlar;
        private System.Windows.Forms.Button btn_dosya_indir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label25;
    }
}