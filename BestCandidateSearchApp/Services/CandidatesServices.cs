using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestCandidateSearchApp.Models;

namespace BestCandidateSearchApp.Services
{
    public class CandidatesServices :ICandidateServices
    {
        IEnumerable<Candidate> candidates = new List<Candidate>
            {
                new Candidate {CandidateId = 1, Name = "John Smith", Email="John.smith@gmail.com",
                     Phone="987654321", Skills = new List<string>{"C#", "MVC", "SQL" } },
                new Candidate {CandidateId = 2, Name = "Sem S", Email="Sem.s@gmail.com",
                     Phone="048769999", Skills = new List<string>{"C#", "MVC", "SQL", ".net" } },
                new Candidate {CandidateId = 3, Name = "Jemi L", Email="Jemi.L@gmail.com",
                     Phone="048769911", Skills = new List<string>{"Javascript", ".Net","C#", "MVC", "SQL" } },
                new Candidate {CandidateId = 4, Name = "Pam p", Email="Pam.p@gmail.com",
                     Phone="0412368799", Skills = new List<string>{"C#", "MVC", "SQL", "Javascript","MongoDb" } },
                new Candidate {CandidateId = 5, Name = "Adam J", Email="Adam.J@gmail.com",
                     Phone="041237590", Skills = new List<string>{"C#", "MVC", "SQL","React.js" } },
                new Candidate {CandidateId = 6, Name = "Mads J", Email="Mads.J@gmail.com",
                     Phone="041237590", Skills = new List<string>{"PHP"} },
                new Candidate {CandidateId = 7, Name = "Alan J", Email="Alan.J@gmail.com",
                     Phone="041237590", Skills = new List<string>{"PHP"} },

            };

        public CandidatesServices()
        {
           
        }

        public IEnumerable<Candidate> GetAll()
        {
            return candidates.ToList();
        }

        public Candidate GetById(int id)
        {
            return candidates.SingleOrDefault(c => c.CandidateId == id);
        }

        public Candidate SearchCandidateBySkills (List<string> skills)
        {
            int skillCount = 0;
            Candidate bestCandidate = new Candidate();
            foreach (var candidate in candidates)
            {

                int currentCount = candidate.Skills.Intersect(skills).Count();
                if (skillCount < currentCount)
                {
                    skillCount = currentCount;
                    bestCandidate = candidate;
                }
            }
            if (skillCount > 0)
                return bestCandidate;
            else return null;
        }
    }
}
