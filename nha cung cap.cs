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
    public partial class QLNCC : Form
    {
        public QLNCC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nha_cung_cap_Load(object sender, EventArgs e)
        {
            string sql = "select * from QLNCC";
            DataTable tbncc = ketnoi.SelectDB(sql);
            dgv_qlncc.DataSource = tbncc;
            LoadData2GridView();
        }
        private void LoadData2GridView()
        {
            string sql = "select * from QLNCC";
            DataTable tbncc = ketnoi.SelectDB(sql);
            dgv_qlncc.DataSource = tbncc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into QLNCC(MaNCC,TenNCC,NgaySinh,GioiTinh,DiaChi,SDT) values (N'" + txt_mancc.Text + "','" + txt_tenncc.Text + "','" + txt_ns.Value.ToString("yyyy-MM-dd") + "',N'" + txt_gt.Text + "','" + txt_dcncc.Text + "','" + txt_sdtncc.Text + "')";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Thêm dữ liệu thành công!");
            LoadData2GridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "update QLNCC set TenNCC = N'" + txt_tenncc.Text + "', NgaySinh = '" + txt_ns.Value.ToString("yyyy-MM-dd") + "', GioiTinh = N'" + txt_gt.Text + "', DiaChi = N'" + txt_dcncc.Text + "', SDT = N'" + txt_sdtncc.Text + "' where MaNCC = '" + txt_mancc.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Sửa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from QLNCC where MaNCC = '" + txt_mancc.Text + "'";
            ketnoi.UpInsDelDB(sql);
            MessageBox.Show("Xóa dữ liệu thành công!");
            LoadData2GridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_mancc.Text = "";
            txt_tenncc.Text = "";
            txt_gt.Text = "";
            txt_ns.Text = "";
            txt_dcncc.Text = "";
            txt_sdtncc.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "select * from QLNCC where TenNCC like N'%" + txtTimKiem.Text + "%' OR DiaChi like '%" + txtTimKiem.Text + "%' OR SDT like '%" + txtTimKiem.Text + "%'";
            DataTable mytable = ketnoi.SelectDB(sql);
            dgv_qlncc.DataSource = mytable;
        }

        private void dgv_qlncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow myrow = new DataGridViewRow();
            myrow = dgv_qlncc.Rows[e.RowIndex];
            txt_mancc.Text = myrow.Cells["MaNCC"].Value.ToString();
            txt_tenncc.Text = myrow.Cells["TenNCC"].Value.ToString();
            txtTimKiem.Text = myrow.Cells["TenNCC"].Value.ToString();
            txt_gt.Text = myrow.Cells["GioiTinh"].Value.ToString();
            txt_ns.Value = DateTime.Parse(myrow.Cells["NgaySinh"].Value.ToString());
            txt_dcncc.Text = myrow.Cells["DiaChi"].Value.ToString();
            txt_sdtncc.Text = myrow.Cells["SDT"].Value.ToString();
        }
    }
}
