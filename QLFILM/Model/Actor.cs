using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.Model
{
    class Actor
    {
        public Actor()
        {
            this.Films = new HashSet<Film>();
        }
        [Key]
        public string AID { get; set; }
        public string ActorName { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
