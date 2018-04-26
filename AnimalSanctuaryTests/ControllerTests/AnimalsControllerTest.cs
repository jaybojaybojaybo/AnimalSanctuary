using System;
using System.Collections.Generic;
using System.Text;
using AnimalSanctuary.Models;
using AnimalSanctuary.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Linq;

namespace AnimalSanctuaryTests.ControllerTests
{
    [TestClass]
    public class AnimalsControllerTest
    {

        [TestMethod]
        public void AnimalsController_IndexModelContainsCorrectData_List()
        {
            //Arrange
            Mock<IAnimalSanctuaryRepository> mock = new Mock<IAnimalSanctuaryRepository>();
            mock.Setup(m => m.Animals).Returns(new Animal[]
            {
                new Animal {AnimalId = 1, Name="Bob", Species = "Builder", Sex = "M", HabitatType="Civilization", MedicalEmergency = false, VetId = 1 },
                new Animal {AnimalId = 2, Name="Reggie", Species = "Octopus", Sex = "F", HabitatType="Ocean", MedicalEmergency = false, VetId = 1 }
            }.AsQueryable());
            AnimalsController controller = new AnimalsController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = new AnimalsController(mock.Object).Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Animal>));

        }
    }
}
