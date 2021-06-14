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
    class BUSCategory
    {
        DAOCategory daoCategory;
        public BUSCategory()
        {
            daoCategory = new DAOCategory();
        }
        public void ShowCategory(DataGridView dg)
        {
            dg.DataSource = daoCategory.GetCategory();
        }
        public void AddCategory(Category ca)
        {
            try
            {
                daoCategory.AddCategory(ca);
                MessageBox.Show("Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
