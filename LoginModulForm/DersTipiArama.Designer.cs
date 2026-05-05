namespace LoginModulForm
{
    partial class DersTipiArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DersTipiArama));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_tipara = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aratip = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "←";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmb_tipara);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btn_aratip);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(100, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 205);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tip Ara";
            // 
            // cmb_tipara
            // 
            this.cmb_tipara.FormattingEnabled = true;
            this.cmb_tipara.Location = new System.Drawing.Point(135, 70);
            this.cmb_tipara.Name = "cmb_tipara";
            this.cmb_tipara.Size = new System.Drawing.Size(136, 21);
            this.cmb_tipara.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(46, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tip Adı...:";
            // 
            // btn_aratip
            // 
            this.btn_aratip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_aratip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_aratip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aratip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aratip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_aratip.Location = new System.Drawing.Point(49, 158);
            this.btn_aratip.Name = "btn_aratip";
            this.btn_aratip.Size = new System.Drawing.Size(222, 23);
            this.btn_aratip.TabIndex = 38;
            this.btn_aratip.Text = "Ara";
            this.btn_aratip.UseVisualStyleBackColor = true;
            this.btn_aratip.Click += new System.EventHandler(this.btn_aratip_Click);
            // 
            // DersTipiArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Name = "DersTipiArama";
            this.Text = "DersTipiArama";
            this.Load += new System.EventHandler(this.DersTipiArama_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_tipara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aratip;
    }
}