using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Miray_v2.Forms
{
    public partial class Form_Raporlama_Detail : Form
    {
        public Form_Raporlama_Detail()
        {
            InitializeComponent();
        }

        public string Bayi = string.Empty;

        private void Form_Raporlama_Detail_Load(object sender, EventArgs e)
        {
            textBox1.Text = Bayi.ToString();

            if (System.Windows.Forms.Application.OpenForms.OfType<Form>().Any(f => f is Form_Raporlama_Detail))
            { System.Windows.Forms.Application.OpenForms.OfType<Form>().First(f => f is Form_Raporlama_Detail).Activate(); }
            else
            { new Form_Raporlama_Detail().Show(); }

            using (SqlConnection Connection = new SqlConnection(Form1.connections))
            {
                string Sorgu = $"SELECT ISL.NebimSiparisNo AS [Sipariş No], IDL.UrunKodu AS [Ürün Kodu], ILG.Bandrol AS [Bandrol], ISL.Tarih AS [İşlem Tarihi]   From Islemler as ISL INNER JOIN IslemlerDetail AS IDL On ISL.IslemNo = IDL.MasterID INNER JOIN IslemlerLog AS ILG ON  IDL.IslemNo = ILG.DetailID WHERE (MusteriAdi = '" + textBox1.Text + "') AND ISL.IsDeleted = 0 ORDER BY ISL.NebimSiparisNo ASC";

                System.Data.DataTable DT = new System.Data.DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(Sorgu, Connection);

                Connection.Open();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
                var DGV_Sayi = DT.Rows.Count;
                var DGV_Tek_Kolon_Sayi = DGV_Sayi / 3;
                Satir_Sayisi.Text = "Toplam Veri Sayısı: " + DGV_Tek_Kolon_Sayi.ToString() + " Satır";
                Connection.Close();
            }
        }
    }
}
