using NUnit.Framework;

namespace addressbook_web_tests
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
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            Assert.AreEqual(s1.Size, 5);
            Assert.AreEqual(s2.Size, 10);
            Assert.AreEqual(s3.Size, 5);

            s3.Size=(15);

            Assert.AreEqual(s1.Size, 15);

        }


        [Test]
        public void Test2()
        {
            Circle s1 = new Circle(5);
            Circle s2 = new Circle(10);
            Circle s3 = s1;

            Assert.AreEqual(s1.Raduis, 5);
            Assert.AreEqual(s2.Raduis, 10);
            Assert.AreEqual(s3.Raduis, 5);

            s3.Raduis = (15);

            Assert.AreEqual(s1.Raduis, 15);

        }
    }
}