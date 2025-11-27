using System;
using System.Drawing;
using System.Windows.Forms;
using Winforms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Main_WindowToolbar : Form
    {
        private bool Form_Loading = false;
        public Main_WindowToolbar()
        {
            InitializeComponent();
        }
        private void Main_Window_Toolbar_Frm_Load(object sender, EventArgs e)
        {
            if (LoginInfo.Permissions == "E")
            {
                Tools_Btn.Visible = false;
                Matrix_Btn.Visible = false;
            }
        }
        private void Account_Btn_Click(object sender, EventArgs e)
        {
            Button_Colour_Reset();
            LoadForm(new Account_Frm());
        }
        private void Chat_Btn_Click(object sender, EventArgs e)
        {
            Button_Colour_Reset();
            LoadForm(new Chat_Frm());
            Chat_Btn.ForeColor = Color.Gray;
        }
        private void Home_Btn_Click_1(object sender, EventArgs e)
        {
            Button_Colour_Reset();
            LoadForm(new Home_Frm());
            Home_Btn.ForeColor = Color.Gray;
        }
        private void Pay_Btn_Click(object sender, EventArgs e)
        {
            Button_Colour_Reset();
            LoadForm(new Pay_Calculator_Frm()); 
            Pay_Btn.ForeColor = Color.Gray;
        }
        private void Tools_Btn_Click(object sender, EventArgs e)
        {
            Button_Colour_Reset();
            LoadForm(new Tools_Toolbar_Frm());
            Tools_Btn.ForeColor = Color.Gray;
        }
        private void Matrix_Btn_Click(object sender, EventArgs e)
        {
            Button_Colour_Reset();
            LoadForm(new Matrix_Frm());
            Matrix_Btn.ForeColor = Color.Gray;
        }
        private void Shifts_Btn_Click(object sender, EventArgs e)
        {
            Button_Colour_Reset();
            LoadForm(new Shifts_Frm());
            Shifts_Btn.ForeColor = Color.Gray;
        }
        private void Button_Colour_Reset()
        {
            Home_Btn.ForeColor = SystemColors.ControlText; 
            Chat_Btn.ForeColor = SystemColors.ControlText; 
            Shifts_Btn.ForeColor = SystemColors.ControlText; 
            Pay_Btn.ForeColor = SystemColors.ControlText; 
            Tools_Btn.ForeColor = SystemColors.Highlight; 
            Matrix_Btn.ForeColor = SystemColors.ControlText;
        }
        private void LoadForm(Form formToLoad)
        {
            // uses a form loading flag to stop another form from being loaded while there is one already loading
            Form_Loading = true;

            // clears any loaded forms
            Clear_Panel();

            formToLoad.TopLevel = false;
            Main_Window_View_Pnl.Controls.Add(formToLoad);
            formToLoad.BringToFront();
            formToLoad.Show();

            Form_Loading = false;
        }
        private void Clear_Panel()
        {
            // stops the form from being disposed if there is a form in the middle of loading 
            if (Form_Loading)
            {
                return;
            }
            foreach (Control control in Main_Window_View_Pnl.Controls)
            {
                if (control is Form form)
                {
                    form.Dispose();
                }
            }
        }
    }
}
