using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyBusinessApplication.Models
{
    public class Project
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; } 

        public DateTime ProjectEndDate { get; set; }

        [ForeignKey(nameof(ManagerId))]
        public int ManagerId { get; set; }

        internal List<Project> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
