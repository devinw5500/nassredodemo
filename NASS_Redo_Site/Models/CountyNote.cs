using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class CountyNote
    {
        public int CountyNoteId { get; set; }
        public string Note { get; set; }
        public int CountyId { get; set; }

        public virtual County County { get; set; }
    }
}
