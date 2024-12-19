using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhansach
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private SqlConnection cn;
        private SqlCommand cmdSelect, cmdInsert;
        private int i;
        public void Moketnoi(SqlConnection con)
        {
            if(con.State==ConnectionState.Open) 
                con.Close();
            con.Open();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try {
                string s = @"Data Source=DESKTOP-EL1NO5U\SQLSERVER1; Initial Catalog=qlbs;  User ID=vi; Password=123456";
                cn = new SqlConnection(s);
                cn.Open();
             }
            catch(Exception loi) { MessageBox.Show("Không thể kết nối được"); }
            loadListview();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi= MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Hide();
        }

        /*
       public void loadListview()
       {
           Moketnoi(cn);
           cmdSelect = new SqlCommand("secect n.*,c.somanhap from qlnhap n where n.somanhap=c.somanhap", cn);
           SqlDataReader r=cmdSelect.ExecuteReader();
           listView1.Items.Clear();
           while(r.Read())
           {
               string[] st = new string[4];
               st[0] = r[0].ToString();
               st[1] = r[1].ToString();
               st[2] = r[2].ToString();
               st[3] = r[3].ToString();
               ListViewItem lv=new ListViewItem(st);
               listView1.Items.Add(lv);
           }    
           cmdSelect.Dispose();
       }
       */
        public void loadListview()
        {
            
            try
            {
                if(cn.State!=ConnectionState.Open)
                {
                    cn.Open();
                }    
                //Moketnoi(cn);
                // Cập nhật lại câu truy vấn để chỉ rõ các cột cần thiết
                string query = "SELECT n.somanhap, n.ngaynhap, c.masach, c.soluong " +
                               "FROM qlnhap n INNER JOIN chitiet_nhap c ON n.somanhap = c.somanhap";

                using (SqlCommand cmdSelect = new SqlCommand(query, cn))
                {
                    using (SqlDataReader r = cmdSelect.ExecuteReader())
                    {
                        listView1.Items.Clear();

                        while (r.Read())
                        {
                            // Giả sử bạn lấy 4 cột từ câu truy vấn
                            string[] st = new string[4];
                            st[0] = r["somanhap"].ToString();
                            st[1] = r["masach"].ToString();
                            st[2] = r["soluong"].ToString();
                            st[3] = r["ngaynhap"].ToString();

                            ListViewItem lv = new ListViewItem(st);
                            listView1.Items.Add(lv);
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu",ex.Message);
            }
        }
    }
}
