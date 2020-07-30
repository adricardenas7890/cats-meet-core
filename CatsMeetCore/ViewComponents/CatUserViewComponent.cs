using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatsMeetCore.Model;

namespace CatsMeetCore.ViewComponents {

    public class CatUserViewComponent : ViewComponent
    {        
        private List<CatUser> catUsers = new List<CatUser>();


        public CatUserViewComponent () {
            
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            var model = catUsers;
            return await Task.FromResult((IViewComponentResult)View("Lobby", model));
        }
        public List<CatUser> GetCatUsersAsync()
        {
            CatUser catUser = new CatUser();
            catUsers = catUser.GetCatUsers().ToList();
            return catUsers;
        }
    }

}