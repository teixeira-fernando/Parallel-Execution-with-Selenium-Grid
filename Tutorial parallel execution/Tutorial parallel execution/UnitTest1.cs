using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Tutorial_parallel_execution
{
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.Firefox)]
    [TestFixture(BrowserType.Opera)]
    [TestFixture(BrowserType.IE)]
    [Parallelizable(ParallelScope.Fixtures)]
    public class GoogleTesting : Hooks
    {
        public GoogleTesting(BrowserType browser) : base(browser)
        {
            
        }

        [Test]
        public void GoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("selenium");
            Driver.FindElement(By.Name("btnK")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                "The text selenium doenst exist");
        }
    }

}
