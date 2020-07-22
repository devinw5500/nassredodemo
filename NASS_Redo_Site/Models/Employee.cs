using System;
using System.Collections.Generic;

namespace NASS_Redo_Site.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmpGroup = new HashSet<EmpGroup>();
            EmpRole = new HashSet<EmpRole>();
            ReportOnEmployee = new HashSet<ReportOnEmployee>();
        }

        public int EmployeeId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<EmpGroup> EmpGroup { get; set; }
        public virtual ICollection<EmpRole> EmpRole { get; set; }
        public virtual ICollection<ReportOnEmployee> ReportOnEmployee { get; set; }
    }
}
