using BestCandidateSearchApp.Models;
using BestCandidateSearchApp.Services;
using BestCandidateSearchApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BestCandidateSearchApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

