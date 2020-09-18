using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using DotNetRazorDemo.Models;
using DotNetRazorDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotNetRazorDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserRepository _userRepository;

        [BindProperty]
        public User newUser { get; set; }
        public List<User> allUsers { get; set; }
       
        public IndexModel(ILogger<IndexModel> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        public void OnGet()
        {
            allUsers = (List<User>)_userRepository.getAllUsers();
        }

        public IActionResult OnPost()
        {
            _userRepository.addUser(newUser);
            allUsers = (List<User>)_userRepository.getAllUsers();
            return RedirectToPage("index");
        }

    }
}
