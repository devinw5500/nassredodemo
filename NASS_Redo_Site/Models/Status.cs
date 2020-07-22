using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Status
    {
        public Status()
        {
            CurrentStatus = new HashSet<CurrentStatus>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CurrentStatus> CurrentStatus { get; set; }
    }
}
