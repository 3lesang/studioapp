using QLFILM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.DAO
{
    class DAOCategory
    {
        Context db;
        public DAOCategory()
        {
            db = new Context();
        }
        public dynamic GetCategory()
        {
            return db.Categories.Select(s => new
            {
                s.CID,
                s.CategoryName
            }).ToList();
        }
        public dynamic GetCategoryByID(string ID)
        {
            return db.Categories.Single(a => a.CID.Equals(ID));
        }
        public void AddCategory(Category ca)
        {
            db.Categories.Add(ca);
            db.SaveChanges();
        }
        public void DeleteCategory(Category ca)
        {
            db.Categories.Remove(ca);
            db.SaveChanges();
        }
    }
}
