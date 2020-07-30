using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CatsMeetCore.Model;

namespace CatsMeetCore.Pages
{
    public class LobbyModel : PageModel
    {
        private readonly ILogger<LobbyModel> _logger;

        [BindProperty]
        public IList<CatUser> catUsers {get;set;}
        public LobbyModel(ILogger<LobbyModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
           CatUser cat = new CatUser();
           catUsers = cat.GetCatUsers();
        }
    }
}