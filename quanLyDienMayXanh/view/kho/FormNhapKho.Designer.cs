namespace quanLyDienMayXanh.view.kho
{
    partial class FormNhapKho
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            pnlRight = new Panel();
            layoutInput = new FlowLayoutPanel();
            lblHeaderForm = new Label();
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            lblNhanVien = new Label();
            cboNhanVien = new ComboBox();
            lblNCC = new Label();
            txtNhaCungCap = new TextBox();
            lblSanPham = new Label();
            cboSanPham = new ComboBox();
            lblTonKho = new Label();
            txtTonHienTai = new TextBox();
            lblSLNhap = new Label();
            txtSoLuongNhap = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            pnlButtons = new TableLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            dgvPhieuNhap = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colMaPhieu = new DataGridViewTextBoxColumn();
            colTenNCC = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            pnlBottomLeft = new Panel();
            lblTongTienNhap = new Label();
            pnlRight.SuspendLayout();
            layoutInput.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            pnlBottomLeft.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1242, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ NHẬP KHO";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(layoutInput);
            pnlRight.Controls.Add(pnlButtons);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(910, 60);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(9, 8, 9, 8);
            pnlRight.Size = new Size(332, 609);
            pnlRight.TabIndex = 1;
            // 
            // layoutInput
            // 
            layoutInput.AutoScroll = true;
            layoutInput.Controls.Add(lblHeaderForm);
            layoutInput.Controls.Add(lblMaPhieu);
            layoutInput.Controls.Add(txtMaPhieu);
            layoutInput.Controls.Add(lblNhanVien);
            layoutInput.Controls.Add(cboNhanVien);
            layoutInput.Controls.Add(lblNCC);
            layoutInput.Controls.Add(txtNhaCungCap);
            layoutInput.Controls.Add(lblSanPham);
            layoutInput.Controls.Add(cboSanPham);
            layoutInput.Controls.Add(lblTonKho);
            layoutInput.Controls.Add(txtTonHienTai);
            layoutInput.Controls.Add(lblSLNhap);
            layoutInput.Controls.Add(txtSoLuongNhap);
            layoutInput.Controls.Add(lblDonGia);
            layoutInput.Controls.Add(txtDonGia);
            layoutInput.Controls.Add(lblGhiChu);
            layoutInput.Controls.Add(txtGhiChu);
            layoutInput.Dock = DockStyle.Fill;
            layoutInput.FlowDirection = FlowDirection.TopDown;
            layoutInput.Location = new Point(9, 8);
            layoutInput.Name = "layoutInput";
            layoutInput.Size = new Size(314, 525);
            layoutInput.TabIndex = 0;
            layoutInput.WrapContents = false;
            // 
            // lblHeaderForm
            // 
            lblHeaderForm.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblHeaderForm.ForeColor = Color.FromArgb(33, 150, 243);
            lblHeaderForm.Location = new Point(3, 0);
            lblHeaderForm.Margin = new Padding(3, 0, 3, 8);
            lblHeaderForm.Name = "lblHeaderForm";
            lblHeaderForm.Size = new Size(289, 22);
            lblHeaderForm.TabIndex = 0;
            lblHeaderForm.Text = "THÔNG TIN PHIẾU";
            lblHeaderForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblMaPhieu.Location = new Point(3, 30);
            lblMaPhieu.Margin = new Padding(3, 0, 3, 4);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(76, 16);
            lblMaPhieu.TabIndex = 1;
            lblMaPhieu.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Font = new Font("Arial", 10F);
            txtMaPhieu.Location = new Point(3, 52);
            txtMaPhieu.Margin = new Padding(3, 2, 3, 8);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(289, 23);
            txtMaPhieu.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNhanVien.Location = new Point(3, 83);
            lblNhanVien.Margin = new Padding(3, 0, 3, 4);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(81, 16);
            lblNhanVien.TabIndex = 2;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Font = new Font("Arial", 10F);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(3, 105);
            cboNhanVien.Margin = new Padding(3, 2, 3, 8);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(289, 24);
            cboNhanVien.TabIndex = 2;
            // 
            // lblNCC
            // 
            lblNCC.AutoSize = true;
            lblNCC.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNCC.Location = new Point(3, 137);
            lblNCC.Margin = new Padding(3, 0, 3, 4);
            lblNCC.Name = "lblNCC";
            lblNCC.Size = new Size(106, 16);
            lblNCC.TabIndex = 3;
            lblNCC.Text = "Nhà cung cấp:";
            // 
            // txtNhaCungCap
            // 
            txtNhaCungCap.Font = new Font("Arial", 10F);
            txtNhaCungCap.Location = new Point(3, 159);
            txtNhaCungCap.Margin = new Padding(3, 2, 3, 8);
            txtNhaCungCap.Name = "txtNhaCungCap";
            txtNhaCungCap.Size = new Size(289, 23);
            txtNhaCungCap.TabIndex = 3;
            // 
            // lblSanPham
            // 
            lblSanPham.AutoSize = true;
            lblSanPham.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSanPham.Location = new Point(3, 190);
            lblSanPham.Margin = new Padding(3, 0, 3, 4);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(79, 16);
            lblSanPham.TabIndex = 4;
            lblSanPham.Text = "Sản phẩm:";
            // 
            // cboSanPham
            // 
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.Font = new Font("Arial", 10F);
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(3, 212);
            cboSanPham.Margin = new Padding(3, 2, 3, 8);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(289, 24);
            cboSanPham.TabIndex = 4;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // lblTonKho
            // 
            lblTonKho.AutoSize = true;
            lblTonKho.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTonKho.Location = new Point(3, 244);
            lblTonKho.Margin = new Padding(3, 0, 3, 4);
            lblTonKho.Name = "lblTonKho";
            lblTonKho.Size = new Size(123, 16);
            lblTonKho.TabIndex = 5;
            lblTonKho.Text = "Tồn kho hiện tại:";
            // 
            // txtTonHienTai
            // 
            txtTonHienTai.BackColor = SystemColors.ControlLight;
            txtTonHienTai.Font = new Font("Arial", 10F);
            txtTonHienTai.Location = new Point(3, 266);
            txtTonHienTai.Margin = new Padding(3, 2, 3, 8);
            txtTonHienTai.Name = "txtTonHienTai";
            txtTonHienTai.ReadOnly = true;
            txtTonHienTai.Size = new Size(289, 23);
            txtTonHienTai.TabIndex = 5;
            // 
            // lblSLNhap
            // 
            lblSLNhap.AutoSize = true;
            lblSLNhap.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSLNhap.Location = new Point(3, 297);
            lblSLNhap.Margin = new Padding(3, 0, 3, 4);
            lblSLNhap.Name = "lblSLNhap";
            lblSLNhap.Size = new Size(114, 16);
            lblSLNhap.TabIndex = 6;
            lblSLNhap.Text = "Số lượng nhập:";
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Font = new Font("Arial", 10F);
            txtSoLuongNhap.Location = new Point(3, 319);
            txtSoLuongNhap.Margin = new Padding(3, 2, 3, 8);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(289, 23);
            txtSoLuongNhap.TabIndex = 6;
            txtSoLuongNhap.Text = "0";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDonGia.Location = new Point(3, 350);
            lblDonGia.Margin = new Padding(3, 0, 3, 4);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(104, 16);
            lblDonGia.TabIndex = 7;
            lblDonGia.Text = "Đơn giá nhập:";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Arial", 10F);
            txtDonGia.Location = new Point(3, 372);
            txtDonGia.Margin = new Padding(3, 2, 3, 8);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(289, 23);
            txtDonGia.TabIndex = 7;
            txtDonGia.Text = "0";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblGhiChu.Location = new Point(3, 403);
            lblGhiChu.Margin = new Padding(3, 0, 3, 4);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(65, 16);
            lblGhiChu.TabIndex = 9;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Arial", 10F);
            txtGhiChu.Location = new Point(3, 425);
            txtGhiChu.Margin = new Padding(3, 2, 3, 11);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(289, 23);
            txtGhiChu.TabIndex = 9;
            // 
            // pnlButtons
            // 
            pnlButtons.ColumnCount = 2;
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButtons.Controls.Add(btnThem, 0, 0);
            pnlButtons.Controls.Add(btnSua, 1, 0);
            pnlButtons.Controls.Add(btnXoa, 0, 1);
            pnlButtons.Controls.Add(btnLamMoi, 1, 1);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(9, 533);
            pnlButtons.Margin = new Padding(0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.RowCount = 2;
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlButtons.Size = new Size(314, 68);
            pnlButtons.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(76, 175, 80);
            btnThem.Cursor = Cursors.Hand;
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(3, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(151, 30);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DarkOrange;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Dock = DockStyle.Fill;
            btnSua.Enabled = false;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(160, 2);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(151, 30);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(3, 36);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(151, 30);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(33, 150, 243);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(160, 36);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(151, 30);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(0, 0);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(0, 0);
            btnThoat.TabIndex = 0;
            btnThoat.Visible = false;
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.AllowUserToDeleteRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Arial", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhieuNhap.ColumnHeadersHeight = 40;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colID, colMaPhieu, colTenNCC, colTenSP, colSoLuong, colDonGia, colThanhTien, colNgayNhap, colGhiChu });
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.EnableHeadersVisualStyles = false;
            dgvPhieuNhap.Font = new Font("Arial", 10F);
            dgvPhieuNhap.Location = new Point(0, 60);
            dgvPhieuNhap.Margin = new Padding(3, 2, 3, 2);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowTemplate.Height = 35;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(910, 569);
            dgvPhieuNhap.TabIndex = 2;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            // 
            // colMaPhieu
            // 
            colMaPhieu.DataPropertyName = "MaPhieu";
            colMaPhieu.HeaderText = "Mã Phiếu";
            colMaPhieu.Name = "colMaPhieu";
            colMaPhieu.ReadOnly = true;
            // 
            // colTenNCC
            // 
            colTenNCC.DataPropertyName = "TenNCC";
            colTenNCC.HeaderText = "Nhà Cung Cấp";
            colTenNCC.Name = "colTenNCC";
            colTenNCC.ReadOnly = true;
            // 
            // colTenSP
            // 
            colTenSP.DataPropertyName = "TenSP";
            colTenSP.HeaderText = "Tên Sản Phẩm";
            colTenSP.Name = "colTenSP";
            colTenSP.ReadOnly = true;
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.FillWeight = 50F;
            colSoLuong.HeaderText = "SL";
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            colDonGia.DefaultCellStyle = dataGridViewCellStyle2;
            colDonGia.HeaderText = "Đơn Giá";
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            colThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            colNgayNhap.DataPropertyName = "NgayNhap";
            colNgayNhap.HeaderText = "Ngày Nhập";
            colNgayNhap.Name = "colNgayNhap";
            colNgayNhap.ReadOnly = true;
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.Name = "colGhiChu";
            colGhiChu.ReadOnly = true;
            // 
            // pnlBottomLeft
            // 
            pnlBottomLeft.BackColor = Color.White;
            pnlBottomLeft.Controls.Add(lblTongTienNhap);
            pnlBottomLeft.Dock = DockStyle.Bottom;
            pnlBottomLeft.Location = new Point(0, 629);
            pnlBottomLeft.Name = "pnlBottomLeft";
            pnlBottomLeft.Size = new Size(910, 40);
            pnlBottomLeft.TabIndex = 3;
            // 
            // lblTongTienNhap
            // 
            lblTongTienNhap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTienNhap.AutoSize = true;
            lblTongTienNhap.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTongTienNhap.ForeColor = Color.Red;
            lblTongTienNhap.Location = new Point(12, 11);
            lblTongTienNhap.Name = "lblTongTienNhap";
            lblTongTienNhap.Size = new Size(182, 19);
            lblTongTienNhap.TabIndex = 0;
            lblTongTienNhap.Text = "Tổng tiền nhập: 0 VND";
            // 
            // FormNhapKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1242, 669);
            Controls.Add(dgvPhieuNhap);
            Controls.Add(pnlBottomLeft);
            Controls.Add(pnlRight);
            Controls.Add(lblTitle);
            Name = "FormNhapKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNhapKho";
            pnlRight.ResumeLayout(false);
            layoutInput.ResumeLayout(false);
            layoutInput.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            pnlBottomLeft.ResumeLayout(false);
            pnlBottomLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.FlowLayoutPanel layoutInput;
        private System.Windows.Forms.Label lblHeaderForm;

        private System.Windows.Forms.Label lblMaPhieu, lblNhanVien, lblNCC, lblSanPham, lblTonKho, lblSLNhap, lblDonGia, lblGhiChu;
        public System.Windows.Forms.TextBox txtMaPhieu, txtTonHienTai, txtSoLuongNhap, txtDonGia, txtGhiChu;

        public System.Windows.Forms.TextBox txtNhaCungCap;
       
        public System.Windows.Forms.ComboBox cboNhanVien, cboSanPham;

        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        public System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi, btnThoat;

        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;

        private System.Windows.Forms.Panel pnlBottomLeft;
        private System.Windows.Forms.Label lblTongTienNhap;
    }
}