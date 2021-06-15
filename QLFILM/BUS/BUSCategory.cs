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
        public dynamic GetCategoryByID(string ID)
        {
            return daoCategory.GetCategoryByID(ID);
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
        public void DeleteCategory(Category ca)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    daoCategory.DeleteCategory(ca);
                    MessageBox.Show("Delete Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Delete Error");
                }
            }
        }
        public void UpdateCategory()
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    daoCategory.UpdateCategory();
                    MessageBox.Show("Update Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Update Error");
                }
            }
        }
    }
}
