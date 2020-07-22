using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Conversation
    {
        public Conversation()
        {
            ConvoInFile = new HashSet<ConvoInFile>();
            Message = new HashSet<Message>();
            UserInConvo = new HashSet<UserInConvo>();
        }

        public int ConversationId { get; set; }
        public string Subject { get; set; }

        public virtual ICollection<ConvoInFile> ConvoInFile { get; set; }
        public virtual ICollection<Message> Message { get; set; }
        public virtual ICollection<UserInConvo> UserInConvo { get; set; }
    }
}
