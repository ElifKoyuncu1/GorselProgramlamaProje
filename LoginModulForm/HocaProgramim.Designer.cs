namespace LoginModulForm
{
    partial class HocaProgramim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HocaProgramim));
            this.dataGridView_programim = new System.Windows.Forms.DataGridView();
            this.cmb_programVersiyon = new System.Windows.Forms.ComboBox();
            this.cmb_takvim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2_bolum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_programim)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_programim
            // 
            this.dataGridView_programim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_programim.Location = new System.Drawing.Point(12, 59);
            this.dataGridView_programim.Name = "dataGridView_programim";
            this.dataGridView_programim.Size = new System.Drawing.Size(791, 503);
            this.dataGridView_programim.TabIndex = 0;
            // 
            // cmb_programVersiyon
            // 
            this.cmb_programVersiyon.FormattingEnabled = true;
            this.cmb_programVersiyon.Location = new System.Drawing.Point(513, 21);
            this.cmb_programVersiyon.Name = "cmb_programVersiyon";
            this.cmb_programVersiyon.Size = new System.Drawing.Size(239, 21);
            this.cmb_programVersiyon.TabIndex = 1;
            // 
            // cmb_takvim
            // 
            this.cmb_takvim.FormattingEnabled = true;
            this.cmb_takvim.Location = new System.Drawing.Point(141, 21);
            this.cmb_takvim.Name = "cmb_takvim";
            this.cmb_takvim.Size = new System.Drawing.Size(239, 21);
            this.cmb_takvim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dönem Tipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(402, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Program Versiyon";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(304, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2_bolum
            // 
            this.label2_bolum.AutoSize = true;
            this.label2_bolum.BackColor = System.Drawing.Color.Transparent;
            this.label2_bolum.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2_bolum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2_bolum.Location = new System.Drawing.Point(7, 9);
            this.label2_bolum.Name = "label2_bolum";
            this.label2_bolum.Size = new System.Drawing.Size(34, 26);
            this.label2_bolum.TabIndex = 29;
            this.label2_bolum.Text = "←";
            this.label2_bolum.Click += new System.EventHandler(this.label2_bolum_Click);
            // 
            // HocaProgramim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 634);
            this.Controls.Add(this.label2_bolum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_takvim);
            this.Controls.Add(this.cmb_programVersiyon);
            this.Controls.Add(this.dataGridView_programim);
            this.DoubleBuffered = true;
            this.Name = "HocaProgramim";
            this.Text = "HocaProgramim";
            this.Load += new System.EventHandler(this.HocaProgramim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_programim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_programim;
        private System.Windows.Forms.ComboBox cmb_programVersiyon;
        private System.Windows.Forms.ComboBox cmb_takvim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2_bolum;
    }
}