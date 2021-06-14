using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.Model
{
    class Category
    {
        public Category()
        {
            this.Films = new HashSet<Film>();
        }
        [Key]
        public string CID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
