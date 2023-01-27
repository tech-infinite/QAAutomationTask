using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAutomationTask.Page_Objects
{
    public class Reports: BasePage
    {
        
          // Web elements
        private IWebElement lnkReports => driver.FindElement(By.XPath("/html/body/nav/div[2]/div[6]/div[1]/a"));
        private IWebElement btnRunReport => driver.FindElement(By.Name("FilterForm_applyButton"));    
        private IWebElement listViewNameLink => driver.FindElement(By.ClassName("listViewNameLink"));
        private IWebElement lblActivityLog => driver.FindElement(By.XPath("//span[@class='subtab-icon input-icon module-ActivityLog']"));
        private IWebElement lblAction => driver.FindElement(By.Id("listView-2765-ActionButtonHead"));
        private IWebElement reportNavBar => driver.FindElement(By.XPath("//*[@id=\'left-sidebar\']/div[2]/a"));
        private IWebElement searchBarReport => driver.FindElement(By.XPath("//*[@id=\'filter_text\']"));

        private IWebElement actionButton => driver.FindElement(By.Id("listView-e595-ActionButtonHead"));
        private IWebElement checkBox1 => driver.FindElement(By.XPath("//*[@id=\'listView-aee1-main\']/tbody/tr[1]/td[1]/div/input"));
        private IWebElement checkBox2 => driver.FindElement(By.XPath("//*[@id=\'listView-aee1-main\']/tbody/tr[2]/td[1]/div/input"));
        private IWebElement checkBox3 => driver.FindElement(By.XPath("//*[@id=\'listView-aee1-main\']/tbody/tr[3]/td[1]/div/input"));

        // Methods

        public void NavigateToReportsAndSettings() 
        {
            Thread.Sleep(1000);
            var element = driver.FindElement(By.ClassName("mouseonly.menu-tab.reports-settings.current"));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);
            lnkReports.Click();
            
        }

        public void SelectReportNavbar() 
        {
            Thread.Sleep(1000);
            reportNavBar.Click();
        }

        public void SearchReport() 
        {
            Thread.Sleep(1000);
            searchBarReport.Click();
            searchBarReport.SendKeys("Project Profitability");
            Thread.Sleep(1000);
            searchBarReport.SendKeys(Keys.Enter);

        }

        public void RunReport() 
        {
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            var element = driver.FindElement(By.Name("mass[]"));
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);
            element.Click();
            listViewNameLink.Click();
            Thread.Sleep(1000);
            btnRunReport.Click();
        }

        public void NavigateToActivityLog() 
        {
            NavigateToReportsAndSettings();
            lblActivityLog.Click();
            Assert.AreEqual("Activity Log", false);
        }

        public void VerifyResultsOfTheRun() 
        {

        }

        public void SelectItemsOnComboBoxes() 
        {
            bool isCheckBoxSelected = false;

            if (!isCheckBoxSelected)
            {
                checkBox1.Click();
                checkBox2.Click();
                checkBox3.Click();
            }
           
     
        }

        public void DeleteSelectedItems() 
        {
            
        }

        public void VerifyItemsAreDeleted() 
        {

        }


    }
}
