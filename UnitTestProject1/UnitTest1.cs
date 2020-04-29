using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pocos;
using System;
using Logic;
using Moq;
using Repository;
using EFRepo;
using DTO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Logic_Create_Method( )
        {
            //Arange
            StudentDto student = new StudentDto()
            {
               //d = Guid.NewGuid(),
                Name = "Sally Jones",
                DoB = DateTime.Now,
                course = "NET 31"

            };

            Mock<EfRepo> mock = new Mock<EfRepo>();
            StudentLogic logic = new StudentLogic(mock.Object);

            //Act
            try
            {
                logic.Create(student);
            }
            catch (Exception)
            {

                Assert.Fail("bad happen accured");
            }
            

        }

        [TestMethod]
        public void  Test_logic_Get_Method()
        {
            //Arrange
            Guid id = Guid.NewGuid();
            Mock<EfRepo> mock = new Mock<EfRepo>();
            StudentLogic logic = new StudentLogic(mock.Object);
            mock.Setup(repo => repo.Get(id)).Returns(new StudentPoco()
            {

                Id = Guid.NewGuid(),
                Name ="Joe Smith",
                DoB=DateTime.Now,
                course="NET Bridging Program",

            });     
            
            //Act
           StudentPoco poco= logic.Get(id);
            //Assert
            Assert.IsNotNull(poco);
            Assert.AreEqual("Joe Smith", poco.Name);
        }
    }
}
