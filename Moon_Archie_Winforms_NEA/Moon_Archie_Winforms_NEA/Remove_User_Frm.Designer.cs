namespace Moon_Archie_Winforms_NEA
{
    partial class Remove_User_Frm
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
            this.Remove_User_Lbl = new System.Windows.Forms.Label();
            this.Title_Underline_Lbl = new System.Windows.Forms.Label();
            this.Database_Users_GridView = new System.Windows.Forms.DataGridView();
            this.Confirm_Password_Pnl = new System.Windows.Forms.Panel();
            this.Close_Confirm_Password_Btn = new System.Windows.Forms.Button();
            this.Confirm_Password_Btn = new System.Windows.Forms.Button();
            this.Confirm_Password_TxtBox = new System.Windows.Forms.TextBox();
            this.Confirm_Password_Lbl = new System.Windows.Forms.Label();
            this.PhoneNumber_Lbl = new System.Windows.Forms.Label();
            this.EmployeeId_Lbl = new System.Windows.Forms.Label();
            this.Remove_Btn = new System.Windows.Forms.Button();
            this.EmployeeID_Selector_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.employeeSearchDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Database_Users_GridView)).BeginInit();
            this.Confirm_Password_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeID_Selector_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSearchDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Remove_User_Lbl
            // 
            this.Remove_User_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Remove_User_Lbl.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_User_Lbl.Location = new System.Drawing.Point(12, 19);
            this.Remove_User_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Remove_User_Lbl.Name = "Remove_User_Lbl";
            this.Remove_User_Lbl.Size = new System.Drawing.Size(514, 69);
            this.Remove_User_Lbl.TabIndex = 27;
            this.Remove_User_Lbl.Text = "Remove User";
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
            this.Title_Underline_Lbl.TabIndex = 28;
            this.Title_Underline_Lbl.Text = "_________________________________________________________________________________" +
    "_____________________________________";
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
            this.Database_Users_GridView.TabIndex = 29;
            // 
            // Confirm_Password_Pnl
            // 
            this.Confirm_Password_Pnl.Controls.Add(this.Close_Confirm_Password_Btn);
            this.Confirm_Password_Pnl.Controls.Add(this.Confirm_Password_Btn);
            this.Confirm_Password_Pnl.Controls.Add(this.Confirm_Password_TxtBox);
            this.Confirm_Password_Pnl.Controls.Add(this.Confirm_Password_Lbl);
            this.Confirm_Password_Pnl.Location = new System.Drawing.Point(402, 485);
            this.Confirm_Password_Pnl.Name = "Confirm_Password_Pnl";
            this.Confirm_Password_Pnl.Size = new System.Drawing.Size(640, 203);
            this.Confirm_Password_Pnl.TabIndex = 54;
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
            this.Confirm_Password_Lbl.Size = new System.Drawing.Size(481, 32);
            this.Confirm_Password_Lbl.TabIndex = 21;
            this.Confirm_Password_Lbl.Text = "To confirm please enter your password";
            // 
            // PhoneNumber_Lbl
            // 
            this.PhoneNumber_Lbl.AutoSize = true;
            this.PhoneNumber_Lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_Lbl.Location = new System.Drawing.Point(599, 391);
            this.PhoneNumber_Lbl.Name = "PhoneNumber_Lbl";
            this.PhoneNumber_Lbl.Size = new System.Drawing.Size(0, 37);
            this.PhoneNumber_Lbl.TabIndex = 55;
            // 
            // EmployeeId_Lbl
            // 
            this.EmployeeId_Lbl.AutoSize = true;
            this.EmployeeId_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeId_Lbl.Location = new System.Drawing.Point(20, 407);
            this.EmployeeId_Lbl.Name = "EmployeeId_Lbl";
            this.EmployeeId_Lbl.Size = new System.Drawing.Size(162, 32);
            this.EmployeeId_Lbl.TabIndex = 56;
            this.EmployeeId_Lbl.Text = "EmployeeID";
            // 
            // Remove_Btn
            // 
            this.Remove_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Remove_Btn.FlatAppearance.BorderSize = 0;
            this.Remove_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Remove_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Remove_Btn.Location = new System.Drawing.Point(26, 459);
            this.Remove_Btn.Name = "Remove_Btn";
            this.Remove_Btn.Size = new System.Drawing.Size(156, 45);
            this.Remove_Btn.TabIndex = 57;
            this.Remove_Btn.Text = "Remove";
            this.Remove_Btn.UseVisualStyleBackColor = false;
            this.Remove_Btn.Click += new System.EventHandler(this.Remove_Btn_Click);
            // 
            // EmployeeID_Selector_NumericUpDown
            // 
            this.EmployeeID_Selector_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeID_Selector_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID_Selector_NumericUpDown.Location = new System.Drawing.Point(188, 404);
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
            this.EmployeeID_Selector_NumericUpDown.TabIndex = 58;
            this.EmployeeID_Selector_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // employeeSearchDetailsBindingSource
            // 
            this.employeeSearchDetailsBindingSource.DataSource = typeof(Moon_Archie_Winforms_NEA.Employee_Search_Details);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeIDDataGridViewTextBoxColumn.Width = 172;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 155;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 143;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 110;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 194;
            // 
            // Remove_User_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 819);
            this.Controls.Add(this.EmployeeID_Selector_NumericUpDown);
            this.Controls.Add(this.Remove_Btn);
            this.Controls.Add(this.EmployeeId_Lbl);
            this.Controls.Add(this.PhoneNumber_Lbl);
            this.Controls.Add(this.Confirm_Password_Pnl);
            this.Controls.Add(this.Database_Users_GridView);
            this.Controls.Add(this.Remove_User_Lbl);
            this.Controls.Add(this.Title_Underline_Lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Remove_User_Frm";
            this.Text = "Remove_User_Frm";
            this.Load += new System.EventHandler(this.Remove_User_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database_Users_GridView)).EndInit();
            this.Confirm_Password_Pnl.ResumeLayout(false);
            this.Confirm_Password_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeID_Selector_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSearchDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Remove_User_Lbl;
        private System.Windows.Forms.Label Title_Underline_Lbl;
        private System.Windows.Forms.DataGridView Database_Users_GridView;
        private System.Windows.Forms.BindingSource employeeSearchDetailsBindingSource;
        private System.Windows.Forms.Panel Confirm_Password_Pnl;
        private System.Windows.Forms.Button Close_Confirm_Password_Btn;
        private System.Windows.Forms.Button Confirm_Password_Btn;
        private System.Windows.Forms.TextBox Confirm_Password_TxtBox;
        private System.Windows.Forms.Label Confirm_Password_Lbl;
        private System.Windows.Forms.Label PhoneNumber_Lbl;
        private System.Windows.Forms.Label EmployeeId_Lbl;
        private System.Windows.Forms.Button Remove_Btn;
        private System.Windows.Forms.NumericUpDown EmployeeID_Selector_NumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    }
}