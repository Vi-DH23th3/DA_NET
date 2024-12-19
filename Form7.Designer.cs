namespace quanlynhansach
{
    partial class Form7
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
            this.masach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tensach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tacgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.theloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sachtk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
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
            this.masach,
            this.tensach,
            this.tacgia,
            this.NXB,
            this.theloai,
            this.giaban,
            this.sachtk});
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
            // masach
            // 
            this.masach.Text = "Mã sách";
            this.masach.Width = 119;
            // 
            // tensach
            // 
            this.tensach.Text = "Tên sách";
            this.tensach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tensach.Width = 147;
            // 
            // tacgia
            // 
            this.tacgia.Text = "Tác giả";
            this.tacgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tacgia.Width = 139;
            // 
            // NXB
            // 
            this.NXB.Text = "NXB";
            this.NXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NXB.Width = 141;
            // 
            // theloai
            // 
            this.theloai.Text = "Thể loại";
            this.theloai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.theloai.Width = 123;
            // 
            // giaban
            // 
            this.giaban.Text = "Gía bán";
            this.giaban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.giaban.Width = 137;
            // 
            // sachtk
            // 
            this.sachtk.Text = "Số lượng";
            this.sachtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sachtk.Width = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(409, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thống kê sách tồn kho";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader masach;
        private System.Windows.Forms.ColumnHeader tensach;
        private System.Windows.Forms.ColumnHeader tacgia;
        private System.Windows.Forms.ColumnHeader NXB;
        private System.Windows.Forms.ColumnHeader theloai;
        private System.Windows.Forms.ColumnHeader giaban;
        private System.Windows.Forms.ColumnHeader sachtk;
    }
}