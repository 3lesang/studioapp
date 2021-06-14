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
    public partial class fCategory : Form
    {
        BUSCategory busCategory;
        public fCategory()
        {
            InitializeComponent();
            busCategory = new BUSCategory();
        }
        public void Reload()
        {
            dgCategory.DataSource = null;
            busCategory.ShowCategory(dgCategory);
        }
        private void fCategory_Load(object sender, EventArgs e)
        {
            busCategory.ShowCategory(dgCategory);
        }

        private void exitCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            Category ca = new Category();
            ca.CID = txtCategoryID.Text;
            ca.CategoryName = txtCategoryName.Text;
            busCategory.AddCategory(ca);
            Reload();
        }
    }
}
