using System;
using System.Windows.Forms;

namespace Moon_Archie_Winforms_NEA
{
    public partial class Tools_Toolbar_Frm : Form
    {
        private bool Form_Loading = false;
        public Tools_Toolbar_Frm()
        {
            InitializeComponent();
        }
        private void Tools_Toolbar_Frm_Load(object sender, EventArgs e)
        {

        }
        private void Add_User_Btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Add_User_Frm());
        }
        private void Remove_User_Btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Remove_User_Frm());
        }

        private void Edit_User_Info_Btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Edit_User_Info_Frm());
        }

        private void Upload_Shifts_Btn_Click(object sender, EventArgs e)
        {
            LoadForm(new Upload_Shifts_Frm());
        }
        private void LoadForm(Form formToLoad)
        {
            // uses a form loading flag to stop another form from being loaded while there is one already loading
            Form_Loading = true;

            // clears any loaded forms
            Clear_Panel();

            formToLoad.TopLevel = false;
            Tool_Pnl.Controls.Add(formToLoad);
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
            foreach (Control control in Tool_Pnl.Controls)
            {
                if (control is Form form)
                {
                    form.Dispose();
                }
            }
        }
    }
}
