using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
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
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.google.com/");
          IWebElement signin = webDriver.FindElement(By.LinkText("Sign in"));
            signin.Click();
            Assert.Pass();
        }
    }
}