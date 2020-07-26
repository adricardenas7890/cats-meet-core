using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatsMeetCore.Model 
{

    public class HumanUser : User 
    {
        public string Status {get;set;}
        public static HumanUser GetHumanUser() {
            HumanUser cat = new HumanUser();

            return cat;
        }
    }

}