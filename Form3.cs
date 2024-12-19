using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhansach
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private SqlConnection cn;
        private SqlCommand cmdSelect, cmdInsert;
        void them( string ms, string ts, string tg, string tl, string sl, string gn)
        {
            string[] moi = { ms, ts, tg, tl, sl, gn };
            ListViewItem item = new ListViewItem(moi);
            listView1.Items.Add(item);
        }
        Boolean kt_trungMa(string ma)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (ma == listView1.Items[i].SubItems[0].Text)
                {
                    return true;
                }
            }
            return false;
        }
        public void Moketnoi(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ListViewItem item1= new ListViewItem();
            item1.Text = "S006";
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Hoàng tử bé" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Tiểu thuyết" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Nguyễn A" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "20" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "30000" });
            listView1.Items.Add(item1);
            try
            {
                string s= @"Data Source=DESKTOP-EL1NO5U\SQLSERVER1;Initial Catalog=qlbs;  User ID=vi; Password=123456";
                cn = new SqlConnection(s);
                cn.Open();
            }
            catch (Exception loi) { MessageBox.Show("Không thể kết nối được"); }
 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtMaSach.Text) ||
                string.IsNullOrWhiteSpace(txtTenSach.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtTacGia.Text) ||
                string.IsNullOrWhiteSpace(txtTheLoai.Text) ||
                string.IsNullOrWhiteSpace(txtGiaNhap.Text))

                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                    return;
                }
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo");
                return;
            }
            else if (kt_trungMa(txtMaSach.Text))
            {
                MessageBox.Show("Mã đã tồn tại, không thêm được", "Thông báo");
            }
            else
            {
                them(txtMaSach.Text, txtTenSach.Text, txtTacGia.Text, txtTheLoai.Text, txtSoLuong.Text, txtGiaNhap.Text);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }    
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng bạn muốn xóa", "Thông báo");
                return;
            }
            if (listView1.SelectedItems != null)
            {
                DialogResult hoi = MessageBox.Show("Bạn có chắn chắn muốn xóa dòng được chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    for (int i = 0; i < listView1.SelectedItems.Count; i++)
                    {
                        if (listView1.Items[i].Selected)
                            listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng bạn muốn sửa", "Thông báo");
                return;
            }
            if (listView1.SelectedItems != null)
                {

                    listView1.SelectedItems[0].SubItems[0].Text = txtMaSach.Text;
                    listView1.SelectedItems[0].SubItems[1].Text = txtTenSach.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = txtTheLoai.Text;
                    listView1.SelectedItems[0].SubItems[3].Text = txtTacGia.Text;
                    listView1.SelectedItems[0].SubItems[4].Text = txtSoLuong.Text;
                    listView1.SelectedItems[0].SubItems[5].Text = txtGiaNhap.Text;
                    listView1.Update();
                }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem dong = listView1.SelectedItems[0];
            txtMaSach.Text = dong.Text;
            txtTenSach.Text = dong.SubItems[1].Text;
            txtTheLoai.Text = dong.SubItems[2].Text;
            txtTacGia.Text = dong.SubItems[3].Text;
            txtSoLuong.Text = dong.SubItems[4].Text;
            txtGiaNhap.Text=dong.SubItems[5].Text;
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int cotSoLuong = 4;
            int cotGiaNhap = 5;

            foreach (ListViewItem item in listView1.Items)
            {
                if (double.TryParse(item.SubItems[cotSoLuong].Text, out double soluong) && double.TryParse(item.SubItems[cotGiaNhap].Text, out double gianhap))

                {
                    sum += soluong * gianhap;
                }
            }
            txtTong.Text = sum.ToString();
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Lưu Form Dưới Dạng Hình Ảnh";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Chụp ảnh giao diện form
                using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                {
                    this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(filePath, ImageFormat.Png);
                }

                MessageBox.Show("File đã được lưu thành công dưới dạng hình ảnh!", "Thông báo");
            }
        }

        private void btnLuuCSDL_Click(object sender, EventArgs e)
        {
            try
            {
                Moketnoi(cn);
                string sophieunhap = txtMaNhap.Text;
                int slpn = 0;
                DateTime ngaynhap = dateNgayNhap.Value;
                string cbNXB = cmbNXB.SelectedItem.ToString();
                string query = "INSERT INTO qlnhap(somanhap, ngaynhap, soluong )" +
                             "VALUES(@somanhap,@ngaynhap,@soluong)";
                SqlCommand cmdPhieuNhap = new SqlCommand(query, cn);
                {
                    cmdPhieuNhap.Parameters.AddWithValue("@somanhap", sophieunhap);
                    cmdPhieuNhap.Parameters.AddWithValue("@ngaynhap", ngaynhap);
                    cmdPhieuNhap.Parameters.AddWithValue("@soluong", slpn);
                    cmdPhieuNhap.ExecuteNonQuery();
                }
                string queryBooks = "INSERT INTO books(masach,tensach,tacgia,NXB,theloai,giaban,sachtk)" +
                    "VALUES(@masach,@tensach,@tacgia,@NXB,@theloai,@giaban,@sachtk)";
                using (SqlCommand cmdInsertBooks = new SqlCommand(queryBooks, cn))
                {
                    cmdInsertBooks.Parameters.Add("@masach", SqlDbType.NVarChar);
                    cmdInsertBooks.Parameters.Add("@tensach", SqlDbType.NVarChar);
                    cmdInsertBooks.Parameters.Add("@tacgia", SqlDbType.NVarChar);
                    cmdInsertBooks.Parameters.Add("@NXB", SqlDbType.NVarChar);
                    cmdInsertBooks.Parameters.Add("@theloai", SqlDbType.NVarChar);
                    cmdInsertBooks.Parameters.Add("@giaban", SqlDbType.Float);
                    cmdInsertBooks.Parameters.Add("@sachtk", SqlDbType.Int);
                    foreach (ListViewItem item in listView1.Items)
                    {
                        string masach = item.SubItems[0].Text;
                        string tensach = item.SubItems[1].Text;
                        string theloai = item.SubItems[2].Text;
                        string tacgia = item.SubItems[3].Text;
                        int soluong = int.Parse(item.SubItems[4].Text);
                        float gianhap = float.Parse(item.SubItems[5].Text);
                        slpn += soluong;
                        //KIỂM TRA MÃ SÁCH ĐÃ TỒN TẠI CHƯA
                        string queryKT_MS = "SELECT COUNT(*) FROM books b WHERE masach=@masach";
                        using (SqlCommand cmdKT_MS = new SqlCommand(queryKT_MS, cn))
                        {
                            cmdKT_MS.Parameters.AddWithValue("@masach", masach);
                            int count = (int)cmdKT_MS.ExecuteScalar();
                            if (count > 0) //nếu mã sách đã tồn tại
                            {
                                string queryUpdate = "UPDATE books SET sachtk=sachtk+@soluong WHERE masach=@masach";
                                SqlCommand cmdUpdate=new SqlCommand(queryUpdate, cn);
                                {
                                    cmdUpdate.Parameters.AddWithValue("@masach", masach);
                                    cmdUpdate.Parameters.AddWithValue("@soluong", soluong);
                                    cmdUpdate.ExecuteNonQuery();
                                    MessageBox.Show("Mã sách đã tồn tại: Đã cập nhật lại số lượng sách");
                                }
                            }
                            else
                            {
                                cmdInsertBooks.Parameters["@masach"].Value = masach;
                                cmdInsertBooks.Parameters["@tensach"].Value = tensach;
                                cmdInsertBooks.Parameters["@theloai"].Value = theloai;
                                cmdInsertBooks.Parameters["@tacgia"].Value = tacgia;
                                cmdInsertBooks.Parameters["@giaban"].Value = gianhap;
                                cmdInsertBooks.Parameters["@NXB"].Value = cbNXB;
                                cmdInsertBooks.Parameters["@sachtk"].Value = soluong;

                                // Thực thi câu lệnh INSERT
                                cmdInsertBooks.ExecuteNonQuery();
                                MessageBox.Show("Sách chưa có trong kho: Đã thêm sách mới");
                            }
                            string queryChitietNhap = "INSERT INTO chitiet_nhap(somanhap, masach, soluong )" +
                            "VALUES(@somanhap,@masach,@soluong)";
                            SqlCommand cmdChitietNhap = new SqlCommand(queryChitietNhap, cn);
                            {
                                cmdChitietNhap.Parameters.AddWithValue("@somanhap", sophieunhap);
                                cmdChitietNhap.Parameters.AddWithValue("@masach", masach);
                                cmdChitietNhap.Parameters.AddWithValue("@soluong", soluong);
                                cmdChitietNhap.ExecuteNonQuery();
                            }
                            string queryUpdatePhieuNhap = "UPDATE qlnhap SET soluong = soluong + @soluong WHERE somanhap = @somanhap";
                            using (SqlCommand cmdUpdatePhieuNhap = new SqlCommand(queryUpdatePhieuNhap, cn))
                            {
                                cmdUpdatePhieuNhap.Parameters.AddWithValue("@somanhap", sophieunhap);
                                cmdUpdatePhieuNhap.Parameters.AddWithValue("@soluong", soluong);
                                cmdUpdatePhieuNhap.ExecuteNonQuery();
                            }
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"lỗi {ex.Message}");
            }
        }
    }
}
