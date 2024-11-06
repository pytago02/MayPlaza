namespace winformapp
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsename = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbError);
            this.guna2Panel1.Controls.Add(this.lbLogin);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Controls.Add(this.txtPass);
            this.guna2Panel1.Controls.Add(this.txtUsename);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(460, 340);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lbError
            // 
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(107, 305);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(235, 15);
            this.lbError.TabIndex = 4;
            this.lbError.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
            // 
            // lbLogin
            // 
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(159, 25);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(142, 35);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "ĐĂNG NHẬP";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 18;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(54, 229);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(360, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.BorderColor = System.Drawing.Color.DimGray;
            this.txtPass.BorderRadius = 18;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FillColor = System.Drawing.Color.Silver;
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPass.IconLeft")));
            this.txtPass.Location = new System.Drawing.Point(54, 151);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPass.PlaceholderText = "Mật Khẩu";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(360, 40);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsename
            // 
            this.txtUsename.BorderColor = System.Drawing.Color.DimGray;
            this.txtUsename.BorderRadius = 18;
            this.txtUsename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsename.DefaultText = "";
            this.txtUsename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsename.FillColor = System.Drawing.Color.Silver;
            this.txtUsename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsename.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.txtUsename.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsename.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsename.IconLeft")));
            this.txtUsename.Location = new System.Drawing.Point(54, 101);
            this.txtUsename.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.PasswordChar = '\0';
            this.txtUsename.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtUsename.PlaceholderText = "Tên Đăng Nhập";
            this.txtUsename.SelectedText = "";
            this.txtUsename.Size = new System.Drawing.Size(360, 40);
            this.txtUsename.TabIndex = 0;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsename;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbError;
    }
}

