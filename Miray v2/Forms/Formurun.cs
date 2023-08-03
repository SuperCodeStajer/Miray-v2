using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Linq;
namespace Miray_v2.Forms
{
    public partial class Formurun : Form
    {
        public Formurun()
        {
            InitializeComponent();
        }
       urunekle furun = new  urunekle();
        SqlConnection conn = Form1.connection;
        

        SqlDataAdapter da;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            if (yetki == 1 || yetki == 3 || yetki==2)
            {
                urunekle1 ee = new urunekle1();
                ee.UrunEkleYetki.Text = yetki.ToString();
            ee.ShowDialog();
            doldur();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yetki == 1 || yetki == 3 || yetki==2)
            {
                if (urunıd.Text != "" && urunkod.Text != "" && urunad.Text != "" && urunbarkod.Text != "")
                {
                urunekle furun = new urunekle();
                furun.lblid.Text = urunıd.Text;
                furun.UrunDüzenleYetki.Text = yetki.ToString();
                furun.lblkod.Text = urunkod.Text;
                furun.lblad.Text = urunad.Text;
                furun.lblbarkod.Text = urunbarkod.Text;
                furun.ShowDialog();
                furun.Focus();
                doldur();


                }
            else { MessageBox.Show("Önce Satır Seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            
        }
        int yetki;
        private void Formurun_Load(object sender, EventArgs e)
        {
            doldur();
            urunıd.Visible = false;
            urunkod.Visible = false;
            urunad.Visible = false;
            urunbarkod.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.ClearSelection();
            dataGridView1.ReadOnly = true;
            ara.Focus();
            using (SqlConnection baglanti = new SqlConnection(Form1.connections))
            {

                string grupIdSorgusu = "SELECT YetkiID FROM GrupYetki WHERE MenuID = @ID and GrupID=@i";

                using (SqlCommand cmd1 = new SqlCommand(grupIdSorgusu, baglanti))
                {
                    cmd1.Parameters.AddWithValue("@ID", varss.YetkiIDmain);
                    cmd1.Parameters.AddWithValue("@i", varss.GrupIDmain);
                    baglanti.Open();
                    yetki = (int)cmd1.ExecuteScalar();
                    baglanti.Close();
                }
            }
        }
        void doldur()
        {
            
            da = new SqlDataAdapter("SELECT ID, UrunKodu as[Ürün Kodu], UrunAdi as[Ürün Adı], Barkod as[Barkod] FROM Urunler where IsDeleted=0 Order BY 1 desc", conn);
            ds = new DataSet();


            conn.Open();
            da.Fill(ds, "Urunler");
            dataGridView1.DataSource = ds.Tables["Urunler"];

            conn.Close();

        }

        private void ara_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT ID, UrunKodu as[Ürün Kodu], UrunAdi as[Ürün Adı], Barkod  FROM Urunler WHERE (Urunkodu LIKE '%" + ara.Text + "%' OR UrunAdi LIKE '%" + ara.Text + "%'OR Barkod LIKE '%" + ara.Text + "%') AND IsDeleted = 0 Order BY 1 desc", conn);

            SqlDataAdapter daa = new SqlDataAdapter(command);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            dataGridView1.DataSource = dss.Tables[0];
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (yetki == 1 || yetki == 3 || yetki == 2 )
            {
                if (dataGridView1.RowCount > 0)
                {
                    int secili = dataGridView1.SelectedCells[0].RowIndex;
                    string ID = dataGridView1.Rows[secili].Cells[0].Value.ToString();
                    string no = dataGridView1.Rows[secili].Cells[1].Value.ToString();
                    string ads = dataGridView1.Rows[secili].Cells[2].Value.ToString();
                    string plk = dataGridView1.Rows[secili].Cells[3].Value.ToString();

                    urunıd.Text = ID;
                    urunkod.Text = no;
                    urunad.Text = ads;
                    urunbarkod.Text = plk;
                }
            }
            else
            {
                urunıd.Text = "";
                urunkod.Text = "";
                urunad.Text = "";
                urunbarkod.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (yetki == 1)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Seçilen satırları silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        DateTime deletetime = DateTime.Now;
                        string sqlFormattedDate = deletetime.ToString("yyyy-MM-dd HH:mm:ss.fff");

                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int id = Convert.ToInt32(row.Cells["ID"].Value);
                            string deleteQuery = "UPDATE Urunler SET IsDeleted = 1, DeleteUser = @deleteUser, DeleteDate = @deleteTime WHERE ID = @id";
                            using (SqlConnection connection = new SqlConnection(Form1.connections))
                            {
                                SqlCommand command = new SqlCommand(deleteQuery, connection);
                                command.Parameters.AddWithValue("@id", id);
                                command.Parameters.AddWithValue("@deleteUser", varss.userid);
                                command.Parameters.AddWithValue("@deleteTime", sqlFormattedDate);
                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Seçilen satırlar başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        urunıd.Text = "";

                    }
                    doldur();

                }
            }
            else if (yetki == 2)
            {
                MessageBox.Show("Sadece Görüntülüye Bilirsiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (yetki == 3)
            {
                MessageBox.Show("Silme Yetkiniz Yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (yetki == 1 || yetki == 3 || yetki == 2 )
            {
                if (urunıd.Text != "" && urunkod.Text != "" && urunad.Text != "" && urunbarkod.Text != "")
                {
                urunekle furun = new urunekle();
                furun.lblid.Text = urunıd.Text;
                furun.lblkod.Text = urunkod.Text;
                furun.lblad.Text = urunad.Text;
                furun.lblbarkod.Text = urunbarkod.Text;
                furun.UrunDüzenleYetki.Text = yetki.ToString();
                furun.ShowDialog();
                furun.Focus();
                doldur();
                 }
            }
           
        }
        int rowsAffected;
        int rowsAffected1;
        private void button4_Click(object sender, EventArgs e)
        {
            if (yetki == 1 || yetki == 3 || yetki == 2)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Dosyaları (*.xlsx)|*.xlsx|Excel 97-2003 Dosyaları (*.xls)|*.xls|Tüm Dosyalar (*.*)|*.*";
                openFileDialog.Title = "Excel Dosyası Seçin";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    if (Path.GetExtension(fileName) != ".xlsx" && Path.GetExtension(fileName) != ".xls")
                    {
                        MessageBox.Show("Lütfen sadece Excel dosyalarını seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        var excel = new Microsoft.Office.Interop.Excel.Application();
                        var workbook = excel.Workbooks.Open(fileName);

                        // dosya okuma ve insert işlemleri burada yapılabilir
                        var sheet = workbook.Worksheets.Item[1] as Worksheet;
                        // Verileri oku
                        var range = sheet.UsedRange;
                        var rowCount = range.Rows.Count;
                        var colCount = range.Columns.Count;
                        if (colCount != 3)
                        {
                            MessageBox.Show("Excel dosyası beklenen formatta değil. Lütfen dosyayı kontrol edin ve tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        // Verileri saklamak için bir dizi oluştur
                        var data = new string[rowCount, colCount];
                        for (int row = 1; row <= rowCount; row++)
                        {
                            for (int col = 1; col <= colCount; col++)
                            {
                                var cell = range.Cells[row, col] as Microsoft.Office.Interop.Excel.Range;
                                data[row - 1, col - 1] = cell.Value2.ToString();

                            }
                        }

                        HashSet<string> uniqueData = new HashSet<string>();
                        for (int row = 0; row < rowCount; row++)
                        {
                            string rowData = string.Join("|", Enumerable.Range(0, colCount).Select(col => data[row, col]));

                            if (!uniqueData.Contains(rowData))
                            {
                                uniqueData.Add(rowData); // Add the unique row to the HashSet
                            }
                        }

                        workbook.Close();
                        excel.Quit();

                        HashSet<string> existingData = new HashSet<string>();
                        using (SqlConnection connection1 = new SqlConnection(Form1.connections))
                        {
                            connection1.Open();
                            using (SqlCommand checkCommand = new SqlCommand("SELECT UrunKodu, UrunAdi, Barkod FROM Urunler", connection1))
                            {
                                SqlDataReader reader = checkCommand.ExecuteReader();
                                while (reader.Read())
                                {
                                    string urunKodu = reader["UrunKodu"].ToString();
                                    string urunAdi = reader["UrunAdi"].ToString();
                                    string barkod = reader["Barkod"].ToString();
                                    existingData.Add($"{urunKodu}|{urunAdi}|{barkod}");
                                }
                            }
                        }




                        var connection = new SqlConnection(Form1.connections);
                        connection.Open();
                        int createId = varss.userid;
                        DateTime date = DateTime.Now;

                        int isDeleted = 0;
                        var tableName = "Urunler";
                        List<string> failedData = new List<string>(); // Ekleme işlemi başarısız olan verileri tutacak liste
                        List<string> updateData = new List<string>();
                        foreach (var uniqueRow in uniqueData)
                        {
                            var rowValues = uniqueRow.Split('|');
                            var urunKodu = rowValues[0];
                            var urunAdi = rowValues[1];
                            var barkod = rowValues[2];

                            bool isDuplicate = existingData.Any(d =>
                            {
                                var parts = d.Split('|');
                                return parts[2] == barkod && parts[0] == urunKodu;

                            });


                            if (isDuplicate)
                            {
                                var query1 = string.Format("SELECT * FROM {0} WHERE Barkod=@barkod", tableName);
                                var command1 = new SqlCommand(query1, connection);
                                command1.Parameters.AddWithValue("@barkod", barkod);
                                var reader = command1.ExecuteReader();

                                if (reader.Read())
                                {
                                    
                                    var id = reader["ID"].ToString();
                                    var existingUrunKodu = reader["UrunKodu"].ToString();
                                    var existingUrunAdi = reader["UrunAdi"].ToString();
                                    reader.Close();

                                    if (existingUrunKodu == urunKodu && existingUrunAdi == urunAdi)
                                    {
                                       // failedData.Add($"{urunKodu}, {urunAdi}, {barkod} (Önceki Kayıt İle Aynı) \n");
                                        continue;
                                    }
                                    else
                                    {
                                        updateData.Add($"{urunKodu}, {urunAdi}, {barkod} (Güncellenen Kayıt) \n");
                                    }
                                    query1 = string.Format("UPDATE {0} SET UrunKodu=@urunKodu, UrunAdi=@urunAdi, Barkod=@newBarkod, UpdateUser=@createId, UpdateDate=@date, IsDeleted=@isDeleted, DeleteUser=NULL, DeleteDate=NULL WHERE ID=@id", tableName);
                                    command1 = new SqlCommand(query1, connection);
                                    command1.Parameters.AddWithValue("@urunKodu", urunKodu);
                                    command1.Parameters.AddWithValue("@urunAdi", urunAdi);
                                    command1.Parameters.AddWithValue("@newBarkod", barkod);
                                    command1.Parameters.AddWithValue("@createId", createId);
                                    command1.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                                    command1.Parameters.AddWithValue("@isDeleted", isDeleted);
                                    command1.Parameters.AddWithValue("@id", id);
                                    rowsAffected1 = command1.ExecuteNonQuery();
                                }
                                else
                                {
                                    failedData.Add($"{urunKodu}, {urunAdi}, {barkod} (Zaten Var) \n");
                                }
                                reader.Close();
                                
                                //continue;
                            }
                            else
                            {
                                var rowIndices = Enumerable.Range(0, rowCount).Where(i =>
                               string.Join("|", Enumerable.Range(0, colCount).Select(j => data[i, j])) == uniqueRow);
                                var rowIndex = rowIndices.First();

                                var query = "INSERT INTO " + tableName + " (UrunKodu, UrunAdi, Barkod, CreateUser, CreateDate, IsDeleted) VALUES (@urunKodu, @urunAdi, @barkod, @createId, @date, @isDeleted)";
                                var command = new SqlCommand(query, connection);
                                command.Parameters.AddWithValue("@urunKodu", urunKodu);
                                command.Parameters.AddWithValue("@urunAdi", urunAdi);
                                command.Parameters.AddWithValue("@barkod", barkod);
                                command.Parameters.AddWithValue("@createId", createId);
                                command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                                command.Parameters.AddWithValue("@isDeleted", isDeleted);
                                rowsAffected = command.ExecuteNonQuery();

                            }



                        }
                        if (failedData.Count > 0)
                        {

                            MessageBox.Show("Bu Veriler Aktarılamadı\n" + string.Join(",", failedData), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        if (rowsAffected1 > 0)
                        {
                            MessageBox.Show("Güncellene Bilir Veriler Güncellendi! \n"+ string.Join(",",updateData), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Listede Olan Veriler Aktarılmadı,Olmayanlar Aktarıldı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        doldur();
                        failedData.Clear();
                        updateData.Clear();
                    }
                }

            }
        }
    }
}
