namespace StudentManagementSys
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lname = new Guna.UI2.WinForms.Guna2TextBox();
            this.fname = new Guna.UI2.WinForms.Guna2TextBox();
            this.tel = new Guna.UI2.WinForms.Guna2TextBox();
            this.male = new Guna.UI2.WinForms.Guna2CheckBox();
            this.female = new Guna.UI2.WinForms.Guna2CheckBox();
            this.savebtn = new Guna.UI2.WinForms.Guna2Button();
            this.updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.delbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchbtn = new Guna.UI2.WinForms.Guna2Button();
            this.escbtn = new Guna.UI2.WinForms.Guna2Button();
            this.minbtn = new Guna.UI2.WinForms.Guna2Button();
            this.cmbbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.teaid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.lerror = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ferror = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ciderror = new Guna.UI2.WinForms.Guna2CircleButton();
            this.generror = new Guna.UI2.WinForms.Guna2CircleButton();
            this.emailerror = new Guna.UI2.WinForms.Guna2CircleButton();
            this.telerror = new Guna.UI2.WinForms.Guna2CircleButton();
            this.error2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.error = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course ID";
            // 
            // lname
            // 
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.DefaultText = "";
            this.lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lname.DisabledState.Parent = this.lname;
            this.lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lname.FocusedState.Parent = this.lname;
            this.lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lname.HoverState.Parent = this.lname;
            this.lname.Location = new System.Drawing.Point(112, 154);
            this.lname.Name = "lname";
            this.lname.PasswordChar = '\0';
            this.lname.PlaceholderText = "";
            this.lname.SelectedText = "";
            this.lname.ShadowDecoration.Parent = this.lname;
            this.lname.Size = new System.Drawing.Size(200, 25);
            this.lname.TabIndex = 5;
            // 
            // fname
            // 
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.DefaultText = "";
            this.fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fname.DisabledState.Parent = this.fname;
            this.fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fname.FocusedState.Parent = this.fname;
            this.fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fname.HoverState.Parent = this.fname;
            this.fname.Location = new System.Drawing.Point(112, 110);
            this.fname.Name = "fname";
            this.fname.PasswordChar = '\0';
            this.fname.PlaceholderText = "";
            this.fname.SelectedText = "";
            this.fname.ShadowDecoration.Parent = this.fname;
            this.fname.Size = new System.Drawing.Size(200, 25);
            this.fname.TabIndex = 6;
            // 
            // tel
            // 
            this.tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tel.DefaultText = "";
            this.tel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tel.DisabledState.Parent = this.tel;
            this.tel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tel.FocusedState.Parent = this.tel;
            this.tel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tel.HoverState.Parent = this.tel;
            this.tel.Location = new System.Drawing.Point(112, 198);
            this.tel.Name = "tel";
            this.tel.PasswordChar = '\0';
            this.tel.PlaceholderText = "";
            this.tel.SelectedText = "";
            this.tel.ShadowDecoration.Parent = this.tel;
            this.tel.Size = new System.Drawing.Size(200, 25);
            this.tel.TabIndex = 7;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.male.CheckedState.BorderRadius = 2;
            this.male.CheckedState.BorderThickness = 0;
            this.male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.male.Location = new System.Drawing.Point(123, 276);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 17);
            this.male.TabIndex = 8;
            this.male.Text = "Male";
            this.male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.male.UncheckedState.BorderRadius = 2;
            this.male.UncheckedState.BorderThickness = 0;
            this.male.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.female.CheckedState.BorderRadius = 2;
            this.female.CheckedState.BorderThickness = 0;
            this.female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.female.Location = new System.Drawing.Point(231, 276);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(60, 17);
            this.female.TabIndex = 9;
            this.female.Text = "Female";
            this.female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.female.UncheckedState.BorderRadius = 2;
            this.female.UncheckedState.BorderThickness = 0;
            this.female.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // savebtn
            // 
            this.savebtn.BorderRadius = 5;
            this.savebtn.CheckedState.Parent = this.savebtn;
            this.savebtn.CustomImages.Parent = this.savebtn;
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.HoverState.Parent = this.savebtn;
            this.savebtn.Location = new System.Drawing.Point(352, 66);
            this.savebtn.Name = "savebtn";
            this.savebtn.ShadowDecoration.Parent = this.savebtn;
            this.savebtn.Size = new System.Drawing.Size(180, 45);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BorderRadius = 5;
            this.updatebtn.CheckedState.Parent = this.updatebtn;
            this.updatebtn.CustomImages.Parent = this.updatebtn;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.HoverState.Parent = this.updatebtn;
            this.updatebtn.Location = new System.Drawing.Point(352, 128);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.ShadowDecoration.Parent = this.updatebtn;
            this.updatebtn.Size = new System.Drawing.Size(180, 45);
            this.updatebtn.TabIndex = 11;
            this.updatebtn.Text = "Update";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.BorderRadius = 5;
            this.delbtn.CheckedState.Parent = this.delbtn;
            this.delbtn.CustomImages.Parent = this.delbtn;
            this.delbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delbtn.ForeColor = System.Drawing.Color.White;
            this.delbtn.HoverState.Parent = this.delbtn;
            this.delbtn.Location = new System.Drawing.Point(352, 194);
            this.delbtn.Name = "delbtn";
            this.delbtn.ShadowDecoration.Parent = this.delbtn;
            this.delbtn.Size = new System.Drawing.Size(180, 45);
            this.delbtn.TabIndex = 12;
            this.delbtn.Text = "Delete";
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select Teacher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Type the TeacherID";
            // 
            // searchbox
            // 
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.DefaultText = "";
            this.searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbox.DisabledState.Parent = this.searchbox;
            this.searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbox.FocusedState.Parent = this.searchbox;
            this.searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchbox.HoverState.Parent = this.searchbox;
            this.searchbox.Location = new System.Drawing.Point(599, 144);
            this.searchbox.Name = "searchbox";
            this.searchbox.PasswordChar = '\0';
            this.searchbox.PlaceholderText = "";
            this.searchbox.SelectedText = "";
            this.searchbox.ShadowDecoration.Parent = this.searchbox;
            this.searchbox.Size = new System.Drawing.Size(200, 29);
            this.searchbox.TabIndex = 15;
            // 
            // searchbtn
            // 
            this.searchbtn.BorderRadius = 5;
            this.searchbtn.CheckedState.Parent = this.searchbtn;
            this.searchbtn.CustomImages.Parent = this.searchbtn;
            this.searchbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.HoverState.Parent = this.searchbtn;
            this.searchbtn.Location = new System.Drawing.Point(602, 194);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.ShadowDecoration.Parent = this.searchbtn;
            this.searchbtn.Size = new System.Drawing.Size(180, 45);
            this.searchbtn.TabIndex = 16;
            this.searchbtn.Text = "Search";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
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
            this.escbtn.Location = new System.Drawing.Point(804, 8);
            this.escbtn.Name = "escbtn";
            this.escbtn.ShadowDecoration.Parent = this.escbtn;
            this.escbtn.Size = new System.Drawing.Size(39, 26);
            this.escbtn.TabIndex = 17;
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
            this.minbtn.Location = new System.Drawing.Point(758, 8);
            this.minbtn.Name = "minbtn";
            this.minbtn.ShadowDecoration.Parent = this.minbtn;
            this.minbtn.Size = new System.Drawing.Size(39, 26);
            this.minbtn.TabIndex = 18;
            this.minbtn.Text = "Min";
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // cmbbox
            // 
            this.cmbbox.BackColor = System.Drawing.Color.Transparent;
            this.cmbbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox.FocusedColor = System.Drawing.Color.Empty;
            this.cmbbox.FocusedState.Parent = this.cmbbox;
            this.cmbbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbox.FormattingEnabled = true;
            this.cmbbox.HoverState.Parent = this.cmbbox;
            this.cmbbox.ItemHeight = 20;
            this.cmbbox.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110"});
            this.cmbbox.ItemsAppearance.Parent = this.cmbbox;
            this.cmbbox.Location = new System.Drawing.Point(112, 316);
            this.cmbbox.Name = "cmbbox";
            this.cmbbox.ShadowDecoration.Parent = this.cmbbox;
            this.cmbbox.Size = new System.Drawing.Size(200, 26);
            this.cmbbox.TabIndex = 7;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(3, 37);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(849, 10);
            this.guna2Separator1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 30);
            this.panel1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Student Management Sys";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Email";
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.Parent = this.email;
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.FocusedState.Parent = this.email;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.HoverState.Parent = this.email;
            this.email.Location = new System.Drawing.Point(112, 236);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "";
            this.email.SelectedText = "";
            this.email.ShadowDecoration.Parent = this.email;
            this.email.Size = new System.Drawing.Size(200, 25);
            this.email.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "TeacherID";
            // 
            // teaid
            // 
            this.teaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.teaid.DefaultText = "";
            this.teaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.teaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.teaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.teaid.DisabledState.Parent = this.teaid;
            this.teaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.teaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.teaid.FocusedState.Parent = this.teaid;
            this.teaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.teaid.HoverState.Parent = this.teaid;
            this.teaid.Location = new System.Drawing.Point(112, 66);
            this.teaid.Name = "teaid";
            this.teaid.PasswordChar = '\0';
            this.teaid.PlaceholderText = "";
            this.teaid.SelectedText = "";
            this.teaid.ShadowDecoration.Parent = this.teaid;
            this.teaid.Size = new System.Drawing.Size(200, 25);
            this.teaid.TabIndex = 47;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(792, 53);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(51, 26);
            this.guna2Button1.TabIndex = 49;
            this.guna2Button1.Text = "GridView";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Crimson;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(713, 8);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(39, 26);
            this.guna2Button2.TabIndex = 50;
            this.guna2Button2.Text = "Back";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // lerror
            // 
            this.lerror.CheckedState.Parent = this.lerror;
            this.lerror.CustomImages.Parent = this.lerror;
            this.lerror.FillColor = System.Drawing.Color.Red;
            this.lerror.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lerror.ForeColor = System.Drawing.Color.White;
            this.lerror.HoverState.Parent = this.lerror;
            this.lerror.Location = new System.Drawing.Point(318, 156);
            this.lerror.Name = "lerror";
            this.lerror.PressedDepth = 0;
            this.lerror.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.lerror.ShadowDecoration.Parent = this.lerror;
            this.lerror.Size = new System.Drawing.Size(12, 13);
            this.lerror.TabIndex = 70;
            this.lerror.Visible = false;
            // 
            // ferror
            // 
            this.ferror.CheckedState.Parent = this.ferror;
            this.ferror.CustomImages.Parent = this.ferror;
            this.ferror.FillColor = System.Drawing.Color.Red;
            this.ferror.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ferror.ForeColor = System.Drawing.Color.White;
            this.ferror.HoverState.Parent = this.ferror;
            this.ferror.Location = new System.Drawing.Point(318, 116);
            this.ferror.Name = "ferror";
            this.ferror.PressedDepth = 0;
            this.ferror.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ferror.ShadowDecoration.Parent = this.ferror;
            this.ferror.Size = new System.Drawing.Size(12, 13);
            this.ferror.TabIndex = 69;
            this.ferror.Visible = false;
            // 
            // ciderror
            // 
            this.ciderror.CheckedState.Parent = this.ciderror;
            this.ciderror.CustomImages.Parent = this.ciderror;
            this.ciderror.FillColor = System.Drawing.Color.Red;
            this.ciderror.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ciderror.ForeColor = System.Drawing.Color.White;
            this.ciderror.HoverState.Parent = this.ciderror;
            this.ciderror.Location = new System.Drawing.Point(318, 322);
            this.ciderror.Name = "ciderror";
            this.ciderror.PressedDepth = 0;
            this.ciderror.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ciderror.ShadowDecoration.Parent = this.ciderror;
            this.ciderror.Size = new System.Drawing.Size(12, 13);
            this.ciderror.TabIndex = 68;
            this.ciderror.Visible = false;
            // 
            // generror
            // 
            this.generror.CheckedState.Parent = this.generror;
            this.generror.CustomImages.Parent = this.generror;
            this.generror.FillColor = System.Drawing.Color.Red;
            this.generror.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generror.ForeColor = System.Drawing.Color.White;
            this.generror.HoverState.Parent = this.generror;
            this.generror.Location = new System.Drawing.Point(318, 280);
            this.generror.Name = "generror";
            this.generror.PressedDepth = 0;
            this.generror.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.generror.ShadowDecoration.Parent = this.generror;
            this.generror.Size = new System.Drawing.Size(12, 13);
            this.generror.TabIndex = 67;
            this.generror.Visible = false;
            // 
            // emailerror
            // 
            this.emailerror.CheckedState.Parent = this.emailerror;
            this.emailerror.CustomImages.Parent = this.emailerror;
            this.emailerror.FillColor = System.Drawing.Color.Red;
            this.emailerror.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailerror.ForeColor = System.Drawing.Color.White;
            this.emailerror.HoverState.Parent = this.emailerror;
            this.emailerror.Location = new System.Drawing.Point(318, 241);
            this.emailerror.Name = "emailerror";
            this.emailerror.PressedDepth = 0;
            this.emailerror.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.emailerror.ShadowDecoration.Parent = this.emailerror;
            this.emailerror.Size = new System.Drawing.Size(12, 13);
            this.emailerror.TabIndex = 66;
            this.emailerror.Visible = false;
            // 
            // telerror
            // 
            this.telerror.CheckedState.Parent = this.telerror;
            this.telerror.CustomImages.Parent = this.telerror;
            this.telerror.FillColor = System.Drawing.Color.Red;
            this.telerror.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.telerror.ForeColor = System.Drawing.Color.White;
            this.telerror.HoverState.Parent = this.telerror;
            this.telerror.Location = new System.Drawing.Point(318, 207);
            this.telerror.Name = "telerror";
            this.telerror.PressedDepth = 0;
            this.telerror.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.telerror.ShadowDecoration.Parent = this.telerror;
            this.telerror.Size = new System.Drawing.Size(12, 13);
            this.telerror.TabIndex = 65;
            this.telerror.Visible = false;
            // 
            // error2
            // 
            this.error2.CheckedState.Parent = this.error2;
            this.error2.CustomImages.Parent = this.error2;
            this.error2.FillColor = System.Drawing.Color.Red;
            this.error2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.error2.ForeColor = System.Drawing.Color.White;
            this.error2.HoverState.Parent = this.error2;
            this.error2.Location = new System.Drawing.Point(804, 148);
            this.error2.Name = "error2";
            this.error2.PressedDepth = 0;
            this.error2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.error2.ShadowDecoration.Parent = this.error2;
            this.error2.Size = new System.Drawing.Size(12, 13);
            this.error2.TabIndex = 64;
            this.error2.Visible = false;
            // 
            // error
            // 
            this.error.CheckedState.Parent = this.error;
            this.error.CustomImages.Parent = this.error;
            this.error.FillColor = System.Drawing.Color.Red;
            this.error.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.error.ForeColor = System.Drawing.Color.White;
            this.error.HoverState.Parent = this.error;
            this.error.Location = new System.Drawing.Point(318, 71);
            this.error.Name = "error";
            this.error.PressedDepth = 0;
            this.error.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.error.ShadowDecoration.Parent = this.error;
            this.error.Size = new System.Drawing.Size(12, 13);
            this.error.TabIndex = 63;
            this.error.Visible = false;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(854, 388);
            this.Controls.Add(this.lerror);
            this.Controls.Add(this.ferror);
            this.Controls.Add(this.ciderror);
            this.Controls.Add(this.generror);
            this.Controls.Add(this.emailerror);
            this.Controls.Add(this.telerror);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.teaid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.email);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.cmbbox);
            this.Controls.Add(this.minbtn);
            this.Controls.Add(this.escbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox lname;
        private Guna.UI2.WinForms.Guna2TextBox fname;
        private Guna.UI2.WinForms.Guna2TextBox tel;
        private Guna.UI2.WinForms.Guna2CheckBox male;
        private Guna.UI2.WinForms.Guna2CheckBox female;
        private Guna.UI2.WinForms.Guna2Button savebtn;
        private Guna.UI2.WinForms.Guna2Button updatebtn;
        private Guna.UI2.WinForms.Guna2Button delbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox searchbox;
        private Guna.UI2.WinForms.Guna2Button searchbtn;
        private Guna.UI2.WinForms.Guna2Button escbtn;
        private Guna.UI2.WinForms.Guna2Button minbtn;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox teaid;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2CircleButton lerror;
        private Guna.UI2.WinForms.Guna2CircleButton ferror;
        private Guna.UI2.WinForms.Guna2CircleButton ciderror;
        private Guna.UI2.WinForms.Guna2CircleButton generror;
        private Guna.UI2.WinForms.Guna2CircleButton emailerror;
        private Guna.UI2.WinForms.Guna2CircleButton telerror;
        private Guna.UI2.WinForms.Guna2CircleButton error2;
        private Guna.UI2.WinForms.Guna2CircleButton error;
    }
}