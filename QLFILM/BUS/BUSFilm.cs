using QLFILM.DAO;
using QLFILM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLFILM.BUS
{
    class BUSFilm
    {
        DAOFilm daoFilm;
        public BUSFilm()
        {
            daoFilm = new DAOFilm();
        }
        public void ShowFilm(DataGridView dg)
        {
            dg.DataSource = daoFilm.GetFilm();
        }
        public dynamic GetFilmByID(string ID)
        {
            return daoFilm.GetFilmByID(ID);
        }
        public void AddFilm(Film f)
        {
            try
            {
                daoFilm.AddFilm(f);
                MessageBox.Show("Add Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Add Error");
            }
        }
        public void DeleteFilm(Film f)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    daoFilm.DeleteFilm(f);
                    MessageBox.Show("Delete Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Delete Error");
                }
            }
        }
        public void UpdateFilm()
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    daoFilm.UpdateFilm();
                    MessageBox.Show("Update Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Update Error");
                }
            }
        }
        public void ShowActor(ComboBox cb)
        {
            cb.DataSource = daoFilm.GetActor();
            cb.DisplayMember = "ActorName";
            cb.ValueMember = "AID";
        }
        public void ShowDirector(ComboBox cb)
        {
            cb.DataSource = daoFilm.GetDirector();
            cb.DisplayMember = "DirectorName";
            cb.ValueMember = "DID";
        }
        public void ShowCategory(ComboBox cb)
        {
            cb.DataSource = daoFilm.GetCategory();
            cb.DisplayMember = "CategoryName";
            cb.ValueMember = "CID";
        }
    }
}
