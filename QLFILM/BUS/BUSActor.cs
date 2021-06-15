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
    class BUSActor
    {
        DAOActor daoActor;
        public BUSActor()
        {
            daoActor = new DAOActor();
        }
        public void ShowActor(DataGridView dg)
        {
            dg.DataSource = daoActor.GetActor();
        }
        public dynamic GetActorByID(string ID)
        {
            return daoActor.GetActorByID(ID);
        }
        public void AddActor(Actor ac)
        {
            try
            {
                daoActor.AddActor(ac);
                MessageBox.Show("Add Success");
            }
            catch(Exception)
            {
                MessageBox.Show("Add Error");
            }
        }
        public void DeleteActor(Actor ac)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                try
                {
                    daoActor.DeleteActor(ac);
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
