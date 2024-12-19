using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhansach
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private SqlConnection cn;
        private SqlCommand cmdSelect;
        public void Moketnoi(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            try {
                string s = @"Data Source=DESKTOP-EL1NO5U\SQLSERVER1; Initial Catalog=qlbs;  User ID=vi; Password=123456";
                cn = new SqlConnection(s);
                cn.Open();
            } catch (Exception ex) { MessageBox.Show("Lỗi kết nối", ex.Message); }
            loadListview();

        }
        public void loadListview()
        {
            try
            {
             
                Moketnoi(cn);
                string query = "SELECT * FROM books";

                
                using (cmdSelect = new SqlCommand(query, cn))
                {
                    
                    using (SqlDataReader r = cmdSelect.ExecuteReader())
                    {
                        // Xóa tất cả mục cũ trong ListView
                        listView1.Items.Clear();

                        while (r.Read())
                        {
                            
                            string[] s = new string[7];
                            s[0] = r[0].ToString(); 
                            s[1] = r[1].ToString();  
                            s[2] = r[2].ToString(); 
                            s[3] = r[3].ToString();  
                            s[4] = r[4].ToString(); 
                            s[5] = r[5].ToString();  
                            s[6] = r[6].ToString();  

                            ListViewItem lv = new ListViewItem(s);
                            listView1.Items.Add(lv);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu", ex.Message);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Hide();
        }
    }
}
