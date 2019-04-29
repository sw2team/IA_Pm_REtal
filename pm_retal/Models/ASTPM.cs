using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace pm_retal.Models
{
    public class ASTPM
    {

        [Key]
        public int ID { get; set; }
        [ForeignKey("PM_Account")]
        public int PM_ID { get; set; }
        [ForeignKey("Project")]
        public int Project_ID { get; set; }
        [ForeignKey("CU_Account")]
        public int Customer_ID { get; set; }
        public virtual UserAccount PM_Account { get; set; }
        public virtual UserAccount CU_Account { get; set; }
        public virtual Projects Project { get; set; }
    }
}