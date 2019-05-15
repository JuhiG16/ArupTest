using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestCandidateSearchApp.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Name { get; set; }
        public List<String> Skills { get; set; }
    }
}
