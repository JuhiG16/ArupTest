using NUnit.Framework;
using BestCandidateSearchApp.Controllers;
using BestCandidateSearchApp.Services;
using BestCandidateSearchApp.Models;
using System.Collections.Generic;
using System.Linq;

//using BestCandidateSearchApp.

namespace Tests
{
    
    public class CandidatesServicesTest
    {
        private readonly ICandidateRepository _candidateServices;
        

        public CandidatesServicesTest()
        {
            //Arrange
            _candidateServices = new CandidateRepository();
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Candidate_return_Count_Test()
        {
            //Act
            int count =_candidateServices.GetAll().Count();
            //Assert
            Assert.AreEqual(count, 6);
        }

        [Test]
        public void Search_Candidate_by_Skills_Test()
        {
            //Arrange
                List<string> skills = new List<string> { "Javascript", ".Net", "C#", "MVC", "SQL" };
            //Act
            Candidate candidate = _candidateServices.SearchCandidateBySkills(skills);
            //Assert
            Assert.AreEqual(candidate.CandidateId, 3);
        }

        [Test]
        public void Search_Candidate_by_id_Test()
        {
            //Arrange
            int id = 1;
            //Act
            Candidate candidate = _candidateServices.GetById(id);
            //Assert
            Assert.AreEqual(candidate.Name, "John Smith");
        }

        [Test]
        public void Candidate_NotFound_Test()
        {
            //Arrange
            List<string> skills = new List<string> { "Hadup","VB.Net" };
            //Act
            Candidate candidate = _candidateServices.SearchCandidateBySkills(skills);
            //Assert
            Assert.AreEqual(null, candidate);
        }
    }
}