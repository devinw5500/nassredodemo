using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class UserInConvo
    {
        public int UserInConvoId { get; set; }
        public int UserId { get; set; }
        public int ConvoId { get; set; }

        public virtual Conversation Convo { get; set; }
        public virtual User User { get; set; }
    }
}
