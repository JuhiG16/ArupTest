using BestCandidateSearchApp.Models;
using BestCandidateSearchApp.Services;
using BestCandidateSearchApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace BestCandidateSearchApp.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionRepository _positionServices;

        public PositionController(IPositionRepository positionServices)
        {
            
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
    }
}