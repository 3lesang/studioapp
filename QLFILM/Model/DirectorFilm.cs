using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.Model
{
    class DirectorFilm
    {
        public DirectorFilm()
        {
        }
        [Key]
        [Column(Order = 1)]
        public string FID { get; set; }
        [Key]
        [Column(Order = 2)]
        public string DID { get; set; }
        public virtual Film Film { get; set; }
        public virtual Director Director { get; set; }
    }
}
