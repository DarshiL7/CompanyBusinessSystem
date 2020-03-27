using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyBusinessApplication.Models
{
    public class BusinessUnit
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int BusinessUnitId { get; set; }

        public string UnitName { get; set; }

        public string UnitAddress { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public int ProjectId { get; set; }
    }
}
