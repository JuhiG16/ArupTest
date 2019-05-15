using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestCandidateSearchApp.Models;
namespace BestCandidateSearchApp.Services
{
    public interface ICandidateServices
    {

        IEnumerable<Candidate> GetAll();
        Candidate GetById(int id);
        Candidate SearchCandidateBySkills(List<string> skills);
    }
}
