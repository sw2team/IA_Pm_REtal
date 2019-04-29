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
        public List<Projects> projects { get; set; }
        public List<Projects> PmProjects { get; set; }
        public List<Projects> CuProjects { get; set; }
        public List<ASTPM> aSTPMs { get; set; }
        public UserAccount userAccount { get; set; }
        public Skills skillT { get; set; }
        public Projects project { get; set; }

    }

}