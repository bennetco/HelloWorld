using NUnit.Framework;

namespace HelloWorldCommon.Test
{
    [TestFixture]
    public class UnitTest1
    { 
        

        [SetUp]
        public void Blah()
        {
        }


        [Test]
        public void TestMethod1()
        {
            var k = "";
            Assert.That(k.Equals(k));
        }
    }
}
