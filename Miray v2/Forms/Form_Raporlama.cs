using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Miray_v2.Forms
{
    public partial class Form_Raporlama : Form
    {
        public Form_Raporlama()
        {
            InitializeComponent();
        }

        void ComboBox_Bayiler()
        {
            SqlDataReader ComboBoxReader = null;

            using (SqlConnection ComboBoxConnect = new SqlConnection(Form1.connections))
            {
                string MusteriSorgu = "SELECT MusteriAdi FROM Musterilerv2 ORDER BY MusteriAdi";

                using (SqlCommand ComboBoxCmd = new SqlCommand(MusteriSorgu, ComboBoxConnect))
                {
                    ComboBoxConnect.Open();
                    ComboBoxReader = ComboBoxCmd.ExecuteReader();
                    while (ComboBoxReader.Read())
                    {
                        Bayi.Items.Add(ComboBoxReader.GetString(0));
                    }
                    ComboBoxConnect.Close();
                }
            }
        }

        void Bayi_Sayisi()
        {
            using (SqlConnection BayiConnect = new SqlConnection(Form1.connections))
            {
                string BayiSorgu = "SELECT DISTINCT MusteriAdi, CONVERT(varchar, CreateDate, 23) FROM Islemler WHERE IsDeleted = 0 AND CreateDate BETWEEN @p1 AND @p2";

                System.Data.DataTable DaTa = new System.Data.DataTable();
                SqlDataAdapter BayiAdapter = new SqlDataAdapter(BayiSorgu, BayiConnect);

                BayiAdapter.SelectCommand.Parameters.AddWithValue("@p1", TarihBaslangic.Value);
                BayiAdapter.SelectCommand.Parameters.AddWithValue("@p2", TarihBitis.Value);

                BayiConnect.Open();
                BayiAdapter.Fill(DaTa);
                DataGridView.DataSource = DaTa;
                BayiSayisi.Text = DaTa.Rows.Count.ToString();
                BayiConnect.Close();
            }
        }
        void Fis_Sayisi()
        {
            using (SqlConnection FisConnect = new SqlConnection(Form1.connections))
            {
                string FisSorgu = "SELECT CONVERT(varchar, CreateDate, 23), NebimSiparisNo FROM Islemler WHERE IsDeleted = 0 AND CreateDate BETWEEN @p1 AND @p2";

                System.Data.DataTable DaTa = new System.Data.DataTable();
                SqlDataAdapter FisAdapter = new SqlDataAdapter(FisSorgu, FisConnect);

                FisAdapter.SelectCommand.Parameters.AddWithValue("@p1", TarihBaslangic.Value);
                FisAdapter.SelectCommand.Parameters.AddWithValue("@p2", TarihBitis.Value);

                FisConnect.Open();
                FisAdapter.Fill(DaTa);
                DataGridView.DataSource = DaTa;
                FisSayisi.Text = DaTa.Rows.Count.ToString();
                FisConnect.Close();
            }
        }

        void Urun_Sayisi()
        {
            using (SqlConnection UrunConnect = new SqlConnection(Form1.connections))
            {
                string UrunSorgu = "SELECT CONVERT(varchar, CreateDate, 23), UrunKodu FROM IslemlerDetail WHERE IsDeleted = 0 AND CreateDate BETWEEN @p1 AND @p2";

                System.Data.DataTable DaTa = new System.Data.DataTable();
                SqlDataAdapter UrunAdapter = new SqlDataAdapter(UrunSorgu, UrunConnect);

                UrunAdapter.SelectCommand.Parameters.AddWithValue("@p1", TarihBaslangic.Value);
                UrunAdapter.SelectCommand.Parameters.AddWithValue("@p2", TarihBitis.Value);

                UrunConnect.Open();
                UrunAdapter.Fill(DaTa);
                DataGridView.DataSource = DaTa;
                UrunSayisi.Text = DaTa.Rows.Count.ToString();
                UrunConnect.Close();
            }
        }
        void Bandrol_Sayisi()
        {
            using (SqlConnection BandrolConnect = new SqlConnection(Form1.connections))
            {
                string BandrolSorgu = "SELECT CONVERT(varchar, CreateDate, 23), Bandrol FROM IslemlerLog WHERE IsDeleted = 0 AND CreateDate BETWEEN @p1 AND @p2";

                System.Data.DataTable DaTa = new System.Data.DataTable();
                SqlDataAdapter BandrolAdapter = new SqlDataAdapter(BandrolSorgu, BandrolConnect);

                BandrolAdapter.SelectCommand.Parameters.AddWithValue("@p1", TarihBaslangic.Value);
                BandrolAdapter.SelectCommand.Parameters.AddWithValue("@p2", TarihBitis.Value);

                BandrolConnect.Open();
                BandrolAdapter.Fill(DaTa);
                DataGridView.DataSource = DaTa;
                BandrolSayisi.Text = DaTa.Rows.Count.ToString();
                BandrolConnect.Close();
            }
        }

        void Bayi_Fis_Urun_Bandrol_Sayisi()
        {
            using (SqlConnection TopluBayiConnect = new SqlConnection(Form1.connections))
            {
                string TopluBayiFisNoSorgu = $"SELECT CONVERT(varchar, CreateDate, 23), NebimSiparisNo FROM Islemler WHERE IsDeleted = 0 AND CreateDate BETWEEN @p1 AND @p2 AND MusteriAdi ='" + Bayi.Text + "'";

                System.Data.DataTable FisNoDaTa = new System.Data.DataTable();
                SqlDataAdapter FisNoSorgu = new SqlDataAdapter(TopluBayiFisNoSorgu, TopluBayiConnect);

                FisNoSorgu.SelectCommand.Parameters.AddWithValue("@p1", TarihBaslangic.Value);
                FisNoSorgu.SelectCommand.Parameters.AddWithValue("@p2", TarihBitis.Value);

                TopluBayiConnect.Open();
                FisNoSorgu.Fill(FisNoDaTa);
                DataGridView.DataSource = FisNoDaTa;
                FisSayisi_2.Text = FisNoDaTa.Rows.Count.ToString();
                TopluBayiConnect.Close();
            }

            using (SqlConnection TopluBayiConnect = new SqlConnection(Form1.connections))
            {
                string TopluBayiUrunSorgu = $"SELECT CONVERT(varchar, IslemlerDetail.CreateDate, 23), UrunKodu FROM IslemlerDetail INNER JOIN Islemler ON IslemlerDetail.MasterID = Islemler.IslemNo WHERE IslemlerDetail.IsDeleted = 0 AND IslemlerDetail.CreateDate BETWEEN @p1 AND @p2 AND Islemler.MusteriAdi ='" + Bayi.Text + "'";

                System.Data.DataTable UrunDaTa = new System.Data.DataTable();
                SqlDataAdapter UrunSorgu = new SqlDataAdapter(TopluBayiUrunSorgu, TopluBayiConnect);

                UrunSorgu.SelectCommand.Parameters.AddWithValue("@p1", TarihBaslangic.Value);
                UrunSorgu.SelectCommand.Parameters.AddWithValue("@p2", TarihBitis.Value);

                TopluBayiConnect.Open();
                UrunSorgu.Fill(UrunDaTa);
                DataGridView.DataSource = UrunDaTa;
                UrunSayisi_2.Text = UrunDaTa.Rows.Count.ToString();
                TopluBayiConnect.Close();
            }

            using (SqlConnection TopluBayiConnect = new SqlConnection(Form1.connections))
            {
                string TopluBayiBandrolSorgu = $"SELECT CONVERT(varchar, Islemler.CreateDate, 23), Bandrol FROM Islemler INNER JOIN IslemlerLog ON Islemler.IslemNo = IslemlerLog.MasterID WHERE IslemlerLog.IsDeleted = 0 AND IslemlerLog.CreateDate BETWEEN @p1 AND @p2 AND Islemler.MusteriAdi = '" + Bayi.Text + "'";

                System.Data.DataTable BandrolDaTa = new System.Data.DataTable();
                SqlDataAdapter BandrolSorgu = new SqlDataAdapter(TopluBayiBandrolSorgu, TopluBayiConnect);

                BandrolSorgu.SelectCommand.Parameters.AddWithValue("@p1", TarihBaslangic.Value);
                BandrolSorgu.SelectCommand.Parameters.AddWithValue("@p2", TarihBitis.Value);

                TopluBayiConnect.Open();
                BandrolSorgu.Fill(BandrolDaTa);
                DataGridView.DataSource = BandrolDaTa;
                BandrolSayisi_2.Text = BandrolDaTa.Rows.Count.ToString();
                TopluBayiConnect.Close();
            }
        }

        void Secilen_Tarih_Arası_Bayi_Sorgu()
        {
            if (checkBox1.Checked)
            {
                using (SqlConnection DGVConnect = new SqlConnection(Form1.connections))
                {
                    string Sorgu = $"SELECT Musteri.ID, Musteri.MusteriKodu as [Müşteri Kodu], Musteri.MusteriAdi as [Müşteri Adı], Sehir.SehirAdi as [Şehir], CONVERT(varchar, Islem.CreateDate, 23) AS [İşlem Tarihi] FROM Musterilerv2 Musteri INNER JOIN Sehirler Sehir ON Musteri.SehirID = Sehir.ID INNER JOIN Islemler Islem ON Musteri.MusteriAdi = Islem.MusteriAdi WHERE Islem.Tarih BETWEEN @p1 AND @p2 AND Musteri.MusteriAdi = '" + Bayi.Text + "' AND Musteri.IsDeleted = 0 ORDER BY Musteri.MusteriKodu";
                    SqlDataAdapter DA = new SqlDataAdapter(Sorgu, DGVConnect);
                    System.Data.DataTable DS = new System.Data.DataTable();

                    DA.SelectCommand.Parameters.AddWithValue("@p1", TarihBaslangic.Value);
                    DA.SelectCommand.Parameters.AddWithValue("@p2", TarihBitis.Value);

                    DGVConnect.Open();
                    DA.Fill(DS);
                    Liste.DataSource = DS;
                    DGVConnect.Close();
                }
            }

            if (!checkBox1.Checked)
            {
                /*
                BayiSayisi.Text = "0";
                BayiSayisi_2.Text = "0";
                FisSayisi.Text = "0";
                FisSayisi_2.Text = "0";
                UrunSayisi.Text = "0";
                UrunSayisi_2.Text = "0";
                BandrolSayisi.Text = "0";
                BandrolSayisi_2.Text = "0";
                */

                Bayi.Text = "          Lütfen Bayi Seçimi Yapınız";
                using (SqlConnection DGVConnect = new SqlConnection(Form1.connections))
                {
                    //SELECT CONVERT(varchar, Islem.CreateDate, 23), Musteri.ID, Musteri.MusteriKodu as [Müşteri Kodu], Musteri.MusteriAdi as [Müşteri Adı], Sehir.SehirAdi as [Şehir] FROM Musterilerv2 Musteri INNER JOIN Sehirler Sehir ON Musteri.SehirID = Sehir.ID INNER JOIN Islemler Islem ON Musteri.MusteriAdi = Islem.MusteriAdi WHERE Islem.Tarih BETWEEN '2023-07-31' AND '2023-08-01' AND Musteri.IsDeleted = 0 ORDER BY Musteri.MusteriKodu

                    string Sorgu = $"SELECT Musteri.ID, Musteri.MusteriKodu as [Müşteri Kodu], Musteri.MusteriAdi as [Müşteri Adı], Sehir.SehirAdi as [Şehir], CONVERT(varchar, Islem.CreateDate, 23) AS [İşlem Tarihi] FROM Musterilerv2 Musteri INNER JOIN Sehirler Sehir ON Musteri.SehirID = Sehir.ID INNER JOIN Islemler Islem ON Musteri.MusteriAdi = Islem.MusteriAdi WHERE Islem.Tarih BETWEEN @p1 AND @p2 AND Musteri.IsDeleted = 0 ORDER BY Musteri.MusteriKodu";
                    SqlDataAdapter DA = new SqlDataAdapter(Sorgu, DGVConnect);
                    System.Data.DataTable DS = new System.Data.DataTable();

                    DA.SelectCommand.Parameters.AddWithValue("@p1", TarihBaslangic.Value);
                    DA.SelectCommand.Parameters.AddWithValue("@p2", TarihBitis.Value);

                    DGVConnect.Open();
                    DA.Fill(DS);
                    Liste.DataSource = DS;
                    DGVConnect.Close();
                }
            }
        }

        private void Form_Raporlama_Load(object sender, EventArgs e)
        {
            ComboBox_Bayiler();
            BayiSayisi_2.Visible = false;
            FisSayisi_2.Visible = false;
            UrunSayisi_2.Visible = false;
            BandrolSayisi_2.Visible = false;

            TarihBaslangic.Value = DateTime.Now;
            TarihBitis.Value = DateTime.Now;

            using (SqlConnection DGVConnect = new SqlConnection(Form1.connections))
            {
                DGVConnect.Open();
                SqlCommand command = new SqlCommand("SELECT m.ID, m.MusteriKodu as [Müşteri Kodu], m.MusteriAdi as [Müşteri Adı], s.SehirAdi as [Şehir] FROM Musterilerv2 m INNER JOIN Sehirler s ON m.SehirID = s.ID", DGVConnect);

                SqlDataAdapter daa = new SqlDataAdapter(command);
                DataSet dss = new DataSet();
                daa.Fill(dss);
                Liste.DataSource = dss.Tables[0];
                DGVConnect.Close();
            }

            if (!checkBox1.Checked)
            {
                TarihBaslangic.Value = DateTime.Now;
                TarihBitis.Value = DateTime.Now;
            }
        }

        private void Sorgula_Click(object sender, EventArgs e)
        {
            Bayi_Sayisi();
            Fis_Sayisi();
            Urun_Sayisi();
            Bandrol_Sayisi();

            Bayi_Fis_Urun_Bandrol_Sayisi();
            Liste_Bayi_Sorgu();
            Secilen_Tarih_Arası_Bayi_Sorgu();
        }

        void Liste_Bayi_Sorgu()
        {
            using (SqlConnection DGVConnect = new SqlConnection(Form1.connections))
            {
                string Sorgu = $"SELECT m.ID, m.MusteriKodu as [Müşteri Kodu], m.MusteriAdi as [Müşteri Adı], s.SehirAdi as [Şehir] FROM Musterilerv2 m INNER JOIN Sehirler s ON m.SehirID = s.ID WHERE (MusteriKodu LIKE '%" + Bayi.Text + "%' OR MusteriAdi LIKE '%" + Bayi.Text + "%'OR s.SehirAdi LIKE '%" + Bayi.Text + "%') AND m.IsDeleted = 0 ORDER BY M.MusteriKodu desc";

                SqlDataAdapter DA = new SqlDataAdapter(Sorgu, DGVConnect);
                DataSet DS = new DataSet();

                DGVConnect.Open();
                DA.Fill(DS);
                Liste.DataSource = DS.Tables[0];
                DGVConnect.Close();
            }
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            TarihBaslangic.Value = DateTime.Now;
            TarihBitis.Value = DateTime.Now;
            BayiSayisi.Text = "0";
            FisSayisi.Text = "0";
            UrunSayisi.Text = "0";
            BandrolSayisi.Text = "0";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Bayi.Enabled = true;
                BayiSayisi.Visible = false;
                FisSayisi.Visible = false;
                UrunSayisi.Visible = false;
                BandrolSayisi.Visible = false;

                BayiSayisi_2.Visible = true;
                FisSayisi_2.Visible = true;
                UrunSayisi_2.Visible = true;
                BandrolSayisi_2.Visible = true;
            }
            else
            {
                Bayi.Enabled = false;
                BayiSayisi.Visible = true;
                FisSayisi.Visible = true;
                UrunSayisi.Visible = true;
                BandrolSayisi.Visible = true;
            }
        }

        private void Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_Raporlama_Detail Detail = new Form_Raporlama_Detail();
            Detail.Bayi = Bayi_Ismi.Text;
            Detail.Show();
        }

        private void Liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Bayi_Ismi.Text = Liste.CurrentRow.Cells[2].Value.ToString();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                for (int i = 1; i < Liste.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = Liste.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < Liste.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < Liste.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = Liste.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
    }
}
