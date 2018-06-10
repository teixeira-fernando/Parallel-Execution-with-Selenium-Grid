using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace Tutorial_parallel_execution
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE,
        Opera
    }

    public class Hooks : Base
    {
        private BrowserType _browserType;

        public Hooks(BrowserType browser)
        {
            _browserType = browser;
        }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
            
        }

        private void ChooseDriverInstance(BrowserType browser)
        {
            if (remoteOrLocal == false)
            {
                if (browser == BrowserType.Chrome)
                {
                    Driver = new ChromeDriver();
                }
                else if (browser == BrowserType.Firefox)
                {
                    var driverService = FirefoxDriverService.CreateDefaultService();
                    driverService.FirefoxBinaryPath = "C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe";
                    driverService.HideCommandPromptWindow = true;

                    Driver = new FirefoxDriver(driverService);
                    Driver.Manage().Window.Maximize();
                }
            }
            else
            {
                DesiredCapabilities capability = new DesiredCapabilities();
                capability.SetCapability("platform", "WINDOWS");
                if (browser == BrowserType.Chrome)
                {
                    capability = DesiredCapabilities.Chrome();
                }
                else if (browser == BrowserType.Firefox)
                {
                    capability = DesiredCapabilities.Firefox();               
                }
                else if (browser == BrowserType.Opera)
                {
                    capability = DesiredCapabilities.Opera();
                }
                else if (browser == BrowserType.IE)
                {
                    capability = DesiredCapabilities.InternetExplorer();
                }
                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability);
             
            }
            
        }

    }
}
