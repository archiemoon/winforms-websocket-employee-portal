namespace Moon_Archie_Winforms_NEA
{
    partial class Tools_Toolbar_Frm
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
            this.Add_User_Btn = new System.Windows.Forms.Button();
            this.Remove_User_Btn = new System.Windows.Forms.Button();
            this.Edit_User_Info_Btn = new System.Windows.Forms.Button();
            this.Upload_Shifts_Btn = new System.Windows.Forms.Button();
            this.Tool_Pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Add_User_Btn
            // 
            this.Add_User_Btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_User_Btn.FlatAppearance.BorderSize = 0;
            this.Add_User_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_User_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_User_Btn.Location = new System.Drawing.Point(0, 762);
            this.Add_User_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Add_User_Btn.Name = "Add_User_Btn";
            this.Add_User_Btn.Size = new System.Drawing.Size(216, 60);
            this.Add_User_Btn.TabIndex = 0;
            this.Add_User_Btn.Text = "Add User";
            this.Add_User_Btn.UseVisualStyleBackColor = false;
            this.Add_User_Btn.Click += new System.EventHandler(this.Add_User_Btn_Click);
            // 
            // Remove_User_Btn
            // 
            this.Remove_User_Btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Remove_User_Btn.FlatAppearance.BorderSize = 0;
            this.Remove_User_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_User_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_User_Btn.Location = new System.Drawing.Point(210, 762);
            this.Remove_User_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_User_Btn.Name = "Remove_User_Btn";
            this.Remove_User_Btn.Size = new System.Drawing.Size(240, 60);
            this.Remove_User_Btn.TabIndex = 1;
            this.Remove_User_Btn.Text = "Remove User";
            this.Remove_User_Btn.UseVisualStyleBackColor = false;
            this.Remove_User_Btn.Click += new System.EventHandler(this.Remove_User_Btn_Click);
            // 
            // Edit_User_Info_Btn
            // 
            this.Edit_User_Info_Btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_User_Info_Btn.FlatAppearance.BorderSize = 0;
            this.Edit_User_Info_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_User_Info_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_User_Info_Btn.Location = new System.Drawing.Point(446, 762);
            this.Edit_User_Info_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_User_Info_Btn.Name = "Edit_User_Info_Btn";
            this.Edit_User_Info_Btn.Size = new System.Drawing.Size(240, 60);
            this.Edit_User_Info_Btn.TabIndex = 2;
            this.Edit_User_Info_Btn.Text = "Edit User Info";
            this.Edit_User_Info_Btn.UseVisualStyleBackColor = false;
            this.Edit_User_Info_Btn.Click += new System.EventHandler(this.Edit_User_Info_Btn_Click);
            // 
            // Upload_Shifts_Btn
            // 
            this.Upload_Shifts_Btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Upload_Shifts_Btn.FlatAppearance.BorderSize = 0;
            this.Upload_Shifts_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload_Shifts_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_Shifts_Btn.Location = new System.Drawing.Point(680, 762);
            this.Upload_Shifts_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Upload_Shifts_Btn.Name = "Upload_Shifts_Btn";
            this.Upload_Shifts_Btn.Size = new System.Drawing.Size(240, 60);
            this.Upload_Shifts_Btn.TabIndex = 4;
            this.Upload_Shifts_Btn.Text = "Upload Shifts";
            this.Upload_Shifts_Btn.UseVisualStyleBackColor = false;
            this.Upload_Shifts_Btn.Click += new System.EventHandler(this.Upload_Shifts_Btn_Click);
            // 
            // Tool_Pnl
            // 
            this.Tool_Pnl.BackColor = System.Drawing.SystemColors.Control;
            this.Tool_Pnl.Location = new System.Drawing.Point(0, -2);
            this.Tool_Pnl.Margin = new System.Windows.Forms.Padding(4);
            this.Tool_Pnl.Name = "Tool_Pnl";
            this.Tool_Pnl.Size = new System.Drawing.Size(1440, 765);
            this.Tool_Pnl.TabIndex = 5;
            // 
            // Tools_Toolbar_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1438, 819);
            this.Controls.Add(this.Tool_Pnl);
            this.Controls.Add(this.Upload_Shifts_Btn);
            this.Controls.Add(this.Edit_User_Info_Btn);
            this.Controls.Add(this.Remove_User_Btn);
            this.Controls.Add(this.Add_User_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tools_Toolbar_Frm";
            this.Text = "Tools_Frm";
            this.Load += new System.EventHandler(this.Tools_Toolbar_Frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_User_Btn;
        private System.Windows.Forms.Button Remove_User_Btn;
        private System.Windows.Forms.Button Edit_User_Info_Btn;
        private System.Windows.Forms.Button Upload_Shifts_Btn;
        private System.Windows.Forms.Panel Tool_Pnl;
    }
}