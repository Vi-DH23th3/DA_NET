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

        private void thoatStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi=MessageBox.Show("Bạn có muốn đóng chương trình không?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK ) 
                Application.Exit();
        }

        private void nhapStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3=new Form3();
            f3.ShowDialog();
        }

        private void banlStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form4 f4=new Form4();
            f4.ShowDialog();
        }

        private void tk_nhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 =new Form5();
            f5.ShowDialog();
        }

        private void tk_doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 =new Form6();
            f6.ShowDialog();
        }

        private void tk_stkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 =new Form7();
            f7.ShowDialog();
        }
    }
}
