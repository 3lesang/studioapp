using QLFILM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.DAO
{
    class DAOActor
    {
        Context db;
        public DAOActor()
        {
            db = new Context();
        }
        public dynamic GetActor()
        {
            return db.Actors.Select(s => new
            {
                s.AID,
                s.ActorName
            }).ToList();
        }
        public void AddActor(Actor ac)
        {
            db.Actors.Add(ac);
            db.SaveChanges();
        }
    }
}
