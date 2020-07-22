using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class ConvoInFile
    {
        public int ConvoInFileId { get; set; }
        public int ConvoId { get; set; }
        public int FileId { get; set; }

        public virtual Conversation Convo { get; set; }
    }
}
