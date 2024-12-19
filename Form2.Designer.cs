namespace quanlynhansach
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhapStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.banlStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tk_nhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tk_doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tk_stkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapStripMenuItem1,
            this.banlStripMenuItem2,
            this.thongkeStripMenuItem3,
            this.thoatStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhapStripMenuItem1
            // 
            this.nhapStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapStripMenuItem1.Name = "nhapStripMenuItem1";
            this.nhapStripMenuItem1.Size = new System.Drawing.Size(104, 24);
            this.nhapStripMenuItem1.Text = "Nhập sách";
            this.nhapStripMenuItem1.Click += new System.EventHandler(this.nhapStripMenuItem1_Click);
            // 
            // banlStripMenuItem2
            // 
            this.banlStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banlStripMenuItem2.Name = "banlStripMenuItem2";
            this.banlStripMenuItem2.Size = new System.Drawing.Size(93, 24);
            this.banlStripMenuItem2.Text = "Bán sách";
            this.banlStripMenuItem2.Click += new System.EventHandler(this.banlStripMenuItem2_Click);
            // 
            // thongkeStripMenuItem3
            // 
            this.thongkeStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tk_nhapToolStripMenuItem,
            this.tk_doanhThuToolStripMenuItem,
            this.tk_stkToolStripMenuItem});
            this.thongkeStripMenuItem3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongkeStripMenuItem3.Name = "thongkeStripMenuItem3";
            this.thongkeStripMenuItem3.Size = new System.Drawing.Size(96, 24);
            this.thongkeStripMenuItem3.Text = "Thống kê";
            // 
            // tk_nhapToolStripMenuItem
            // 
            this.tk_nhapToolStripMenuItem.Name = "tk_nhapToolStripMenuItem";
            this.tk_nhapToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tk_nhapToolStripMenuItem.Text = "Nhập sách";
            this.tk_nhapToolStripMenuItem.Click += new System.EventHandler(this.tk_nhapToolStripMenuItem_Click);
            // 
            // tk_doanhThuToolStripMenuItem
            // 
            this.tk_doanhThuToolStripMenuItem.Name = "tk_doanhThuToolStripMenuItem";
            this.tk_doanhThuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tk_doanhThuToolStripMenuItem.Text = "Doanh thu";
            this.tk_doanhThuToolStripMenuItem.Click += new System.EventHandler(this.tk_doanhThuToolStripMenuItem_Click);
            // 
            // tk_stkToolStripMenuItem
            // 
            this.tk_stkToolStripMenuItem.Name = "tk_stkToolStripMenuItem";
            this.tk_stkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tk_stkToolStripMenuItem.Text = "Sách tồn kho";
            this.tk_stkToolStripMenuItem.Click += new System.EventHandler(this.tk_stkToolStripMenuItem_Click);
            // 
            // thoatStripMenuItem
            // 
            this.thoatStripMenuItem.BackColor = System.Drawing.Color.White;
            this.thoatStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoatStripMenuItem.Name = "thoatStripMenuItem";
            this.thoatStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.thoatStripMenuItem.Text = "Thoát";
            this.thoatStripMenuItem.Click += new System.EventHandler(this.thoatStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlynhansach.Properties.Resources.nen1;
            this.ClientSize = new System.Drawing.Size(648, 619);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhapStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem banlStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem thongkeStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tk_nhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tk_doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tk_stkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatStripMenuItem;
    }
}