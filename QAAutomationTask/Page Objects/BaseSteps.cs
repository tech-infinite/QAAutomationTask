using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.DevTools.V106.Debugger;

namespace QAAutomationTask.StepDefinitions
{
    public class BaseSteps
    {
        public IWebDriver _driver;
        public string url = "https://demo.1crmcloud.com/";
        public BaseSteps()
        {
            _driver = new ChromeDriver();
        }

        [AfterScenario]
        //[OneTimeTearDown]
        public void Close()
        {
            if (_driver != null)
            {
                _driver.Close();
                //driver.Dispose();
                _driver.Quit();
            }
        }
    }
}
