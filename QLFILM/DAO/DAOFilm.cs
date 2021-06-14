﻿using System;
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
            return db.Films.Select(s => new {
                s.FID,
                s.EnglishTitle,
                s.VietnameseTitle,
                s.Year,
                s.Length,
                s.Rating,
                s.Gross
            }).ToList();
        }
        public dynamic GetActor()
        {
            var actor = db.Actors
                .SqlQuery("select AID, ActorName from Actors").ToList();
            return actor;
        }
        public dynamic GetDirector()
        {
            var actor = db.Directors
                .SqlQuery("select DID, DirectorName from Directors").ToList();
            return actor;
        }
        public dynamic GetCategory()
        {
            var actor = db.Categories
                .SqlQuery("select CID, CategoryName from Categories").ToList();
            return actor;
        }
    }
}