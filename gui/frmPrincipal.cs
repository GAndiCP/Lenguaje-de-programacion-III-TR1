using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEstudiantes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panel3.Visible= false;
        }
        private void hideSubMenu()
        {
            if(panel3.Visible==true)
                panel3.Visible= false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnprincipal_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void btnestudiante_Click(object sender, EventArgs e)
        {
            openPanel4(new frmEstudiantes());
            hideSubMenu();
        }

        private void btncurso_Click(object sender, EventArgs e)
        {
            openPanel4(new frmCursos());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openPanel4(Form childForm)
        {
            if(activeForm!=null)
                activeForm.Close(); 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
