using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.DAO
{
    class DAOFilm
    {
        Context db;
        public DAOFilm()
        {
            db = new Context();
        }
        public dynamic GetFilm()
        {
            return db.Films.ToList();
        }
    }
}
