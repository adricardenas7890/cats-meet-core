using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatsMeetCore.Model 
{

    public class User 
    {      
        [Key] // Adds ID as identity column. Will create this ID automatically
        public int UserID {get;set;}

        [Required] // Name cannot be null
        public string Name {get;set;}
    }
}