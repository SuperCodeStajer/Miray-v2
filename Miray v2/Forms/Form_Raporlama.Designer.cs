namespace Miray_v2.Forms
{
    partial class Form_Raporlama
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
            TarihBaslangic = new System.Windows.Forms.DateTimePicker();
            TarihBitis = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            Bayi = new System.Windows.Forms.ComboBox();
            Sorgula = new System.Windows.Forms.Button();
            Temizle = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            Excel = new System.Windows.Forms.Button();
            Bayi_Ismi = new System.Windows.Forms.Label();
            DataGridView = new System.Windows.Forms.DataGridView();
            checkBox1 = new System.Windows.Forms.CheckBox();
            panel2 = new System.Windows.Forms.Panel();
            BayiSayisi_2 = new System.Windows.Forms.Label();
            BayiSayisi = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            FisSayisi_2 = new System.Windows.Forms.Label();
            FisSayisi = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            UrunSayisi_2 = new System.Windows.Forms.Label();
            UrunSayisi = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            BandrolSayisi_2 = new System.Windows.Forms.Label();
            BandrolSayisi = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Liste = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Liste).BeginInit();
            SuspendLayout();
            // 
            // TarihBaslangic
            // 
            TarihBaslangic.CustomFormat = "dd-MM-yyyy";
            TarihBaslangic.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TarihBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            TarihBaslangic.Location = new System.Drawing.Point(12, 121);
            TarihBaslangic.Name = "TarihBaslangic";
            TarihBaslangic.Size = new System.Drawing.Size(225, 23);
            TarihBaslangic.TabIndex = 0;
            TarihBaslangic.Value = new System.DateTime(2023, 7, 27, 0, 0, 0, 0);
            // 
            // TarihBitis
            // 
            TarihBitis.CustomFormat = "dd-MM-yyyy";
            TarihBitis.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TarihBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            TarihBitis.Location = new System.Drawing.Point(12, 194);
            TarihBitis.Name = "TarihBitis";
            TarihBitis.Size = new System.Drawing.Size(225, 23);
            TarihBitis.TabIndex = 1;
            TarihBitis.Value = new System.DateTime(2023, 7, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 95);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(225, 23);
            label1.TabIndex = 2;
            label1.Text = "Başlangıç Tarihi";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 168);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(225, 23);
            label2.TabIndex = 3;
            label2.Text = "Bitiş Tarihi";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bayi
            // 
            Bayi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            Bayi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            Bayi.Enabled = false;
            Bayi.FormattingEnabled = true;
            Bayi.Location = new System.Drawing.Point(12, 261);
            Bayi.Name = "Bayi";
            Bayi.Size = new System.Drawing.Size(225, 23);
            Bayi.TabIndex = 5;
            Bayi.Text = "          Lütfen Bayi Seçimi Yapınız";
            // 
            // Sorgula
            // 
            Sorgula.BackColor = System.Drawing.Color.FromArgb(247, 159, 31);
            Sorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Sorgula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Sorgula.ForeColor = System.Drawing.Color.White;
            Sorgula.Image = Properties.Resources.search__3_;
            Sorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Sorgula.Location = new System.Drawing.Point(12, 303);
            Sorgula.Name = "Sorgula";
            Sorgula.Size = new System.Drawing.Size(225, 35);
            Sorgula.TabIndex = 6;
            Sorgula.Text = "Sorgula";
            Sorgula.UseVisualStyleBackColor = false;
            Sorgula.Click += Sorgula_Click;
            // 
            // Temizle
            // 
            Temizle.BackColor = System.Drawing.Color.FromArgb(255, 71, 87);
            Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Temizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Temizle.ForeColor = System.Drawing.Color.White;
            Temizle.Image = Properties.Resources.remove;
            Temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Temizle.Location = new System.Drawing.Point(12, 344);
            Temizle.Name = "Temizle";
            Temizle.Size = new System.Drawing.Size(225, 35);
            Temizle.TabIndex = 7;
            Temizle.Text = "İçeriği Temizle";
            Temizle.UseVisualStyleBackColor = false;
            Temizle.Click += Temizle_Click;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(Excel);
            panel1.Controls.Add(Bayi_Ismi);
            panel1.Controls.Add(DataGridView);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(Temizle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TarihBaslangic);
            panel1.Controls.Add(Bayi);
            panel1.Controls.Add(Sorgula);
            panel1.Controls.Add(TarihBitis);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(252, 510);
            panel1.TabIndex = 8;
            // 
            // Excel
            // 
            Excel.BackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            Excel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Excel.ForeColor = System.Drawing.Color.White;
            Excel.Image = Properties.Resources.file_excel;
            Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Excel.Location = new System.Drawing.Point(12, 385);
            Excel.Name = "Excel";
            Excel.Size = new System.Drawing.Size(225, 35);
            Excel.TabIndex = 11;
            Excel.Text = "Excel'e Aktar\r\n";
            Excel.UseVisualStyleBackColor = false;
            Excel.Click += Excel_Click;
            // 
            // Bayi_Ismi
            // 
            Bayi_Ismi.Location = new System.Drawing.Point(0, 28);
            Bayi_Ismi.Name = "Bayi_Ismi";
            Bayi_Ismi.Size = new System.Drawing.Size(252, 23);
            Bayi_Ismi.TabIndex = 10;
            Bayi_Ismi.Text = "Bayi İsmi";
            Bayi_Ismi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Bayi_Ismi.Visible = false;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new System.Drawing.Point(0, 0);
            DataGridView.Name = "DataGridView";
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new System.Drawing.Size(252, 25);
            DataGridView.TabIndex = 1;
            DataGridView.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.Location = new System.Drawing.Point(12, 237);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(225, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Bayi Seçimi Yapmak İstiyormusunuz?";
            checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(BayiSayisi_2);
            panel2.Controls.Add(BayiSayisi);
            panel2.Controls.Add(label3);
            panel2.Location = new System.Drawing.Point(258, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(139, 70);
            panel2.TabIndex = 9;
            // 
            // BayiSayisi_2
            // 
            BayiSayisi_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BayiSayisi_2.Location = new System.Drawing.Point(0, 24);
            BayiSayisi_2.Name = "BayiSayisi_2";
            BayiSayisi_2.Size = new System.Drawing.Size(139, 46);
            BayiSayisi_2.TabIndex = 13;
            BayiSayisi_2.Text = "--";
            BayiSayisi_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BayiSayisi
            // 
            BayiSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BayiSayisi.Location = new System.Drawing.Point(0, 24);
            BayiSayisi.Name = "BayiSayisi";
            BayiSayisi.Size = new System.Drawing.Size(137, 46);
            BayiSayisi.TabIndex = 1;
            BayiSayisi.Text = "0";
            BayiSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 24);
            label3.TabIndex = 0;
            label3.Text = "Bayi Sayısı";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(FisSayisi_2);
            panel3.Controls.Add(FisSayisi);
            panel3.Controls.Add(label6);
            panel3.Location = new System.Drawing.Point(403, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(139, 70);
            panel3.TabIndex = 10;
            // 
            // FisSayisi_2
            // 
            FisSayisi_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FisSayisi_2.Location = new System.Drawing.Point(0, 24);
            FisSayisi_2.Name = "FisSayisi_2";
            FisSayisi_2.Size = new System.Drawing.Size(139, 46);
            FisSayisi_2.TabIndex = 14;
            FisSayisi_2.Text = "00";
            FisSayisi_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FisSayisi
            // 
            FisSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FisSayisi.Location = new System.Drawing.Point(0, 31);
            FisSayisi.Name = "FisSayisi";
            FisSayisi.Size = new System.Drawing.Size(139, 39);
            FisSayisi.TabIndex = 1;
            FisSayisi.Text = "0";
            FisSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(-3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(142, 24);
            label6.TabIndex = 0;
            label6.Text = "Fiş Sayısı";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.White;
            panel4.Controls.Add(UrunSayisi_2);
            panel4.Controls.Add(UrunSayisi);
            panel4.Controls.Add(label8);
            panel4.Location = new System.Drawing.Point(548, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(139, 70);
            panel4.TabIndex = 11;
            // 
            // UrunSayisi_2
            // 
            UrunSayisi_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            UrunSayisi_2.Location = new System.Drawing.Point(0, 25);
            UrunSayisi_2.Name = "UrunSayisi_2";
            UrunSayisi_2.Size = new System.Drawing.Size(139, 45);
            UrunSayisi_2.TabIndex = 14;
            UrunSayisi_2.Text = "00";
            UrunSayisi_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UrunSayisi
            // 
            UrunSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            UrunSayisi.Location = new System.Drawing.Point(0, 25);
            UrunSayisi.Name = "UrunSayisi";
            UrunSayisi.Size = new System.Drawing.Size(139, 45);
            UrunSayisi.TabIndex = 1;
            UrunSayisi.Text = "0";
            UrunSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(0, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(139, 25);
            label8.TabIndex = 0;
            label8.Text = "Ürün Çeşit Sayısı";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.White;
            panel5.Controls.Add(BandrolSayisi_2);
            panel5.Controls.Add(BandrolSayisi);
            panel5.Controls.Add(label10);
            panel5.Location = new System.Drawing.Point(693, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(139, 70);
            panel5.TabIndex = 12;
            // 
            // BandrolSayisi_2
            // 
            BandrolSayisi_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BandrolSayisi_2.Location = new System.Drawing.Point(0, 24);
            BandrolSayisi_2.Name = "BandrolSayisi_2";
            BandrolSayisi_2.Size = new System.Drawing.Size(139, 46);
            BandrolSayisi_2.TabIndex = 14;
            BandrolSayisi_2.Text = "00";
            BandrolSayisi_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BandrolSayisi
            // 
            BandrolSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BandrolSayisi.Location = new System.Drawing.Point(-3, 30);
            BandrolSayisi.Name = "BandrolSayisi";
            BandrolSayisi.Size = new System.Drawing.Size(142, 40);
            BandrolSayisi.TabIndex = 1;
            BandrolSayisi.Text = "0";
            BandrolSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(0, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(139, 24);
            label10.TabIndex = 0;
            label10.Text = "Bandrol Sayısı";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(258, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(0, 0);
            dataGridView1.TabIndex = 13;
            // 
            // Liste
            // 
            Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Liste.Location = new System.Drawing.Point(258, 76);
            Liste.Name = "Liste";
            Liste.RowTemplate.Height = 25;
            Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            Liste.Size = new System.Drawing.Size(574, 395);
            Liste.TabIndex = 14;
            Liste.CellClick += Liste_CellClick;
            Liste.CellEnter += Liste_CellEnter;
            // 
            // Form_Raporlama
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(812, 450);
            Controls.Add(Liste);
            Controls.Add(dataGridView1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_Raporlama";
            Text = "Raporlama Formu";
            Load += Form_Raporlama_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Liste).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Bayi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BayiSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TarihBaslangic;
        private System.Windows.Forms.DateTimePicker TarihBitis;
        private System.Windows.Forms.Button Sorgula;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FisSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label UrunSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label BandrolSayisi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label BayiSayisi_2;
        private System.Windows.Forms.Label FisSayisi_2;
        private System.Windows.Forms.Label UrunSayisi_2;
        private System.Windows.Forms.Label BandrolSayisi_2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label Bayi_Ismi;
        private System.Windows.Forms.Button Excel;
    }
}