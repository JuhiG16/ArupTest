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
        private readonly ICandidateServices _candidateServices;
        private readonly IPositionServices _positionServices;

        public HomeController(ICandidateServices candidateServices, IPositionServices positionServices)
        {
            this._candidateServices = candidateServices;
            this._positionServices = positionServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Positions()
        {
            IEnumerable<PositionViewModel> vmPositions = _positionServices.GetAll().
                Select(p => new PositionViewModel
                {
                    PositionId = p.PositionId,
                    Name = p.Name,
                    Skills = p.Skills
                });
            return View(vmPositions);
        }

        [HttpGet]
        public IActionResult SearchCandidate(int posId)
        {
            Position p = _positionServices.GetById(posId);
            Candidate candidate = _candidateServices.SearchCandidateBySkills(p.Skills);
            if (null != candidate)
            {
                CandidateViewModel vmCandidate = new CandidateViewModel
                {
                    CandidateId = candidate.CandidateId,
                    Name = candidate.Name,
                    Email = candidate.Email,
                    Phone = candidate.Phone,
                    Skills = candidate.Skills
                };
                return View(vmCandidate);
            }
            else
            {
                ViewBag.message = "Candidate not found";
                return View();
            }
        }
    }
}

//List<CandidateViewModel> vmCandidates = candidates.Select(c => new CandidateViewModel
//{
//    CandidateId = c.CandidateId,
//    Name = c.Name,
//    Email = c.Email,
//    Phone = c.Phone,
//    Skills = c.Skills
//}).ToList();


//return View(vmCandidates);
//}
//else
//{
//    ViewBag.message = "Candidate not found";
//    return View();
//}


