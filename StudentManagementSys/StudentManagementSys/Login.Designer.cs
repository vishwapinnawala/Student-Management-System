namespace StudentManagementSys
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.teacherbtn = new Guna.UI2.WinForms.Guna2Button();
            this.studentbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.escbtn = new Guna.UI2.WinForms.Guna2Button();
            this.minbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherbtn
            // 
            this.teacherbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.teacherbtn.BorderRadius = 10;
            this.teacherbtn.CheckedState.Parent = this.teacherbtn;
            this.teacherbtn.CustomImages.Parent = this.teacherbtn;
            this.teacherbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.teacherbtn.ForeColor = System.Drawing.Color.White;
            this.teacherbtn.HoverState.Parent = this.teacherbtn;
            this.teacherbtn.Location = new System.Drawing.Point(85, 67);
            this.teacherbtn.Name = "teacherbtn";
            this.teacherbtn.ShadowDecoration.Parent = this.teacherbtn;
            this.teacherbtn.Size = new System.Drawing.Size(126, 114);
            this.teacherbtn.TabIndex = 0;
            this.teacherbtn.Text = "Teacher";
            this.teacherbtn.Click += new System.EventHandler(this.teacherbtn_Click);
            // 
            // studentbtn
            // 
            this.studentbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentbtn.BorderRadius = 10;
            this.studentbtn.BorderThickness = 1;
            this.studentbtn.CheckedState.Parent = this.studentbtn;
            this.studentbtn.CustomImages.Parent = this.studentbtn;
            this.studentbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentbtn.ForeColor = System.Drawing.Color.White;
            this.studentbtn.HoverState.Parent = this.studentbtn;
            this.studentbtn.Location = new System.Drawing.Point(273, 67);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.ShadowDecoration.Parent = this.studentbtn;
            this.studentbtn.Size = new System.Drawing.Size(126, 114);
            this.studentbtn.TabIndex = 1;
            this.studentbtn.Text = "Student";
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(3, 34);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(647, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // escbtn
            // 
            this.escbtn.BorderRadius = 10;
            this.escbtn.CheckedState.Parent = this.escbtn;
            this.escbtn.CustomImages.Parent = this.escbtn;
            this.escbtn.FillColor = System.Drawing.Color.Crimson;
            this.escbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.escbtn.ForeColor = System.Drawing.Color.White;
            this.escbtn.HoverState.Parent = this.escbtn;
            this.escbtn.Location = new System.Drawing.Point(567, 5);
            this.escbtn.Name = "escbtn";
            this.escbtn.ShadowDecoration.Parent = this.escbtn;
            this.escbtn.Size = new System.Drawing.Size(44, 27);
            this.escbtn.TabIndex = 3;
            this.escbtn.Text = "Esc";
            this.escbtn.Click += new System.EventHandler(this.escbtn_Click);
            // 
            // minbtn
            // 
            this.minbtn.BorderRadius = 10;
            this.minbtn.CheckedState.Parent = this.minbtn;
            this.minbtn.CustomImages.Parent = this.minbtn;
            this.minbtn.FillColor = System.Drawing.Color.Crimson;
            this.minbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minbtn.ForeColor = System.Drawing.Color.White;
            this.minbtn.HoverState.Parent = this.minbtn;
            this.minbtn.Location = new System.Drawing.Point(506, 5);
            this.minbtn.Name = "minbtn";
            this.minbtn.ShadowDecoration.Parent = this.minbtn;
            this.minbtn.Size = new System.Drawing.Size(44, 27);
            this.minbtn.TabIndex = 4;
            this.minbtn.Text = "Min";
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 38);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Management Sys";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(460, 67);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(126, 114);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Staff";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(626, 227);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minbtn);
            this.Controls.Add(this.escbtn);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.studentbtn);
            this.Controls.Add(this.teacherbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button teacherbtn;
        private Guna.UI2.WinForms.Guna2Button studentbtn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button escbtn;
        private Guna.UI2.WinForms.Guna2Button minbtn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
    }
}

