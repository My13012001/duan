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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql = "select * from Dangnhap where username = '" + txtTaiKhoan.Text + "' and password = '" + txtMatKhau.Text + "'";
            DataTable mytable = ketnoi.SelectDB(sql);
            if (mytable.Rows.Count > 0)
            {
                Trangchu frm = new Trangchu();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
