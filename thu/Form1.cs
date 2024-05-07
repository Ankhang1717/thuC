using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            functions.ketnoi();
            load_dgridview();
            btn_luu.Enabled = false;
            txt_mahang.Enabled = false;
            btn_boqua.Enabled = false;
            functions.fillcombo("select mamau, tenmau from tblMausac", cb_mamau, "mamau", "tenmau");
            cb_mamau.SelectedIndex = -1;
            load_dgridview();
            resetvalue();
        
        }


        DataTable tblhh;
        private void load_dgridview()
        {
            string sql;
            sql = "select * from tblHanghoa";
            tblhh = functions.GetDataTable(sql);
            dgridhanghoa.DataSource = tblhh;
            dgridhanghoa.Columns[0].HeaderText = "Mã hàng";
            dgridhanghoa.Columns[1].HeaderText = "Tên hàng";
            dgridhanghoa.Columns[2].HeaderText = "Mã màu";
            dgridhanghoa.Columns[3].HeaderText = "Số lượng";
            dgridhanghoa.Columns[4].HeaderText = "Thời gian bảo hành";
            dgridhanghoa.AllowUserToAddRows = false;
            dgridhanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void dgridhanghoa_Click(object sender, EventArgs e)
        {
            if(btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mahang.Focus();
                return;
            }
            if(tblhh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_mahang.Text = dgridhanghoa.CurrentRow.Cells["mahang"].Value.ToString();
            txt_tenhang.Text = dgridhanghoa.CurrentRow.Cells["tenhang"].Value.ToString();
            txt_soluong.Text = dgridhanghoa.CurrentRow.Cells["soluong"].Value.ToString();
            cb_mamau.Text = dgridhanghoa.CurrentRow.Cells["mamau"].Value.ToString();
            txt_baohanh.Text = dgridhanghoa.CurrentRow.Cells["thoigianbaohanh"].Value.ToString();

            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = true;


        }

        private void resetvalue()
        {
            txt_mahang.Text = "";
            txt_tenhang.Text = "";
            cb_mamau.Text = "";
            txt_soluong.Text = "";
            txt_baohanh.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_boqua.Enabled = true;
            btn_luu.Enabled = true;
            txt_mahang.Enabled = true;
            resetvalue();

        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            txt_mahang.Enabled = false;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql; 
            if(tblhh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txt_mahang.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "Delete tblHanghoa where mahang = N'" + txt_mahang.Text.Trim() + "' ";
                functions.runsql(sql);
                load_dgridview();
                resetvalue();
            }    
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txt_mahang.Text == "")
            {
                MessageBox.Show("Phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information );
                txt_mahang.Focus();
                return;
            }
            if(txt_tenhang.Text == "")
            {
                MessageBox.Show("Phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information );
                txt_tenhang.Focus();
                return;
            }   
            if(cb_mamau.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_mamau.Focus();
                return;
            }
            if (txt_soluong.Text == "")
            {
                MessageBox.Show("Phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (txt_baohanh.Text == "")
            {
                MessageBox.Show("Phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_baohanh.Focus();
                return;
            }
            sql = "Select mahang from tblHanghoa where mahang = N'" + txt_mahang.Text + "' ";
            if(functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mahang.Text = "";
                txt_mahang.Focus();
                return;
            }
            sql = "insert into tblHanghoa (mahang, tenhang, mamau, soluong, thoigianbaohanh) values(N'" + txt_mahang.Text + "', N'" + txt_tenhang.Text + "', N'" + cb_mamau.SelectedValue.ToString() + "', '" + txt_soluong.Text + "', '" + txt_baohanh.Text + "')";
            functions.runsql(sql);
            load_dgridview();
            resetvalue();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            txt_mahang.Enabled = false;
        }
    }
}
