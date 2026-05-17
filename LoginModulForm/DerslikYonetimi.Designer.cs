namespace LoginModulForm
{
    partial class DerslikYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DerslikYonetimi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_dekle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_ekle = new System.Windows.Forms.NumericUpDown();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.text_drsEkle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_dsil = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_sil = new System.Windows.Forms.NumericUpDown();
            this.btn_sil = new System.Windows.Forms.Button();
            this.text_dersSil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_dgncl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.num_guncelle = new System.Windows.Forms.NumericUpDown();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.text_drsGuncelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_listele = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ekle)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sil)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_guncelle)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 382);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.lbl_dekle);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(565, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Derslik Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_dekle
            // 
            this.lbl_dekle.AutoSize = true;
            this.lbl_dekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dekle.Location = new System.Drawing.Point(2, 2);
            this.lbl_dekle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dekle.Name = "lbl_dekle";
            this.lbl_dekle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_dekle.Size = new System.Drawing.Size(26, 20);
            this.lbl_dekle.TabIndex = 1;
            this.lbl_dekle.Text = "←";
            this.lbl_dekle.Click += new System.EventHandler(this.lbl_dekle_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_ekle);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.text_drsEkle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(112, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(339, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Derslik Ekle";
            // 
            // num_ekle
            // 
            this.num_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num_ekle.Location = new System.Drawing.Point(168, 96);
            this.num_ekle.Name = "num_ekle";
            this.num_ekle.Size = new System.Drawing.Size(111, 19);
            this.num_ekle.TabIndex = 5;
            // 
            // btn_ekle
            // 
            this.btn_ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ekle.Location = new System.Drawing.Point(70, 159);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(187, 27);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // text_drsEkle
            // 
            this.text_drsEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_drsEkle.Location = new System.Drawing.Point(168, 64);
            this.text_drsEkle.Margin = new System.Windows.Forms.Padding(2);
            this.text_drsEkle.Name = "text_drsEkle";
            this.text_drsEkle.Size = new System.Drawing.Size(111, 19);
            this.text_drsEkle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kapasite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Derslik Adı..:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.lbl_dsil);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(565, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Derslik Sil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_dsil
            // 
            this.lbl_dsil.AutoSize = true;
            this.lbl_dsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dsil.Location = new System.Drawing.Point(2, 2);
            this.lbl_dsil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dsil.Name = "lbl_dsil";
            this.lbl_dsil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_dsil.Size = new System.Drawing.Size(24, 18);
            this.lbl_dsil.TabIndex = 2;
            this.lbl_dsil.Text = "←";
            this.lbl_dsil.Click += new System.EventHandler(this.lbl_dsil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_sil);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.text_dersSil);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(107, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(339, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Derslik Sil";
            // 
            // num_sil
            // 
            this.num_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num_sil.Location = new System.Drawing.Point(142, 94);
            this.num_sil.Name = "num_sil";
            this.num_sil.Size = new System.Drawing.Size(163, 19);
            this.num_sil.TabIndex = 6;
            // 
            // btn_sil
            // 
            this.btn_sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sil.Location = new System.Drawing.Point(78, 158);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(185, 28);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click_1);
            // 
            // text_dersSil
            // 
            this.text_dersSil.Location = new System.Drawing.Point(142, 52);
            this.text_dersSil.Margin = new System.Windows.Forms.Padding(2);
            this.text_dersSil.Name = "text_dersSil";
            this.text_dersSil.Size = new System.Drawing.Size(163, 19);
            this.text_dersSil.TabIndex = 2;
            this.text_dersSil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_dersSil_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kapasite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Derslik Adı..:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.lbl_dgncl);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(565, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Derslik Güncelle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_dgncl
            // 
            this.lbl_dgncl.AutoSize = true;
            this.lbl_dgncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dgncl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dgncl.Location = new System.Drawing.Point(2, 2);
            this.lbl_dgncl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dgncl.Name = "lbl_dgncl";
            this.lbl_dgncl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_dgncl.Size = new System.Drawing.Size(21, 16);
            this.lbl_dgncl.TabIndex = 2;
            this.lbl_dgncl.Text = "←";
            this.lbl_dgncl.Click += new System.EventHandler(this.lbl_dgncl_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.num_guncelle);
            this.groupBox3.Controls.Add(this.btn_guncelle);
            this.groupBox3.Controls.Add(this.text_drsGuncelle);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(108, 47);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(339, 216);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Derslik Güncelle";
            // 
            // num_guncelle
            // 
            this.num_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num_guncelle.Location = new System.Drawing.Point(145, 104);
            this.num_guncelle.Name = "num_guncelle";
            this.num_guncelle.Size = new System.Drawing.Size(155, 19);
            this.num_guncelle.TabIndex = 6;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_guncelle.Location = new System.Drawing.Point(85, 160);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(161, 32);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // text_drsGuncelle
            // 
            this.text_drsGuncelle.Location = new System.Drawing.Point(145, 56);
            this.text_drsGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.text_drsGuncelle.Name = "text_drsGuncelle";
            this.text_drsGuncelle.Size = new System.Drawing.Size(155, 19);
            this.text_drsGuncelle.TabIndex = 2;
            this.text_drsGuncelle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_drsGuncelle_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kapasite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Derslik Adı..:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(565, 356);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Derslik Listele";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 306);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(561, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_listele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 46);
            this.panel1.TabIndex = 6;
            // 
            // btn_listele
            // 
            this.btn_listele.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_listele.Location = new System.Drawing.Point(184, 16);
            this.btn_listele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(185, 25);
            this.btn_listele.TabIndex = 5;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click_1);
            // 
            // DerslikYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 382);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "DerslikYonetimi";
            this.Text = "DerslikYonetimi";
            this.Load += new System.EventHandler(this.DerslikYonetimi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ekle)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sil)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_guncelle)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_dekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_dsil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_dgncl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.NumericUpDown num_ekle;
        public System.Windows.Forms.TextBox text_drsEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox text_dersSil;
        public System.Windows.Forms.TextBox text_drsGuncelle;
        public System.Windows.Forms.NumericUpDown num_sil;
        public System.Windows.Forms.NumericUpDown num_guncelle;
    }
}