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
        // private IWebElement inputSearchFilter => driver.FindElement(By.XPath("//*[@id='listView-8884-FilterFormfilter_text-input']"));
        // #listView-7bb4-FilterForm_applyButton
        private IWebElement btnRunReport => driver.FindElement(By.Name("FilterForm_applyButton"));

       
        private IWebElement listViewNameLink => driver.FindElement(By.ClassName("listViewNameLink"));
        private IWebElement lblActivityLog => driver.FindElement(By.XPath("//span[@class='subtab-icon input-icon module-ActivityLog']"));
        private IWebElement lblAction => driver.FindElement(By.Id("listView-2765-ActionButtonHead"));
        private IWebElement reportNavBar => driver.FindElement(By.XPath("//*[@id=\'left-sidebar\']/div[2]/a"));
        private IWebElement searchBarReport => driver.FindElement(By.XPath("//*[@id=\'filter_text\']"));

        // Methods

        public void NavigateToReportsAndSettings() 
        {
            Thread.Sleep(1000);
            var element = driver.FindElement(By.XPath("//*[@id='grouptab-5']"));
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
            // //*[@id="listView-d9f3-main"]/tbody/tr/td[1]/div
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
            lblActivityLog.Click();
        }

        public void VerifyResultsOfTheRun() 
        {

        }

        public void SelectItemsOnComboBoxes() 
        {
            List<IWebElement> checkList = (List<IWebElement>)driver.FindElement(By.ClassName("listViewTd listViewMeta"));
            for (int i = 0; i < checkList.Count; i++)
            {

            }
            
            // cb3 = //*[@id="listView-aee1-main"]/tbody/tr[3]/td[1]/div/input
            // cb2 = //*[@id="listView-aee1-main"]/tbody/tr[2]/td[1]/div/input
            //cb1 = //*[@id="listView-aee1-main"]/tbody/tr[1]/td[1]/div/input
        }

        public static void DeleteSelectedItems() 
        {

        }

        public void VerifyItemsAreDeleted() 
        {

        }


    }
}
