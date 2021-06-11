using System;
using System.Collections.Generic;

namespace winform
{
    public partial class Category
    {
        public Category()
        {
            this.Films = new HashSet<Film>();
        }
        public string CID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
