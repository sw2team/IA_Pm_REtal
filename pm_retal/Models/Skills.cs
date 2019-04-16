using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace pm_retal.Models
{
    public class Skills
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Skill name is required")]
        public string skillName { get; set; }
        [Required(ErrorMessage = "Value is required")]
        public int value { get; set; }
        public int Suser_id { get; set; }
    }
}