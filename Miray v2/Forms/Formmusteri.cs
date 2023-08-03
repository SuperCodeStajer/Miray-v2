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
    public partial class Formmusteri : Form
    {

        public Formmusteri()
        {

            InitializeComponent();

        }



        musteriekle fekle = new musteriekle();

        SqlConnection conn = Form1.connection;
        SqlConnection conn1 = Form1.connection;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        int yetki;
        private void Formmusteri_Load(object sender, EventArgs e)
        {

            doldur();
            ad.Visible = false;
            numara.Visible = false;
            plaka.Visible = false;
            mid.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Columns["ID"].Visible = false;
            this.dataGridView1.Columns["a"].Visible = false;
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

            da = new SqlDataAdapter("SELECT m.ID, m.MusteriKodu as [Müşteri Kodu], m.MusteriAdi as [Müşteri Adı],m.SehirID as[a], s.SehirAdi as [Şehir] FROM Musterilerv2 m INNER JOIN Sehirler s ON m.SehirID = s.ID WHERE m.IsDeleted = 0 ORDER BY M.MusteriKodu desc", conn);



            ds = new DataSet();


            conn.Open();
            da.Fill(ds, "Musterilerv2");
            dataGridView1.DataSource = ds.Tables["Musterilerv2"];

            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (yetki == 1 || yetki == 3 || yetki == 2)
            {
                musteriekle1cs ee = new musteriekle1cs();
                ee.MusteriEkleYetki.Text = yetki.ToString();
                ee.ShowDialog();
                doldur();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yetki == 1 || yetki == 3 || yetki == 2)
            {
                if (numara.Text != "" && ad.Text != "" && plaka.Text != "")
                {
                    musteriekle fekle = new musteriekle();
                    fekle.numaraM.Text = numara.Text;
                    fekle.adM.Text = ad.Text;
                    fekle.MusteriDuzenleYetki.Text = yetki.ToString();
                    fekle.plakaM.Text = plaka.Text;
                    fekle.id.Text = mid.Text;
                    fekle.ShowDialog();
                    fekle.Focus();
                    doldur();


                }
                else
                {
                    MessageBox.Show("Önce Satır Seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void ara_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT m.ID, m.MusteriKodu as [Müşteri Kodu], m.MusteriAdi as [Müşteri Adı],m.SehirID as[a], s.SehirAdi as [Şehir] FROM Musterilerv2 m INNER JOIN Sehirler s ON m.SehirID = s.ID   WHERE (MusteriKodu LIKE '%" + ara.Text + "%' OR MusteriAdi LIKE '%" + ara.Text + "%'OR s.SehirAdi LIKE '%" + ara.Text + "%') AND m.IsDeleted = 0 ORDER BY M.MusteriKodu desc", conn);

            SqlDataAdapter daa = new SqlDataAdapter(command);
            DataSet dss = new DataSet();
            daa.Fill(dss);
            dataGridView1.DataSource = dss.Tables[0];
            conn.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (yetki == 1)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Seçilen satırları silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        DateTime deletetime = DateTime.Now;
                        string sqlFormattedDate = deletetime.ToString("yyyy-MM-dd HH:mm:ss.fff");

                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int id = Convert.ToInt32(row.Cells["ID"].Value);
                            string deleteQuery = "UPDATE Musterilerv2 SET IsDeleted = 1, DeleteUser = @deleteUser, DeleteDate = @deleteTime WHERE ID = @id";
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
                        mid.Text = "";

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
        SqlCommand komut;
        void sil(int numara)
        {
            string sql = "Update Musterilerv2 set IsDeleted=1 WHERE MusteriKodu=@numara";
            komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@numara", numara);
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (yetki == 1 || yetki == 3 || yetki == 2)
            {
                if (dataGridView1.RowCount > 0)
                {
                    int secili = dataGridView1.SelectedCells[0].RowIndex;
                    string ID = dataGridView1.Rows[secili].Cells[0].Value.ToString();
                    string no = dataGridView1.Rows[secili].Cells[1].Value.ToString();
                    string ads = dataGridView1.Rows[secili].Cells[2].Value.ToString();
                    string plk = dataGridView1.Rows[secili].Cells[3].Value.ToString();

                    mid.Text = ID;
                    numara.Text = no;
                    ad.Text = ads;
                    plaka.Text = plk;
                }
            }
            else
            {
                mid.Text = "";
                numara.Text = "";
                ad.Text = "";
                plaka.Text = "";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void numara_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (yetki == 1 || yetki == 3 || yetki == 2)
            {
                if (numara.Text != "" && ad.Text != "" && plaka.Text != "")
                {
                    musteriekle fekle = new musteriekle();
                    fekle.MusteriDuzenleYetki.Text = yetki.ToString();

                    fekle.numaraM.Text = numara.Text;
                    fekle.adM.Text = ad.Text;
                    fekle.plakaM.Text = plaka.Text;
                    fekle.id.Text = mid.Text;
                    fekle.ShowDialog();
                    fekle.Focus();
                    doldur();
                }
            }

        }
        int rowsAffected;
        int rowsAffected1;
        private int GetSehirIDFromSehirlerTable(string sehir)
        {
            var sehirID = 0; var query = "SELECT PlakaKodu FROM Sehirler WHERE SehirAdi=@sehir";
            using (var command = new SqlCommand(query, conn1))
            {
                conn1.Open();
                command.Parameters.AddWithValue("@sehir", sehir);
                var result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    sehirID = id;
                }
                conn1.Close();
            }

            return sehirID;
        }
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
                            using (SqlCommand checkCommand = new SqlCommand("SELECT MusteriKodu, MusteriAdi, SehirID FROM Musterilerv2", connection1))
                            {
                                SqlDataReader reader = checkCommand.ExecuteReader();
                                while (reader.Read())
                                {
                                    string musteriKodu = reader["MusteriKodu"].ToString();
                                    string musteriAdi = reader["MusteriAdi"].ToString();
                                    string sehirID = reader["SehirID"].ToString();
                                    existingData.Add($"{musteriKodu}|{musteriAdi}|{sehirID}");
                                }
                            }
                        }




                        var connection = new SqlConnection(Form1.connections);
                        connection.Open();
                        int createId = varss.userid;
                        DateTime date = DateTime.Now;

                        int isDeleted = 0;
                        var tableName = "MusterilerV2";
                        List<string> failedData = new List<string>(); // Ekleme işlemi başarısız olan verileri tutacak liste
                        List<string> updateData = new List<string>();
                        foreach (var uniqueRow in uniqueData)
                        {
                            var rowValues = uniqueRow.Split('|');
                            var musteriKodu = rowValues[0];
                            var musteriAdi = rowValues[1];
                            var sehir = rowValues[2];

                            bool isDuplicate = existingData.Any(d =>
                            {
                                var parts = d.Split('|');
                                return parts[0] == musteriKodu;
                            });


                            if (isDuplicate)
                            {
                                var query1 = string.Format("SELECT * FROM {0} WHERE MusteriKodu=@musteriKodu", tableName);
                                var command1 = new SqlCommand(query1, connection);
                                command1.Parameters.AddWithValue("@musteriKodu", musteriKodu);
                                var reader = command1.ExecuteReader();
                                if (reader.Read())
                                {

                                    var id = reader["ID"].ToString();
                                    var existingMusteriAdi = reader["MusteriAdi"].ToString();
                                    var existingSehirID = reader["SehirID"].ToString();
                                    reader.Close();
                                    var sehirID = GetSehirIDFromSehirlerTable(sehir);

                                    if (sehirID == 0)
                                    {
                                        failedData.Add($"{musteriKodu}, {musteriAdi}, {sehir} (Şehir Eşleştirilemedi)");
                                        continue;
                                    }
                                    if (existingMusteriAdi == musteriAdi && existingSehirID == sehirID.ToString())
                                    {
                                        //failedData.Add($"{musteriKodu}, {musteriAdi}, {sehir} (Önceki Kayıt İle Aynı)");
                                        continue;
                                    }
                                    else
                                    {
                                        updateData.Add($"{musteriKodu}, {musteriAdi}, {sehir} (Güncellenen Kayıt) \n");

                                    }
                                    query1 = string.Format("UPDATE {0} SET MusteriKodu=@newMusteriKodu, MusteriAdi=@musteriAdi, SehirID=@sehirID, UpdateUser=@createId, UpdateDate=@date, IsDeleted=@isDeleted, DeleteUser=NULL, DeleteDate=NULL WHERE ID=@id", tableName);
                                    command1 = new SqlCommand(query1, connection);
                                    command1.Parameters.AddWithValue("@newMusteriKodu", musteriKodu);
                                    command1.Parameters.AddWithValue("@musteriAdi", musteriAdi);
                                    command1.Parameters.AddWithValue("@sehirID", sehirID);
                                    command1.Parameters.AddWithValue("@createId", createId);
                                    command1.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                                    command1.Parameters.AddWithValue("@isDeleted", isDeleted);
                                    command1.Parameters.AddWithValue("@id", id);
                                    rowsAffected1 = command1.ExecuteNonQuery();
                                }

                                else
                                {
                                    failedData.Add($"{musteriKodu}, {musteriAdi}, {sehir} (Zaten Var)");
                                }

                                reader.Close();

                                //continue;

                            }
                            else
                            {
                                var rowIndices = Enumerable.Range(0, rowCount).Where(i =>
                               string.Join("|", Enumerable.Range(0, colCount).Select(j => data[i, j])) == uniqueRow);
                                var rowIndex = rowIndices.First();
                                var sehirID = GetSehirIDFromSehirlerTable(sehir);

                                if (sehirID == 0)
                                {
                                    failedData.Add($"{musteriKodu}, {musteriAdi}, {sehir} (Şehir Eşleştirilemedi)");
                                    continue;
                                }
                                var query = string.Format("INSERT INTO {0} (MusteriKodu, MusteriAdi, SehirID, CreateUser, CreateDate, IsDeleted) VALUES (@musteriKodu, @musteriAdi, @sehirID, @createId, @date, @isDeleted)", tableName);
                                var command = new SqlCommand(query, connection);
                                command.Parameters.AddWithValue("@musteriKodu", musteriKodu);
                                command.Parameters.AddWithValue("@musteriAdi", musteriAdi);
                                command.Parameters.AddWithValue("@sehirID", sehirID);
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
                            MessageBox.Show("Güncellene Bilir Veriler Güncellendi!\n" + string.Join(",", updateData), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

