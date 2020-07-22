using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class CurrentStatus
    {
        public int CurrentStatusId { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
