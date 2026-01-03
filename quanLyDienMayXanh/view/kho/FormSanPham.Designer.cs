namespace quanLyDienMayXanh.view.kho
{
    partial class FormSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitle = new Label();
            pnlTop = new Panel();
            grpThongTin = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtMoTa = new TextBox();
            lblMoTa = new Label();
            txtHinhAnh = new TextBox();
            lblHinhAnh = new Label();
            txtBaoHanh = new TextBox();
            lblBaoHanh = new Label();
            cboTrangThaiHang = new ComboBox();
            lblTrangThai = new Label();
            txtDVT = new ComboBox();
            lblDVT = new Label();
            txtGiaBan = new TextBox();
            lblGiaBan = new Label();
            txtGiaNhap = new TextBox();
            lblGiaNhap = new Label();
            txtThuongHieu = new TextBox();
            lblThuongHieu = new Label();
            cboDanhMuc = new ComboBox();
            lblDanhMuc = new Label();
            txtTenSP = new TextBox();
            lblTenSP = new Label();
            txtMaSP = new TextBox();
            lblMaSP = new Label();
            pnlCenter = new Panel();
            dgvSanPham = new DataGridView();
            colHinhAnh = new DataGridViewImageColumn();
            colMaSP = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colDanhMuc = new DataGridViewTextBoxColumn();
            colThuongHieu = new DataGridViewTextBoxColumn();
            colTonKho = new DataGridViewTextBoxColumn();
            colDVT = new DataGridViewTextBoxColumn();
            colGiaBan = new DataGridViewTextBoxColumn();
            grpTimKiem = new GroupBox();
            btnTimKiem = new Button();
            cboLocDanhMuc = new ComboBox();
            lblLocDM = new Label();
            txtTimKiem = new TextBox();
            lblTuKhoa = new Label();
            pnlTop.SuspendLayout();
            grpThongTin.SuspendLayout();
            pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            grpTimKiem.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1100, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(grpThongTin);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 60);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(10);
            pnlTop.Size = new Size(1100, 300);
            pnlTop.TabIndex = 1;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(txtMoTa);
            grpThongTin.Controls.Add(lblMoTa);
            grpThongTin.Controls.Add(txtHinhAnh);
            grpThongTin.Controls.Add(lblHinhAnh);
            grpThongTin.Controls.Add(txtBaoHanh);
            grpThongTin.Controls.Add(lblBaoHanh);
            grpThongTin.Controls.Add(cboTrangThaiHang);
            grpThongTin.Controls.Add(lblTrangThai);
            grpThongTin.Controls.Add(txtDVT);
            grpThongTin.Controls.Add(lblDVT);
            grpThongTin.Controls.Add(txtGiaBan);
            grpThongTin.Controls.Add(lblGiaBan);
            grpThongTin.Controls.Add(txtGiaNhap);
            grpThongTin.Controls.Add(lblGiaNhap);
            grpThongTin.Controls.Add(txtThuongHieu);
            grpThongTin.Controls.Add(lblThuongHieu);
            grpThongTin.Controls.Add(cboDanhMuc);
            grpThongTin.Controls.Add(lblDanhMuc);
            grpThongTin.Controls.Add(txtTenSP);
            grpThongTin.Controls.Add(lblTenSP);
            grpThongTin.Controls.Add(txtMaSP);
            grpThongTin.Controls.Add(lblMaSP);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Font = new Font("Arial", 10F, FontStyle.Bold);
            grpThongTin.ForeColor = Color.FromArgb(33, 150, 243);
            grpThongTin.Location = new Point(10, 10);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1080, 280);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = " THÔNG TIN CHI TIẾT ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(33, 150, 243);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(660, 230);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 35);
            btnLamMoi.TabIndex = 25;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(540, 230);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 193, 7);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(420, 230);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(76, 175, 80);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(300, 230);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Arial", 10F);
            txtMoTa.Location = new Point(786, 137);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(180, 50);
            txtMoTa.TabIndex = 21;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblMoTa.ForeColor = Color.Black;
            lblMoTa.Location = new Point(706, 140);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(41, 15);
            lblMoTa.TabIndex = 20;
            lblMoTa.Text = "Mô tả:";
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Font = new Font("Arial", 10F);
            txtHinhAnh.Location = new Point(440, 137);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(180, 23);
            txtHinhAnh.TabIndex = 19;
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblHinhAnh.ForeColor = Color.Black;
            lblHinhAnh.Location = new Point(361, 140);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(59, 15);
            lblHinhAnh.TabIndex = 18;
            lblHinhAnh.Text = "Link Ảnh:";
            // 
            // txtBaoHanh
            // 
            txtBaoHanh.Font = new Font("Arial", 10F);
            txtBaoHanh.Location = new Point(100, 136);
            txtBaoHanh.Name = "txtBaoHanh";
            txtBaoHanh.Size = new Size(180, 23);
            txtBaoHanh.TabIndex = 17;
            // 
            // lblBaoHanh
            // 
            lblBaoHanh.AutoSize = true;
            lblBaoHanh.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblBaoHanh.ForeColor = Color.Black;
            lblBaoHanh.Location = new Point(30, 140);
            lblBaoHanh.Name = "lblBaoHanh";
            lblBaoHanh.Size = new Size(63, 15);
            lblBaoHanh.TabIndex = 16;
            lblBaoHanh.Text = "Bảo hành:";
            // 
            // cboTrangThaiHang
            // 
            cboTrangThaiHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThaiHang.Font = new Font("Arial", 10F);
            cboTrangThaiHang.FormattingEnabled = true;
            cboTrangThaiHang.Items.AddRange(new object[] { "MOI", "CU", "TRUNG_BAY" });
            cboTrangThaiHang.Location = new Point(440, 187);
            cboTrangThaiHang.Name = "cboTrangThaiHang";
            cboTrangThaiHang.Size = new Size(180, 24);
            cboTrangThaiHang.TabIndex = 15;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblTrangThai.ForeColor = Color.Black;
            lblTrangThai.Location = new Point(361, 190);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(66, 15);
            lblTrangThai.TabIndex = 14;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // txtDVT
            // 
            txtDVT.Font = new Font("Arial", 10F);
            txtDVT.FormattingEnabled = true;
            txtDVT.Items.AddRange(new object[] { "Cái", "Chiếc", "Bộ", "Hộp", "Kg" });
            txtDVT.Location = new Point(786, 87);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(180, 24);
            txtDVT.TabIndex = 13;
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblDVT.ForeColor = Color.Black;
            lblDVT.Location = new Point(706, 90);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(71, 15);
            lblDVT.TabIndex = 12;
            lblDVT.Text = "Đơn vị tính:";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Arial", 10F);
            txtGiaBan.Location = new Point(440, 87);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(180, 23);
            txtGiaBan.TabIndex = 11;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblGiaBan.ForeColor = Color.Black;
            lblGiaBan.Location = new Point(361, 90);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(52, 15);
            lblGiaBan.TabIndex = 10;
            lblGiaBan.Text = "Giá bán:";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Font = new Font("Arial", 10F);
            txtGiaNhap.Location = new Point(100, 86);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(180, 23);
            txtGiaNhap.TabIndex = 9;
            // 
            // lblGiaNhap
            // 
            lblGiaNhap.AutoSize = true;
            lblGiaNhap.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblGiaNhap.ForeColor = Color.Black;
            lblGiaNhap.Location = new Point(30, 90);
            lblGiaNhap.Name = "lblGiaNhap";
            lblGiaNhap.Size = new Size(59, 15);
            lblGiaNhap.TabIndex = 8;
            lblGiaNhap.Text = "Giá nhập:";
            // 
            // txtThuongHieu
            // 
            txtThuongHieu.Font = new Font("Arial", 10F);
            txtThuongHieu.Location = new Point(100, 186);
            txtThuongHieu.Name = "txtThuongHieu";
            txtThuongHieu.Size = new Size(180, 23);
            txtThuongHieu.TabIndex = 7;
            // 
            // lblThuongHieu
            // 
            lblThuongHieu.AutoSize = true;
            lblThuongHieu.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblThuongHieu.ForeColor = Color.Black;
            lblThuongHieu.Location = new Point(30, 190);
            lblThuongHieu.Name = "lblThuongHieu";
            lblThuongHieu.Size = new Size(39, 15);
            lblThuongHieu.TabIndex = 6;
            lblThuongHieu.Text = "Hãng:";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhMuc.Font = new Font("Arial", 10F);
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(786, 37);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(180, 24);
            cboDanhMuc.TabIndex = 5;
            // 
            // lblDanhMuc
            // 
            lblDanhMuc.AutoSize = true;
            lblDanhMuc.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblDanhMuc.ForeColor = Color.Black;
            lblDanhMuc.Location = new Point(706, 40);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.Size = new Size(67, 15);
            lblDanhMuc.TabIndex = 4;
            lblDanhMuc.Text = "Danh mục:";
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Arial", 10F);
            txtTenSP.Location = new Point(440, 37);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(180, 23);
            txtTenSP.TabIndex = 3;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblTenSP.ForeColor = Color.Black;
            lblTenSP.Location = new Point(361, 40);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(50, 15);
            lblTenSP.TabIndex = 2;
            lblTenSP.Text = "Tên SP:";
            // 
            // txtMaSP
            // 
            txtMaSP.Font = new Font("Arial", 10F);
            txtMaSP.Location = new Point(100, 36);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(180, 23);
            txtMaSP.TabIndex = 1;
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblMaSP.ForeColor = Color.Black;
            lblMaSP.Location = new Point(30, 40);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(46, 15);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã SP:";
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(dgvSanPham);
            pnlCenter.Controls.Add(grpTimKiem);
            pnlCenter.Dock = DockStyle.Fill;
            pnlCenter.Location = new Point(0, 360);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Padding = new Padding(10);
            pnlCenter.Size = new Size(1100, 340);
            pnlCenter.TabIndex = 2;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSanPham.ColumnHeadersHeight = 40;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { colMaSP,colHinhAnh , colTenSP, colDanhMuc, colThuongHieu, colTonKho, colDVT, colGiaBan });
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.Location = new Point(10, 80);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowTemplate.Height = 60;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1080, 250);
            dgvSanPham.TabIndex = 1;
            // 
            // colHinhAnh
            // 
            colHinhAnh.HeaderText = "Ảnh";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.Name = "colHinhAnh";
            // 
            // colMaSP
            // 
            colMaSP.HeaderText = "Mã SP";
            colMaSP.Name = "colMaSP";
            // 
            // colTenSP
            // 
            colTenSP.HeaderText = "Tên SP";
            colTenSP.Name = "colTenSP";
            // 
            // colDanhMuc
            // 
            colDanhMuc.HeaderText = "Danh mục";
            colDanhMuc.Name = "colDanhMuc";
            // 
            // colThuongHieu
            // 
            colThuongHieu.HeaderText = "Thương hiệu";
            colThuongHieu.Name = "colThuongHieu";
            // 
            // colTonKho
            // 
            colTonKho.HeaderText = "Tồn";
            colTonKho.Name = "colTonKho";
            // 
            // colDVT
            // 
            colDVT.HeaderText = "ĐVT";
            colDVT.Name = "colDVT";
            // 
            // colGiaBan
            // 
            colGiaBan.HeaderText = "Giá bán";
            colGiaBan.Name = "colGiaBan";
            // 
            // grpTimKiem
            // 
            grpTimKiem.Controls.Add(btnTimKiem);
            grpTimKiem.Controls.Add(cboLocDanhMuc);
            grpTimKiem.Controls.Add(lblLocDM);
            grpTimKiem.Controls.Add(txtTimKiem);
            grpTimKiem.Controls.Add(lblTuKhoa);
            grpTimKiem.Dock = DockStyle.Top;
            grpTimKiem.Location = new Point(10, 10);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Size = new Size(1080, 70);
            grpTimKiem.TabIndex = 0;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "TÌM KIẾM & LỌC";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Gray;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(650, 25);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cboLocDanhMuc
            // 
            cboLocDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocDanhMuc.Font = new Font("Arial", 10F);
            cboLocDanhMuc.FormattingEnabled = true;
            cboLocDanhMuc.Location = new Point(430, 27);
            cboLocDanhMuc.Name = "cboLocDanhMuc";
            cboLocDanhMuc.Size = new Size(180, 24);
            cboLocDanhMuc.TabIndex = 3;
            // 
            // lblLocDM
            // 
            lblLocDM.AutoSize = true;
            lblLocDM.Location = new Point(350, 30);
            lblLocDM.Name = "lblLocDM";
            lblLocDM.Size = new Size(75, 16);
            lblLocDM.TabIndex = 2;
            lblLocDM.Text = "Danh mục:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Arial", 10F);
            txtTimKiem.Location = new Point(100, 27);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TabIndex = 1;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Location = new Point(30, 30);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(64, 16);
            lblTuKhoa.TabIndex = 0;
            lblTuKhoa.Text = "Từ khóa:";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlCenter);
            Controls.Add(pnlTop);
            Controls.Add(lblTitle);
            Font = new Font("Arial", 10F);
            Margin = new Padding(4);
            Name = "FormSanPham";
            Text = "Quản Lý Sản Phẩm";
            pnlTop.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            grpTimKiem.ResumeLayout(false);
            grpTimKiem.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView dgvSanPham;
        public System.Windows.Forms.TextBox txtMaSP;
        public System.Windows.Forms.TextBox txtTenSP;
        public System.Windows.Forms.TextBox txtThuongHieu;
        public System.Windows.Forms.TextBox txtGiaNhap;
        public System.Windows.Forms.TextBox txtGiaBan;
        public System.Windows.Forms.TextBox txtBaoHanh;
        public System.Windows.Forms.TextBox txtHinhAnh;
        public System.Windows.Forms.TextBox txtMoTa;
        public System.Windows.Forms.ComboBox cboDanhMuc;
        public System.Windows.Forms.ComboBox txtDVT;
        public System.Windows.Forms.ComboBox cboTrangThaiHang;
        public System.Windows.Forms.TextBox txtTimKiem;
        public System.Windows.Forms.ComboBox cboLocDanhMuc;
        public System.Windows.Forms.Button btnTimKiem;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblBaoHanh;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Label lblLocDM;
        private System.Windows.Forms.DataGridViewImageColumn colHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuongHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
    }
}