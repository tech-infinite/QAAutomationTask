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

namespace QAAutomationTask.Page_Objects
{
    public class BasePage
    {
        public IWebDriver driver;
        public string url = "https://demo.1crmcloud.com/";
        public void SetDriver(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToHomepage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void WaitForElement(IWebElement element, int timeOutSeconds = 30)
        {
            int counter = 0;
            while (!element.Enabled)
            {
                Thread.Sleep(1000);
                counter++;

                if (counter >= timeOutSeconds)
                {
                    break;
                }
            }

        }



    }
}
