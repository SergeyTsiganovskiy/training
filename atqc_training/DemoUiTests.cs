using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace atqc_training
{
    [TestFixture]
    public class DemoTUIests
    {
        IWebDriver webdriver;

        public DemoTUIests()
        {
            DesiredCapabilities browser = DesiredCapabilities.Chrome();
            webdriver = new RemoteWebDriver(new Uri("http://192.168.0.101:4444/wd/hub"), browser);
            webdriver.Manage().Window.Maximize();
        }

        [SetUp]
        public void Preconditions()
        {
            string url = "https://www.epam.com/";
            webdriver.Navigate().GoToUrl(url);
        }

        [Test]
        public void DemoUIMethod1()
        {
            var wait = new WebDriverWait(webdriver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("ul[class=header__controls] a[href$=contact]"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/about/who-we-are/contact"));

        }

        [Test]
        public void DemoUIMethod2()
        {
            var wait = new WebDriverWait(webdriver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("ul[class=header__controls] a[href$=contact]"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/about/who-we-are/contact"));
        }

        [Test]
        public void DemoUIMethod3()
        {
            var wait = new WebDriverWait(webdriver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("ul[class=header__controls] a[href$=contact]"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/about/who-we-are/contact"));
        }

        [Test]
        public void DemoUIMethod4()
        {
            var wait = new WebDriverWait(webdriver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("ul[class=header__controls] a[href$=contact]"))).Click();
            Assert.IsTrue(false);
        }


        [OneTimeTearDown]
        public void Quit()
        {
            webdriver.Quit();
        }
    }
}
