using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Tutorial_parallel_execution
{

    public class Base
    {
        public bool remoteOrLocal = true;
        public IWebDriver Driver { get; set; }
    }
}
