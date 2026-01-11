using System.Drawing;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view.kho
{
    partial class FormDanhMuc
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
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(875, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ DANH MỤC SẢN PHẨM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(layoutInput);
            pnlRight.Controls.Add(pnlButtons);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(569, 52);
            pnlRight.Margin = new Padding(3, 2, 3, 2);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(18, 15, 18, 15);
            pnlRight.Size = new Size(306, 398);
            pnlRight.TabIndex = 1;
            // 
            // layoutInput
            // 
            layoutInput.Controls.Add(lblHeaderForm);
            layoutInput.Controls.Add(lblMaDM);
            layoutInput.Controls.Add(txtMaDM);
            layoutInput.Controls.Add(lblTenDM);
            layoutInput.Controls.Add(txtTenDM);
            layoutInput.Dock = DockStyle.Fill;
            layoutInput.FlowDirection = FlowDirection.TopDown;
            layoutInput.Location = new Point(18, 15);
            layoutInput.Margin = new Padding(3, 2, 3, 2);
            layoutInput.Name = "layoutInput";
            layoutInput.Size = new Size(270, 300);
            layoutInput.TabIndex = 0;
            layoutInput.WrapContents = false;
            // 
            // lblHeaderForm
            // 
            lblHeaderForm.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblHeaderForm.ForeColor = Color.FromArgb(33, 150, 243);
            lblHeaderForm.Location = new Point(0, 0);
            lblHeaderForm.Margin = new Padding(0, 0, 0, 15);
            lblHeaderForm.Name = "lblHeaderForm";
            lblHeaderForm.Size = new Size(262, 22);
            lblHeaderForm.TabIndex = 0;
            lblHeaderForm.Text = "THÔNG TIN CHI TIẾT";
            lblHeaderForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaDM
            // 
            lblMaDM.AutoSize = true;
            lblMaDM.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblMaDM.Location = new Point(0, 37);
            lblMaDM.Margin = new Padding(0, 0, 0, 4);
            lblMaDM.Name = "lblMaDM";
            lblMaDM.Size = new Size(104, 16);
            lblMaDM.TabIndex = 1;
            lblMaDM.Text = "Mã danh mục:";
            // 
            // txtMaDM
            // 
            txtMaDM.Font = new Font("Arial", 10F);
            txtMaDM.Location = new Point(0, 57);
            txtMaDM.Margin = new Padding(0, 0, 0, 11);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.Size = new Size(263, 23);
            txtMaDM.TabIndex = 2;
            // 
            // lblTenDM
            // 
            lblTenDM.AutoSize = true;
            lblTenDM.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTenDM.Location = new Point(0, 91);
            lblTenDM.Margin = new Padding(0, 0, 0, 4);
            lblTenDM.Name = "lblTenDM";
            lblTenDM.Size = new Size(108, 16);
            lblTenDM.TabIndex = 3;
            lblTenDM.Text = "Tên danh mục:";
            // 
            // txtTenDM
            // 
            txtTenDM.Font = new Font("Arial", 10F);
            txtTenDM.Location = new Point(0, 111);
            txtTenDM.Margin = new Padding(0, 0, 0, 19);
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(263, 23);
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
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(18, 315);
            pnlButtons.Margin = new Padding(3, 2, 3, 2);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.RowCount = 2;
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlButtons.Size = new Size(270, 68);
            pnlButtons.TabIndex = 9;
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
            btnThem.Size = new Size(129, 30);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 193, 7);
            btnSua.Cursor = Cursors.Hand;
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(138, 2);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 30);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
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
            btnXoa.Size = new Size(129, 30);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
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
            btnLamMoi.Location = new Point(138, 36);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(129, 30);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.BackgroundColor = Color.White;
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
            dgvDanhMuc.Location = new Point(0, 52);
            dgvDanhMuc.Margin = new Padding(3, 2, 3, 2);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.RowHeadersVisible = false;
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.RowTemplate.Height = 35;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.Size = new Size(569, 398);
            dgvDanhMuc.TabIndex = 2;
            // 
            // colMaDM
            // 
            colMaDM.DataPropertyName = "MaDanhMuc";
            colMaDM.HeaderText = "Mã DM";
            colMaDM.MinimumWidth = 6;
            colMaDM.Name = "colMaDM";
            colMaDM.ReadOnly = true;
            // 
            // colTenDM
            // 
            colTenDM.DataPropertyName = "TenDanhMuc";
            colTenDM.HeaderText = "Tên Danh Mục";
            colTenDM.MinimumWidth = 6;
            colTenDM.Name = "colTenDM";
            colTenDM.ReadOnly = true;
            // 
            // FormDanhMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(875, 450);
            Controls.Add(dgvDanhMuc);
            Controls.Add(pnlRight);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
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