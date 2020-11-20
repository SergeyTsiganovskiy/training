using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace atqc_training
{
    [TestFixture]
    public class DemoTests
    {

        [Test]
        public void DemoMethod1()
        {
            Assert.IsTrue(2 + 2 == 4);
        }

        [Test]
        public void DemoMethod2()
        {
            Assert.IsTrue(2 - 2  == 0);
        }

        [Test]
        public void DemoMethod3()
        {
            Assert.IsTrue(2 + 3 == 5);
        }

        [Test]
        public void DemoMethod4()
        {
            Assert.IsTrue(3 - 2 == 1);
        }
    }
}
