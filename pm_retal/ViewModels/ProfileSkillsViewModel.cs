using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using pm_retal.Models;

namespace pm_retal.ViewModels
{
    public class ProfileSkillsViewModel
    {
        public List<UserAccount> UserAccount { get; set; }
        public List<Skills> Skills { get; set; }
        
    }

}