using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Person
    {
        public Person()
        {
            PersonInfo = new HashSet<PersonInfo>();
            User = new HashSet<User>();
        }

        public int PersonId { get; set; }
        public string UniqueUserId { get; set; }

        public virtual ICollection<PersonInfo> PersonInfo { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
