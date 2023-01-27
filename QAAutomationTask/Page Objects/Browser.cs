using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace QAAutomationTask.Page_Objects
{
 
    public class Browser: IDisposable
    {
        static IWebDriver _driver = new ChromeDriver();
        
        public static IWebDriver GetInstance()
        {
            return _driver;
        }
        ///[BeforeScenario]

        [AfterScenario]
        [OneTimeTearDown]
        public void Close()
        {
            if (_driver != null)
            {
                _driver.Close();
                _driver.Quit();
            }
        }

        public void Dispose()
        {
            this.Close();
        }
    }
}
