
namespace Miray_v2
{
    partial class islemdetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(islemdetay));
            panel1 = new System.Windows.Forms.Panel();
            GenelSayac = new System.Windows.Forms.Label();
            genelbilgi = new System.Windows.Forms.Label();
            sayac1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            BarkodTxt = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label15 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            Eklecheck = new System.Windows.Forms.CheckBox();
            CıkarCheck = new System.Windows.Forms.CheckBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button5 = new System.Windows.Forms.Button();
            IslemDetayMusteriID = new System.Windows.Forms.Label();
            IslemDetayMusteriKodu = new System.Windows.Forms.Label();
            IslemDetayMusteriAdi = new System.Windows.Forms.Label();
            İslemDetayNebimNo = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            ThisUrunID = new System.Windows.Forms.Label();
            ThisUrunKodu = new System.Windows.Forms.Label();
            ThisUrunAdi = new System.Windows.Forms.Label();
            İslemDetayMasterID = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            AzalanChecked = new System.Windows.Forms.CheckBox();
            ArtanChecked = new System.Windows.Forms.CheckBox();
            NormalChecked = new System.Windows.Forms.CheckBox();
            SeriChecked = new System.Windows.Forms.CheckBox();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)İslemDetayMasterID).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.FromArgb(247, 183, 49);
            panel1.Controls.Add(GenelSayac);
            panel1.Controls.Add(genelbilgi);
            panel1.Controls.Add(sayac1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1219, 75);
            panel1.TabIndex = 3;
            // 
            // GenelSayac
            // 
            GenelSayac.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            GenelSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            GenelSayac.ForeColor = System.Drawing.Color.White;
            GenelSayac.Location = new System.Drawing.Point(0, 21);
            GenelSayac.Name = "GenelSayac";
            GenelSayac.Size = new System.Drawing.Size(1219, 54);
            GenelSayac.TabIndex = 26;
            GenelSayac.Text = "0";
            GenelSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genelbilgi
            // 
            genelbilgi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            genelbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            genelbilgi.ForeColor = System.Drawing.Color.White;
            genelbilgi.Location = new System.Drawing.Point(0, -3);
            genelbilgi.Name = "genelbilgi";
            genelbilgi.Size = new System.Drawing.Size(1219, 29);
            genelbilgi.TabIndex = 17;
            genelbilgi.Text = "(NBM0023 - Özgür Yayıncılık - A.Kitabı)";
            genelbilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sayac1
            // 
            sayac1.AutoSize = true;
            sayac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            sayac1.ForeColor = System.Drawing.Color.White;
            sayac1.Location = new System.Drawing.Point(450, 4);
            sayac1.Name = "sayac1";
            sayac1.Size = new System.Drawing.Size(15, 15);
            sayac1.TabIndex = 22;
            sayac1.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(217, 89);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 15);
            label4.TabIndex = 11;
            label4.Text = "*Barkod / ISBN :";
            // 
            // BarkodTxt
            // 
            BarkodTxt.Location = new System.Drawing.Point(331, 85);
            BarkodTxt.Name = "BarkodTxt";
            BarkodTxt.Size = new System.Drawing.Size(248, 23);
            BarkodTxt.TabIndex = 1;
            BarkodTxt.TextChanged += BarkodTxt_TextChanged;
            BarkodTxt.KeyDown += BarkodTxt_KeyDown;
            BarkodTxt.KeyPress += BarkodTxt_KeyPress;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.FromArgb(104, 109, 224);
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Image = Properties.Resources.add;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(1002, 210);
            button1.Name = "button1";
            button1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            button1.Size = new System.Drawing.Size(101, 30);
            button1.TabIndex = 10;
            button1.Text = "Yeni Kitap";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button2.BackColor = System.Drawing.Color.FromArgb(112, 161, 255);
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Image = Properties.Resources.remove;
            button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.Location = new System.Drawing.Point(661, 167);
            button2.Name = "button2";
            button2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            button2.Size = new System.Drawing.Size(101, 30);
            button2.TabIndex = 26;
            button2.Text = "    Çıkar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button3.BackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.White;
            button3.Image = (System.Drawing.Image)resources.GetObject("button3.Image");
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.Location = new System.Drawing.Point(1109, 210);
            button3.Name = "button3";
            button3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            button3.Size = new System.Drawing.Size(101, 30);
            button3.TabIndex = 11;
            button3.Text = "    Kaydet";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(12, 139);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(65, 15);
            label15.TabIndex = 29;
            label15.Text = "*Miktar : ";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(113, 167);
            textBox4.MaxLength = 1000000;
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox4.Size = new System.Drawing.Size(314, 73);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.Enter += textBox4_Enter;
            textBox4.KeyDown += textBox4_KeyDown;
            // 
            // Eklecheck
            // 
            Eklecheck.AutoSize = true;
            Eklecheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Eklecheck.Location = new System.Drawing.Point(97, 87);
            Eklecheck.Name = "Eklecheck";
            Eklecheck.Size = new System.Drawing.Size(50, 19);
            Eklecheck.TabIndex = 2;
            Eklecheck.Text = "Ekle";
            Eklecheck.UseVisualStyleBackColor = true;
            Eklecheck.CheckedChanged += Eklecheck_CheckedChanged;
            // 
            // CıkarCheck
            // 
            CıkarCheck.AutoSize = true;
            CıkarCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CıkarCheck.Location = new System.Drawing.Point(154, 88);
            CıkarCheck.Name = "CıkarCheck";
            CıkarCheck.Size = new System.Drawing.Size(54, 19);
            CıkarCheck.TabIndex = 3;
            CıkarCheck.Text = "Çıkar";
            CıkarCheck.UseVisualStyleBackColor = true;
            CıkarCheck.CheckedChanged += CıkarCheck_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1198, 402);
            dataGridView1.TabIndex = 33;
            dataGridView1.DataSourceChanged += dataGridView1_DataSourceChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button5
            // 
            button5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button5.BackColor = System.Drawing.SystemColors.ControlDark;
            button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 209, 161);
            button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.ForeColor = System.Drawing.Color.White;
            button5.Image = Properties.Resources.log_out__1_;
            button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button5.Location = new System.Drawing.Point(450, 113);
            button5.Name = "button5";
            button5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            button5.Size = new System.Drawing.Size(101, 30);
            button5.TabIndex = 34;
            button5.Text = "Geri Dön";
            button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // IslemDetayMusteriID
            // 
            IslemDetayMusteriID.AutoSize = true;
            IslemDetayMusteriID.Location = new System.Drawing.Point(427, 147);
            IslemDetayMusteriID.Name = "IslemDetayMusteriID";
            IslemDetayMusteriID.Size = new System.Drawing.Size(38, 15);
            IslemDetayMusteriID.TabIndex = 35;
            IslemDetayMusteriID.Text = "label6";
            // 
            // IslemDetayMusteriKodu
            // 
            IslemDetayMusteriKodu.AutoSize = true;
            IslemDetayMusteriKodu.Location = new System.Drawing.Point(471, 147);
            IslemDetayMusteriKodu.Name = "IslemDetayMusteriKodu";
            IslemDetayMusteriKodu.Size = new System.Drawing.Size(38, 15);
            IslemDetayMusteriKodu.TabIndex = 35;
            IslemDetayMusteriKodu.Text = "label6";
            // 
            // IslemDetayMusteriAdi
            // 
            IslemDetayMusteriAdi.AutoSize = true;
            IslemDetayMusteriAdi.Location = new System.Drawing.Point(515, 147);
            IslemDetayMusteriAdi.Name = "IslemDetayMusteriAdi";
            IslemDetayMusteriAdi.Size = new System.Drawing.Size(38, 15);
            IslemDetayMusteriAdi.TabIndex = 35;
            IslemDetayMusteriAdi.Text = "label6";
            // 
            // İslemDetayNebimNo
            // 
            İslemDetayNebimNo.AutoSize = true;
            İslemDetayNebimNo.Location = new System.Drawing.Point(559, 147);
            İslemDetayNebimNo.Name = "İslemDetayNebimNo";
            İslemDetayNebimNo.Size = new System.Drawing.Size(38, 15);
            İslemDetayNebimNo.TabIndex = 35;
            İslemDetayNebimNo.Text = "label6";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(686, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(248, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(579, 113);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 15);
            label6.TabIndex = 37;
            label6.Text = "*Ürün Adı :";
            // 
            // ThisUrunID
            // 
            ThisUrunID.AutoSize = true;
            ThisUrunID.Location = new System.Drawing.Point(441, 162);
            ThisUrunID.Name = "ThisUrunID";
            ThisUrunID.Size = new System.Drawing.Size(38, 15);
            ThisUrunID.TabIndex = 38;
            ThisUrunID.Text = "label6";
            // 
            // ThisUrunKodu
            // 
            ThisUrunKodu.AutoSize = true;
            ThisUrunKodu.Location = new System.Drawing.Point(485, 162);
            ThisUrunKodu.Name = "ThisUrunKodu";
            ThisUrunKodu.Size = new System.Drawing.Size(0, 15);
            ThisUrunKodu.TabIndex = 38;
            // 
            // ThisUrunAdi
            // 
            ThisUrunAdi.AutoSize = true;
            ThisUrunAdi.Location = new System.Drawing.Point(529, 165);
            ThisUrunAdi.Name = "ThisUrunAdi";
            ThisUrunAdi.Size = new System.Drawing.Size(38, 15);
            ThisUrunAdi.TabIndex = 39;
            ThisUrunAdi.Text = "label6";
            // 
            // İslemDetayMasterID
            // 
            İslemDetayMasterID.Location = new System.Drawing.Point(559, 174);
            İslemDetayMasterID.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            İslemDetayMasterID.Name = "İslemDetayMasterID";
            İslemDetayMasterID.Size = new System.Drawing.Size(52, 23);
            İslemDetayMasterID.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 15);
            label2.TabIndex = 41;
            label2.Text = "*İşlem Tipi :";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(AzalanChecked);
            panel2.Controls.Add(ArtanChecked);
            panel2.Controls.Add(NormalChecked);
            panel2.Controls.Add(SeriChecked);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(BarkodTxt);
            panel2.Controls.Add(CıkarCheck);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Eklecheck);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(İslemDetayNebimNo);
            panel2.Controls.Add(İslemDetayMasterID);
            panel2.Controls.Add(IslemDetayMusteriAdi);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(IslemDetayMusteriKodu);
            panel2.Controls.Add(ThisUrunAdi);
            panel2.Controls.Add(IslemDetayMusteriID);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(ThisUrunKodu);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(ThisUrunID);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label15);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1219, 660);
            panel2.TabIndex = 42;
            // 
            // AzalanChecked
            // 
            AzalanChecked.AutoSize = true;
            AzalanChecked.Location = new System.Drawing.Point(301, 113);
            AzalanChecked.Name = "AzalanChecked";
            AzalanChecked.Size = new System.Drawing.Size(61, 19);
            AzalanChecked.TabIndex = 42;
            AzalanChecked.Text = "Azalan";
            AzalanChecked.UseVisualStyleBackColor = true;
            AzalanChecked.CheckedChanged += AzalanChecked_CheckedChanged;
            // 
            // ArtanChecked
            // 
            ArtanChecked.AutoSize = true;
            ArtanChecked.Location = new System.Drawing.Point(240, 113);
            ArtanChecked.Name = "ArtanChecked";
            ArtanChecked.Size = new System.Drawing.Size(55, 19);
            ArtanChecked.TabIndex = 42;
            ArtanChecked.Text = "Artan";
            ArtanChecked.UseVisualStyleBackColor = true;
            ArtanChecked.CheckedChanged += ArtanChecked_CheckedChanged;
            // 
            // NormalChecked
            // 
            NormalChecked.AutoSize = true;
            NormalChecked.Location = new System.Drawing.Point(116, 113);
            NormalChecked.Name = "NormalChecked";
            NormalChecked.Size = new System.Drawing.Size(66, 19);
            NormalChecked.TabIndex = 7;
            NormalChecked.Text = "Normal";
            NormalChecked.UseVisualStyleBackColor = true;
            NormalChecked.CheckedChanged += SeriChecked_CheckedChanged;
            // 
            // SeriChecked
            // 
            SeriChecked.AutoSize = true;
            SeriChecked.Location = new System.Drawing.Point(188, 113);
            SeriChecked.Name = "SeriChecked";
            SeriChecked.Size = new System.Drawing.Size(45, 19);
            SeriChecked.TabIndex = 6;
            SeriChecked.Text = "Seri";
            SeriChecked.UseVisualStyleBackColor = true;
            SeriChecked.CheckedChanged += NormalChecked_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(113, 138);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(314, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown1.KeyDown += numericUpDown1_KeyDown;
            numericUpDown1.KeyPress += numericUpDown1_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(12, 113);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(102, 15);
            label5.TabIndex = 41;
            label5.Text = "*Ekleme Türü :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(686, 81);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(248, 23);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(579, 86);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 15);
            label3.TabIndex = 41;
            label3.Text = "*Ürün Kodu :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 169);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 15);
            label1.TabIndex = 29;
            label1.Text = "*Bandrol(ler) : ";
            // 
            // islemdetay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1219, 660);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1085, 620);
            Name = "islemdetay";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = " İşlem Detay Ekle";
            FormClosing += islemdetay_FormClosing;
            Load += islemdetay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)İslemDetayMasterID).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BarkodTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label genelbilgi;
        private System.Windows.Forms.Label sayac1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox Eklecheck;
        private System.Windows.Forms.CheckBox CıkarCheck;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label IslemDetayMusteriID;
        public System.Windows.Forms.Label IslemDetayMusteriKodu;
        public System.Windows.Forms.Label IslemDetayMusteriAdi;
        public System.Windows.Forms.Label İslemDetayNebimNo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label ThisUrunID;
        public System.Windows.Forms.Label ThisUrunKodu;
        public System.Windows.Forms.Label ThisUrunAdi;
        public System.Windows.Forms.NumericUpDown İslemDetayMasterID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GenelSayac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox NormalChecked;
        private System.Windows.Forms.CheckBox SeriChecked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox AzalanChecked;
        private System.Windows.Forms.CheckBox ArtanChecked;
    }
}