using EasyGym.Data.Models;
using EasyGym.Repository;
using Moq;
using System;
using Xunit;

namespace GymTestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var newTrainingTest = new Training
            {
                TrainingID = 1,
                Data = DateTime.Now,
                NameTraining = "Test",
               
            };
            var context = new Mock<GymContext>();
            var mockTrainingRepo = new Mock<ITrainingRepository>();
            mockTrainingRepo.Setup(x=> x.Add(newTrainingTest));
            mockTrainingRepo.Object.Add(newTrainingTest);
            mockTrainingRepo.Verify(x => x.Add(newTrainingTest), Times.Once());
        }
    }
}
