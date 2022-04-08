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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void panelChildform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChilForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childForm);
            panelChildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            openChilForm(new QLH());
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
         
        }

        private void btnNV_Click(object sender, EventArgs e)
        {

        }

        private void btnHĐ_Click(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHang_Click_1(object sender, EventArgs e)
        {
            openChilForm(new QLH());
        }

        private void btnKH_Click_1(object sender, EventArgs e)
        {
            openChilForm(new QLKH());
        }

        private void btnNCC_Click_1(object sender, EventArgs e)
        {
            openChilForm(new QLNCC());
        }

        private void btnNV_Click_1(object sender, EventArgs e)
        {
            openChilForm(new QLNV());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChilForm(new QLHD());
        }

        private void panelChildform_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
