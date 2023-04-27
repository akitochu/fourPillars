using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class PersonTests
    {
        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            //arange
            var subject = new Person(fName, lName);
            //act
            var result = subject.FullName;
            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }

        [Test]
        public void Point3DTest()
        {
            var subject = new Point3D(1, 3, 5);
            var result = new Point3D(1, 3, 5);
            Assert.AreEqual(result, subject);
        }
    }
}
