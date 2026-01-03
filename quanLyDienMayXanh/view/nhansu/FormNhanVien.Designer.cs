using System.Drawing;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view.nhansu
{
    partial class FormNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyleHeader = new DataGridViewCellStyle();

            // --- 1. KHỞI TẠO CONTROLS ---
            this.lblTitle = new Label();
            this.pnlRight = new Panel();
            this.layoutInput = new FlowLayoutPanel();
            this.lblHeaderForm = new Label();

            this.lblMaNV = new Label();
            this.txtMaNV = new TextBox();

            this.lblHoTen = new Label();
            this.txtHoTen = new TextBox();

            this.lblGioiTinh = new Label();
            this.cboGioiTinh = new ComboBox();

            this.lblChucVu = new Label();
            this.cboChucVu = new ComboBox();

            this.lblSDT = new Label();
            this.txtSDT = new TextBox();

            this.lblEmail = new Label();
            this.txtEmail = new TextBox();

            this.pnlButtons = new TableLayoutPanel();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnLamMoi = new Button();

            this.dgvNhanVien = new DataGridView();
            this.colMaNV = new DataGridViewTextBoxColumn();
            this.colHoTen = new DataGridViewTextBoxColumn();
            this.colGioiTinh = new DataGridViewTextBoxColumn();
            this.colChucVu = new DataGridViewTextBoxColumn();
            this.colSDT = new DataGridViewTextBoxColumn();
            this.colEmail = new DataGridViewTextBoxColumn();

            // --- 2. BẮT ĐẦU LAYOUT ---
            this.pnlRight.SuspendLayout();
            this.layoutInput.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = Color.White;
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            this.lblTitle.Location = new Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            // --- THAY ĐỔI 1: Tăng chiều cao lên 90 ---
            this.lblTitle.Size = new Size(1100, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHÂN SỰ";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = Color.White;
            this.pnlRight.Controls.Add(this.layoutInput);
            this.pnlRight.Dock = DockStyle.Right;
            // --- THAY ĐỔI 2: Đẩy xuống Y=90 ---
            this.pnlRight.Location = new Point(750, 90);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new Padding(20);
            this.pnlRight.Size = new Size(350, 560); // Điều chỉnh chiều cao cho khớp (650 - 90)
            this.pnlRight.TabIndex = 1;

            // 
            // layoutInput
            // 
            this.layoutInput.Controls.Add(this.lblHeaderForm);
            this.layoutInput.Controls.Add(this.lblMaNV);
            this.layoutInput.Controls.Add(this.txtMaNV);
            this.layoutInput.Controls.Add(this.lblHoTen);
            this.layoutInput.Controls.Add(this.txtHoTen);
            this.layoutInput.Controls.Add(this.lblGioiTinh);
            this.layoutInput.Controls.Add(this.cboGioiTinh);
            this.layoutInput.Controls.Add(this.lblChucVu);
            this.layoutInput.Controls.Add(this.cboChucVu);
            this.layoutInput.Controls.Add(this.lblSDT);
            this.layoutInput.Controls.Add(this.txtSDT);
            this.layoutInput.Controls.Add(this.lblEmail);
            this.layoutInput.Controls.Add(this.txtEmail);
            this.layoutInput.Controls.Add(this.pnlButtons);
            this.layoutInput.Dock = DockStyle.Fill;
            this.layoutInput.FlowDirection = FlowDirection.TopDown;
            this.layoutInput.Location = new Point(20, 20);
            this.layoutInput.Name = "layoutInput";
            this.layoutInput.Size = new Size(310, 520);
            this.layoutInput.TabIndex = 0;
            this.layoutInput.WrapContents = false;

            // 
            // lblHeaderForm
            // 
            this.lblHeaderForm.Font = new Font("Arial", 14F, FontStyle.Bold);
            this.lblHeaderForm.ForeColor = Color.FromArgb(33, 150, 243);
            this.lblHeaderForm.Location = new Point(0, 0);
            this.lblHeaderForm.Margin = new Padding(0, 0, 0, 20);
            this.lblHeaderForm.Name = "lblHeaderForm";
            this.lblHeaderForm.Size = new Size(300, 30);
            this.lblHeaderForm.TabIndex = 0;
            this.lblHeaderForm.Text = "THÔNG TIN CHI TIẾT";
            this.lblHeaderForm.TextAlign = ContentAlignment.MiddleCenter;

            // --- Helper Font ---
            Font fontLabel = new Font("Arial", 10F, FontStyle.Bold);
            Font fontInput = new Font("Arial", 10F);

            // lblMaNV
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = fontLabel;
            this.lblMaNV.Location = new Point(0, 50);
            this.lblMaNV.Margin = new Padding(0, 0, 0, 5);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new Size(118, 19);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã nhân viên:";

            // txtMaNV
            this.txtMaNV.Font = fontInput;
            this.txtMaNV.Location = new Point(0, 74);
            this.txtMaNV.Margin = new Padding(0, 0, 0, 15);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new Size(300, 27);
            this.txtMaNV.TabIndex = 2;

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = fontLabel;
            this.lblHoTen.Location = new Point(0, 116);
            this.lblHoTen.Margin = new Padding(0, 0, 0, 5);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new Size(90, 19);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ và tên:";

            // txtHoTen
            this.txtHoTen.Font = fontInput;
            this.txtHoTen.Location = new Point(0, 140);
            this.txtHoTen.Margin = new Padding(0, 0, 0, 15);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new Size(300, 27);
            this.txtHoTen.TabIndex = 4;

            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = fontLabel;
            this.lblGioiTinh.Location = new Point(0, 182);
            this.lblGioiTinh.Margin = new Padding(0, 0, 0, 5);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new Size(83, 19);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới tính:";

            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = fontInput;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.Location = new Point(0, 206);
            this.cboGioiTinh.Margin = new Padding(0, 0, 0, 15);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new Size(300, 27);
            this.cboGioiTinh.TabIndex = 6;

            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = fontLabel;
            this.lblChucVu.Location = new Point(0, 248);
            this.lblChucVu.Margin = new Padding(0, 0, 0, 5);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new Size(82, 19);
            this.lblChucVu.TabIndex = 7;
            this.lblChucVu.Text = "Chức vụ:";

            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboChucVu.Font = fontInput;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new Point(0, 272);
            this.cboChucVu.Margin = new Padding(0, 0, 0, 15);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new Size(300, 27);
            this.cboChucVu.TabIndex = 8;

            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = fontLabel;
            this.lblSDT.Location = new Point(0, 314);
            this.lblSDT.Margin = new Padding(0, 0, 0, 5);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new Size(118, 19);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "Số điện thoại:";

            // txtSDT
            // 
            this.txtSDT.Font = fontInput;
            this.txtSDT.Location = new Point(0, 338);
            this.txtSDT.Margin = new Padding(0, 0, 0, 15);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new Size(300, 27);
            this.txtSDT.TabIndex = 10;

            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = fontLabel;
            this.lblEmail.Location = new Point(0, 380);
            this.lblEmail.Margin = new Padding(0, 0, 0, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(57, 19);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";

            // txtEmail
            // 
            this.txtEmail.Font = fontInput;
            this.txtEmail.Location = new Point(0, 404);
            this.txtEmail.Margin = new Padding(0, 0, 0, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(300, 27);
            this.txtEmail.TabIndex = 12;

            // 
            // pnlButtons
            // 
            this.pnlButtons.ColumnCount = 2;
            this.pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.pnlButtons.Controls.Add(this.btnThem, 0, 0);
            this.pnlButtons.Controls.Add(this.btnSua, 1, 0);
            this.pnlButtons.Controls.Add(this.btnXoa, 0, 1);
            this.pnlButtons.Controls.Add(this.btnLamMoi, 1, 1);
            this.pnlButtons.Location = new Point(3, 459);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RowCount = 2;
            this.pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.pnlButtons.Size = new Size(300, 90);
            this.pnlButtons.TabIndex = 13;

            // btnThem
            this.btnThem.Text = "Thêm";
            this.btnThem.BackColor = Color.FromArgb(76, 175, 80);
            this.btnThem.ForeColor = Color.White;
            this.btnThem.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.btnThem.FlatStyle = FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Dock = DockStyle.Fill;
            this.btnThem.Cursor = Cursors.Hand;
            this.btnThem.Margin = new Padding(3);
            this.btnThem.Name = "btnThem";

            // btnSua
            this.btnSua.Text = "Sửa";
            this.btnSua.BackColor = Color.FromArgb(255, 193, 7);
            this.btnSua.ForeColor = Color.White;
            this.btnSua.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.btnSua.FlatStyle = FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Dock = DockStyle.Fill;
            this.btnSua.Cursor = Cursors.Hand;
            this.btnSua.Margin = new Padding(3);
            this.btnSua.Name = "btnSua";

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.btnXoa.FlatStyle = FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Dock = DockStyle.Fill;
            this.btnXoa.Cursor = Cursors.Hand;
            this.btnXoa.Margin = new Padding(3);
            this.btnXoa.Name = "btnXoa";

            // btnLamMoi
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.BackColor = Color.FromArgb(33, 150, 243);
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Dock = DockStyle.Fill;
            this.btnLamMoi.Cursor = Cursors.Hand;
            this.btnLamMoi.Margin = new Padding(3);
            this.btnLamMoi.Name = "btnLamMoi";

            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = Color.White;
            this.dgvNhanVien.BorderStyle = BorderStyle.FixedSingle;
            this.dgvNhanVien.Dock = DockStyle.Fill;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.RowTemplate.Height = 35;
            this.dgvNhanVien.Font = new Font("Arial", 11F);

            // Header Style
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            dataGridViewCellStyleHeader.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyleHeader.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyleHeader.Font = new Font("Arial", 11F, FontStyle.Bold);
            dataGridViewCellStyleHeader.ForeColor = Color.White;
            dataGridViewCellStyleHeader.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyleHeader.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyleHeader.WrapMode = DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleHeader;
            this.dgvNhanVien.ColumnHeadersHeight = 40;

            this.dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colGioiTinh,
            this.colChucVu,
            this.colSDT,
            this.colEmail});
            // --- THAY ĐỔI 3: Đẩy xuống Y=90 ---
            this.dgvNhanVien.Location = new Point(0, 90);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new Size(750, 560); // Điều chỉnh chiều cao cho khớp
            this.dgvNhanVien.TabIndex = 2;

            // colMaNV
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";

            // colHoTen
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";

            // colGioiTinh
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";

            // colChucVu
            this.colChucVu.HeaderText = "Chức vụ";
            this.colChucVu.MinimumWidth = 6;
            this.colChucVu.Name = "colChucVu";

            // colSDT
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";

            // colEmail
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";

            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1100, 650);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormNhanVien";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Sự";
            this.pnlRight.ResumeLayout(false);
            this.layoutInput.ResumeLayout(false);
            this.layoutInput.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // PUBLIC Controls
        public Label lblTitle;
        public DataGridView dgvNhanVien;
        public DataGridViewTextBoxColumn colMaNV;
        public DataGridViewTextBoxColumn colHoTen;
        public DataGridViewTextBoxColumn colGioiTinh;
        public DataGridViewTextBoxColumn colChucVu;
        public DataGridViewTextBoxColumn colSDT;
        public DataGridViewTextBoxColumn colEmail;

        private Panel pnlRight;
        private FlowLayoutPanel layoutInput;
        private Label lblHeaderForm;

        private Label lblMaNV, lblHoTen, lblGioiTinh, lblChucVu, lblSDT, lblEmail;
        public TextBox txtMaNV, txtHoTen, txtSDT, txtEmail;
        public ComboBox cboGioiTinh, cboChucVu;

        private TableLayoutPanel pnlButtons;
        public Button btnThem, btnSua, btnXoa, btnLamMoi;
    }
}