using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class User
    {
        public User()
        {
            Client = new HashSet<Client>();
            CurrentStatus = new HashSet<CurrentStatus>();
            Employee = new HashSet<Employee>();
            EmployeeOnOrder = new HashSet<EmployeeOnOrder>();
            OrderClient = new HashSet<OrderClient>();
            UserInConvo = new HashSet<UserInConvo>();
            Vendor = new HashSet<Vendor>();
            WorkflowDetails = new HashSet<WorkflowDetails>();
            WorkflowGroup = new HashSet<WorkflowGroup>();
        }

        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string AspnetuserId { get; set; }

        public virtual AspNetUsers Aspnetuser { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<CurrentStatus> CurrentStatus { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<EmployeeOnOrder> EmployeeOnOrder { get; set; }
        public virtual ICollection<OrderClient> OrderClient { get; set; }
        public virtual ICollection<UserInConvo> UserInConvo { get; set; }
        public virtual ICollection<Vendor> Vendor { get; set; }
        public virtual ICollection<WorkflowDetails> WorkflowDetails { get; set; }
        public virtual ICollection<WorkflowGroup> WorkflowGroup { get; set; }
    }
}
