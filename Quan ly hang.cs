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
    public partial class QLH : Form
    {
        private static string QLNCC = "";
        private static string QLNV = "";
        public QLH()
        {
            InitializeComponent();
        }

        private void QLH_Load(object sender, EventArgs e)
        {
            string sql = "select * from QLH";
            DataTable tbh = ketnoi.SelectDB(sql);
            dgv_qlh.DataSource = tbh;
            LoadData2GridView();
            LoadData2Combobox();
            LoadData3Combobox();
        }
        private void LoadData2GridView()
        {
            string sql = "select * from QLH";
            DataTable tbh = ketnoi.SelectDB(sql);
            dgv_qlh.DataSource = tbh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           // string sql = "insert into QLH(mah,tenh,dg,sl,MaNCC,manv) values (N'" + txt_mah.Text + "','" + txt_tenh.Text + "','" + txt_dg.Text + "',N'" + txt_sl.Text + "','" + txtmancc + "', '"+ txt_manv +"')";
            //ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Thêm dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           // string sql = "update QLH set tenh = N'" + txt_tenh.Text + "', dg = '" + txt_dg.Text + "', sl = N'" + txt_sl.Text + "', MaNCC = '" + txtmancc +"', manv = '"+ txt_manv +"' where mah = '" + txt_mah.Text + "'";
           // ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Sửa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from QLH where mah = '" + txt_mah.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Xóa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txt_mah.Text = "";
            txt_tenh.Text = "";
            txt_dg.Text = "";
            txt_sl.Text = "";
            //txtmancc.Text = "";
            //txt_manv.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "select * from QLH where tenh like N'%" + txtTimKiem.Text + "%' OR dg like '%" + txtTimKiem.Text + "%' OR sl like '%" + txtTimKiem.Text + "%' OR MaNCC like '%" + txtTimKiem.Text + "%' OR manv like '%" + txtTimKiem.Text + "%'" ;
            DataTable mytable = ketnoi.SelectDB(sql);
            dgv_qlh.DataSource = mytable;
        }

        private void dgv_qlh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow myrow = new DataGridViewRow();
            myrow = dgv_qlh.Rows[e.RowIndex];
            txt_mah.Text = myrow.Cells["mah"].Value.ToString();
            txt_tenh.Text = myrow.Cells["tenh"].Value.ToString();
            txtTimKiem.Text = myrow.Cells["tenh"].Value.ToString();
            txt_dg.Text = myrow.Cells["dg"].Value.ToString();
            txt_sl.Text = myrow.Cells["sl"].Value.ToString();
            //txtmancc.Text = myrow.Cells["MaNCC"].Value.ToString();
            //txt_manv.Text = myrow.Cells["manv"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xuatbaocao_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string sql = "insert into QLH(mah,tenh,dg,sl,MaNCC,manv) values (N'" + txt_mah.Text + "','" + txt_tenh.Text + "','" + txt_dg.Text + "',N'" + txt_sl.Text + "','" + QLNCC + "', '" + QLNV + "')";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Thêm dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string sql = "update QLH set tenh = N'" + txt_tenh.Text + "', dg = '" + txt_dg.Text + "', sl = N'" + txt_sl.Text + "', MaNCC = '" + QLNCC + "', manv = '" + QLNV + "' where mah = '" + txt_mah.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Sửa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string sql = "delete from QLH where mah = '" + txt_mah.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Xóa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            txt_mah.Text = "";
            txt_tenh.Text = "";
            txt_dg.Text = "";
            txt_sl.Text = "";
            cbomncc.Text = "";
            cbomnv.Text = "";
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from QLH where tenh like N'%" + txtTimKiem.Text + "%' OR dg like '%" + txtTimKiem.Text + "%' OR sl like '%" + txtTimKiem.Text + "%' OR MaNCC like '%" + txtTimKiem.Text + "%' OR manv like '%" + txtTimKiem.Text + "%'";
            DataTable mytable = ketnoi.SelectDB(sql);
            dgv_qlh.DataSource = mytable;
        }

        private void dgv_qlh_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow myrow = new DataGridViewRow();
            myrow = dgv_qlh.Rows[e.RowIndex];
            txt_mah.Text = myrow.Cells["mah"].Value.ToString();
            txt_tenh.Text = myrow.Cells["tenh"].Value.ToString();
            txtTimKiem.Text = myrow.Cells["tenh"].Value.ToString();
            txt_dg.Text = myrow.Cells["dg"].Value.ToString();
            txt_sl.Text = myrow.Cells["sl"].Value.ToString();
            cbomncc.Text = myrow.Cells["MaNCC"].Value.ToString();
            cbomnv.Text = myrow.Cells["manv"].Value.ToString();
        }
        private void LoadData2Combobox()
        {
            string sql = "select MaNCC from QLNCC";
            DataTable mytable = new DataTable();
            mytable = ketnoi.SelectDB(sql);
            cbomncc.ValueMember = "MaNCC";
            cbomncc.DisplayMember = "MaNCC";
            cbomncc.DataSource = mytable;
        }
        private void LoadData3Combobox()
        {
            string sql = "select MaNV from QLNV";
            DataTable mytable = new DataTable();
            mytable = ketnoi.SelectDB(sql);
            cbomnv.ValueMember = "MaNV";
            cbomnv.DisplayMember = "MaNV";
            cbomnv.DataSource = mytable;
        }

        private void cbomncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLNCC = cbomncc.SelectedValue.ToString();
        }

        private void cbomnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLNV = cbomnv.SelectedValue.ToString();
        }

        private void btn_xuatbaocao_Click_1(object sender, EventArgs e)
        {
            XuatFile f = new XuatFile();
            f.ShowDialog();
        }
    }
}
