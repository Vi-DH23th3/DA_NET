namespace quanlynhansach
{
    partial class Form6
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.madonhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenkh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.masach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.Location = new System.Drawing.Point(476, 532);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 39);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.madonhang,
            this.tenkh,
            this.masach,
            this.sl,
            this.tongtien,
            this.ngayban});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(69, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(962, 356);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // madonhang
            // 
            this.madonhang.Text = "Mã đơn hàng";
            this.madonhang.Width = 125;
            // 
            // tenkh
            // 
            this.tenkh.Text = "Tên khách hàng";
            this.tenkh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tenkh.Width = 184;
            // 
            // masach
            // 
            this.masach.Text = "Mã sách";
            this.masach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.masach.Width = 167;
            // 
            // sl
            // 
            this.sl.DisplayIndex = 4;
            this.sl.Text = "Số lượng";
            this.sl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sl.Width = 192;
            // 
            // tongtien
            // 
            this.tongtien.DisplayIndex = 3;
            this.tongtien.Text = "Tổng tiền";
            this.tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tongtien.Width = 151;
            // 
            // ngayban
            // 
            this.ngayban.Text = "Ngày bán";
            this.ngayban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ngayban.Width = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(409, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thống kê doanh thu";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader madonhang;
        private System.Windows.Forms.ColumnHeader tenkh;
        private System.Windows.Forms.ColumnHeader masach;
        private System.Windows.Forms.ColumnHeader tongtien;
        private System.Windows.Forms.ColumnHeader sl;
        private System.Windows.Forms.ColumnHeader ngayban;
    }
}