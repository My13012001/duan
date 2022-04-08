using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GS25
{
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into QLKH(MaKH,TenKH,NgaySinh,GioiTinh,SDT,SoDiem) values (N'" + txt_makh.Text + "','" + txt_tenkh.Text + "','" + txt_nskh.Value.ToString("yyyy-MM-dd") + "',N'" + txt_gt.Text + "','" + txt_sdtkh.Text + "','" + txt_dtl.Text + "')";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Thêm dữ liệu thành công!");
            LoadData2GridView();
        }

        private void khach_hang_Load(object sender, EventArgs e)
        {
            string sql = "select * from QLKH";
            DataTable tbkh = ketnoi.SelectDB(sql);
            dgv_qlkh.DataSource = tbkh;
            LoadData2GridView();
        }
        private void LoadData2GridView()
        {
            string sql = "select * from QLKH";
            DataTable tbkh = ketnoi.SelectDB(sql);
            dgv_qlkh.DataSource = tbkh;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update QLKH set TenKH = N'" + txt_tenkh.Text + "', NgaySinh = '" + txt_nskh.Value.ToString("yyyy-MM-dd") + "', GioiTinh = N'" + txt_gt.Text + "', SDT = N'" + txt_sdtkh.Text + "', SoDiem = N'" + txt_dtl.Text + "' where MaKH = '" + txt_makh.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Sửa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from QLKH where MaKH = '" + txt_makh.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Xóa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_nskh.Text = "";
            txt_gt.Text = "";
            txt_sdtkh.Text = "";
            txt_dtl.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from QLKH where TenKH like N'%" + txtTimKiem.Text + "%' OR SDT like '%" + txtTimKiem.Text + "%' OR SoDiem like '%" + txtTimKiem.Text + "%'";
            DataTable mytable = ketnoi.SelectDB(sql);
            dgv_qlkh.DataSource = mytable;
        }

        private void dgv_qlkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow myrow = new DataGridViewRow();
            myrow = dgv_qlkh.Rows[e.RowIndex];
            txt_makh.Text = myrow.Cells["MaKH"].Value.ToString();
            txt_tenkh.Text = myrow.Cells["TenKH"].Value.ToString();
            txtTimKiem.Text = myrow.Cells["TenKH"].Value.ToString();
            txt_gt.Text = myrow.Cells["GioiTinh"].Value.ToString();
            txt_nskh.Value = DateTime.Parse(myrow.Cells["NgaySinh"].Value.ToString());
            txt_sdtkh.Text = myrow.Cells["SDT"].Value.ToString();
            txt_dtl.Text = myrow.Cells["SoDiem"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
