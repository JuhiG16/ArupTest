using NUnit.Framework;
using BestCandidateSearchApp.Controllers;
using BestCandidateSearchApp.Services;
using BestCandidateSearchApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1
{
    
    class PositionServiceTest
    {
        private readonly IPositionServices _positionServices;
        public PositionServiceTest()
        {
            _positionServices = new PositionServices();
        }

        [Test]
        public void Position_return_Count_Test()
        {
            //Act
            int count = _positionServices.GetAll().Count();
            //Assert
            Assert.AreEqual(count, 6);
        }

        [Test]
        public void Search_Position_by_id_Test()
        {
            //Arrange
            int id = 104;
            //Act
            Position position = _positionServices.GetById(id);
            //Assert
            Assert.AreEqual(position.Name, ".Net developer");
        }
    }
}
