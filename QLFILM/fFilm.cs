using QLFILM.BUS;
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
    public partial class fFilm : Form
    {
        BUSFilm busFilm;
        public fFilm()
        {
            InitializeComponent();
            busFilm = new BUSFilm();
        }

        private void fFilm_Load(object sender, EventArgs e)
        {
            busFilm.ShowFilm(dgFilm);
        }
    }
}
