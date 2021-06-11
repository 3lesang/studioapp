using System;
using System.Collections.Generic;

namespace winform
{    
    public class Actor
    {
        public Actor()
        {
            this.Films = new HashSet<Film>();
        }
        public string AID { get; set; }
        public string ActorName { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
