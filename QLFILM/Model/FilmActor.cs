using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.Model
{
    class FilmActor
    {
        public FilmActor()
        {
        }
        [Key]
        [Column(Order = 1)]
        public string FID { get; set; }
        [Key]
        [Column(Order = 2)]
        public string AID { get; set; }
        public virtual Film Film { get; set; }
        public virtual Actor Actor { get; set; }
    }
}
