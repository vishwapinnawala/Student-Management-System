namespace StudentManagementSys
{
    partial class createacc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createacc));
            this.escbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.userid = new Guna.UI2.WinForms.Guna2TextBox();
            this.storebtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // escbtn
            // 
            this.escbtn.BackColor = System.Drawing.Color.White;
            this.escbtn.BorderRadius = 10;
            this.escbtn.CheckedState.Parent = this.escbtn;
            this.escbtn.CustomImages.Parent = this.escbtn;
            this.escbtn.FillColor = System.Drawing.Color.Crimson;
            this.escbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.escbtn.ForeColor = System.Drawing.Color.White;
            this.escbtn.HoverState.Parent = this.escbtn;
            this.escbtn.Location = new System.Drawing.Point(379, 7);
            this.escbtn.Name = "escbtn";
            this.escbtn.ShadowDecoration.Parent = this.escbtn;
            this.escbtn.Size = new System.Drawing.Size(44, 27);
            this.escbtn.TabIndex = 14;
            this.escbtn.Text = "Esc";
            this.escbtn.Click += new System.EventHandler(this.escbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 27);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Student Management Sys";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(137, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(137, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "UserID";
            // 
            // password
            // 
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.BorderRadius = 5;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.FocusedState.Parent = this.password;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.HoverState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(136, 134);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(148, 21);
            this.password.TabIndex = 21;
            // 
            // userid
            // 
            this.userid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userid.BorderRadius = 5;
            this.userid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userid.DefaultText = "";
            this.userid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userid.DisabledState.Parent = this.userid;
            this.userid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userid.FocusedState.Parent = this.userid;
            this.userid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userid.HoverState.Parent = this.userid;
            this.userid.Location = new System.Drawing.Point(136, 74);
            this.userid.Name = "userid";
            this.userid.PasswordChar = '\0';
            this.userid.PlaceholderForeColor = System.Drawing.Color.White;
            this.userid.PlaceholderText = "";
            this.userid.SelectedText = "";
            this.userid.ShadowDecoration.Parent = this.userid;
            this.userid.Size = new System.Drawing.Size(148, 21);
            this.userid.TabIndex = 20;
            // 
            // storebtn
            // 
            this.storebtn.BorderColor = System.Drawing.Color.Empty;
            this.storebtn.BorderRadius = 10;
            this.storebtn.CheckedState.Parent = this.storebtn;
            this.storebtn.CustomImages.Parent = this.storebtn;
            this.storebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.storebtn.ForeColor = System.Drawing.Color.White;
            this.storebtn.HoverState.Parent = this.storebtn;
            this.storebtn.Location = new System.Drawing.Point(150, 177);
            this.storebtn.Name = "storebtn";
            this.storebtn.ShadowDecoration.Parent = this.storebtn;
            this.storebtn.Size = new System.Drawing.Size(118, 35);
            this.storebtn.TabIndex = 24;
            this.storebtn.Text = "Store";
            this.storebtn.Click += new System.EventHandler(this.storebtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Crimson;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(330, 7);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(44, 27);
            this.guna2Button1.TabIndex = 25;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // createacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(430, 224);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.storebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.escbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createacc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createacc";
            this.Load += new System.EventHandler(this.createacc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button escbtn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox userid;
        private Guna.UI2.WinForms.Guna2Button storebtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
    }
}