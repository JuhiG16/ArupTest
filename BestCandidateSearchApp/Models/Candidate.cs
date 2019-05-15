using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestCandidateSearchApp.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<string> Skills { get; set; }
    }
}
