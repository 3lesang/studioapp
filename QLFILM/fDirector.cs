using QLFILM.BUS;
using QLFILM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLFILM
{
    public partial class fDirector : Form
    {
        BUSDirector busDirector;
        public fDirector()
        {
            InitializeComponent();
            busDirector = new BUSDirector();
        }
        public void Reload()
        {
            dgDirector.DataSource = null;
            busDirector.ShowDirector(dgDirector);
        }
        private void fDirector_Load(object sender, EventArgs e)
        {
            busDirector.ShowDirector(dgDirector);
        }

        private void exitDirector_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDirector_Click(object sender, EventArgs e)
        {
            Director di = new Director();
            di.DID = txtDirectorID.Text;
            di.DirectorName = txtDirectorName.Text;
            busDirector.AddDirector(di);
            Reload();
        }
    }
}
