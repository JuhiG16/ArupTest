using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestCandidateSearchApp.ViewModels
{
   //This class is not required for the Arup solution.
    public class PositionCreateViewModel
    {
        [Required]
        public int PositionId { get; set; }
        [Required(ErrorMessage = "Please provide Position Name.")]
        [StringLength(256, ErrorMessage = "Position Name is very large.")]
        [RegularExpression(@"^[a-zA-Z.]{2,}$", ErrorMessage = "Position Name can contain only alphabets and should have min 2 letters.")]
        public string Name { get; set; }
        [Required]
        public List<String> Skills { get; set; }
    }
}
