using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pm_retal.Models
{
    public class Skills
    {
        public int id { get; set; }
        public string skillName { get; set; }
        public int value { get; set; }
        public int user_type_id { get; set; }
    }
}