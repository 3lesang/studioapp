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
    public partial class fFilm : Form
    {
        BUSFilm busFilm;
        public fFilm()
        {
            InitializeComponent();
            busFilm = new BUSFilm();
        }
        public void Reload()
        {
            dgFilm.DataSource = null;
            busFilm.ShowFilm(dgFilm);
        }
        private void fFilm_Load(object sender, EventArgs e)
        {
            busFilm.ShowFilm(dgFilm);
            busFilm.ShowActor(cbActor);
            busFilm.ShowCategory(cbCategory);
            busFilm.ShowDirector(cbDrector);
        }

        private void exitFilm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = this.dgFilm.CurrentRow.Cells[0].Value.ToString();
            Film f = busFilm.GetFilmByID(ID);
            this.txtFilmID.Text = f.FID;
            this.txtEnglishTitle.Text = f.EnglishTitle;
            this.txtVietnameseTitle.Text = f.VietnameseTitle;
            this.txtYear.Text = f.Year.ToString();
            this.txtLength.Text = f.Length.ToString();
            this.txtGating.Text = f.Rating.ToString();
            this.txtGross.Text = f.Gross.ToString();

        }

        private void addFilm_Click(object sender, EventArgs e)
        {
            Film f = new Film();
            f.FID = txtFilmID.Text;
            f.EnglishTitle = txtEnglishTitle.Text;
            f.VietnameseTitle = txtVietnameseTitle.Text;
            f.Year = int.Parse(txtYear.Text);
            f.Length = double.Parse(txtLength.Text);
            f.Rating = double.Parse(txtGating.Text);
            f.Gross = double.Parse(txtGross.Text);
            busFilm.AddFilm(f);
            Reload();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ID = this.dgFilm.CurrentRow.Cells[0].Value.ToString();
            Film f = busFilm.GetFilmByID(ID);
            busFilm.DeleteFilm(f);
            Reload();
        }

        private void delFilm_Click(object sender, EventArgs e)
        {
            string ID = this.dgFilm.CurrentRow.Cells[0].Value.ToString();
            Film f = busFilm.GetFilmByID(ID);
            busFilm.DeleteFilm(f);
            Reload();
        }
    }
}
