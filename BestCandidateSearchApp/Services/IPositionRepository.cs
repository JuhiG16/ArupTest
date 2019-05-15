using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestCandidateSearchApp.Models;

namespace BestCandidateSearchApp.Services
{
    public interface IPositionRepository
    {
        IEnumerable<Position> GetAll();
        Position GetById(int id);
    }
}
