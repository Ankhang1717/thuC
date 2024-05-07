namespace thu
{
    partial class Form1
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
            this.lb_danhmuc = new System.Windows.Forms.Label();
            this.lb_mahang = new System.Windows.Forms.Label();
            this.lb_tenhang = new System.Windows.Forms.Label();
            this.lb_mamau = new System.Windows.Forms.Label();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.lb_baohanh = new System.Windows.Forms.Label();
            this.dgridhanghoa = new System.Windows.Forms.DataGridView();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_baohanh = new System.Windows.Forms.TextBox();
            this.cb_mamau = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridhanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_danhmuc
            // 
            this.lb_danhmuc.AutoSize = true;
            this.lb_danhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_danhmuc.Location = new System.Drawing.Point(166, 19);
            this.lb_danhmuc.Name = "lb_danhmuc";
            this.lb_danhmuc.Size = new System.Drawing.Size(393, 39);
            this.lb_danhmuc.TabIndex = 0;
            this.lb_danhmuc.Text = "DANH MỤC HÀNG HÓA";
            // 
            // lb_mahang
            // 
            this.lb_mahang.AutoSize = true;
            this.lb_mahang.Location = new System.Drawing.Point(45, 93);
            this.lb_mahang.Name = "lb_mahang";
            this.lb_mahang.Size = new System.Drawing.Size(62, 16);
            this.lb_mahang.TabIndex = 1;
            this.lb_mahang.Text = "Mã hàng:";
            // 
            // lb_tenhang
            // 
            this.lb_tenhang.AutoSize = true;
            this.lb_tenhang.Location = new System.Drawing.Point(45, 132);
            this.lb_tenhang.Name = "lb_tenhang";
            this.lb_tenhang.Size = new System.Drawing.Size(67, 16);
            this.lb_tenhang.TabIndex = 2;
            this.lb_tenhang.Text = "Tên hàng:";
            // 
            // lb_mamau
            // 
            this.lb_mamau.AutoSize = true;
            this.lb_mamau.Location = new System.Drawing.Point(45, 169);
            this.lb_mamau.Name = "lb_mamau";
            this.lb_mamau.Size = new System.Drawing.Size(58, 16);
            this.lb_mamau.TabIndex = 3;
            this.lb_mamau.Text = "Mã màu:";
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Location = new System.Drawing.Point(45, 212);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(63, 16);
            this.lb_soluong.TabIndex = 4;
            this.lb_soluong.Text = "Số lượng:";
            // 
            // lb_baohanh
            // 
            this.lb_baohanh.AutoSize = true;
            this.lb_baohanh.Location = new System.Drawing.Point(45, 254);
            this.lb_baohanh.Name = "lb_baohanh";
            this.lb_baohanh.Size = new System.Drawing.Size(125, 16);
            this.lb_baohanh.TabIndex = 5;
            this.lb_baohanh.Text = "Thời gian bảo hành:";
            // 
            // dgridhanghoa
            // 
            this.dgridhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridhanghoa.Location = new System.Drawing.Point(48, 313);
            this.dgridhanghoa.Name = "dgridhanghoa";
            this.dgridhanghoa.RowHeadersWidth = 51;
            this.dgridhanghoa.RowTemplate.Height = 24;
            this.dgridhanghoa.Size = new System.Drawing.Size(616, 150);
            this.dgridhanghoa.TabIndex = 6;
            this.dgridhanghoa.Click += new System.EventHandler(this.dgridhanghoa_Click);
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(190, 90);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(132, 22);
            this.txt_mahang.TabIndex = 7;
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Location = new System.Drawing.Point(190, 129);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(132, 22);
            this.txt_tenhang.TabIndex = 8;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(190, 212);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(132, 22);
            this.txt_soluong.TabIndex = 9;
            // 
            // txt_baohanh
            // 
            this.txt_baohanh.Location = new System.Drawing.Point(190, 251);
            this.txt_baohanh.Name = "txt_baohanh";
            this.txt_baohanh.Size = new System.Drawing.Size(132, 22);
            this.txt_baohanh.TabIndex = 10;
            // 
            // cb_mamau
            // 
            this.cb_mamau.FormattingEnabled = true;
            this.cb_mamau.Location = new System.Drawing.Point(190, 166);
            this.cb_mamau.Name = "cb_mamau";
            this.cb_mamau.Size = new System.Drawing.Size(132, 24);
            this.cb_mamau.TabIndex = 11;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(48, 497);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(65, 32);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(159, 497);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(65, 32);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(272, 497);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(65, 32);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(503, 497);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(65, 32);
            this.btn_boqua.TabIndex = 15;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(391, 497);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(65, 32);
            this.btn_luu.TabIndex = 16;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(599, 497);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(65, 32);
            this.btn_dong.TabIndex = 17;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 602);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cb_mamau);
            this.Controls.Add(this.txt_baohanh);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.dgridhanghoa);
            this.Controls.Add(this.lb_baohanh);
            this.Controls.Add(this.lb_soluong);
            this.Controls.Add(this.lb_mamau);
            this.Controls.Add(this.lb_tenhang);
            this.Controls.Add(this.lb_mahang);
            this.Controls.Add(this.lb_danhmuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridhanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_danhmuc;
        private System.Windows.Forms.Label lb_mahang;
        private System.Windows.Forms.Label lb_tenhang;
        private System.Windows.Forms.Label lb_mamau;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.Label lb_baohanh;
        private System.Windows.Forms.DataGridView dgridhanghoa;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_baohanh;
        private System.Windows.Forms.ComboBox cb_mamau;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_dong;
    }
}

