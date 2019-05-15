using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestCandidateSearchApp.ViewModels
{
    public class PositionViewModel
    {
        public int PositionId { get; set; }
        public string Name { get; set; }
        public List<String> Skills { get; set; }
    }
}
