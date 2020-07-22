using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public int ConvoId { get; set; }
        public int UserSentId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Contents { get; set; }

        public virtual Conversation Convo { get; set; }
    }
}
