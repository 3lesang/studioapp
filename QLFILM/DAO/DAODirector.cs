using QLFILM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.DAO
{
    class DAODirector
    {
        Context db;
        public DAODirector()
        {
            db = new Context();
        }
        public dynamic GetDirector()
        {
            return db.Directors.Select(s => new {
                s.DID,
                s.DirectorName
            }).ToList();
        }
        public dynamic GetDirectorByID(string ID)
        {
            return db.Directors.Single(a => a.DID.Equals(ID));
        }
        public void AddDirector(Director di)
        {
            db.Directors.Add(di);
            db.SaveChanges();
        }
        public void DeleteDirector(Director di)
        {
            db.Directors.Remove(di);
            db.SaveChanges();
        }
        public void UpdateDirector()
        {
            db.SaveChanges();
        }

    }
}
