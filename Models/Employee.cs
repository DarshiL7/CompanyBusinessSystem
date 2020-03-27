using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyBusinessApplication.Models
{
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string EmpAddress { get; set; }

        public string EmpMobile { get; set; }

        public bool Status { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public int ProjectId { get; set; }
    }
}
