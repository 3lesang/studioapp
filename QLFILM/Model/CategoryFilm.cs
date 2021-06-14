using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.Model
{
    class CategoryFilm
    {
        public CategoryFilm()
        {
        }
        [Key]
        [Column(Order = 1)]
        public string FID { get; set; }
        [Key]
        [Column(Order = 2)]
        public string CID { get; set; }
        public Film Film { get; set; }
        public Category Category { get; set; }
    }
}
