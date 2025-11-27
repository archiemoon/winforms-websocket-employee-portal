namespace Moon_Archie_Winforms_NEA
{
    partial class Chat_Frm
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
            this.Message_Pnl = new System.Windows.Forms.Panel();
            this.Messages_TxtBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.MessageInput_TxtBox = new System.Windows.Forms.RichTextBox();
            this.Message_Send_Btn = new System.Windows.Forms.Button();
            this.Load_Messages_Btn = new System.Windows.Forms.Button();
            this.Message_Pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Message_Pnl
            // 
            this.Message_Pnl.BackColor = System.Drawing.SystemColors.Control;
            this.Message_Pnl.Controls.Add(this.Messages_TxtBox);
            this.Message_Pnl.Location = new System.Drawing.Point(-2, 25);
            this.Message_Pnl.Margin = new System.Windows.Forms.Padding(6);
            this.Message_Pnl.Name = "Message_Pnl";
            this.Message_Pnl.Size = new System.Drawing.Size(1316, 694);
            this.Message_Pnl.TabIndex = 1;
            // 
            // Messages_TxtBox
            // 
            this.Messages_TxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.Messages_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Messages_TxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Messages_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messages_TxtBox.Location = new System.Drawing.Point(0, 0);
            this.Messages_TxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.Messages_TxtBox.Name = "Messages_TxtBox";
            this.Messages_TxtBox.ReadOnly = true;
            this.Messages_TxtBox.Size = new System.Drawing.Size(1316, 694);
            this.Messages_TxtBox.TabIndex = 1;
            this.Messages_TxtBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Connect_Btn);
            this.panel1.Controls.Add(this.MessageInput_TxtBox);
            this.panel1.Controls.Add(this.Message_Send_Btn);
            this.panel1.Location = new System.Drawing.Point(-2, 719);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1442, 98);
            this.panel1.TabIndex = 2;
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.BackColor = System.Drawing.Color.Firebrick;
            this.Connect_Btn.FlatAppearance.BorderSize = 0;
            this.Connect_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect_Btn.Location = new System.Drawing.Point(1298, 0);
            this.Connect_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(16, 98);
            this.Connect_Btn.TabIndex = 2;
            this.Connect_Btn.UseVisualStyleBackColor = false;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // MessageInput_TxtBox
            // 
            this.MessageInput_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageInput_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageInput_TxtBox.Location = new System.Drawing.Point(0, 0);
            this.MessageInput_TxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.MessageInput_TxtBox.Name = "MessageInput_TxtBox";
            this.MessageInput_TxtBox.Size = new System.Drawing.Size(1304, 98);
            this.MessageInput_TxtBox.TabIndex = 1;
            this.MessageInput_TxtBox.Text = "";
            // 
            // Message_Send_Btn
            // 
            this.Message_Send_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Message_Send_Btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.Message_Send_Btn.FlatAppearance.BorderSize = 0;
            this.Message_Send_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Message_Send_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Message_Send_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_Send_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Message_Send_Btn.Location = new System.Drawing.Point(1313, 0);
            this.Message_Send_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Message_Send_Btn.Name = "Message_Send_Btn";
            this.Message_Send_Btn.Size = new System.Drawing.Size(130, 98);
            this.Message_Send_Btn.TabIndex = 0;
            this.Message_Send_Btn.Text = "➤";
            this.Message_Send_Btn.UseVisualStyleBackColor = false;
            this.Message_Send_Btn.Click += new System.EventHandler(this.Message_Send_Btn_Click);
            // 
            // Load_Messages_Btn
            // 
            this.Load_Messages_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Load_Messages_Btn.FlatAppearance.BorderSize = 0;
            this.Load_Messages_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Messages_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Messages_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Load_Messages_Btn.Location = new System.Drawing.Point(1313, 675);
            this.Load_Messages_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Load_Messages_Btn.Name = "Load_Messages_Btn";
            this.Load_Messages_Btn.Size = new System.Drawing.Size(128, 44);
            this.Load_Messages_Btn.TabIndex = 3;
            this.Load_Messages_Btn.Text = "see more";
            this.Load_Messages_Btn.UseVisualStyleBackColor = false;
            this.Load_Messages_Btn.Click += new System.EventHandler(this.Load_Messages_Btn_Click);
            // 
            // Chat_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1438, 819);
            this.Controls.Add(this.Load_Messages_Btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Message_Pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Chat_Frm";
            this.Text = "Chat_Frm";
            this.Load += new System.EventHandler(this.Chat_Frm_Load);
            this.Message_Pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Message_Pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Message_Send_Btn;
        private System.Windows.Forms.RichTextBox MessageInput_TxtBox;
        private System.Windows.Forms.Button Connect_Btn;
        private System.Windows.Forms.RichTextBox Messages_TxtBox;
        private System.Windows.Forms.Button Load_Messages_Btn;
    }
}