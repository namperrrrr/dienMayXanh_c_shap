using System.Drawing;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view.nhansu
{
    partial class FormChucVu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            pnlRight = new Panel();
            layoutInput = new FlowLayoutPanel();
            lblHeaderForm = new Label();
            lblMaCV = new Label();
            txtMaCV = new TextBox();
            lblTenCV = new Label();
            txtTenCV = new TextBox();
            lblLuong = new Label();
            txtLuongCoBan = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            pnlButtons = new TableLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvChucVu = new DataGridView();
            colMaCV = new DataGridViewTextBoxColumn();
            colTenCV = new DataGridViewTextBoxColumn();
            colLuong = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            pnlRight.SuspendLayout();
            layoutInput.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.BackColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1000, 90);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ CHỨC VỤ & LƯƠNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // pnlRight
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(layoutInput);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(650, 90);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(20);
            pnlRight.Size = new Size(350, 510);
            pnlRight.TabIndex = 1;

            // layoutInput
            layoutInput.Controls.Add(lblHeaderForm);
            layoutInput.Controls.Add(lblMaCV);
            layoutInput.Controls.Add(txtMaCV);
            layoutInput.Controls.Add(lblTenCV);
            layoutInput.Controls.Add(txtTenCV);
            layoutInput.Controls.Add(lblLuong);
            layoutInput.Controls.Add(txtLuongCoBan);
            layoutInput.Controls.Add(lblMoTa);
            layoutInput.Controls.Add(txtMoTa);
            layoutInput.Controls.Add(pnlButtons);
            layoutInput.Dock = DockStyle.Fill;
            layoutInput.FlowDirection = FlowDirection.TopDown;
            layoutInput.Location = new Point(20, 20);
            layoutInput.Name = "layoutInput";
            layoutInput.Size = new Size(310, 470);
            layoutInput.TabIndex = 0;
            layoutInput.WrapContents = false;

            // lblHeaderForm
            lblHeaderForm.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblHeaderForm.ForeColor = Color.FromArgb(33, 150, 243);
            lblHeaderForm.Location = new Point(0, 0);
            lblHeaderForm.Margin = new Padding(0, 0, 0, 20);
            lblHeaderForm.Name = "lblHeaderForm";
            lblHeaderForm.Size = new Size(300, 30);
            lblHeaderForm.TabIndex = 0;
            lblHeaderForm.Text = "THÔNG TIN CHI TIẾT";
            lblHeaderForm.TextAlign = ContentAlignment.MiddleCenter;

            // lblMaCV
            lblMaCV.AutoSize = true;
            lblMaCV.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblMaCV.Location = new Point(0, 50);
            lblMaCV.Margin = new Padding(0, 0, 0, 5);
            lblMaCV.Name = "lblMaCV";
            lblMaCV.Size = new Size(106, 19);
            lblMaCV.TabIndex = 1;
            lblMaCV.Text = "Mã chức vụ:";

            // txtMaCV
            txtMaCV.Font = new Font("Arial", 10F);
            txtMaCV.Location = new Point(0, 74);
            txtMaCV.Margin = new Padding(0, 0, 0, 15);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(300, 27);
            txtMaCV.TabIndex = 2;

            // lblTenCV
            lblTenCV.AutoSize = true;
            lblTenCV.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTenCV.Location = new Point(0, 116);
            lblTenCV.Margin = new Padding(0, 0, 0, 5);
            lblTenCV.Name = "lblTenCV";
            lblTenCV.Size = new Size(113, 19);
            lblTenCV.TabIndex = 3;
            lblTenCV.Text = "Tên chức vụ:";

            // txtTenCV
            txtTenCV.Font = new Font("Arial", 10F);
            txtTenCV.Location = new Point(0, 140);
            txtTenCV.Margin = new Padding(0, 0, 0, 15);
            txtTenCV.Name = "txtTenCV";
            txtTenCV.Size = new Size(300, 27);
            txtTenCV.TabIndex = 4;

            // lblLuong
            lblLuong.AutoSize = true;
            lblLuong.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblLuong.Location = new Point(0, 182);
            lblLuong.Margin = new Padding(0, 0, 0, 5);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(181, 19);
            lblLuong.TabIndex = 5;
            lblLuong.Text = "Lương cơ bản (VND):";

            // txtLuongCoBan
            txtLuongCoBan.Font = new Font("Arial", 10F);
            txtLuongCoBan.Location = new Point(0, 206);
            txtLuongCoBan.Margin = new Padding(0, 0, 0, 15);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(300, 27);
            txtLuongCoBan.TabIndex = 6;
            // --- SỬA Ở ĐÂY: Căn lề trái ---
            txtLuongCoBan.TextAlign = HorizontalAlignment.Left;

            // lblMoTa
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblMoTa.Location = new Point(0, 248);
            lblMoTa.Margin = new Padding(0, 0, 0, 5);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(138, 19);
            lblMoTa.TabIndex = 7;
            lblMoTa.Text = "Mô tả công việc:";

            // txtMoTa
            txtMoTa.Font = new Font("Arial", 10F);
            txtMoTa.Location = new Point(0, 272);
            txtMoTa.Margin = new Padding(0, 0, 0, 25);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(300, 27);
            txtMoTa.TabIndex = 8;

            // pnlButtons
            pnlButtons.ColumnCount = 2;
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButtons.Controls.Add(btnThem, 0, 0);
            pnlButtons.Controls.Add(btnSua, 1, 0);
            pnlButtons.Controls.Add(btnXoa, 0, 1);
            pnlButtons.Controls.Add(btnLamMoi, 1, 1);
            pnlButtons.Location = new Point(3, 327);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.RowCount = 2;
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlButtons.Size = new Size(300, 90);
            pnlButtons.TabIndex = 9;

            // btnThem
            btnThem.BackColor = Color.FromArgb(76, 175, 80);
            btnThem.Cursor = Cursors.Hand;
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(144, 39);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;

            // btnSua
            btnSua.BackColor = Color.FromArgb(255, 193, 7);
            btnSua.Cursor = Cursors.Hand;
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(153, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(144, 39);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;

            // btnXoa
            btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(3, 48);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 39);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;

            // btnLamMoi
            btnLamMoi.BackColor = Color.FromArgb(33, 150, 243);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.Dock = DockStyle.Fill;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(153, 48);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(144, 39);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;

            // dgvChucVu
            dgvChucVu.AllowUserToAddRows = false;
            dgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChucVu.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Arial", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChucVu.ColumnHeadersHeight = 40;
            dgvChucVu.Columns.AddRange(new DataGridViewColumn[] { colMaCV, colTenCV, colLuong, colMoTa });
            dgvChucVu.Dock = DockStyle.Fill;
            dgvChucVu.EnableHeadersVisualStyles = false;
            dgvChucVu.Font = new Font("Arial", 11F);
            dgvChucVu.Location = new Point(0, 90);
            dgvChucVu.Name = "dgvChucVu";
            dgvChucVu.RowHeadersVisible = false;
            dgvChucVu.RowHeadersWidth = 51;
            dgvChucVu.RowTemplate.Height = 35;
            dgvChucVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChucVu.Size = new Size(650, 510);
            dgvChucVu.TabIndex = 2;

            // colMaCV
            colMaCV.HeaderText = "Mã CV";
            colMaCV.MinimumWidth = 6;
            colMaCV.Name = "colMaCV";

            // colTenCV
            colTenCV.HeaderText = "Tên chức vụ";
            colTenCV.MinimumWidth = 6;
            colTenCV.Name = "colTenCV";

            // colLuong
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            colLuong.DefaultCellStyle = dataGridViewCellStyle2;
            colLuong.HeaderText = "Lương cơ bản (VND)";
            colLuong.MinimumWidth = 6;
            colLuong.Name = "colLuong";

            // colMoTa
            colMoTa.HeaderText = "Mô tả";
            colMoTa.MinimumWidth = 6;
            colMoTa.Name = "colMoTa";

            // FormChucVu
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvChucVu);
            Controls.Add(pnlRight);
            Controls.Add(lblTitle);
            Name = "FormChucVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Chức Vụ";
            Load += FormChucVu_Load;
            pnlRight.ResumeLayout(false);
            layoutInput.ResumeLayout(false);
            layoutInput.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label lblTitle;
        public DataGridView dgvChucVu;
        public DataGridViewTextBoxColumn colMaCV;
        public DataGridViewTextBoxColumn colTenCV;
        public DataGridViewTextBoxColumn colLuong;
        public DataGridViewTextBoxColumn colMoTa;

        private Panel pnlRight;
        private FlowLayoutPanel layoutInput;
        private Label lblHeaderForm;

        private Label lblMaCV, lblTenCV, lblLuong, lblMoTa;
        public TextBox txtMaCV, txtTenCV, txtLuongCoBan, txtMoTa;

        private TableLayoutPanel pnlButtons;
        public Button btnThem, btnSua, btnXoa, btnLamMoi;
    }
}