
namespace QL_GS25
{
    partial class QLH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLH));
            this.button6 = new System.Windows.Forms.Button();
            this.dgv_qlh = new System.Windows.Forms.DataGridView();
            this.mah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txt_tenh = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_dg = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tx = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDonGia = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xuatbaocao = new System.Windows.Forms.Button();
            this.txtTenHang = new System.Windows.Forms.Label();
            this.txt_mah = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbomnv = new System.Windows.Forms.ComboBox();
            this.cbomncc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(570, 24);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 4;
            this.button6.Text = "Tìm kiếm";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // dgv_qlh
            // 
            this.dgv_qlh.AllowUserToAddRows = false;
            this.dgv_qlh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_qlh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qlh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mah,
            this.tenh,
            this.dg,
            this.sl,
            this.MaNCC,
            this.manv});
            this.dgv_qlh.Location = new System.Drawing.Point(6, 71);
            this.dgv_qlh.Name = "dgv_qlh";
            this.dgv_qlh.RowHeadersVisible = false;
            this.dgv_qlh.RowHeadersWidth = 51;
            this.dgv_qlh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qlh.Size = new System.Drawing.Size(831, 175);
            this.dgv_qlh.TabIndex = 0;
            this.dgv_qlh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlh_CellContentClick_1);
            // 
            // mah
            // 
            this.mah.DataPropertyName = "mah";
            this.mah.HeaderText = "Mã Hàng";
            this.mah.MinimumWidth = 6;
            this.mah.Name = "mah";
            // 
            // tenh
            // 
            this.tenh.DataPropertyName = "tenh";
            this.tenh.HeaderText = "Tên hàng";
            this.tenh.MinimumWidth = 6;
            this.tenh.Name = "tenh";
            // 
            // dg
            // 
            this.dg.DataPropertyName = "dg";
            this.dg.HeaderText = "Đơn Giá";
            this.dg.MinimumWidth = 6;
            this.dg.Name = "dg";
            // 
            // sl
            // 
            this.sl.DataPropertyName = "sl";
            this.sl.HeaderText = "Số Lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "(VNĐ)";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(567, 140);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 39);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Làm mới";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.Location = new System.Drawing.Point(724, 140);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 39);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(208, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 39);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(386, 140);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 39);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // txt_tenh
            // 
            this.txt_tenh.Location = new System.Drawing.Point(110, 91);
            this.txt_tenh.Name = "txt_tenh";
            this.txt_tenh.Size = new System.Drawing.Size(108, 26);
            this.txt_tenh.TabIndex = 8;
            // 
            // txt_sl
            // 
            this.txt_sl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sl.Location = new System.Drawing.Point(370, 43);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(108, 26);
            this.txt_sl.TabIndex = 7;
            // 
            // txt_dg
            // 
            this.txt_dg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dg.Location = new System.Drawing.Point(370, 86);
            this.txt_dg.Name = "txt_dg";
            this.txt_dg.Size = new System.Drawing.Size(108, 26);
            this.txt_dg.TabIndex = 6;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(143, 24);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(392, 26);
            this.txtTimKiem.TabIndex = 3;
            // 
            // tx
            // 
            this.tx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(296, 43);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(72, 20);
            this.tx.TabIndex = 5;
            this.tx.Text = "Số lượng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(814, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.AutoSize = true;
            this.txtDonGia.Location = new System.Drawing.Point(296, 89);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(64, 20);
            this.txtDonGia.TabIndex = 4;
            this.txtDonGia.Text = "Đơn giá";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_xuatbaocao);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.dgv_qlh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 244);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hàng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_xuatbaocao
            // 
            this.btn_xuatbaocao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xuatbaocao.Image = ((System.Drawing.Image)(resources.GetObject("btn_xuatbaocao.Image")));
            this.btn_xuatbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xuatbaocao.Location = new System.Drawing.Point(682, 25);
            this.btn_xuatbaocao.Name = "btn_xuatbaocao";
            this.btn_xuatbaocao.Size = new System.Drawing.Size(132, 32);
            this.btn_xuatbaocao.TabIndex = 19;
            this.btn_xuatbaocao.Text = "Xuất báo cáo";
            this.btn_xuatbaocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xuatbaocao.UseVisualStyleBackColor = true;
            this.btn_xuatbaocao.Click += new System.EventHandler(this.btn_xuatbaocao_Click_1);
            // 
            // txtTenHang
            // 
            this.txtTenHang.AutoSize = true;
            this.txtTenHang.Location = new System.Drawing.Point(38, 91);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(76, 20);
            this.txtTenHang.TabIndex = 3;
            this.txtTenHang.Text = "Tên hàng";
            // 
            // txt_mah
            // 
            this.txt_mah.Location = new System.Drawing.Point(110, 43);
            this.txt_mah.Name = "txt_mah";
            this.txt_mah.Size = new System.Drawing.Size(108, 26);
            this.txt_mah.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(41, 140);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 39);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtMaHang
            // 
            this.txtMaHang.AutoSize = true;
            this.txtMaHang.Location = new System.Drawing.Point(38, 43);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(71, 20);
            this.txtMaHang.TabIndex = 0;
            this.txtMaHang.Text = "Mã hàng";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(430, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cbomnv);
            this.groupBox1.Controls.Add(this.cbomncc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txt_tenh);
            this.groupBox1.Controls.Add(this.txt_sl);
            this.groupBox1.Controls.Add(this.txt_dg);
            this.groupBox1.Controls.Add(this.tx);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txt_mah);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 193);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbomnv
            // 
            this.cbomnv.FormattingEnabled = true;
            this.cbomnv.Location = new System.Drawing.Point(682, 84);
            this.cbomnv.Name = "cbomnv";
            this.cbomnv.Size = new System.Drawing.Size(121, 28);
            this.cbomnv.TabIndex = 18;
            this.cbomnv.SelectedIndexChanged += new System.EventHandler(this.cbomnv_SelectedIndexChanged);
            // 
            // cbomncc
            // 
            this.cbomncc.FormattingEnabled = true;
            this.cbomncc.Location = new System.Drawing.Point(705, 43);
            this.cbomncc.Name = "cbomncc";
            this.cbomncc.Size = new System.Drawing.Size(121, 28);
            this.cbomncc.TabIndex = 17;
            this.cbomncc.SelectedIndexChanged += new System.EventHandler(this.cbomncc_SelectedIndexChanged);
            // 
            // QLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLH";
            this.Text = "Quan_ly_hang";
            this.Load += new System.EventHandler(this.QLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgv_qlh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mah;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txt_tenh;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_dg;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtDonGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xuatbaocao;
        private System.Windows.Forms.Label txtTenHang;
        private System.Windows.Forms.TextBox txt_mah;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label txtMaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbomnv;
        private System.Windows.Forms.ComboBox cbomncc;
    }
}