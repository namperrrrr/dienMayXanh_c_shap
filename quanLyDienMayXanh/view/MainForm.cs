using quanLyDienMayXanh.Controller;
using quanLyDienMayXanh.domain;
using quanLyDienMayXanh.view.kho;
using quanLyDienMayXanh.view.nhansu;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view
{
    public partial class MainForm : Form
    {
        private TaiKhoan taiKhoanHienTai;

        // --- BẢNG MÀU GIAO DIỆN ---
        private Color COLOR_MENU_BG = Color.FromArgb(33, 150, 243);    // Xanh chủ đạo
        private Color COLOR_MENU_HOVER = Color.FromArgb(25, 118, 210); // Xanh đậm khi hover
        private Color COLOR_TEXT_MAIN = Color.White;                    // Chữ trắng

        private Color COLOR_SUB_BG = Color.FromArgb(240, 248, 255);    // Nền menu con
        private Color COLOR_TEXT_SUB = Color.FromArgb(60, 60, 60);     // Chữ menu con

        private Color COLOR_LOGOUT_BG = Color.Crimson;                 // Đỏ cho nút đăng xuất

        // Các biến điều khiển
        private Panel pnlNhanSuSubMenu;
        private Panel pnlNhanSuHeader;
        private Panel pnlMenuContainer;

        // Kích thước Menu
        private int MENU_WIDTH = 340;

        public MainForm(TaiKhoan tk)
        {
            this.taiKhoanHienTai = tk;
            InitializeComponent();

            this.DoubleBuffered = true;
            SetupCustomUI();
        }
        private void SetupCustomUI()
        {
            // 1. Cấu hình khung Menu
            this.pnlMenu.Width = MENU_WIDTH;
            this.pnlMenu.BackColor = COLOR_MENU_BG;
            this.pnlMenu.Padding = new Padding(0);
            this.pnlMenu.AutoScroll = false;

            // 2. Setup các thành phần con
            SetupUserInfo();      // Tạo phần User Info
            SetupLogo();          // Tạo phần Logo
            SetupLogout();        // Tạo nút Logout
            SetupMenuContainer(); // Tạo khung chứa Menu
            CreateMenu();         // Tạo các nút Menu chức năng

            this.pnlLogo.SendToBack();
            this.pnlUserInfo.BringToFront();
            this.pnlMenuContainer.BringToFront();

            // 4. Phân quyền
            PhanQuyen();
        }
        private void SetupLogo()
        {
            this.pnlLogo.Dock = DockStyle.Top;
            this.pnlLogo.Height = 90;
            this.pnlLogo.BackColor = Color.White;
            this.pnlLogo.Padding = new Padding(0);

            this.picLogo.Image = null;
            string pathLogo = @"icons\logo_dmx.png";
            if (File.Exists(pathLogo))
            {
                try { this.picLogo.Image = Image.FromFile(pathLogo); } catch { }
            }
            else
            {
                this.picLogo.Image = LoadImageFromUrl("https://img.icons8.com/fluency/96/shop.png");
            }
        }
        private void SetupUserInfo()
        {
            this.pnlUserInfo.Dock = DockStyle.Top;
            this.pnlUserInfo.Height = 80;
            this.pnlUserInfo.BackColor = COLOR_MENU_BG;

            if (this.taiKhoanHienTai != null)
                this.lblUserName.Text = this.taiKhoanHienTai.TenDangNhap;

            this.lblUserName.ForeColor = Color.White;
            this.lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            string urlAvatar = "https://img.icons8.com/fluency/48/employee-card.png";
            string role = "NHÂN VIÊN";

            if (taiKhoanHienTai != null)
            {
                if (taiKhoanHienTai.CapDoQuyen == 3) { role = "QUẢN TRỊ VIÊN"; urlAvatar = "https://img.icons8.com/fluency/48/admin-settings-male.png"; }
                else if (taiKhoanHienTai.CapDoQuyen == 2) { role = "QUẢN LÝ"; urlAvatar = "https://img.icons8.com/fluency/48/manager.png"; }
            }
            this.lblUserRole.Text = role;
            this.lblUserRole.ForeColor = Color.FromArgb(224, 224, 224);

            this.picAvatar.BackColor = Color.White;
            Image ava = LoadImageFromUrl(urlAvatar);
            if (ava != null) this.picAvatar.Image = ava;
        }
        private void SetupLogout()
        {
            Panel pnlLogout = new Panel();
            pnlLogout.Height = 60;
            pnlLogout.Dock = DockStyle.Bottom;
            pnlLogout.BackColor = COLOR_LOGOUT_BG;
            pnlLogout.Cursor = Cursors.Hand;
            pnlLogout.Padding = new Padding(20, 0, 0, 0);

            Label lbl = new Label();
            lbl.Text = "ĐĂNG XUẤT";
            lbl.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.AutoSize = true;
            lbl.Location = new Point(70, 20);
            lbl.Enabled = false;

            PictureBox pic = new PictureBox();
            pic.Image = LoadImageFromUrl("https://img.icons8.com/ios-filled/50/ffffff/exit.png");
            pic.Size = new Size(24, 24);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Location = new Point(30, 18);
            pic.Enabled = false;

            pnlLogout.Controls.Add(pic);
            pnlLogout.Controls.Add(lbl);

            pnlLogout.MouseEnter += (s, e) => pnlLogout.BackColor = Color.Red;
            pnlLogout.MouseLeave += (s, e) => pnlLogout.BackColor = COLOR_LOGOUT_BG;

            // --- XỬ LÝ SỰ KIỆN CLICK ---
            pnlLogout.Click += (s, e) => {
                if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;

                    this.Close(); // Đóng form lại
                }
            };

            this.pnlMenu.Controls.Add(pnlLogout);
            pnlLogout.SendToBack(); // Đảm bảo Logout nằm dưới cùng
        }

        private void SetupMenuContainer()
        {
            pnlMenuContainer = new Panel();
            pnlMenuContainer.BackColor = COLOR_MENU_BG;
            pnlMenuContainer.Dock = DockStyle.Fill;
            pnlMenuContainer.AutoScroll = true;

            this.pnlMenu.Controls.Add(pnlMenuContainer);
        }

        // TẠO MENU ITEMS
        private void CreateMenu()
        {
            // Kho
            AddMenuItem("Sản phẩm Kho", "https://img.icons8.com/fluency/48/product.png",
                new string[] { "Danh sách sản phẩm", "Nhập kho", "Danh mục", "Nhà cung cấp" });

            // Nhân sự
            var nsMenu = AddMenuItem("Nhân sự hệ thống", "https://img.icons8.com/fluency/48/conference-call.png",
                new string[] { "Quản lý nhân viên", "Quản lý tài khoản", "Quản lý chức vụ" });
            this.pnlNhanSuHeader = nsMenu.HeaderPanel;
            this.pnlNhanSuSubMenu = nsMenu.SubPanel;

            // POS
            AddMenuItem("Bán hàng (POS)", "https://img.icons8.com/fluency/48/pos-terminal.png",
                new string[] { "Lập hóa đơn", "Khách hàng thân thiết", "Lịch sử giao dịch" });

            // Bảo hành
            AddMenuItem("Dịch vụ bảo hành", "https://img.icons8.com/fluency/48/maintenance.png",
                new string[] { "Tiếp nhận bảo hành", "Tra cứu", "Trả máy" });

            // Thống kê
            AddMenuItem("Khuyến mãi & Thống kê", "https://img.icons8.com/fluency/48/analytics.png",
                new string[] { "Doanh thu ngày", "Doanh thu tháng", "Lợi nhuận" });
        }

        private (Panel HeaderPanel, Panel SubPanel) AddMenuItem(string headerText, string iconUrl, string[] subItems)
        {
            Panel pnlItemContainer = new Panel();
            pnlItemContainer.Dock = DockStyle.Top;
            pnlItemContainer.BackColor = COLOR_MENU_BG;

            int headerHeight = 55;
            int subHeight = subItems.Length * 45;
            pnlItemContainer.Height = headerHeight;

            // Header
            Panel pnlHeader = new Panel();
            pnlHeader.Height = headerHeight;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = COLOR_MENU_BG;
            pnlHeader.Cursor = Cursors.Hand;
            pnlHeader.Padding = new Padding(20, 0, 0, 0);

            // Icon
            PictureBox picIcon = new PictureBox();
            picIcon.Size = new Size(28, 28);
            picIcon.Location = new Point(20, 13);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.Image = LoadImageFromUrl(iconUrl);
            picIcon.Enabled = false;

            // Text
            Label lblText = new Label();
            lblText.Text = headerText;
            lblText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblText.ForeColor = COLOR_TEXT_MAIN;
            lblText.AutoSize = true;
            lblText.Location = new Point(65, 16);
            lblText.Enabled = false;

            // Arrow
            Label lblArrow = new Label();
            lblArrow.Text = "◀";
            lblArrow.Font = new Font("Segoe UI", 10);
            lblArrow.ForeColor = Color.White;
            lblArrow.AutoSize = true;
            lblArrow.Location = new Point(MENU_WIDTH - 40, 18);
            lblArrow.Enabled = false;

            pnlHeader.Controls.Add(picIcon);
            pnlHeader.Controls.Add(lblText);
            pnlHeader.Controls.Add(lblArrow);

            // SubMenu
            Panel pnlSub = new Panel();
            pnlSub.Dock = DockStyle.Fill;
            pnlSub.BackColor = COLOR_SUB_BG;
            pnlSub.Visible = false;

            for (int i = subItems.Length - 1; i >= 0; i--)
            {
                string subName = subItems[i];
                Button btnSub = new Button();
                btnSub.Text = "      •  " + subName;
                btnSub.TextAlign = ContentAlignment.MiddleLeft;
                btnSub.Dock = DockStyle.Top;
                btnSub.Height = 45;
                btnSub.FlatStyle = FlatStyle.Flat;
                btnSub.FlatAppearance.BorderSize = 0;
                btnSub.BackColor = COLOR_SUB_BG;
                btnSub.ForeColor = COLOR_TEXT_SUB;
                btnSub.Font = new Font("Segoe UI", 10);
                btnSub.Cursor = Cursors.Hand;
                btnSub.Tag = subName;

                // Hover Submenu
                btnSub.MouseEnter += (s, e) => {
                    btnSub.BackColor = Color.FromArgb(200, 230, 255);
                    btnSub.ForeColor = Color.Blue;
                };
                btnSub.MouseLeave += (s, e) => {
                    btnSub.BackColor = COLOR_SUB_BG;
                    btnSub.ForeColor = COLOR_TEXT_SUB;
                };
                btnSub.Click += (s, e) => OpenChildForm(subName);

                pnlSub.Controls.Add(btnSub);
            }

            // Click Header Event
            pnlHeader.Click += (s, e) => {
                bool isOpening = !pnlSub.Visible;
                pnlSub.Visible = isOpening;
                lblArrow.Text = isOpening ? "▼" : "◀";
                pnlHeader.BackColor = isOpening ? COLOR_MENU_HOVER : COLOR_MENU_BG;
                pnlItemContainer.Height = isOpening ? (headerHeight + subHeight) : headerHeight;
            };

            // Hover Header
            pnlHeader.MouseEnter += (s, e) => {
                if (!pnlSub.Visible) pnlHeader.BackColor = COLOR_MENU_HOVER;
            };
            pnlHeader.MouseLeave += (s, e) => {
                if (!pnlSub.Visible) pnlHeader.BackColor = COLOR_MENU_BG;
            };

            pnlItemContainer.Controls.Add(pnlSub);
            pnlItemContainer.Controls.Add(pnlHeader);

            this.pnlMenuContainer.Controls.Add(pnlItemContainer);
            this.pnlMenuContainer.Controls.SetChildIndex(pnlItemContainer, 0);
            pnlItemContainer.BringToFront();

            return (pnlHeader, pnlSub);
        }

        private void PhanQuyen()
        {
            if (taiKhoanHienTai == null) return;
            if (taiKhoanHienTai.CapDoQuyen == 1 && pnlNhanSuHeader != null && pnlNhanSuHeader.Parent != null)
                pnlNhanSuHeader.Parent.Visible = false; // Nhân viên thì ẩn tab Nhân sự
            else if (taiKhoanHienTai.CapDoQuyen == 2 && pnlNhanSuSubMenu != null)
                foreach (Control c in pnlNhanSuSubMenu.Controls)
                    if (c is Button btn && (string)btn.Tag == "Quản lý tài khoản") btn.Visible = false; // Quản lý thì ẩn tạo tài khoản
        }
        private void OpenChildForm(string formName)
        {
            this.pnlCards.Controls.Clear();
            Form childForm = null;
            switch (formName)
            {
                case "Quản lý nhân viên": childForm = new FormNhanVien(); break;
                case "Quản lý tài khoản": childForm = new FormTaiKhoan(); break;
                case "Quản lý chức vụ": childForm = new FormChucVu(); break;
                case "Danh sách sản phẩm": childForm = new FormSanPham(); break;
                case "Nhập kho": childForm = new FormNhapKho(); break;
                // Thêm các case khác ở đây cho Kho, POS...
                default:
                    this.pnlCards.Controls.Add(new Label
                    {
                        Text = "Đang phát triển: " + formName,
                        AutoSize = true,
                        Location = new Point(50, 50),
                        Font = new Font("Segoe UI", 20)
                    });
                    return;
            }
            if (childForm != null)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.pnlCards.Controls.Add(childForm);
                childForm.Show();
            }
        }

        private Image LoadImageFromUrl(string url)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (WebClient wc = new WebClient()) using (MemoryStream ms = new MemoryStream(wc.DownloadData(url))) return Image.FromStream(ms);
            }
            catch { return null; }
        }
    }
}