namespace Moon_Archie_Winforms_NEA
{
    partial class Edit_User_Info_Frm
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
            this.EmployeeID_Selector_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.EmployeeId_Lbl = new System.Windows.Forms.Label();
            this.PhoneNumber_Lbl = new System.Windows.Forms.Label();
            this.Confirm_Password_Pnl = new System.Windows.Forms.Panel();
            this.Close_Confirm_Password_Btn = new System.Windows.Forms.Button();
            this.Confirm_Password_Btn = new System.Windows.Forms.Button();
            this.Confirm_Password_TxtBox = new System.Windows.Forms.TextBox();
            this.Confirm_Password_Lbl = new System.Windows.Forms.Label();
            this.Database_Users_GridView = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSearchDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Edit_User_Lbl = new System.Windows.Forms.Label();
            this.Title_Underline_Lbl = new System.Windows.Forms.Label();
            this.Name_TxtBox = new System.Windows.Forms.TextBox();
            this.Email_TxtBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_TxtBox = new System.Windows.Forms.TextBox();
            this.Username_TxtBox = new System.Windows.Forms.TextBox();
            this.Password_TxtBox = new System.Windows.Forms.TextBox();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.Email_Lbl = new System.Windows.Forms.Label();
            this.Phone_Number_Lbl = new System.Windows.Forms.Label();
            this.Username_Lbl = new System.Windows.Forms.Label();
            this.Password_Lbl = new System.Windows.Forms.Label();
            this.Permission_Lbl = new System.Windows.Forms.Label();
            this.Permission_GroupBox = new System.Windows.Forms.GroupBox();
            this.Employee_Permision_RBtn = new System.Windows.Forms.RadioButton();
            this.Manager_Permision_RBtn = new System.Windows.Forms.RadioButton();
            this.Select_Btn = new System.Windows.Forms.Button();
            this.New_Password_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeID_Selector_NumericUpDown)).BeginInit();
            this.Confirm_Password_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Database_Users_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSearchDetailsBindingSource)).BeginInit();
            this.Permission_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeID_Selector_NumericUpDown
            // 
            this.EmployeeID_Selector_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeID_Selector_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID_Selector_NumericUpDown.Location = new System.Drawing.Point(188, 390);
            this.EmployeeID_Selector_NumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.EmployeeID_Selector_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EmployeeID_Selector_NumericUpDown.Name = "EmployeeID_Selector_NumericUpDown";
            this.EmployeeID_Selector_NumericUpDown.Size = new System.Drawing.Size(84, 38);
            this.EmployeeID_Selector_NumericUpDown.TabIndex = 66;
            this.EmployeeID_Selector_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Update_Btn
            // 
            this.Update_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Update_Btn.FlatAppearance.BorderSize = 0;
            this.Update_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Update_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Update_Btn.Location = new System.Drawing.Point(755, 390);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(156, 44);
            this.Update_Btn.TabIndex = 65;
            this.Update_Btn.Text = "Update";
            this.Update_Btn.UseVisualStyleBackColor = false;
            this.Update_Btn.Visible = false;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // EmployeeId_Lbl
            // 
            this.EmployeeId_Lbl.AutoSize = true;
            this.EmployeeId_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeId_Lbl.Location = new System.Drawing.Point(20, 393);
            this.EmployeeId_Lbl.Name = "EmployeeId_Lbl";
            this.EmployeeId_Lbl.Size = new System.Drawing.Size(162, 32);
            this.EmployeeId_Lbl.TabIndex = 64;
            this.EmployeeId_Lbl.Text = "EmployeeID";
            // 
            // PhoneNumber_Lbl
            // 
            this.PhoneNumber_Lbl.AutoSize = true;
            this.PhoneNumber_Lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_Lbl.Location = new System.Drawing.Point(599, 377);
            this.PhoneNumber_Lbl.Name = "PhoneNumber_Lbl";
            this.PhoneNumber_Lbl.Size = new System.Drawing.Size(0, 37);
            this.PhoneNumber_Lbl.TabIndex = 63;
            // 
            // Confirm_Password_Pnl
            // 
            this.Confirm_Password_Pnl.Controls.Add(this.Close_Confirm_Password_Btn);
            this.Confirm_Password_Pnl.Controls.Add(this.Confirm_Password_Btn);
            this.Confirm_Password_Pnl.Controls.Add(this.Confirm_Password_TxtBox);
            this.Confirm_Password_Pnl.Controls.Add(this.Confirm_Password_Lbl);
            this.Confirm_Password_Pnl.Location = new System.Drawing.Point(746, 445);
            this.Confirm_Password_Pnl.Name = "Confirm_Password_Pnl";
            this.Confirm_Password_Pnl.Size = new System.Drawing.Size(640, 203);
            this.Confirm_Password_Pnl.TabIndex = 62;
            this.Confirm_Password_Pnl.Visible = false;
            // 
            // Close_Confirm_Password_Btn
            // 
            this.Close_Confirm_Password_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Confirm_Password_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Confirm_Password_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Confirm_Password_Btn.Location = new System.Drawing.Point(527, 107);
            this.Close_Confirm_Password_Btn.Name = "Close_Confirm_Password_Btn";
            this.Close_Confirm_Password_Btn.Size = new System.Drawing.Size(106, 45);
            this.Close_Confirm_Password_Btn.TabIndex = 26;
            this.Close_Confirm_Password_Btn.Text = "Close";
            this.Close_Confirm_Password_Btn.UseVisualStyleBackColor = true;
            this.Close_Confirm_Password_Btn.Click += new System.EventHandler(this.Close_Confirm_Password_Btn_Click);
            // 
            // Confirm_Password_Btn
            // 
            this.Confirm_Password_Btn.BackColor = System.Drawing.Color.Green;
            this.Confirm_Password_Btn.FlatAppearance.BorderSize = 0;
            this.Confirm_Password_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.Confirm_Password_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_Password_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Password_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Confirm_Password_Btn.Location = new System.Drawing.Point(9, 107);
            this.Confirm_Password_Btn.Name = "Confirm_Password_Btn";
            this.Confirm_Password_Btn.Size = new System.Drawing.Size(164, 45);
            this.Confirm_Password_Btn.TabIndex = 25;
            this.Confirm_Password_Btn.Text = "Confirm";
            this.Confirm_Password_Btn.UseVisualStyleBackColor = false;
            this.Confirm_Password_Btn.Click += new System.EventHandler(this.Confirm_Password_Btn_Click);
            // 
            // Confirm_Password_TxtBox
            // 
            this.Confirm_Password_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.Confirm_Password_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Confirm_Password_TxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Password_TxtBox.Location = new System.Drawing.Point(9, 47);
            this.Confirm_Password_TxtBox.Name = "Confirm_Password_TxtBox";
            this.Confirm_Password_TxtBox.Size = new System.Drawing.Size(624, 44);
            this.Confirm_Password_TxtBox.TabIndex = 24;
            // 
            // Confirm_Password_Lbl
            // 
            this.Confirm_Password_Lbl.AutoSize = true;
            this.Confirm_Password_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Password_Lbl.Location = new System.Drawing.Point(3, 12);
            this.Confirm_Password_Lbl.Name = "Confirm_Password_Lbl";
            this.Confirm_Password_Lbl.Size = new System.Drawing.Size(592, 32);
            this.Confirm_Password_Lbl.TabIndex = 21;
            this.Confirm_Password_Lbl.Text = "To confirm changes please enter your password";
            // 
            // Database_Users_GridView
            // 
            this.Database_Users_GridView.AllowUserToAddRows = false;
            this.Database_Users_GridView.AllowUserToDeleteRows = false;
            this.Database_Users_GridView.AutoGenerateColumns = false;
            this.Database_Users_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Database_Users_GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Database_Users_GridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Database_Users_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database_Users_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.Database_Users_GridView.DataSource = this.employeeSearchDetailsBindingSource;
            this.Database_Users_GridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Database_Users_GridView.Location = new System.Drawing.Point(24, 122);
            this.Database_Users_GridView.Margin = new System.Windows.Forms.Padding(4);
            this.Database_Users_GridView.Name = "Database_Users_GridView";
            this.Database_Users_GridView.ReadOnly = true;
            this.Database_Users_GridView.RowHeadersWidth = 82;
            this.Database_Users_GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Database_Users_GridView.RowTemplate.Height = 33;
            this.Database_Users_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Database_Users_GridView.Size = new System.Drawing.Size(1393, 252);
            this.Database_Users_GridView.TabIndex = 61;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 172;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 155;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 143;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 110;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 194;
            // 
            // employeeSearchDetailsBindingSource
            // 
            this.employeeSearchDetailsBindingSource.DataSource = typeof(Moon_Archie_Winforms_NEA.Employee_Search_Details);
            // 
            // Edit_User_Lbl
            // 
            this.Edit_User_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Edit_User_Lbl.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_User_Lbl.Location = new System.Drawing.Point(12, 19);
            this.Edit_User_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Edit_User_Lbl.Name = "Edit_User_Lbl";
            this.Edit_User_Lbl.Size = new System.Drawing.Size(514, 69);
            this.Edit_User_Lbl.TabIndex = 59;
            this.Edit_User_Lbl.Text = "Edit User Details";
            // 
            // Title_Underline_Lbl
            // 
            this.Title_Underline_Lbl.AutoSize = true;
            this.Title_Underline_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Title_Underline_Lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title_Underline_Lbl.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Underline_Lbl.Location = new System.Drawing.Point(10, 69);
            this.Title_Underline_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title_Underline_Lbl.Name = "Title_Underline_Lbl";
            this.Title_Underline_Lbl.Size = new System.Drawing.Size(1426, 24);
            this.Title_Underline_Lbl.TabIndex = 60;
            this.Title_Underline_Lbl.Text = "_________________________________________________________________________________" +
    "_____________________________________";
            // 
            // Name_TxtBox
            // 
            this.Name_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.Name_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_TxtBox.Enabled = false;
            this.Name_TxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_TxtBox.Location = new System.Drawing.Point(114, 440);
            this.Name_TxtBox.Name = "Name_TxtBox";
            this.Name_TxtBox.Size = new System.Drawing.Size(545, 37);
            this.Name_TxtBox.TabIndex = 67;
            // 
            // Email_TxtBox
            // 
            this.Email_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.Email_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email_TxtBox.Enabled = false;
            this.Email_TxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_TxtBox.Location = new System.Drawing.Point(114, 495);
            this.Email_TxtBox.Name = "Email_TxtBox";
            this.Email_TxtBox.Size = new System.Drawing.Size(545, 37);
            this.Email_TxtBox.TabIndex = 68;
            // 
            // PhoneNumber_TxtBox
            // 
            this.PhoneNumber_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.PhoneNumber_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumber_TxtBox.Enabled = false;
            this.PhoneNumber_TxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_TxtBox.Location = new System.Drawing.Point(228, 549);
            this.PhoneNumber_TxtBox.Name = "PhoneNumber_TxtBox";
            this.PhoneNumber_TxtBox.Size = new System.Drawing.Size(436, 37);
            this.PhoneNumber_TxtBox.TabIndex = 69;
            this.PhoneNumber_TxtBox.Text = "+44";
            // 
            // Username_TxtBox
            // 
            this.Username_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.Username_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_TxtBox.Enabled = false;
            this.Username_TxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_TxtBox.Location = new System.Drawing.Point(167, 603);
            this.Username_TxtBox.Name = "Username_TxtBox";
            this.Username_TxtBox.Size = new System.Drawing.Size(492, 37);
            this.Username_TxtBox.TabIndex = 70;
            // 
            // Password_TxtBox
            // 
            this.Password_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.Password_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_TxtBox.Enabled = false;
            this.Password_TxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TxtBox.Location = new System.Drawing.Point(161, 657);
            this.Password_TxtBox.Name = "Password_TxtBox";
            this.Password_TxtBox.ReadOnly = true;
            this.Password_TxtBox.Size = new System.Drawing.Size(365, 37);
            this.Password_TxtBox.TabIndex = 71;
            this.Password_TxtBox.UseSystemPasswordChar = true;
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Lbl.Location = new System.Drawing.Point(21, 445);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(85, 32);
            this.Name_Lbl.TabIndex = 73;
            this.Name_Lbl.Text = "Name";
            // 
            // Email_Lbl
            // 
            this.Email_Lbl.AutoSize = true;
            this.Email_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Lbl.Location = new System.Drawing.Point(21, 500);
            this.Email_Lbl.Name = "Email_Lbl";
            this.Email_Lbl.Size = new System.Drawing.Size(81, 32);
            this.Email_Lbl.TabIndex = 74;
            this.Email_Lbl.Text = "Email";
            // 
            // Phone_Number_Lbl
            // 
            this.Phone_Number_Lbl.AutoSize = true;
            this.Phone_Number_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Number_Lbl.Location = new System.Drawing.Point(21, 554);
            this.Phone_Number_Lbl.Name = "Phone_Number_Lbl";
            this.Phone_Number_Lbl.Size = new System.Drawing.Size(194, 32);
            this.Phone_Number_Lbl.TabIndex = 75;
            this.Phone_Number_Lbl.Text = "Phone Number";
            // 
            // Username_Lbl
            // 
            this.Username_Lbl.AutoSize = true;
            this.Username_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Lbl.Location = new System.Drawing.Point(21, 608);
            this.Username_Lbl.Name = "Username_Lbl";
            this.Username_Lbl.Size = new System.Drawing.Size(138, 32);
            this.Username_Lbl.TabIndex = 76;
            this.Username_Lbl.Text = "Username";
            // 
            // Password_Lbl
            // 
            this.Password_Lbl.AutoSize = true;
            this.Password_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Lbl.Location = new System.Drawing.Point(21, 662);
            this.Password_Lbl.Name = "Password_Lbl";
            this.Password_Lbl.Size = new System.Drawing.Size(132, 32);
            this.Password_Lbl.TabIndex = 77;
            this.Password_Lbl.Text = "Password";
            // 
            // Permission_Lbl
            // 
            this.Permission_Lbl.AutoSize = true;
            this.Permission_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Permission_Lbl.Location = new System.Drawing.Point(21, 715);
            this.Permission_Lbl.Name = "Permission_Lbl";
            this.Permission_Lbl.Size = new System.Drawing.Size(147, 32);
            this.Permission_Lbl.TabIndex = 78;
            this.Permission_Lbl.Text = "Permission";
            // 
            // Permission_GroupBox
            // 
            this.Permission_GroupBox.Controls.Add(this.Employee_Permision_RBtn);
            this.Permission_GroupBox.Controls.Add(this.Manager_Permision_RBtn);
            this.Permission_GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Permission_GroupBox.Location = new System.Drawing.Point(174, 692);
            this.Permission_GroupBox.Name = "Permission_GroupBox";
            this.Permission_GroupBox.Size = new System.Drawing.Size(418, 71);
            this.Permission_GroupBox.TabIndex = 79;
            this.Permission_GroupBox.TabStop = false;
            // 
            // Employee_Permision_RBtn
            // 
            this.Employee_Permision_RBtn.AutoSize = true;
            this.Employee_Permision_RBtn.Enabled = false;
            this.Employee_Permision_RBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Permision_RBtn.Location = new System.Drawing.Point(218, 19);
            this.Employee_Permision_RBtn.Name = "Employee_Permision_RBtn";
            this.Employee_Permision_RBtn.Size = new System.Drawing.Size(176, 37);
            this.Employee_Permision_RBtn.TabIndex = 52;
            this.Employee_Permision_RBtn.TabStop = true;
            this.Employee_Permision_RBtn.Text = "Employee";
            this.Employee_Permision_RBtn.UseVisualStyleBackColor = true;
            // 
            // Manager_Permision_RBtn
            // 
            this.Manager_Permision_RBtn.AutoSize = true;
            this.Manager_Permision_RBtn.Enabled = false;
            this.Manager_Permision_RBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manager_Permision_RBtn.Location = new System.Drawing.Point(6, 19);
            this.Manager_Permision_RBtn.Name = "Manager_Permision_RBtn";
            this.Manager_Permision_RBtn.Size = new System.Drawing.Size(160, 37);
            this.Manager_Permision_RBtn.TabIndex = 51;
            this.Manager_Permision_RBtn.TabStop = true;
            this.Manager_Permision_RBtn.Text = "Manager";
            this.Manager_Permision_RBtn.UseVisualStyleBackColor = true;
            // 
            // Select_Btn
            // 
            this.Select_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Select_Btn.FlatAppearance.BorderSize = 0;
            this.Select_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Select_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Select_Btn.Location = new System.Drawing.Point(290, 391);
            this.Select_Btn.Name = "Select_Btn";
            this.Select_Btn.Size = new System.Drawing.Size(45, 44);
            this.Select_Btn.TabIndex = 80;
            this.Select_Btn.Text = "✓";
            this.Select_Btn.UseVisualStyleBackColor = false;
            this.Select_Btn.Click += new System.EventHandler(this.Select_Btn_Click);
            // 
            // New_Password_Btn
            // 
            this.New_Password_Btn.BackColor = System.Drawing.SystemColors.Control;
            this.New_Password_Btn.FlatAppearance.BorderSize = 0;
            this.New_Password_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.New_Password_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Password_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Password_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.New_Password_Btn.Location = new System.Drawing.Point(547, 654);
            this.New_Password_Btn.Name = "New_Password_Btn";
            this.New_Password_Btn.Size = new System.Drawing.Size(45, 44);
            this.New_Password_Btn.TabIndex = 81;
            this.New_Password_Btn.Text = "X";
            this.New_Password_Btn.UseVisualStyleBackColor = false;
            this.New_Password_Btn.Visible = false;
            this.New_Password_Btn.Click += new System.EventHandler(this.New_Password_Btn_Click);
            // 
            // Edit_User_Info_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 819);
            this.Controls.Add(this.New_Password_Btn);
            this.Controls.Add(this.Select_Btn);
            this.Controls.Add(this.Permission_GroupBox);
            this.Controls.Add(this.Permission_Lbl);
            this.Controls.Add(this.Password_Lbl);
            this.Controls.Add(this.Username_Lbl);
            this.Controls.Add(this.Phone_Number_Lbl);
            this.Controls.Add(this.Email_Lbl);
            this.Controls.Add(this.Name_Lbl);
            this.Controls.Add(this.Password_TxtBox);
            this.Controls.Add(this.Username_TxtBox);
            this.Controls.Add(this.PhoneNumber_TxtBox);
            this.Controls.Add(this.Email_TxtBox);
            this.Controls.Add(this.Name_TxtBox);
            this.Controls.Add(this.EmployeeID_Selector_NumericUpDown);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.EmployeeId_Lbl);
            this.Controls.Add(this.PhoneNumber_Lbl);
            this.Controls.Add(this.Confirm_Password_Pnl);
            this.Controls.Add(this.Database_Users_GridView);
            this.Controls.Add(this.Edit_User_Lbl);
            this.Controls.Add(this.Title_Underline_Lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_User_Info_Frm";
            this.Text = "Edit_User_Info_Frm";
            this.Load += new System.EventHandler(this.Edit_User_Info_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeID_Selector_NumericUpDown)).EndInit();
            this.Confirm_Password_Pnl.ResumeLayout(false);
            this.Confirm_Password_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Database_Users_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSearchDetailsBindingSource)).EndInit();
            this.Permission_GroupBox.ResumeLayout(false);
            this.Permission_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown EmployeeID_Selector_NumericUpDown;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Label EmployeeId_Lbl;
        private System.Windows.Forms.Label PhoneNumber_Lbl;
        private System.Windows.Forms.Panel Confirm_Password_Pnl;
        private System.Windows.Forms.Button Close_Confirm_Password_Btn;
        private System.Windows.Forms.Button Confirm_Password_Btn;
        private System.Windows.Forms.TextBox Confirm_Password_TxtBox;
        private System.Windows.Forms.Label Confirm_Password_Lbl;
        private System.Windows.Forms.DataGridView Database_Users_GridView;
        private System.Windows.Forms.Label Edit_User_Lbl;
        private System.Windows.Forms.Label Title_Underline_Lbl;
        private System.Windows.Forms.TextBox Name_TxtBox;
        private System.Windows.Forms.TextBox Email_TxtBox;
        private System.Windows.Forms.TextBox PhoneNumber_TxtBox;
        private System.Windows.Forms.TextBox Username_TxtBox;
        private System.Windows.Forms.TextBox Password_TxtBox;
        private System.Windows.Forms.Label Name_Lbl;
        private System.Windows.Forms.Label Email_Lbl;
        private System.Windows.Forms.Label Phone_Number_Lbl;
        private System.Windows.Forms.Label Username_Lbl;
        private System.Windows.Forms.Label Password_Lbl;
        private System.Windows.Forms.Label Permission_Lbl;
        private System.Windows.Forms.GroupBox Permission_GroupBox;
        private System.Windows.Forms.RadioButton Employee_Permision_RBtn;
        private System.Windows.Forms.RadioButton Manager_Permision_RBtn;
        private System.Windows.Forms.Button Select_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeSearchDetailsBindingSource;
        private System.Windows.Forms.Button New_Password_Btn;
    }
}