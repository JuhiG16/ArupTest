using BestCandidateSearchApp.Models;
using BestCandidateSearchApp.Services;
using BestCandidateSearchApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BestCandidateSearchApp.Controllers
{

    public class CandidateController : Controller
    {
        private readonly ICandidateRepository _candidateServices;
        private readonly IPositionRepository _positionServices;

        public CandidateController(ICandidateRepository candidateServices, IPositionRepository positionServices)
        {
            this._candidateServices = candidateServices;
            this._positionServices = positionServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BestCandidate(int posId)
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
                return RedirectToAction("NotFount");
                
            }
            
        }

        public IActionResult NotFount()
        {
            ViewBag.message = "Candidate not found";
            return View();
        }


    }
}