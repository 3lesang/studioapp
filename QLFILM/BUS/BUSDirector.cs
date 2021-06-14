using QLFILM.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLFILM.BUS
{
    class BUSDirector
    {
        DAODirector daoDirector;
        public BUSDirector()
        {
            daoDirector = new DAODirector();
        }
        public void ShowFilm(DataGridView dg)
        {
            dg.DataSource = daoDirector.GetDirector();
        }
    }
}
