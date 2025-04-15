namespace E2320152_FINAL_PROJECT_PROTASKER
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SIGNUP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.or = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.normaldescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.forgetpassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.showpass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Signinbtn = new Guna.UI2.WinForms.Guna2Button();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.SIGNUP);
            this.guna2Panel1.Controls.Add(this.or);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.normaldescription);
            this.guna2Panel1.Controls.Add(this.forgetpassword);
            this.guna2Panel1.Controls.Add(this.showpass);
            this.guna2Panel1.Controls.Add(this.Signinbtn);
            this.guna2Panel1.Controls.Add(this.password);
            this.guna2Panel1.Controls.Add(this.Username);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(381, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(307, 388);
            this.guna2Panel1.TabIndex = 0;
            // 
            // SIGNUP
            // 
            this.SIGNUP.BackColor = System.Drawing.Color.Transparent;
            this.SIGNUP.ForeColor = System.Drawing.Color.Crimson;
            this.SIGNUP.Location = new System.Drawing.Point(180, 354);
            this.SIGNUP.Name = "SIGNUP";
            this.SIGNUP.Size = new System.Drawing.Size(47, 15);
            this.SIGNUP.TabIndex = 10;
            this.SIGNUP.Text = "SIGN UP";
            this.SIGNUP.Click += new System.EventHandler(this.SIGNUP_Click);
            // 
            // or
            // 
            this.or.BackColor = System.Drawing.Color.Transparent;
            this.or.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or.Location = new System.Drawing.Point(143, 284);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(23, 22);
            this.or.TabIndex = 9;
            this.or.Text = "OR";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(86, 354);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(92, 15);
            this.guna2HtmlLabel2.TabIndex = 8;
            this.guna2HtmlLabel2.Text = "Need an account?";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(31, 290);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(250, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // normaldescription
            // 
            this.normaldescription.BackColor = System.Drawing.Color.Transparent;
            this.normaldescription.Location = new System.Drawing.Point(53, 67);
            this.normaldescription.Name = "normaldescription";
            this.normaldescription.Size = new System.Drawing.Size(197, 15);
            this.normaldescription.TabIndex = 6;
            this.normaldescription.Text = "ProTasker is a Task management system";
            // 
            // forgetpassword
            // 
            this.forgetpassword.BackColor = System.Drawing.Color.Transparent;
            this.forgetpassword.Location = new System.Drawing.Point(162, 258);
            this.forgetpassword.Name = "forgetpassword";
            this.forgetpassword.Size = new System.Drawing.Size(88, 15);
            this.forgetpassword.TabIndex = 5;
            this.forgetpassword.Text = "Forget Password?";
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showpass.CheckedState.BorderRadius = 2;
            this.showpass.CheckedState.BorderThickness = 0;
            this.showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showpass.Location = new System.Drawing.Point(152, 189);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(101, 17);
            this.showpass.TabIndex = 4;
            this.showpass.Text = "Show password";
            this.showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showpass.UncheckedState.BorderRadius = 2;
            this.showpass.UncheckedState.BorderThickness = 0;
            this.showpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showpass.UseVisualStyleBackColor = true;
            // 
            // Signinbtn
            // 
            this.Signinbtn.BorderRadius = 5;
            this.Signinbtn.CheckedState.Parent = this.Signinbtn;
            this.Signinbtn.CustomImages.Parent = this.Signinbtn;
            this.Signinbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Signinbtn.ForeColor = System.Drawing.Color.White;
            this.Signinbtn.HoverState.Parent = this.Signinbtn;
            this.Signinbtn.Location = new System.Drawing.Point(53, 212);
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.ShadowDecoration.Parent = this.Signinbtn;
            this.Signinbtn.Size = new System.Drawing.Size(200, 40);
            this.Signinbtn.TabIndex = 3;
            this.Signinbtn.Text = "Sign in";
            this.Signinbtn.Click += new System.EventHandler(this.Signinbtn_Click);
            // 
            // password
            // 
            this.password.BorderRadius = 5;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "123";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.FocusedState.Parent = this.password;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.HoverState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(53, 148);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "Password";
            this.password.SelectedText = "";
            this.password.SelectionStart = 3;
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(200, 36);
            this.password.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.BorderRadius = 5;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.DefaultText = "Naween kanishka";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.Parent = this.Username;
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.FocusedState.Parent = this.Username;
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.HoverState.Parent = this.Username;
            this.Username.Location = new System.Drawing.Point(53, 106);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderText = "Username";
            this.Username.SelectedText = "";
            this.Username.SelectionStart = 15;
            this.Username.ShadowDecoration.Parent = this.Username;
            this.Username.Size = new System.Drawing.Size(200, 36);
            this.Username.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(110, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(86, 39);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "LOGIN";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(700, 412);
            this.guna2Panel2.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 412);
            this.Controls.Add(this.guna2Panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProTasker | Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel normaldescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel forgetpassword;
        private Guna.UI2.WinForms.Guna2CheckBox showpass;
        private Guna.UI2.WinForms.Guna2Button Signinbtn;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel SIGNUP;
        private Guna.UI2.WinForms.Guna2HtmlLabel or;
    }
}

