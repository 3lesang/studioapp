using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLFILM
{
    public partial class fMain : Form
    {

        public fMain()
        {
            InitializeComponent();
            var myContext = new Context();
            myContext.Database.CreateIfNotExists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new fFilm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new fCategory());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new fDirector());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new fActor());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new fActor());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new fFilm());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new fDirector());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new fCategory());
        }
    }
} 
