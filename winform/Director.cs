using System;
using System.Collections.Generic;

namespace winform
{
    public partial class Director
    {
        public Director()
        {
            this.Films = new HashSet<Film>();
        }
        public string DID { get; set; }
        public string DirectorName { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
