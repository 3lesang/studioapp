using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.Model
{
    class Film
    {
        public Film()
        {
            this.Actors = new HashSet<Actor>();
            this.Categories = new HashSet<Category>();
            this.Directors = new HashSet<Director>();
        }
        [Key]
        public string FID { get; set; }
        public string EnglishTitle { get; set; }
        public string VietnameseTitle { get; set; }
        public int Year { get; set; }
        public Nullable<double> Length { get; set; }
        public Nullable<double> Rating { get; set; }
        public Nullable<double> Gross { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Director> Directors { get; set; }
    }
}
