namespace Moon_Archie_Winforms_NEA
{
    partial class Pay_Calculator_Frm
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
            this.Past_Payslip_List_Pnl = new System.Windows.Forms.Panel();
            this.Payslip_TxtBox = new System.Windows.Forms.RichTextBox();
            this.Payslips_Lbl = new System.Windows.Forms.Label();
            this.underline_Lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.New_Payslip_Btn = new System.Windows.Forms.Button();
            this.Payslip_View_Pnl = new System.Windows.Forms.Panel();
            this.Past_Payslip_List_Pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Past_Payslip_List_Pnl
            // 
            this.Past_Payslip_List_Pnl.BackColor = System.Drawing.SystemColors.Control;
            this.Past_Payslip_List_Pnl.Controls.Add(this.Payslip_TxtBox);
            this.Past_Payslip_List_Pnl.Controls.Add(this.Payslips_Lbl);
            this.Past_Payslip_List_Pnl.Controls.Add(this.underline_Lbl);
            this.Past_Payslip_List_Pnl.Location = new System.Drawing.Point(0, 0);
            this.Past_Payslip_List_Pnl.Name = "Past_Payslip_List_Pnl";
            this.Past_Payslip_List_Pnl.Size = new System.Drawing.Size(456, 821);
            this.Past_Payslip_List_Pnl.TabIndex = 0;
            // 
            // Payslip_TxtBox
            // 
            this.Payslip_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Payslip_TxtBox.Location = new System.Drawing.Point(0, 61);
            this.Payslip_TxtBox.Name = "Payslip_TxtBox";
            this.Payslip_TxtBox.ReadOnly = true;
            this.Payslip_TxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Payslip_TxtBox.Size = new System.Drawing.Size(459, 760);
            this.Payslip_TxtBox.TabIndex = 4;
            this.Payslip_TxtBox.Text = "";
            // 
            // Payslips_Lbl
            // 
            this.Payslips_Lbl.BackColor = System.Drawing.SystemColors.Control;
            this.Payslips_Lbl.Font = new System.Drawing.Font("Nirmala UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payslips_Lbl.Location = new System.Drawing.Point(0, 0);
            this.Payslips_Lbl.Name = "Payslips_Lbl";
            this.Payslips_Lbl.Size = new System.Drawing.Size(456, 52);
            this.Payslips_Lbl.TabIndex = 2;
            this.Payslips_Lbl.Text = "Payslips\r\n\r\n\r\n\r\n";
            this.Payslips_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // underline_Lbl
            // 
            this.underline_Lbl.BackColor = System.Drawing.SystemColors.Control;
            this.underline_Lbl.Font = new System.Drawing.Font("Nirmala UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline_Lbl.Location = new System.Drawing.Point(0, 9);
            this.underline_Lbl.Name = "underline_Lbl";
            this.underline_Lbl.Size = new System.Drawing.Size(459, 52);
            this.underline_Lbl.TabIndex = 3;
            this.underline_Lbl.Text = "___________________________";
            this.underline_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.New_Payslip_Btn);
            this.panel2.Location = new System.Drawing.Point(462, 730);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 91);
            this.panel2.TabIndex = 1;
            // 
            // New_Payslip_Btn
            // 
            this.New_Payslip_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.New_Payslip_Btn.FlatAppearance.BorderSize = 0;
            this.New_Payslip_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Payslip_Btn.Font = new System.Drawing.Font("Nirmala UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Payslip_Btn.Location = new System.Drawing.Point(3, 3);
            this.New_Payslip_Btn.Name = "New_Payslip_Btn";
            this.New_Payslip_Btn.Size = new System.Drawing.Size(973, 88);
            this.New_Payslip_Btn.TabIndex = 0;
            this.New_Payslip_Btn.Text = "+ New Payslip";
            this.New_Payslip_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.New_Payslip_Btn.UseVisualStyleBackColor = true;
            this.New_Payslip_Btn.Click += new System.EventHandler(this.new_Payslip_Btn_Click);
            // 
            // Payslip_View_Pnl
            // 
            this.Payslip_View_Pnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Payslip_View_Pnl.Location = new System.Drawing.Point(462, 0);
            this.Payslip_View_Pnl.Name = "Payslip_View_Pnl";
            this.Payslip_View_Pnl.Size = new System.Drawing.Size(979, 724);
            this.Payslip_View_Pnl.TabIndex = 2;
            // 
            // Pay_Calculator_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1438, 819);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Payslip_View_Pnl);
            this.Controls.Add(this.Past_Payslip_List_Pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pay_Calculator_Frm";
            this.Text = "Pay_Calculator_Frm";
            this.Load += new System.EventHandler(this.Pay_Calculator_Frm_Load);
            this.Past_Payslip_List_Pnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Past_Payslip_List_Pnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Payslip_View_Pnl;
        private System.Windows.Forms.Button New_Payslip_Btn;
        private System.Windows.Forms.Label Payslips_Lbl;
        private System.Windows.Forms.Label underline_Lbl;
        private System.Windows.Forms.RichTextBox Payslip_TxtBox;
    }
}