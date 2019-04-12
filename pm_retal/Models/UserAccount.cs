using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace pm_retal.Models
{
    public class UserAccount
    {

        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "FullName is required")]
        public string FullName { get; set; }
        //[Required(ErrorMessage = "Img is required")]
        [DisplayName("Upload File")]
        public string ImagePath { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
        [Required(ErrorMessage = "JobDescription is required")]
        public string JobDescription { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; }
       [Required(ErrorMessage ="Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="please confirm password.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public int UserType_Id { get; set; }
       

    }

}