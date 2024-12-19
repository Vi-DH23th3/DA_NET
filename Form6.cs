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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private SqlConnection cn;
        private SqlCommand cmdSelect,cmdItem;
        private int i;
        public void Moketnoi(SqlConnection con)
        {
            if(con.State==ConnectionState.Open) 
                con.Close();
            con.Open();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                string s = @"Data Source=DESKTOP-EL1NO5U\SQLSERVER1; Initial Catalog=qlbs;  User ID=vi; Password=123456";
                cn = new SqlConnection(s);
                cn.Open();
            }
            catch (Exception loi) { MessageBox.Show("Không thể kết nối được"); }
            LoadListview();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Hide();
        }

        public void LoadListview()
        {
            Moketnoi(cn);
            string query = "Select bh.madonhang, bh.tenkh, bh.ngayban, bh.tongtien, cb.masach, cb.solg"+
                " FROM qlbanhang bh INNER JOIN chitiet_bansach cb ON bh.madonhang=cb.madonhang";
            using (SqlCommand cmdSelect = new SqlCommand(query, cn))
            {
                using (SqlDataReader r = cmdSelect.ExecuteReader())
                {
                    listView1.Items.Clear();
                    while (r.Read())
                    {
                        string[] st = new string[6];
                        st[0] = r["madonhang"].ToString();
                        st[1] = r["tenkh"].ToString();
                        st[2] = r["masach"].ToString();
                        st[3] = r["solg"].ToString();
                        st[4] = r["tongtien"].ToString();
                        st[5] = r["ngayban"].ToString();
                        ListViewItem lv = new ListViewItem(st);
                        listView1.Items.Add(lv);
                    }
                }
            }
        }
    }
}
