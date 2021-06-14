using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.Model
{
    class Director
    {
        public Director()
        {
            this.Films = new HashSet<Film>();
        }
        [Key]
        public string DID { get; set; }
        public string DirectorName { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
