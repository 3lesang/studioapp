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
    class BUSDirector
    {
        DAODirector daoDirector;
        public BUSDirector()
        {
            daoDirector = new DAODirector();
        }
        public void ShowDirector(DataGridView dg)
        {
            dg.DataSource = daoDirector.GetDirector();
        }
        public dynamic GetDirectorByID(string ID)
        {
            return daoDirector.GetDirectorByID(ID);
        }
        public void AddDirector(Director di)
        {
            try
            {
                daoDirector.AddDirector(di);
                MessageBox.Show("Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        public void DeleteActor(Director di)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    daoDirector.DeleteDirector(di);
                    MessageBox.Show("Delete Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Delete Error");
                }
            }

        }
    }
}
