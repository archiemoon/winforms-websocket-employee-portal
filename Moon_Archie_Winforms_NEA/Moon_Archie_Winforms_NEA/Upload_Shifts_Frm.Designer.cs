namespace Moon_Archie_Winforms_NEA
{
    partial class Upload_Shifts_Frm
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
            this.Date_Time_Picker = new System.Windows.Forms.DateTimePicker();
            this.Hours_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Date_Time_Lbl = new System.Windows.Forms.Label();
            this.Hours_Lbl = new System.Windows.Forms.Label();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.Current_Shifts_DataGridView = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimeShiftInfoClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Hours_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Current_Shifts_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeShiftInfoClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Date_Time_Picker
            // 
            this.Date_Time_Picker.CustomFormat = "ddd(dd) HH:mm";
            this.Date_Time_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Time_Picker.Location = new System.Drawing.Point(48, 75);
            this.Date_Time_Picker.Name = "Date_Time_Picker";
            this.Date_Time_Picker.Size = new System.Drawing.Size(221, 31);
            this.Date_Time_Picker.TabIndex = 1;
            this.Date_Time_Picker.Value = new System.DateTime(2024, 2, 5, 0, 0, 0, 0);
            // 
            // Hours_NumericUpDown
            // 
            this.Hours_NumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.Hours_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hours_NumericUpDown.DecimalPlaces = 1;
            this.Hours_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours_NumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Hours_NumericUpDown.Location = new System.Drawing.Point(48, 159);
            this.Hours_NumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Hours_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Hours_NumericUpDown.Name = "Hours_NumericUpDown";
            this.Hours_NumericUpDown.ReadOnly = true;
            this.Hours_NumericUpDown.Size = new System.Drawing.Size(73, 31);
            this.Hours_NumericUpDown.TabIndex = 59;
            this.Hours_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Date_Time_Lbl
            // 
            this.Date_Time_Lbl.AutoSize = true;
            this.Date_Time_Lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Time_Lbl.Location = new System.Drawing.Point(43, 44);
            this.Date_Time_Lbl.Name = "Date_Time_Lbl";
            this.Date_Time_Lbl.Size = new System.Drawing.Size(226, 27);
            this.Date_Time_Lbl.TabIndex = 60;
            this.Date_Time_Lbl.Text = "Date and Start Time";
            // 
            // Hours_Lbl
            // 
            this.Hours_Lbl.AutoSize = true;
            this.Hours_Lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours_Lbl.Location = new System.Drawing.Point(44, 129);
            this.Hours_Lbl.Name = "Hours_Lbl";
            this.Hours_Lbl.Size = new System.Drawing.Size(196, 27);
            this.Hours_Lbl.TabIndex = 61;
            this.Hours_Lbl.Text = "Number of Hours";
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Add_Btn.FlatAppearance.BorderSize = 0;
            this.Add_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Add_Btn.Location = new System.Drawing.Point(48, 225);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(110, 44);
            this.Add_Btn.TabIndex = 66;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Clear_Btn.FlatAppearance.BorderSize = 0;
            this.Clear_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Clear_Btn.Location = new System.Drawing.Point(634, 707);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(110, 44);
            this.Clear_Btn.TabIndex = 67;
            this.Clear_Btn.Text = "Clear";
            this.Clear_Btn.UseVisualStyleBackColor = false;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // Current_Shifts_DataGridView
            // 
            this.Current_Shifts_DataGridView.AllowUserToAddRows = false;
            this.Current_Shifts_DataGridView.AllowUserToDeleteRows = false;
            this.Current_Shifts_DataGridView.AutoGenerateColumns = false;
            this.Current_Shifts_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Current_Shifts_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Current_Shifts_DataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Current_Shifts_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Current_Shifts_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn});
            this.Current_Shifts_DataGridView.DataSource = this.overtimeShiftInfoClassBindingSource;
            this.Current_Shifts_DataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Current_Shifts_DataGridView.Location = new System.Drawing.Point(636, 10);
            this.Current_Shifts_DataGridView.Name = "Current_Shifts_DataGridView";
            this.Current_Shifts_DataGridView.ReadOnly = true;
            this.Current_Shifts_DataGridView.RowHeadersWidth = 82;
            this.Current_Shifts_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Current_Shifts_DataGridView.RowTemplate.Height = 33;
            this.Current_Shifts_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Current_Shifts_DataGridView.Size = new System.Drawing.Size(792, 688);
            this.Current_Shifts_DataGridView.TabIndex = 68;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 172;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayDataGridViewTextBoxColumn.Width = 95;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 161;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursDataGridViewTextBoxColumn.Width = 114;
            // 
            // overtimeShiftInfoClassBindingSource
            // 
            this.overtimeShiftInfoClassBindingSource.DataSource = typeof(Moon_Archie_Winforms_NEA.Overtime_Shift_Info_Class);
            // 
            // Upload_Shifts_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 819);
            this.Controls.Add(this.Current_Shifts_DataGridView);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Hours_Lbl);
            this.Controls.Add(this.Date_Time_Lbl);
            this.Controls.Add(this.Hours_NumericUpDown);
            this.Controls.Add(this.Date_Time_Picker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Upload_Shifts_Frm";
            this.Text = "Upload_Shifts_Frm";
            this.Load += new System.EventHandler(this.Upload_Shifts_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hours_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Current_Shifts_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeShiftInfoClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Date_Time_Picker;
        private System.Windows.Forms.NumericUpDown Hours_NumericUpDown;
        private System.Windows.Forms.Label Date_Time_Lbl;
        private System.Windows.Forms.Label Hours_Lbl;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Clear_Btn;
        private System.Windows.Forms.DataGridView Current_Shifts_DataGridView;
        private System.Windows.Forms.BindingSource overtimeShiftInfoClassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
    }
}