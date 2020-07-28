using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatsMeetCore.Model 
{

    public class CatUser : User 
    {
        public string Mood {get;set;}
        public string Picture {get;set;} = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg";
        public string Status {get;set;}

        public List<CatUser> GetCatUsers() {

            Random rnd = new Random();
            List<CatUser> catUsers = new List<CatUser>();

            // Number of online users
            int onlineCount = rnd.Next(1,6);

            // API CALL

            // Temporary list of users
            catUsers.Add(new CatUser{UserID= 900, Name = "Jerry", Mood="Content", Status="Online"});
            catUsers.Add(new CatUser{UserID= 901, Name = "Samantha", Mood="Content", Status="Online"});
            catUsers.Add(new CatUser{UserID= 902, Name = "Jerry", Mood="Content", Status="Online"});

            return catUsers;
        }
    }

}