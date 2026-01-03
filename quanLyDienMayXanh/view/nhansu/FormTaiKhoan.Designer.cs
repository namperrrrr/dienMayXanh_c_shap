namespace quanLyDienMayXanh.view.nhansu
{
    partial class FormTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleHeader = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.layoutInput = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeaderForm = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popupGoiY = new System.Windows.Forms.ContextMenuStrip(this.components);

            this.pnlRight.SuspendLayout();
            this.layoutInput.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            // --- THAY ĐỔI 1: Tăng chiều cao lên 90 ---
            this.lblTitle.Size = new System.Drawing.Size(1000, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.layoutInput);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            // --- THAY ĐỔI 2: Đẩy xuống Y=90 ---
            this.pnlRight.Location = new System.Drawing.Point(650, 90);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRight.Size = new System.Drawing.Size(350, 510); // Điều chỉnh chiều cao cho khớp
            this.pnlRight.TabIndex = 1;

            // 
            // layoutInput
            // 
            this.layoutInput.Controls.Add(this.lblHeaderForm);
            this.layoutInput.Controls.Add(this.lblMaNV);
            this.layoutInput.Controls.Add(this.txtMaNV);
            this.layoutInput.Controls.Add(this.lblTenDangNhap);
            this.layoutInput.Controls.Add(this.txtTenDangNhap);
            this.layoutInput.Controls.Add(this.lblMatKhau);
            this.layoutInput.Controls.Add(this.txtMatKhau);
            this.layoutInput.Controls.Add(this.lblQuyen);
            this.layoutInput.Controls.Add(this.cboQuyen);
            this.layoutInput.Controls.Add(this.lblTrangThai);
            this.layoutInput.Controls.Add(this.cboTrangThai);
            this.layoutInput.Controls.Add(this.pnlButtons);
            this.layoutInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutInput.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutInput.Location = new System.Drawing.Point(20, 20);
            this.layoutInput.Name = "layoutInput";
            this.layoutInput.Size = new System.Drawing.Size(310, 470);
            this.layoutInput.TabIndex = 0;
            this.layoutInput.WrapContents = false;

            // 
            // lblHeaderForm
            // 
            this.lblHeaderForm.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeaderForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblHeaderForm.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderForm.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblHeaderForm.Name = "lblHeaderForm";
            this.lblHeaderForm.Size = new System.Drawing.Size(300, 30);
            this.lblHeaderForm.TabIndex = 0;
            this.lblHeaderForm.Text = "THÔNG TIN TÀI KHOẢN";
            this.lblHeaderForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.Location = new System.Drawing.Point(0, 50);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(206, 19);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã nhân viên (Gõ để tìm):";

            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 10F);
            this.txtMaNV.Location = new System.Drawing.Point(0, 74);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(300, 27);
            this.txtMaNV.TabIndex = 2;

            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.Location = new System.Drawing.Point(0, 116);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(132, 19);
            this.lblTenDangNhap.TabIndex = 3;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";

            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(0, 140);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(300, 27);
            this.txtTenDangNhap.TabIndex = 4;

            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.Location = new System.Drawing.Point(0, 182);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(86, 19);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu:";

            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 10F);
            this.txtMatKhau.Location = new System.Drawing.Point(0, 206);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(300, 27);
            this.txtMatKhau.TabIndex = 6;

            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuyen.Location = new System.Drawing.Point(0, 248);
            this.lblQuyen.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(100, 19);
            this.lblQuyen.TabIndex = 7;
            this.lblQuyen.Text = "Quyền hạn:";

            // 
            // cboQuyen
            // 
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.Font = new System.Drawing.Font("Arial", 10F);
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý (Level 2)",
            "Admin (Level 3)"});
            this.cboQuyen.Location = new System.Drawing.Point(0, 272);
            this.cboQuyen.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(300, 27);
            this.cboQuyen.TabIndex = 8;

            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.Location = new System.Drawing.Point(0, 314);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(94, 19);
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "Trạng thái:";

            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Arial", 10F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Đã khóa"});
            this.cboTrangThai.Location = new System.Drawing.Point(0, 338);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(300, 27);
            this.cboTrangThai.TabIndex = 10;

            // 
            // pnlButtons
            // 
            this.pnlButtons.ColumnCount = 2;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.Controls.Add(this.btnThem, 0, 0);
            this.pnlButtons.Controls.Add(this.btnSua, 1, 0);
            this.pnlButtons.Controls.Add(this.btnXoa, 0, 1);
            this.pnlButtons.Controls.Add(this.btnLamMoi, 1, 1);
            this.pnlButtons.Location = new System.Drawing.Point(3, 393);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RowCount = 2;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.Size = new System.Drawing.Size(300, 90);
            this.pnlButtons.TabIndex = 11;

            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;

            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(153, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;

            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(3, 48);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(153, 48);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(144, 39);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;

            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Header Style
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            dataGridViewCellStyleHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyleHeader.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyleHeader.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleHeader.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyleHeader.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyleHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleHeader;
            this.dgvTaiKhoan.ColumnHeadersHeight = 40;

            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUser,
            this.colMaNV,
            this.colQuyen,
            this.colTrangThai});
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.Font = new System.Drawing.Font("Arial", 11F);
            // --- THAY ĐỔI 3: Đẩy xuống Y=90 ---
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 90);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 35;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(650, 510);
            this.dgvTaiKhoan.TabIndex = 2;

            // 
            // colUser
            // 
            this.colUser.HeaderText = "Tên đăng nhập";
            this.colUser.MinimumWidth = 6;
            this.colUser.Name = "colUser";

            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";

            // 
            // colQuyen
            // 
            this.colQuyen.HeaderText = "Quyền hạn";
            this.colQuyen.MinimumWidth = 6;
            this.colQuyen.Name = "colQuyen";

            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";

            // 
            // popupGoiY
            // 
            this.popupGoiY.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.popupGoiY.Name = "popupGoiY";
            this.popupGoiY.Size = new System.Drawing.Size(61, 4);

            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.pnlRight.ResumeLayout(false);
            this.layoutInput.ResumeLayout(false);
            this.layoutInput.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Controls
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView dgvTaiKhoan;
        public System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        public System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        public System.Windows.Forms.DataGridViewTextBoxColumn colQuyen;
        public System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.FlowLayoutPanel layoutInput;
        private System.Windows.Forms.Label lblHeaderForm;

        private System.Windows.Forms.Label lblMaNV, lblTenDangNhap, lblMatKhau, lblQuyen, lblTrangThai;
        public System.Windows.Forms.TextBox txtMaNV, txtTenDangNhap, txtMatKhau;
        public System.Windows.Forms.ComboBox cboQuyen, cboTrangThai;

        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        public System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi;

        public System.Windows.Forms.ContextMenuStrip popupGoiY;
    }
}