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
        [BindProperty]
        public string Name {get;set;}
        [BindProperty]
        public string Pic {get;set;}
        private readonly ILogger<LobbyModel> _logger;

        public LobbyModel(ILogger<LobbyModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}