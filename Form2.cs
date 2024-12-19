using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhansach
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string tendn;
        private void thoatStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi=MessageBox.Show("Bạn có muốn đóng chương trình không?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK ) 
                Application.Exit();
        }
        //Menu open form 3: nhập sách
        private void nhapStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3=new Form3();
            f3.ShowDialog();
        }
        //Menu open form4: bán sách
        private void banlStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form4 f4=new Form4();
            f4.ShowDialog();
        }
        //Menu open form5: Thống kê nhập sách
        private void tk_nhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tendn=="nv")
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else
            {
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }

        }
        //Menu open form6: thống kê doanh thu
        private void tk_doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tendn == "nv")
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form6 f6 = new Form6();
                f6.ShowDialog();
            }
           
        }
        //Menu open form7: thống kê sách tồn kho
        private void tk_stkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tendn == "nv")
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
            
        }
    }
}
