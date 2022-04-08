using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QL_GS25
{
    public partial class XuatFile : Form
    {
        public XuatFile()
        {
            InitializeComponent();
        }
        private void XuatFile_Load(object sender, EventArgs e)
        {
            
            this.QLHTableAdapter.Fill(this.QL_GS25DataSet.QLH);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
