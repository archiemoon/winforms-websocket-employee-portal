namespace Moon_Archie_Winforms_NEA
{
    partial class PaySlip_Window
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
            this.Template_CheckBox = new System.Windows.Forms.CheckedListBox();
            this.Position_Lbl = new System.Windows.Forms.Label();
            this.Template_Lbl = new System.Windows.Forms.Label();
            this.Site_Lbl = new System.Windows.Forms.Label();
            this.Site_CheckBox = new System.Windows.Forms.CheckedListBox();
            this.Hours_Worked_Lbl = new System.Windows.Forms.Label();
            this.Hours_Worked_TxtBox = new System.Windows.Forms.TextBox();
            this.Confirm_Password_Pnl = new System.Windows.Forms.Panel();
            this.Submit_Btn = new System.Windows.Forms.Button();
            this.Confirm_Password_Btn = new System.Windows.Forms.Button();
            this.Confirm_Password_TxtBox = new System.Windows.Forms.TextBox();
            this.Confirm_Password_Lbl = new System.Windows.Forms.Label();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.Position_CheckBox = new System.Windows.Forms.CheckedListBox();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.Confirm_Password_Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Template_CheckBox
            // 
            this.Template_CheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.Template_CheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Template_CheckBox.CheckOnClick = true;
            this.Template_CheckBox.FormattingEnabled = true;
            this.Template_CheckBox.Items.AddRange(new object[] {
            "Casual e-timesheet",
            "Contracted e-timesheet"});
            this.Template_CheckBox.Location = new System.Drawing.Point(556, 177);
            this.Template_CheckBox.Name = "Template_CheckBox";
            this.Template_CheckBox.Size = new System.Drawing.Size(363, 84);
            this.Template_CheckBox.TabIndex = 2;
            // 
            // Position_Lbl
            // 
            this.Position_Lbl.AutoSize = true;
            this.Position_Lbl.Location = new System.Drawing.Point(551, 22);
            this.Position_Lbl.Name = "Position_Lbl";
            this.Position_Lbl.Size = new System.Drawing.Size(155, 25);
            this.Position_Lbl.TabIndex = 3;
            this.Position_Lbl.Text = "Select Position";
            // 
            // Template_Lbl
            // 
            this.Template_Lbl.AutoSize = true;
            this.Template_Lbl.Location = new System.Drawing.Point(551, 149);
            this.Template_Lbl.Name = "Template_Lbl";
            this.Template_Lbl.Size = new System.Drawing.Size(167, 25);
            this.Template_Lbl.TabIndex = 4;
            this.Template_Lbl.Text = "Select Template";
            // 
            // Site_Lbl
            // 
            this.Site_Lbl.AutoSize = true;
            this.Site_Lbl.Location = new System.Drawing.Point(551, 278);
            this.Site_Lbl.Name = "Site_Lbl";
            this.Site_Lbl.Size = new System.Drawing.Size(115, 25);
            this.Site_Lbl.TabIndex = 5;
            this.Site_Lbl.Text = "Select Site";
            // 
            // Site_CheckBox
            // 
            this.Site_CheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.Site_CheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Site_CheckBox.CheckOnClick = true;
            this.Site_CheckBox.FormattingEnabled = true;
            this.Site_CheckBox.Items.AddRange(new object[] {
            "Splashpoint Leisure Centre",
            "Wadurs Leisure Centre"});
            this.Site_CheckBox.Location = new System.Drawing.Point(556, 306);
            this.Site_CheckBox.Name = "Site_CheckBox";
            this.Site_CheckBox.Size = new System.Drawing.Size(363, 84);
            this.Site_CheckBox.TabIndex = 6;
            // 
            // Hours_Worked_Lbl
            // 
            this.Hours_Worked_Lbl.AutoSize = true;
            this.Hours_Worked_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours_Worked_Lbl.Location = new System.Drawing.Point(551, 394);
            this.Hours_Worked_Lbl.Name = "Hours_Worked_Lbl";
            this.Hours_Worked_Lbl.Size = new System.Drawing.Size(167, 29);
            this.Hours_Worked_Lbl.TabIndex = 9;
            this.Hours_Worked_Lbl.Text = "Hours Worked";
            // 
            // Hours_Worked_TxtBox
            // 
            this.Hours_Worked_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.Hours_Worked_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hours_Worked_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours_Worked_TxtBox.Location = new System.Drawing.Point(556, 426);
            this.Hours_Worked_TxtBox.Name = "Hours_Worked_TxtBox";
            this.Hours_Worked_TxtBox.Size = new System.Drawing.Size(282, 40);
            this.Hours_Worked_TxtBox.TabIndex = 10;
            // 
            // Confirm_Password_Pnl
            // 
            this.Confirm_Password_Pnl.Controls.Add(this.Submit_Btn);
            this.Confirm_Password_Pnl.Controls.Add(this.Confirm_Password_Btn);
            this.Confirm_Password_Pnl.Controls.Add(this.Confirm_Password_TxtBox);
            this.Confirm_Password_Pnl.Controls.Add(this.Confirm_Password_Lbl);
            this.Confirm_Password_Pnl.Location = new System.Drawing.Point(40, 378);
            this.Confirm_Password_Pnl.Name = "Confirm_Password_Pnl";
            this.Confirm_Password_Pnl.Size = new System.Drawing.Size(461, 161);
            this.Confirm_Password_Pnl.TabIndex = 26;
            this.Confirm_Password_Pnl.Visible = false;
            // 
            // Submit_Btn
            // 
            this.Submit_Btn.BackColor = System.Drawing.Color.Green;
            this.Submit_Btn.Enabled = false;
            this.Submit_Btn.FlatAppearance.BorderSize = 0;
            this.Submit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.Submit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Submit_Btn.Location = new System.Drawing.Point(274, 107);
            this.Submit_Btn.Name = "Submit_Btn";
            this.Submit_Btn.Size = new System.Drawing.Size(164, 45);
            this.Submit_Btn.TabIndex = 28;
            this.Submit_Btn.Text = "Submit";
            this.Submit_Btn.UseVisualStyleBackColor = false;
            this.Submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // Confirm_Password_Btn
            // 
            this.Confirm_Password_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Confirm_Password_Btn.FlatAppearance.BorderSize = 0;
            this.Confirm_Password_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
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
            this.Confirm_Password_TxtBox.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Password_TxtBox.Location = new System.Drawing.Point(9, 47);
            this.Confirm_Password_TxtBox.Name = "Confirm_Password_TxtBox";
            this.Confirm_Password_TxtBox.Size = new System.Drawing.Size(429, 41);
            this.Confirm_Password_TxtBox.TabIndex = 24;
            // 
            // Confirm_Password_Lbl
            // 
            this.Confirm_Password_Lbl.AutoSize = true;
            this.Confirm_Password_Lbl.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Password_Lbl.Location = new System.Drawing.Point(3, 12);
            this.Confirm_Password_Lbl.Name = "Confirm_Password_Lbl";
            this.Confirm_Password_Lbl.Size = new System.Drawing.Size(324, 32);
            this.Confirm_Password_Lbl.TabIndex = 21;
            this.Confirm_Password_Lbl.Text = "Enter Password to submit";
            // 
            // Save_Btn
            // 
            this.Save_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Save_Btn.FlatAppearance.BorderSize = 0;
            this.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Save_Btn.Location = new System.Drawing.Point(556, 485);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(164, 45);
            this.Save_Btn.TabIndex = 27;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = false;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Date_Picker
            // 
            this.Date_Picker.CustomFormat = "dd/MM/yyyy";
            this.Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Picker.Location = new System.Drawing.Point(72, 22);
            this.Date_Picker.Name = "Date_Picker";
            this.Date_Picker.Size = new System.Drawing.Size(398, 31);
            this.Date_Picker.TabIndex = 28;
            // 
            // Position_CheckBox
            // 
            this.Position_CheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.Position_CheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Position_CheckBox.CheckOnClick = true;
            this.Position_CheckBox.FormattingEnabled = true;
            this.Position_CheckBox.Items.AddRange(new object[] {
            "Lifeguard",
            "Swim School Assistant Instructor"});
            this.Position_CheckBox.Location = new System.Drawing.Point(556, 50);
            this.Position_CheckBox.Name = "Position_CheckBox";
            this.Position_CheckBox.Size = new System.Drawing.Size(363, 84);
            this.Position_CheckBox.TabIndex = 1;
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.FlatAppearance.BorderSize = 0;
            this.Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Btn.Location = new System.Drawing.Point(736, 485);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(102, 45);
            this.Clear_Btn.TabIndex = 29;
            this.Clear_Btn.Text = "Clear";
            this.Clear_Btn.UseVisualStyleBackColor = true;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // PaySlip_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 724);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.Date_Picker);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Confirm_Password_Pnl);
            this.Controls.Add(this.Hours_Worked_TxtBox);
            this.Controls.Add(this.Hours_Worked_Lbl);
            this.Controls.Add(this.Site_CheckBox);
            this.Controls.Add(this.Site_Lbl);
            this.Controls.Add(this.Template_Lbl);
            this.Controls.Add(this.Position_Lbl);
            this.Controls.Add(this.Template_CheckBox);
            this.Controls.Add(this.Position_CheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaySlip_Window";
            this.Text = "PaySlip_Window";
            this.Load += new System.EventHandler(this.PaySlip_Window_Load);
            this.Confirm_Password_Pnl.ResumeLayout(false);
            this.Confirm_Password_Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox Template_CheckBox;
        private System.Windows.Forms.Label Position_Lbl;
        private System.Windows.Forms.Label Template_Lbl;
        private System.Windows.Forms.Label Site_Lbl;
        private System.Windows.Forms.CheckedListBox Site_CheckBox;
        private System.Windows.Forms.Label Hours_Worked_Lbl;
        private System.Windows.Forms.TextBox Hours_Worked_TxtBox;
        private System.Windows.Forms.Panel Confirm_Password_Pnl;
        private System.Windows.Forms.Button Submit_Btn;
        private System.Windows.Forms.Button Confirm_Password_Btn;
        private System.Windows.Forms.TextBox Confirm_Password_TxtBox;
        private System.Windows.Forms.Label Confirm_Password_Lbl;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.DateTimePicker Date_Picker;
        private System.Windows.Forms.CheckedListBox Position_CheckBox;
        private System.Windows.Forms.Button Clear_Btn;
    }
}