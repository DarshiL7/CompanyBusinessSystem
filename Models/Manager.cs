using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBusinessApplication.Models
{
    public class Manager
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ManagerId { get; set; }

        public string ManagerName { get; set; }

        public string ManagerAddress { get; set; }

        public string ManagerMobile { get; set; }

        public bool Status { get; set; }
    }
}
