using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhansach
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private SqlConnection cn;
        public void Moktenoi(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
        }
        Boolean kt_trungMa(string ma)
        {
            for (int i = 0; i < lstHoaDon.Items.Count; i++)
            {
                if (ma == lstHoaDon.Items[i].SubItems[0].Text)
                {
                    return true;
                }
            }
            return false;
        }
        void them(string msach, string tensach, string soluong, string giasach)
        {
            string[] dongmoi = { msach, tensach, soluong, giasach };
            ListViewItem item = new ListViewItem(dongmoi);
            lstHoaDon.Items.Add(item);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu
            if (string.IsNullOrWhiteSpace(txtMaSach.Text) ||
                string.IsNullOrWhiteSpace(txtTenSach.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtGiaSach.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }

            // Kiểm tra giá trị số
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo");
                return;
            }

            if (!decimal.TryParse(txtGiaSach.Text, out decimal giaSach) || giaSach <= 0)
            {
                MessageBox.Show("Giá sách không hợp lệ", "Thông báo");
                return;
            }

            // Kiểm tra mã sách trùng lặp
            if (kt_trungMa(txtMaSach.Text))
            {
                MessageBox.Show("Mã đã tồn tại, không thêm được", "Thông báo");
            }
            else
            {
                them(txtMaSach.Text, txtTenSach.Text, txtSoLuong.Text, txtGiaSach.Text);
                MessageBox.Show("Thêm thành công", "Thông báo");

            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstHoaDon.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng bạn muốn xóa", "Thông báo");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in lstHoaDon.SelectedItems)
                {
                    lstHoaDon.Items.Remove(item);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstHoaDon.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng bạn muốn sửa", "Thông báo");
                return;
            }
            ListViewItem item = lstHoaDon.SelectedItems[0];
            // Cập nhật thông tin của dòng được chọn
            item.SubItems[0].Text = txtMaSach.Text;
            item.SubItems[1].Text = txtTenSach.Text;
            item.SubItems[2].Text = txtSoLuong.Text;
            item.SubItems[3].Text = txtGiaSach.Text;
            MessageBox.Show("Sửa thành công", "Thông báo");
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
            int cotSoLuong = 2;
            int cotDonGia = 3;

            foreach (ListViewItem item in lstHoaDon.Items)
            {
                if (double.TryParse(item.SubItems[cotSoLuong].Text, out double soluong) && double.TryParse(item.SubItems[cotDonGia].Text, out double dongia))

                {
                    sum += soluong * dongia;
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

        private void lstHoaDon_Click(object sender, EventArgs e)
        {
            ListViewItem dong = lstHoaDon.SelectedItems[0];
            txtMaSach.Text = dong.Text;
            txtTenSach.Text = dong.SubItems[1].Text;
            txtSoLuong.Text = dong.SubItems[2].Text;
            txtGiaSach.Text = dong.SubItems[3].Text;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                Moktenoi(cn); // Mở kết nối (đảm bảo kết nối đã được mở)

                string query = "SELECT * FROM books WHERE masach = @masach";
                using (SqlCommand cmdMS = new SqlCommand(query, cn))
                {
                    // Thêm tham số vào câu truy vấn
                    cmdMS.Parameters.AddWithValue("@masach", txtMaSach.Text);

                    // Thực thi câu truy vấn và lấy kết quả
                    using (SqlDataReader reader = cmdMS.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Đọc dữ liệu từ reader và gán vào các TextBox
                                txtTenSach.Text = reader["tensach"].ToString();
                                txtGiaSach.Text = reader["giaban"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message); // Xử lý lỗi nếu có
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            string s = @"Data Source=DESKTOP-EL1NO5U\SQLSERVER1;Initial Catalog=qlbs;  User ID=vi; Password=123456";
            cn = new SqlConnection(s);
            cn.Open();
        }

        private void btnLuuCSDL_Click(object sender, EventArgs e)
        {
            try
            {
                Moktenoi(cn);
                string mahd = txtMaHD.Text;
                string tenkh = txtTenKH.Text;
                float tongtien=float.Parse(txtTong.Text);
                DateTime ngayban = dateNgayBan.Value;

                {
                    string queryBH = "INSERT INTO qlbanhang(madonhang,tenkh,ngayban,tongtien)" +
                          "VALUES(@madonhang,@tenkh,@ngayban,@tongtien)";
                    using (SqlCommand cmdBH = new SqlCommand(queryBH, cn))
                    {
                        cmdBH.Parameters.AddWithValue("@madonhang", mahd);
                        cmdBH.Parameters.AddWithValue("@tenkh", tenkh);
                        cmdBH.Parameters.AddWithValue("@ngayban", ngayban);
                        cmdBH.Parameters.AddWithValue("@tongtien", tongtien);

                        cmdBH.ExecuteNonQuery();
                    }
                    foreach (ListViewItem item in lstHoaDon.Items)
                    {
                        string masach = item.SubItems[0].Text;
                        string tensach = item.SubItems[1].Text;
                        int soluong =int.Parse(item.SubItems[2].Text);
                        float giasach = float.Parse(item.SubItems[3].Text);
                        if (!int.TryParse(item.SubItems[2].Text, out soluong))
                        {
                            MessageBox.Show($"Số lượng sách không hợp lệ cho mã sách {masach}");
                            return;
                        }
                        if (!float.TryParse(item.SubItems[3].Text, out giasach))
                        {
                            MessageBox.Show($"Giá sách không hợp lệ cho mã sách {masach}");
                            return;
                        }

                        string queryB = "SELECT sachtk FROM books WHERE masach=@masach";
                        using (SqlCommand cmdB = new SqlCommand(queryB, cn))
                        {

                            cmdB.Parameters.AddWithValue("@masach", masach);
                            object tam = cmdB.ExecuteScalar();
                            if (tam != null)
                            {
                                int soluongtk = Convert.ToInt32(tam);
                                if (soluongtk < soluong)
                                {
                                    MessageBox.Show($"{masach} không còn đủ để bán");
                                    return;
                                }    
                                else
                                {
                                    soluongtk -= soluong;
                                    string query = "UPDATE books SET sachtk = @sachtk WHERE masach=@masach";
                                    SqlCommand cmdUpdate = new SqlCommand(query, cn);
                                    {

                                        cmdUpdate.Parameters.AddWithValue("@masach", masach);
                                        cmdUpdate.Parameters.AddWithValue("@sachtk", soluongtk);

                                        cmdUpdate.ExecuteNonQuery();
                                        MessageBox.Show("Đã cập nhật lại số lượng sách trong kho");
                                    }
                                }
                            }                           
                            string queryCT_BS = "INSERT INTO chitiet_bansach(madonhang,masach,solg)"
                                + "VALUES(@madonhang,@masach,@solg)";
                            using (SqlCommand cmdCT_BS = new SqlCommand(queryCT_BS, cn))
                            {
                                cmdCT_BS.Parameters.AddWithValue("@madonhang", mahd);
                                cmdCT_BS.Parameters.AddWithValue("@masach", masach);
                                cmdCT_BS.Parameters.AddWithValue("@solg", soluong);

                                cmdCT_BS.ExecuteNonQuery();
                            }
                        }
                       
                    }
                    MessageBox.Show("Đã lưu dữ liệu thành công", "Thông báo");
                }

            }
            catch (Exception ex) { MessageBox.Show($"Lỗi:{ex.Message}"); }
        }
    }
}
