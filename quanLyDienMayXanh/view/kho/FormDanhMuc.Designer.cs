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
            lblTitle = new Label();
            pnlRight = new Panel();
            layoutInput = new FlowLayoutPanel();
            lblHeaderForm = new Label();
            lblMaDM = new Label();
            txtMaDM = new TextBox();
            lblTenDM = new Label();
            txtTenDM = new TextBox();
            pnlButtons = new TableLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvDanhMuc = new DataGridView();
            colMaDM = new DataGridViewTextBoxColumn();
            colTenDM = new DataGridViewTextBoxColumn();
            pnlRight.SuspendLayout();
            layoutInput.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243); // Màu xanh chủ đạo
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1000, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ DANH MỤC SẢN PHẨM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // pnlRight (Panel bên phải chứa input)
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(layoutInput);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(650, 70);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(20);
            pnlRight.Size = new Size(350, 530);
            pnlRight.TabIndex = 1;

            // 
            // layoutInput
            // 
            layoutInput.Controls.Add(lblHeaderForm);
            layoutInput.Controls.Add(lblMaDM);
            layoutInput.Controls.Add(txtMaDM);
            layoutInput.Controls.Add(lblTenDM);
            layoutInput.Controls.Add(txtTenDM);
            layoutInput.Controls.Add(pnlButtons);
            layoutInput.Dock = DockStyle.Fill;
            layoutInput.FlowDirection = FlowDirection.TopDown;
            layoutInput.Location = new Point(20, 20);
            layoutInput.Name = "layoutInput";
            layoutInput.Size = new Size(310, 490);
            layoutInput.TabIndex = 0;
            layoutInput.WrapContents = false;

            // 
            // lblHeaderForm
            // 
            lblHeaderForm.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblHeaderForm.ForeColor = Color.FromArgb(33, 150, 243);
            lblHeaderForm.Location = new Point(0, 0);
            lblHeaderForm.Margin = new Padding(0, 0, 0, 20);
            lblHeaderForm.Name = "lblHeaderForm";
            lblHeaderForm.Size = new Size(300, 30);
            lblHeaderForm.TabIndex = 0;
            lblHeaderForm.Text = "THÔNG TIN CHI TIẾT";
            lblHeaderForm.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblMaDM
            // 
            lblMaDM.AutoSize = true;
            lblMaDM.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblMaDM.Location = new Point(0, 50);
            lblMaDM.Margin = new Padding(0, 0, 0, 5);
            lblMaDM.Name = "lblMaDM";
            lblMaDM.Size = new Size(110, 19);
            lblMaDM.TabIndex = 1;
            lblMaDM.Text = "Mã danh mục:";

            // 
            // txtMaDM
            // 
            txtMaDM.Font = new Font("Arial", 10F);
            txtMaDM.Location = new Point(0, 74);
            txtMaDM.Margin = new Padding(0, 0, 0, 15);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.Size = new Size(300, 27);
            txtMaDM.TabIndex = 2;

            // 
            // lblTenDM
            // 
            lblTenDM.AutoSize = true;
            lblTenDM.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTenDM.Location = new Point(0, 116);
            lblTenDM.Margin = new Padding(0, 0, 0, 5);
            lblTenDM.Name = "lblTenDM";
            lblTenDM.Size = new Size(117, 19);
            lblTenDM.TabIndex = 3;
            lblTenDM.Text = "Tên danh mục:";

            // 
            // txtTenDM
            // 
            txtTenDM.Font = new Font("Arial", 10F);
            txtTenDM.Location = new Point(0, 140);
            txtTenDM.Margin = new Padding(0, 0, 0, 25); // Khoảng cách lớn hơn chút trước nút bấm
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(300, 27);
            txtTenDM.TabIndex = 4;

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
            pnlButtons.Location = new Point(3, 195); // Vị trí panel nút
            pnlButtons.Name = "pnlButtons";
            pnlButtons.RowCount = 2;
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlButtons.Size = new Size(300, 90);
            pnlButtons.TabIndex = 9;

            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(76, 175, 80); // Xanh lá
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

            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 193, 7); // Vàng cam
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

            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(244, 67, 54); // Đỏ
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

            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(33, 150, 243); // Xanh dương
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

            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.BackgroundColor = Color.White;
            // Style Header
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Arial", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhMuc.ColumnHeadersHeight = 40;
            dgvDanhMuc.Columns.AddRange(new DataGridViewColumn[] { colMaDM, colTenDM });
            dgvDanhMuc.Dock = DockStyle.Fill;
            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.Font = new Font("Arial", 11F);
            dgvDanhMuc.Location = new Point(0, 70);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.RowHeadersVisible = false;
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.RowTemplate.Height = 35;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.Size = new Size(650, 530);
            dgvDanhMuc.TabIndex = 2;

            // 
            // colMaDM
            // 
            colMaDM.DataPropertyName = "MaDanhMuc";
            colMaDM.HeaderText = "Mã DM";
            colMaDM.MinimumWidth = 6;
            colMaDM.Name = "colMaDM";
            colMaDM.ReadOnly = true;
            colMaDM.Width = 120; // Cố định chiều rộng cột Mã nhỏ lại

            // 
            // colTenDM
            // 
            colTenDM.DataPropertyName = "TenDanhMuc";
            colTenDM.HeaderText = "Tên Danh Mục";
            colTenDM.MinimumWidth = 6;
            colTenDM.Name = "colTenDM";
            colTenDM.ReadOnly = true;
            // Cột này sẽ tự động Fill vì dgv set AutoSizeColumnsMode = Fill

            // 
            // FormDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvDanhMuc);
            Controls.Add(pnlRight);
            Controls.Add(lblTitle);
            Name = "FormDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Danh Mục";
            pnlRight.ResumeLayout(false);
            layoutInput.ResumeLayout(false);
            layoutInput.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label lblTitle;
        public DataGridView dgvDanhMuc;
        public DataGridViewTextBoxColumn colMaDM;
        public DataGridViewTextBoxColumn colTenDM;

        private Panel pnlRight;
        private FlowLayoutPanel layoutInput;
        private Label lblHeaderForm;

        private Label lblMaDM, lblTenDM;
        public TextBox txtMaDM, txtTenDM;

        private TableLayoutPanel pnlButtons;
        public Button btnThem, btnSua, btnXoa, btnLamMoi;
    }
}