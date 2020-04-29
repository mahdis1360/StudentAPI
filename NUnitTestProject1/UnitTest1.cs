using NUnit.Framework;
using Pocos;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {


            // Arrange
            StudentPoco studenet=new StudenetPoco()
            {

            }
            Assert.Pass();
        }
    }
}