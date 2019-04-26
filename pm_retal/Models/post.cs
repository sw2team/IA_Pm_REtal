using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pm_retal.Models
{

    public class Post
    {

        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Write SomeThing....")]
        public string post_Description { get; set; }
        public int Customer_ID { get; set; }


    }
}
    