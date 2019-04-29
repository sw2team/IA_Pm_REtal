using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace pm_retal.Models
{

    public class Projects
    {

        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Write SomeThing....")]
        public string post_Name { get; set; }
        [Required(ErrorMessage = "Write SomeThing....")]
        public string post_Description { get; set; }
        [ForeignKey("CAccount")]
        public int Customer_ID { get; set; }
        [ForeignKey("PAccount")]
        public int PM_ID { get; set; }
        public string status { get; set; }
        public virtual UserAccount CAccount { get; set; }
        public virtual UserAccount PAccount { get; set; }

    }
}
    