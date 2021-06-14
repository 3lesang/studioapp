using QLFILM.DAO;
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
        public void ShowActor(ComboBox cb)
        {
            cb.DataSource = daoFilm.GetActor();
            cb.DisplayMember = "ActorName";
            cb.ValueMember = "AID";
        }
    }
}
