using System.Drawing;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view.kho
{
    partial class FormDanhMuc
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

            // Khởi tạo các controls
            this.lblTitle = new Label();
            this.pnlRight = new Panel();
            this.layoutInput = new FlowLayoutPanel();
            this.lblHeaderForm = new Label();

            this.lblMaDM = new Label();
            this.txtMaDanhMuc = new TextBox();

            this.lblTenDM = new Label();
            this.txtTenDanhMuc = new TextBox();

            // Tìm kiếm
            this.lblTimKiem = new Label();
            this.txtTimKiem = new TextBox();
            this.btnTimKiem = new Button();

            this.pnlButtons = new TableLayoutPanel();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnLamMoi = new Button();

            this.dgvDanhMuc = new DataGridView();
            this.colMaDanhMuc = new DataGridViewTextBoxColumn();
            this.colTenDanhMuc = new DataGridViewTextBoxColumn();

            this.pnlRight.SuspendLayout();
            this.layoutInput.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
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
            this.lblTitle.Size = new Size(1000, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ DANH MỤC SẢN PHẨM";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // pnlRight (Sidebar bên phải)
            // 
            this.pnlRight.BackColor = Color.White;
            this.pnlRight.Controls.Add(this.layoutInput);
            this.pnlRight.Dock = DockStyle.Right;
            this.pnlRight.Location = new Point(650, 90);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new Padding(20);
            this.pnlRight.Size = new Size(350, 510);
            this.pnlRight.TabIndex = 1;

            // 
            // layoutInput (Dàn hàng dọc)
            // 
            this.layoutInput.Controls.Add(this.lblHeaderForm);
            this.layoutInput.Controls.Add(this.lblMaDM);
            this.layoutInput.Controls.Add(this.txtMaDanhMuc);
            this.layoutInput.Controls.Add(this.lblTenDM);
            this.layoutInput.Controls.Add(this.txtTenDanhMuc);
            this.layoutInput.Controls.Add(this.pnlButtons);
            // Thêm phần tìm kiếm xuống dưới nút bấm cho gọn
            this.layoutInput.Controls.Add(this.lblTimKiem);
            this.layoutInput.Controls.Add(this.txtTimKiem);
            this.layoutInput.Controls.Add(this.btnTimKiem);

            this.layoutInput.Dock = DockStyle.Fill;
            this.layoutInput.FlowDirection = FlowDirection.TopDown;
            this.layoutInput.Location = new Point(20, 20);
            this.layoutInput.Name = "layoutInput";
            this.layoutInput.Size = new Size(310, 470);
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

            // Font chung
            Font fontLabel = new Font("Arial", 10F, FontStyle.Bold);
            Font fontInput = new Font("Arial", 10F);

            // lblMaDM
            this.lblMaDM.AutoSize = true;
            this.lblMaDM.Font = fontLabel;
            this.lblMaDM.Location = new Point(0, 50);
            this.lblMaDM.Margin = new Padding(0, 0, 0, 5);
            this.lblMaDM.Name = "lblMaDM";
            this.lblMaDM.Size = new Size(106, 19);
            this.lblMaDM.TabIndex = 1;
            this.lblMaDM.Text = "Mã danh mục:";

            // txtMaDanhMuc
            this.txtMaDanhMuc.Font = fontInput;
            this.txtMaDanhMuc.Location = new Point(0, 74);
            this.txtMaDanhMuc.Margin = new Padding(0, 0, 0, 15);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new Size(300, 27);
            this.txtMaDanhMuc.TabIndex = 2;

            // lblTenDM
            this.lblTenDM.AutoSize = true;
            this.lblTenDM.Font = fontLabel;
            this.lblTenDM.Location = new Point(0, 116);
            this.lblTenDM.Margin = new Padding(0, 0, 0, 5);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new Size(113, 19);
            this.lblTenDM.TabIndex = 3;
            this.lblTenDM.Text = "Tên danh mục:";

            // txtTenDanhMuc
            this.txtTenDanhMuc.Font = fontInput;
            this.txtTenDanhMuc.Location = new Point(0, 140);
            this.txtTenDanhMuc.Margin = new Padding(0, 0, 0, 25);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new Size(300, 27);
            this.txtTenDanhMuc.TabIndex = 4;

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
            this.pnlButtons.Location = new Point(0, 192);
            this.pnlButtons.Margin = new Padding(0, 0, 0, 20);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RowCount = 2;
            this.pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.pnlButtons.Size = new Size(300, 90);
            this.pnlButtons.TabIndex = 5;

            // btnThem
            this.btnThem.BackColor = Color.FromArgb(76, 175, 80);
            this.btnThem.Cursor = Cursors.Hand;
            this.btnThem.Dock = DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = FlatStyle.Flat;
            this.btnThem.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.btnThem.ForeColor = Color.White;
            this.btnThem.Location = new Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(144, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;

            // btnSua
            this.btnSua.BackColor = Color.FromArgb(255, 193, 7);
            this.btnSua.Cursor = Cursors.Hand;
            this.btnSua.Dock = DockStyle.Fill;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = FlatStyle.Flat;
            this.btnSua.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.btnSua.ForeColor = Color.White;
            this.btnSua.Location = new Point(153, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new Size(144, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;

            // btnXoa
            this.btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            this.btnXoa.Cursor = Cursors.Hand;
            this.btnXoa.Dock = DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = FlatStyle.Flat;
            this.btnXoa.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.Location = new Point(3, 48);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(144, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;

            // btnLamMoi
            this.btnLamMoi.BackColor = Color.FromArgb(33, 150, 243);
            this.btnLamMoi.Cursor = Cursors.Hand;
            this.btnLamMoi.Dock = DockStyle.Fill;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.Location = new Point(153, 48);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new Size(144, 39);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;

            // Tim kiem (Them vao duoi cac nut cho tien)
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = fontLabel;
            this.lblTimKiem.Location = new Point(0, 302);
            this.lblTimKiem.Margin = new Padding(0, 0, 0, 5);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Text = "Tìm kiếm:";

            this.txtTimKiem.Font = fontInput;
            this.txtTimKiem.Location = new Point(0, 326);
            this.txtTimKiem.Margin = new Padding(0, 0, 0, 10);
            this.txtTimKiem.Size = new Size(300, 27);

            this.btnTimKiem.BackColor = Color.Gray;
            this.btnTimKiem.FlatStyle = FlatStyle.Flat;
            this.btnTimKiem.ForeColor = Color.White;
            this.btnTimKiem.Font = fontLabel;
            this.btnTimKiem.Location = new Point(0, 363);
            this.btnTimKiem.Size = new Size(300, 35);
            this.btnTimKiem.Text = "Tìm theo tên/mã";
            this.btnTimKiem.UseVisualStyleBackColor = false;

            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Arial", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMuc.ColumnHeadersHeight = 40;
            this.dgvDanhMuc.Columns.AddRange(new DataGridViewColumn[] {
            this.colMaDanhMuc,
            this.colTenDanhMuc});
            this.dgvDanhMuc.Dock = DockStyle.Fill;
            this.dgvDanhMuc.EnableHeadersVisualStyles = false;
            this.dgvDanhMuc.Font = new Font("Arial", 11F);
            this.dgvDanhMuc.Location = new Point(0, 90);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.RowTemplate.Height = 35;
            this.dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new Size(650, 510);
            this.dgvDanhMuc.TabIndex = 2;

            // colMaDanhMuc
            this.colMaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.colMaDanhMuc.HeaderText = "Mã Danh Mục";
            this.colMaDanhMuc.Name = "colMaDanhMuc";
            this.colMaDanhMuc.ReadOnly = true;

            // colTenDanhMuc
            this.colTenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.colTenDanhMuc.HeaderText = "Tên Danh Mục";
            this.colTenDanhMuc.Name = "colTenDanhMuc";
            this.colTenDanhMuc.ReadOnly = true;

            // FormDanhMuc
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormDanhMuc";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục";
            this.pnlRight.ResumeLayout(false);
            this.layoutInput.ResumeLayout(false);
            this.layoutInput.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        public Label lblTitle;
        public DataGridView dgvDanhMuc;
        public DataGridViewTextBoxColumn colMaDanhMuc;
        public DataGridViewTextBoxColumn colTenDanhMuc;

        private Panel pnlRight;
        private FlowLayoutPanel layoutInput;
        private Label lblHeaderForm;

        private Label lblMaDM, lblTenDM, lblTimKiem;
        public TextBox txtMaDanhMuc, txtTenDanhMuc, txtTimKiem;
        public Button btnTimKiem;

        private TableLayoutPanel pnlButtons;
        public Button btnThem, btnSua, btnXoa, btnLamMoi;
    }
}