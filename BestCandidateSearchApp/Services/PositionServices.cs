using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestCandidateSearchApp.Models;

namespace BestCandidateSearchApp.Services
{
    public class PositionServices : IPositionServices
    {
         IEnumerable<Position> positions = new List<Position>
            {
                new Position{ PositionId = 101, Name="Database developer",
                    Skills = new List<string>{"Sql", "MongoDb", "Javascript"} },
                 new Position{ PositionId = 102, Name="React developer",
                    Skills = new List<string>{"Sql", "React.js", "Javascript"} },
                  new Position{ PositionId = 103, Name="Java developer",
                    Skills = new List<string>{"Sql", "Java", "Javascript"} },
                   new Position{ PositionId = 104, Name=".Net developer",
                    Skills = new List<string>{"C#", "MVC", "SQL", "Javascript","MongoDb" } },
                    new Position{ PositionId = 105, Name="Database developer",
                    Skills = new List<string>{ "C#", "MVC", "SQL", ".net", "Html", "CSS"} },
                    new Position{ PositionId = 106, Name="PHP developer",
                    Skills = new List<string>{ "PHP"} }
            };
        

        public IEnumerable<Position> GetAll()
        {
            return positions.ToList();
        }

        public Position GetById(int id)
        {
            return positions.SingleOrDefault(p => p.PositionId == id);
        }
    }
}
//public PositionServices()
//{
//    positions = new List<Position>
//    {
//        new Position{ PositionId = 101, Name="Database developer",
//            Skills = new List<string>{"Sql", "MongoDb", "Javascript"} },
//         new Position{ PositionId = 102, Name="React developer",
//            Skills = new List<string>{"Sql", "React.js", "Javascript"} },
//          new Position{ PositionId = 103, Name="Java developer",
//            Skills = new List<string>{"Sql", "Java", "Javascript"} },
//           new Position{ PositionId = 104, Name=".Net developer",
//            Skills = new List<string>{"C#", "MVC", "SQL", "Javascript","MongoDb" } },
//            new Position{ PositionId = 105, Name="Database developer",
//            Skills = new List<string>{ "C#", "MVC", "SQL", ".net", "Html", "CSS"} }
//    };
//}