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
    public partial class QLNV : Form
    {
        private static string QLKH = "";
        public QLNV()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            string sql = "select * from QLNV";
            DataTable tbnv = ketnoi.SelectDB(sql);
            dgv_qlnv.DataSource = tbnv;
            LoadData2GridView();
            LoadData2Combobox();
        }
        private void LoadData2GridView()
        {
            string sql = "select * from QLNV";
            DataTable tbnv = ketnoi.SelectDB(sql);
            dgv_qlnv.DataSource = tbnv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into QLNV(MaNV,TenNV,NgaySinh,GioiTinh,QueQuan,SDT,MaKH) values (N'" + txtmanv.Text + "','" + txttennv.Text + "','" + txtns.Value.ToString("yyyy-MM-dd") + "',N'" + txtgt.Text + "','" + txtqq.Text + "','" + txtsdt.Text + "','"+ QLKH +"')";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Thêm dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update QLNV set TenNV = N'" + txttennv.Text + "', NgaySinh = '" + txtns.Value.ToString("yyyy-MM-dd") + "', GioiTinh = N'" + txtgt.Text + "', QueQuan = N'" + txtqq.Text + "', SDT = N'" + txtsdt.Text + "', MaKH = N'"+ QLKH +"' where MaNV = '" + txtmanv.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Sửa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from QLNV where MaNCC = '" + txtmanv.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Xóa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtgt.Text = "";
            txtns.Text = "";
            txtqq.Text = "";
            txtsdt.Text = "";
            cbomkh.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "select * from QLNV where TenNV like N'%" + txtTimkiem.Text + "%' OR QueQuan like '%" + txtTimkiem.Text + "%' OR SDT like '%" + txtTimkiem.Text + "%'";
            DataTable mytable = ketnoi.SelectDB(sql);
            dgv_qlnv.DataSource = mytable;
        }

        private void dgv_qlnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow myrow = new DataGridViewRow();
            myrow = dgv_qlnv.Rows[e.RowIndex];
            txtmanv.Text = myrow.Cells["MaNV"].Value.ToString();
            txttennv.Text = myrow.Cells["TenNV"].Value.ToString();
            txtTimkiem.Text = myrow.Cells["TenNV"].Value.ToString();
            txtgt.Text = myrow.Cells["GioiTinh"].Value.ToString();
            txtns.Value = DateTime.Parse(myrow.Cells["NgaySinh"].Value.ToString());
            txtqq.Text = myrow.Cells["QueQuan"].Value.ToString();
            txtsdt.Text = myrow.Cells["SDT"].Value.ToString();
            cbomkh.Text = myrow.Cells["MaKH"].Value.ToString();
        }
        private void LoadData2Combobox()
        {
            string sql = "select MaKH from QLKH";
            DataTable mytable = new DataTable();
            mytable = ketnoi.SelectDB(sql);
            cbomkh.ValueMember = "MaKH";
            cbomkh.DisplayMember = "MaKH";
            cbomkh.DataSource = mytable;
        }

        private void cbomkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLKH = cbomkh.SelectedValue.ToString();
        }
    }
}
