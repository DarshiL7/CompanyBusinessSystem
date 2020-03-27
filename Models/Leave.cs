using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyBusinessApplication.Models
{
    public class Leave
    {
            
        public int LeaveId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string LeaveReason { get; set; }
        [ForeignKey(nameof(EmpId))]
        public int EmpId { get; set; }
    }
}
