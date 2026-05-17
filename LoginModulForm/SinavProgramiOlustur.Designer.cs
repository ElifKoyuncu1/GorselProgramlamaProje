namespace LoginModulForm
{
    partial class SinavProgramiOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavProgramiOlustur));
            this.lbl_program = new System.Windows.Forms.Label();
            this.lbl_takvim = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.lbl_aciklama = new System.Windows.Forms.Label();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.dataGridView_program = new System.Windows.Forms.DataGridView();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_programOlustur = new System.Windows.Forms.Button();
            this.cmb_programVersiyon = new System.Windows.Forms.ComboBox();
            this.chk_cumartesiKullan = new System.Windows.Forms.CheckBox();
            this.cmb_takvim = new System.Windows.Forms.ComboBox();
            this.label2_bolum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_program)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_program
            // 
            this.lbl_program.AutoSize = true;
            this.lbl_program.BackColor = System.Drawing.Color.Transparent;
            this.lbl_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_program.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_program.Location = new System.Drawing.Point(76, 147);
            this.lbl_program.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_program.Name = "lbl_program";
            this.lbl_program.Size = new System.Drawing.Size(116, 13);
            this.lbl_program.TabIndex = 23;
            this.lbl_program.Text = "Program Versiyonu:";
            // 
            // lbl_takvim
            // 
            this.lbl_takvim.AutoSize = true;
            this.lbl_takvim.BackColor = System.Drawing.Color.Transparent;
            this.lbl_takvim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_takvim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_takvim.Location = new System.Drawing.Point(76, 73);
            this.lbl_takvim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_takvim.Name = "lbl_takvim";
            this.lbl_takvim.Size = new System.Drawing.Size(121, 13);
            this.lbl_takvim.TabIndex = 22;
            this.lbl_takvim.Text = "Dönem / Sınav Tipi:";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_durum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_durum.Location = new System.Drawing.Point(76, 40);
            this.lbl_durum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(55, 13);
            this.lbl_durum.TabIndex = 21;
            this.lbl_durum.Text = "Durum : ";
            // 
            // lbl_aciklama
            // 
            this.lbl_aciklama.AutoSize = true;
            this.lbl_aciklama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aciklama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_aciklama.Location = new System.Drawing.Point(76, 9);
            this.lbl_aciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_aciklama.Name = "lbl_aciklama";
            this.lbl_aciklama.Size = new System.Drawing.Size(268, 13);
            this.lbl_aciklama.TabIndex = 20;
            this.lbl_aciklama.Text = "Bu ekranda 3 farklı sınav programı oluşturulur.";
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Location = new System.Drawing.Point(81, -29);
            this.lbl_baslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(123, 13);
            this.lbl_baslik.TabIndex = 19;
            this.lbl_baslik.Text = "Sınav Programı Oluştur..:";
            // 
            // dataGridView_program
            // 
            this.dataGridView_program.AllowUserToDeleteRows = false;
            this.dataGridView_program.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            this.dataGridView_program.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_program.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_program.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_program.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView_program.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_program.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_program.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_program.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_program.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_program.EnableHeadersVisualStyles = false;
            this.dataGridView_program.GridColor = System.Drawing.Color.Black;
            this.dataGridView_program.Location = new System.Drawing.Point(38, 233);
            this.dataGridView_program.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_program.Name = "dataGridView_program";
            this.dataGridView_program.ReadOnly = true;
            this.dataGridView_program.RowHeadersVisible = false;
            this.dataGridView_program.RowHeadersWidth = 51;
            this.dataGridView_program.RowTemplate.Height = 36;
            this.dataGridView_program.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_program.Size = new System.Drawing.Size(707, 528);
            this.dataGridView_program.TabIndex = 18;
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.Transparent;
            this.btn_temizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_temizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_temizle.Location = new System.Drawing.Point(313, 189);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(172, 28);
            this.btn_temizle.TabIndex = 17;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.Transparent;
            this.btn_listele.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_listele.Location = new System.Drawing.Point(566, 189);
            this.btn_listele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(172, 28);
            this.btn_listele.TabIndex = 16;
            this.btn_listele.Text = "Programı Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_programOlustur
            // 
            this.btn_programOlustur.BackColor = System.Drawing.Color.Transparent;
            this.btn_programOlustur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_programOlustur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_programOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_programOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_programOlustur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_programOlustur.Location = new System.Drawing.Point(64, 189);
            this.btn_programOlustur.Margin = new System.Windows.Forms.Padding(2);
            this.btn_programOlustur.Name = "btn_programOlustur";
            this.btn_programOlustur.Size = new System.Drawing.Size(172, 28);
            this.btn_programOlustur.TabIndex = 15;
            this.btn_programOlustur.Text = "3 Program Oluştur";
            this.btn_programOlustur.UseVisualStyleBackColor = false;
            this.btn_programOlustur.Click += new System.EventHandler(this.btn_programOlustur_Click);
            // 
            // cmb_programVersiyon
            // 
            this.cmb_programVersiyon.FormattingEnabled = true;
            this.cmb_programVersiyon.Location = new System.Drawing.Point(197, 144);
            this.cmb_programVersiyon.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_programVersiyon.Name = "cmb_programVersiyon";
            this.cmb_programVersiyon.Size = new System.Drawing.Size(138, 21);
            this.cmb_programVersiyon.TabIndex = 14;
            this.cmb_programVersiyon.SelectedIndexChanged += new System.EventHandler(this.cmb_programVersiyon_SelectedIndexChanged);
            // 
            // chk_cumartesiKullan
            // 
            this.chk_cumartesiKullan.AutoSize = true;
            this.chk_cumartesiKullan.BackColor = System.Drawing.Color.Transparent;
            this.chk_cumartesiKullan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_cumartesiKullan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_cumartesiKullan.Location = new System.Drawing.Point(79, 110);
            this.chk_cumartesiKullan.Margin = new System.Windows.Forms.Padding(2);
            this.chk_cumartesiKullan.Name = "chk_cumartesiKullan";
            this.chk_cumartesiKullan.Size = new System.Drawing.Size(172, 17);
            this.chk_cumartesiKullan.TabIndex = 13;
            this.chk_cumartesiKullan.Text = "Cumartesi sınav yapılabilir";
            this.chk_cumartesiKullan.UseVisualStyleBackColor = false;
            // 
            // cmb_takvim
            // 
            this.cmb_takvim.FormattingEnabled = true;
            this.cmb_takvim.Location = new System.Drawing.Point(197, 70);
            this.cmb_takvim.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_takvim.Name = "cmb_takvim";
            this.cmb_takvim.Size = new System.Drawing.Size(138, 21);
            this.cmb_takvim.TabIndex = 12;
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
            // SinavProgramiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 772);
            this.Controls.Add(this.label2_bolum);
            this.Controls.Add(this.lbl_program);
            this.Controls.Add(this.lbl_takvim);
            this.Controls.Add(this.lbl_durum);
            this.Controls.Add(this.lbl_aciklama);
            this.Controls.Add(this.lbl_baslik);
            this.Controls.Add(this.dataGridView_program);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_programOlustur);
            this.Controls.Add(this.cmb_programVersiyon);
            this.Controls.Add(this.chk_cumartesiKullan);
            this.Controls.Add(this.cmb_takvim);
            this.DoubleBuffered = true;
            this.Name = "SinavProgramiOlustur";
            this.Text = "SinavProgramiOlustur";
            this.Load += new System.EventHandler(this.SinavProgramiOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_program)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_program;
        private System.Windows.Forms.Label lbl_takvim;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.Label lbl_aciklama;
        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.DataGridView dataGridView_program;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_programOlustur;
        private System.Windows.Forms.ComboBox cmb_programVersiyon;
        private System.Windows.Forms.CheckBox chk_cumartesiKullan;
        private System.Windows.Forms.ComboBox cmb_takvim;
        private System.Windows.Forms.Label label2_bolum;
    }
}