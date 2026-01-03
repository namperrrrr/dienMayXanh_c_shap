namespace quanLyDienMayXanh.view
{
    partial class MainForm
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
            pnlMenu = new Panel();
            pnlUserInfo = new Panel();
            lblUserRole = new Label();
            lblUserName = new Label();
            picAvatar = new PictureBox();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            pnlCards = new Panel();
            pnlMenu.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(33, 150, 243);
            pnlMenu.Controls.Add(pnlUserInfo);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(316, 700);
            pnlMenu.TabIndex = 0;
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.Controls.Add(lblUserRole);
            pnlUserInfo.Controls.Add(lblUserName);
            pnlUserInfo.Controls.Add(picAvatar);
            pnlUserInfo.Dock = DockStyle.Top;
            pnlUserInfo.Location = new Point(0, 80);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(316, 70);
            pnlUserInfo.TabIndex = 1;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Arial", 9F, FontStyle.Italic);
            lblUserRole.ForeColor = Color.Gray;
            lblUserRole.Location = new Point(80, 40);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(38, 17);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "Role";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblUserName.ForeColor = Color.Black;
            lblUserName.Location = new Point(80, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(110, 22);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.White;
            picAvatar.Location = new Point(15, 10);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(50, 50);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.White;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(316, 80);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(316, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlCards
            // 
            pnlCards.BackColor = Color.WhiteSmoke;
            pnlCards.Dock = DockStyle.Fill;
            pnlCards.Location = new Point(316, 0);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(884, 700);
            pnlCards.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlCards);
            Controls.Add(pnlMenu);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Điện máy Xanh";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // QUAN TRỌNG: Đổi kiểu dữ liệu ở đây
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.PictureBox picAvatar;
    }
}