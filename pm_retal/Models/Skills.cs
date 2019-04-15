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
        public string skillName { get; set; }
        public int value { get; set; }
        public int user_type_id { get; set; }
    }
}