namespace Moon_Archie_Winforms_NEA
{
    partial class Login_Frm
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
            this.Username_TxtBox = new System.Windows.Forms.TextBox();
            this.Password_TxtBox = new System.Windows.Forms.TextBox();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.Password_Reset_PopUp_Lbl = new System.Windows.Forms.Button();
            this.Password_Reset_Info_Lbl = new System.Windows.Forms.Label();
            this.Username_Lbl = new System.Windows.Forms.Label();
            this.Password_Lbl = new System.Windows.Forms.Label();
            this.showPassword_CheckBox = new System.Windows.Forms.CheckBox();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username_TxtBox
            // 
            this.Username_TxtBox.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_TxtBox.Location = new System.Drawing.Point(235, 121);
            this.Username_TxtBox.Name = "Username_TxtBox";
            this.Username_TxtBox.Size = new System.Drawing.Size(331, 41);
            this.Username_TxtBox.TabIndex = 0;
            // 
            // Password_TxtBox
            // 
            this.Password_TxtBox.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TxtBox.Location = new System.Drawing.Point(235, 205);
            this.Password_TxtBox.Name = "Password_TxtBox";
            this.Password_TxtBox.Size = new System.Drawing.Size(331, 41);
            this.Password_TxtBox.TabIndex = 1;
            this.Password_TxtBox.UseSystemPasswordChar = true;
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Login_Btn.Location = new System.Drawing.Point(235, 261);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(114, 56);
            this.Login_Btn.TabIndex = 2;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Password_Reset_PopUp_Lbl
            // 
            this.Password_Reset_PopUp_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Password_Reset_PopUp_Lbl.FlatAppearance.BorderSize = 0;
            this.Password_Reset_PopUp_Lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Password_Reset_PopUp_Lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Reset_PopUp_Lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Password_Reset_PopUp_Lbl.Location = new System.Drawing.Point(226, 323);
            this.Password_Reset_PopUp_Lbl.Name = "Password_Reset_PopUp_Lbl";
            this.Password_Reset_PopUp_Lbl.Size = new System.Drawing.Size(317, 45);
            this.Password_Reset_PopUp_Lbl.TabIndex = 4;
            this.Password_Reset_PopUp_Lbl.Text = "Forgotten your password?";
            this.Password_Reset_PopUp_Lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Password_Reset_PopUp_Lbl.UseVisualStyleBackColor = false;
            this.Password_Reset_PopUp_Lbl.Click += new System.EventHandler(this.Password_Reset_PopUp_Lbl_Click);
            // 
            // Password_Reset_Info_Lbl
            // 
            this.Password_Reset_Info_Lbl.AutoSize = true;
            this.Password_Reset_Info_Lbl.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Reset_Info_Lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Password_Reset_Info_Lbl.Location = new System.Drawing.Point(231, 380);
            this.Password_Reset_Info_Lbl.Name = "Password_Reset_Info_Lbl";
            this.Password_Reset_Info_Lbl.Size = new System.Drawing.Size(215, 72);
            this.Password_Reset_Info_Lbl.TabIndex = 5;
            this.Password_Reset_Info_Lbl.Text = "Please contact your a\r\ndministrator in order \r\nto reset password.";
            this.Password_Reset_Info_Lbl.Visible = false;
            // 
            // Username_Lbl
            // 
            this.Username_Lbl.AutoSize = true;
            this.Username_Lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Lbl.Location = new System.Drawing.Point(230, 91);
            this.Username_Lbl.Name = "Username_Lbl";
            this.Username_Lbl.Size = new System.Drawing.Size(122, 27);
            this.Username_Lbl.TabIndex = 6;
            this.Username_Lbl.Text = "Username";
            // 
            // Password_Lbl
            // 
            this.Password_Lbl.AutoSize = true;
            this.Password_Lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Lbl.Location = new System.Drawing.Point(230, 175);
            this.Password_Lbl.Name = "Password_Lbl";
            this.Password_Lbl.Size = new System.Drawing.Size(117, 27);
            this.Password_Lbl.TabIndex = 7;
            this.Password_Lbl.Text = "Password";
            // 
            // showPassword_CheckBox
            // 
            this.showPassword_CheckBox.AutoSize = true;
            this.showPassword_CheckBox.Location = new System.Drawing.Point(580, 215);
            this.showPassword_CheckBox.Name = "showPassword_CheckBox";
            this.showPassword_CheckBox.Size = new System.Drawing.Size(28, 27);
            this.showPassword_CheckBox.TabIndex = 8;
            this.showPassword_CheckBox.UseVisualStyleBackColor = true;
            this.showPassword_CheckBox.CheckedChanged += new System.EventHandler(this.showPassword_CheckBox_CheckedChanged);
            // 
            // Close_Btn
            // 
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Btn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Btn.Location = new System.Drawing.Point(438, 261);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(128, 56);
            this.Close_Btn.TabIndex = 40;
            this.Close_Btn.Text = "Close";
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Login_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 571);
            this.Controls.Add(this.Close_Btn);
            this.Controls.Add(this.showPassword_CheckBox);
            this.Controls.Add(this.Password_Lbl);
            this.Controls.Add(this.Username_Lbl);
            this.Controls.Add(this.Password_Reset_Info_Lbl);
            this.Controls.Add(this.Password_Reset_PopUp_Lbl);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Password_TxtBox);
            this.Controls.Add(this.Username_TxtBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Frm";
            this.Load += new System.EventHandler(this.Login_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_TxtBox;
        private System.Windows.Forms.TextBox Password_TxtBox;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Button Password_Reset_PopUp_Lbl;
        private System.Windows.Forms.Label Password_Reset_Info_Lbl;
        private System.Windows.Forms.Label Username_Lbl;
        private System.Windows.Forms.Label Password_Lbl;
        private System.Windows.Forms.CheckBox showPassword_CheckBox;
        private System.Windows.Forms.Button Close_Btn;
    }
}