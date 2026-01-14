namespace WinFormsApp.MDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFormA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormA());
            //FormA f1 = new FormA();
            //f1.MdiParent = this;
            //f1.Show();
        }

        private void mnuFormB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormB());
            //FormB f2 = new FormB();
            //f2.MdiParent = this;
            //f2.Show();
        }

        private void mnuFormC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormC());
            //FormC f3 = new FormC();
            //f3.MdiParent = this;
            //f3.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuFromMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnuFromMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mnuFormNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void mnuFormClose_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

        }

        private void mnuFormCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        private void OpenChildForm(Form formName)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formName.GetType())
                {
                    f.Activate();
                    return;
                }
            }

            formName.MdiParent = this;
            formName.WindowState = FormWindowState.Normal;
            formName.Show();
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuArrangeCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
