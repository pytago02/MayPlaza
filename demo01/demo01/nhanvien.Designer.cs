namespace demo01
{
    partial class nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhanvien));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDangxuat = new System.Windows.Forms.Label();
            this.btnDong = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_AddRoom1 = new demo01.All_Use_Control.UC_AddRoom();
            this.btnThunho = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrangchu = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnThongke = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnDichVu = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnQlNhanVien = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnThongtinkhach = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnDattraphong = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelDangxuat);
            this.panel3.Controls.Add(this.btnDong);
            this.panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.panel3.Controls.Add(this.guna2HtmlLabel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnThunho);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(1, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1267, 701);
            this.panel3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nhân Viên";
            // 
            // labelDangxuat
            // 
            this.labelDangxuat.AutoSize = true;
            this.labelDangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDangxuat.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangxuat.Location = new System.Drawing.Point(1156, 661);
            this.labelDangxuat.Name = "labelDangxuat";
            this.labelDangxuat.Size = new System.Drawing.Size(75, 19);
            this.labelDangxuat.TabIndex = 23;
            this.labelDangxuat.Text = "Đăng Xuất";
            this.labelDangxuat.Click += new System.EventHandler(this.labelDangxuat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Animated = true;
            this.btnDong.AutoRoundedCorners = true;
            this.btnDong.BorderRadius = 14;
            this.btnDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDong.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDong.FillColor = System.Drawing.Color.Transparent;
            this.btnDong.FillColor2 = System.Drawing.Color.Silver;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Image = global::demo01.Properties.Resources.close_FILL0_wght400_GRAD0_opsz24;
            this.btnDong.Location = new System.Drawing.Point(1237, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(30, 30);
            this.btnDong.TabIndex = 12;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(16, 1);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(75, 75);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 22;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(563, 16);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(221, 42);
            this.guna2HtmlLabel1.TabIndex = 21;
            this.guna2HtmlLabel1.Text = "May Plaza Hotel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(122, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 570);
            this.panel2.TabIndex = 20;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1120, 570);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // btnThunho
            // 
            this.btnThunho.Animated = true;
            this.btnThunho.AutoRoundedCorners = true;
            this.btnThunho.BorderRadius = 14;
            this.btnThunho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThunho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThunho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThunho.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThunho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThunho.FillColor = System.Drawing.Color.Transparent;
            this.btnThunho.FillColor2 = System.Drawing.Color.Silver;
            this.btnThunho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThunho.ForeColor = System.Drawing.Color.White;
            this.btnThunho.Image = global::demo01.Properties.Resources.minimize_FILL0_wght400_GRAD0_opsz24;
            this.btnThunho.Location = new System.Drawing.Point(1201, 0);
            this.btnThunho.Name = "btnThunho";
            this.btnThunho.Size = new System.Drawing.Size(30, 30);
            this.btnThunho.TabIndex = 11;
            this.btnThunho.Click += new System.EventHandler(this.btnThunho_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTrangchu);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.btnDichVu);
            this.panel1.Controls.Add(this.btnQlNhanVien);
            this.panel1.Controls.Add(this.btnThongtinkhach);
            this.panel1.Controls.Add(this.btnDattraphong);
            this.panel1.Location = new System.Drawing.Point(5, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 578);
            this.panel1.TabIndex = 19;
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.Animated = true;
            this.btnTrangchu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangchu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangchu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangchu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangchu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangchu.FillColor = System.Drawing.Color.Silver;
            this.btnTrangchu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrangchu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnTrangchu.ForeColor = System.Drawing.Color.White;
            this.btnTrangchu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnTrangchu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangchu.Image")));
            this.btnTrangchu.Location = new System.Drawing.Point(11, 3);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTrangchu.Size = new System.Drawing.Size(80, 80);
            this.btnTrangchu.TabIndex = 23;
            this.btnTrangchu.Text = "Trang Chủ";
            // 
            // btnThongke
            // 
            this.btnThongke.Animated = true;
            this.btnThongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongke.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongke.FillColor = System.Drawing.Color.Silver;
            this.btnThongke.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThongke.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.Location = new System.Drawing.Point(11, 433);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnThongke.Size = new System.Drawing.Size(80, 80);
            this.btnThongke.TabIndex = 22;
            this.btnThongke.Text = "Thanh Toán";
            // 
            // btnDichVu
            // 
            this.btnDichVu.Animated = true;
            this.btnDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDichVu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDichVu.FillColor = System.Drawing.Color.Silver;
            this.btnDichVu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDichVu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnDichVu.ForeColor = System.Drawing.Color.White;
            this.btnDichVu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Image")));
            this.btnDichVu.Location = new System.Drawing.Point(11, 175);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDichVu.Size = new System.Drawing.Size(80, 80);
            this.btnDichVu.TabIndex = 21;
            this.btnDichVu.Text = "Dịch Vụ";
            // 
            // btnQlNhanVien
            // 
            this.btnQlNhanVien.Animated = true;
            this.btnQlNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQlNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQlNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlNhanVien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQlNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQlNhanVien.FillColor = System.Drawing.Color.Silver;
            this.btnQlNhanVien.FillColor2 = System.Drawing.Color.DimGray;
            this.btnQlNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnQlNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQlNhanVien.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnQlNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQlNhanVien.Image")));
            this.btnQlNhanVien.Location = new System.Drawing.Point(11, 347);
            this.btnQlNhanVien.Name = "btnQlNhanVien";
            this.btnQlNhanVien.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnQlNhanVien.Size = new System.Drawing.Size(80, 80);
            this.btnQlNhanVien.TabIndex = 20;
            this.btnQlNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // btnThongtinkhach
            // 
            this.btnThongtinkhach.Animated = true;
            this.btnThongtinkhach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongtinkhach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongtinkhach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongtinkhach.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongtinkhach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongtinkhach.FillColor = System.Drawing.Color.Silver;
            this.btnThongtinkhach.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThongtinkhach.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongtinkhach.ForeColor = System.Drawing.Color.White;
            this.btnThongtinkhach.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnThongtinkhach.Image = ((System.Drawing.Image)(resources.GetObject("btnThongtinkhach.Image")));
            this.btnThongtinkhach.Location = new System.Drawing.Point(11, 261);
            this.btnThongtinkhach.Name = "btnThongtinkhach";
            this.btnThongtinkhach.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnThongtinkhach.Size = new System.Drawing.Size(80, 80);
            this.btnThongtinkhach.TabIndex = 18;
            this.btnThongtinkhach.Text = "Thông Tin Khách";
            // 
            // btnDattraphong
            // 
            this.btnDattraphong.Animated = true;
            this.btnDattraphong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDattraphong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDattraphong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDattraphong.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDattraphong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDattraphong.FillColor = System.Drawing.Color.Silver;
            this.btnDattraphong.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDattraphong.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnDattraphong.ForeColor = System.Drawing.Color.White;
            this.btnDattraphong.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnDattraphong.Image = ((System.Drawing.Image)(resources.GetObject("btnDattraphong.Image")));
            this.btnDattraphong.Location = new System.Drawing.Point(11, 89);
            this.btnDattraphong.Name = "btnDattraphong";
            this.btnDattraphong.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDattraphong.Size = new System.Drawing.Size(80, 80);
            this.btnDattraphong.TabIndex = 17;
            this.btnDattraphong.Text = "Đặt - Trả Phòng";
            // 
            // nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nhanvien";
            this.Load += new System.EventHandler(this.nhanvien_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDangxuat;
        private Guna.UI2.WinForms.Guna2GradientButton btnDong;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnThunho;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnThongke;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnDichVu;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnQlNhanVien;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnThongtinkhach;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnDattraphong;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnTrangchu;
        private All_Use_Control.UC_AddRoom uC_AddRoom1;
    }
}