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
    public partial class QLHD : Form
    {
        private static string QLH = "";
        private static string QLKH = "";
        public QLHD()
        {
            InitializeComponent();
        }

        private void tx_Click(object sender, EventArgs e)
        {

        }

        private void hoa_don_Load(object sender, EventArgs e)
        {
            string sql = "select * from CTHD";
            DataTable tbhd = ketnoi.SelectDB(sql);
            dgv_qlhd.DataSource = tbhd;
            LoadData2GridView();
            LoadData2Combobox();
            LoadData3Combobox();
        }
        private void LoadData2GridView()
        {
            string sql = "select * from CTHD";
            DataTable tbhd = ketnoi.SelectDB(sql);
            dgv_qlhd.DataSource = tbhd;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into CTHD(MaHD,NgayBan,mah,MaKH,Soluongban,GiaBan,TongTien) values (N'" + txt_mahd.Text + "','" + txtnb.Value.ToString("yyyy-MM-dd") + "','" + QLH + "',N'" + QLKH + "','" + txt_sl.Text + "', '" + txt_dg.Text + "','" + txttt.Text + "' )";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Thêm dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update CTHD set NgayBan = N'" + txtnb.Value.ToString("yyyy-MM-dd") + "', mah = '" + QLH + "', MaKH = N'" + QLKH + "', Soluongban = '" + txt_sl.Text + "', GiaBan = '" + txt_dg.Text + "', Tongtien = '" + txttt.Text + "' where MaHD = '" + txt_mahd.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Sửa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from CTHD where mah = '" + txt_mahd.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Xóa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = "";
            txtnb.Text = "";
            cbomh.Text = "";
            cbomkh.Text = "";
            txt_sl.Text = "";
            txt_dg.Text = "";
            txttt.Text = "";
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "select * from CTHD where MaHD like N'%" + txtTimKiem.Text + "%' OR mah like '%" + txtTimKiem.Text + "%' OR MaKH like '%" + txtTimKiem.Text + "%' OR Soluongban like '%" + txtTimKiem.Text + "%' OR GiaBan like '%" + txtTimKiem.Text + "%'";
            DataTable mytable = ketnoi.SelectDB(sql);
            dgv_qlhd.DataSource = mytable;
        }

        private void dgv_qlh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow myrow = new DataGridViewRow();
            myrow = dgv_qlhd.Rows[e.RowIndex];
            txt_mahd.Text = myrow.Cells["MaHD"].Value.ToString();
            txtnb.Value = DateTime.Parse(myrow.Cells["NgayBan"].Value.ToString());
            cbomh.Text = myrow.Cells["mah"].Value.ToString();
            txtTimKiem.Text = myrow.Cells["MaHD"].Value.ToString();
            cbomkh.Text = myrow.Cells["MaKH"].Value.ToString();
            txt_sl.Text = myrow.Cells["Soluongban"].Value.ToString();
            txt_dg.Text = myrow.Cells["GiaBan"].Value.ToString();
            txttt.Text = myrow.Cells["Tongtien"].Value.ToString();
        }
        private void LoadData2Combobox()
        {
            string sql = "select mah from QLH";
            DataTable mytable = new DataTable();
            mytable = ketnoi.SelectDB(sql);
            cbomh.ValueMember = "mah";
            cbomh.DisplayMember = "mah";
            cbomh.DataSource = mytable;
        }
        private void LoadData3Combobox()
        {
            string sql = "select MaKH from QLKH";
            DataTable mytable = new DataTable();
            mytable = ketnoi.SelectDB(sql);
            cbomkh.ValueMember = "MaKH";
            cbomkh.DisplayMember = "MaKH";
            cbomkh.DataSource = mytable;
        }

        private void cbomh_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLH = cbomh.SelectedValue.ToString();
        }

        private void cbomkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLKH = cbomkh.SelectedValue.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xuatbaocao_Click(object sender, EventArgs e)
        {
            XuatHD g = new XuatHD();
            g.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gia = Convert.ToInt32(txt_dg.Text);
            int soluong = Convert.ToInt32(txt_sl.Text);
            int kq = gia * soluong;
            txttt.Text = kq.ToString();
        }
    }
}
