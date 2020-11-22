using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace atqc_training
{
    [Parallelizable(ParallelScope.Fixtures)]
    [TestFixture]
    public class DemoUi1Tests
    {
        IWebDriver webdriver;
        const string url = "https://www.epam.com/";

        public DemoUi1Tests()
        {
            DesiredCapabilities browser = DesiredCapabilities.Chrome();
            webdriver = new RemoteWebDriver(new Uri("http://192.168.0.101:4444/wd/hub"), browser);
            //webdriver = new ChromeDriver();
            webdriver.Manage().Window.Maximize();
        }


        [Test]
        public void DemoUI1Method1()
        {
            webdriver.Navigate().GoToUrl(url);
            var wait = new WebDriverWait(webdriver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("ul[class=header__controls] a[href$=contact]"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/about/who-we-are/contact"));

        }

        [Test]
        public void DemoUI1Method2()
        {
            webdriver.Navigate().GoToUrl(url);
            var wait = new WebDriverWait(webdriver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("ul[class=header__controls] a[href$=contact]"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/about/who-we-are/contact"));
        }

        [Test]
        public void DemoUI1Method3()
        {
            webdriver.Navigate().GoToUrl(url);
            var wait = new WebDriverWait(webdriver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("ul[class=header__controls] a[href$=contact]"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/about/who-we-are/contact"));
        }


        [OneTimeTearDown]
        public void Quit()
        {
            webdriver.Quit();
        }
    }
}
