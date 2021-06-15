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

        private void dgCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = this.dgCategory.CurrentRow.Cells[0].Value.ToString();
            Category ca = busCategory.GetCategoryByID(ID);
            this.txtCategoryID.Text = ca.CID;
            this.txtCategoryName.Text = ca.CategoryName;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ID = this.dgCategory.CurrentRow.Cells[0].Value.ToString();
            Category ca = busCategory.GetCategoryByID(ID);
            busCategory.DeleteCategory(ca);
            Reload();
        }

        private void delCategory_Click(object sender, EventArgs e)
        {
            string ID = this.dgCategory.CurrentRow.Cells[0].Value.ToString();
            Category ca = busCategory.GetCategoryByID(ID);
            busCategory.DeleteCategory(ca);
            Reload();
        }

        private void editCategory_Click(object sender, EventArgs e)
        {
            string ID = this.dgCategory.CurrentRow.Cells[0].Value.ToString();
            Category ca = busCategory.GetCategoryByID(ID);
            ca.CID = this.txtCategoryID.Text;
            ca.CategoryName = this.txtCategoryName.Text;
            busCategory.UpdateCategory();
            Reload();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string ID = this.dgCategory.CurrentRow.Cells[0].Value.ToString();
            Category ca = busCategory.GetCategoryByID(ID);
            busCategory.DeleteCategory(ca);
            Reload();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string ID = this.dgCategory.CurrentRow.Cells[0].Value.ToString();
            Category ca = busCategory.GetCategoryByID(ID);
            ca.CID = this.txtCategoryID.Text;
            ca.CategoryName = this.txtCategoryName.Text;
            busCategory.UpdateCategory();
            Reload();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Category ca = new Category();
            ca.CID = txtCategoryID.Text;
            ca.CategoryName = txtCategoryName.Text;
            busCategory.AddCategory(ca);
            Reload();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
