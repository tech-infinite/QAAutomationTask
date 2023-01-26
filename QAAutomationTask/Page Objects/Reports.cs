using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAutomationTask.Page_Objects
{
    class Reports: BasePage
    {
        
        public Reports()
        {
            
        }
 
        // Web elements
        // #listView-8884-FilterFormfilter_text-input-select-list > div > div:nth-child(3) > div
        private IWebElement lnkReportsAndSettings => driver.FindElement(By.Id("grouptab-5"));
        private IWebElement lnkReports => driver.FindElement(By.CssSelector("body > nav > div.tab-nav-sub-wrap > div:nth-child(12) > div:nth-child(1) > a"));
        private IWebElement inputSearchFilter => driver.FindElement(By.XPath("//*[@id='listView-8884-FilterFormfilter_text-input']"));
        private IWebElement btnRunReport => driver.FindElement(By.Id("listView-85af-FilterForm_applyButton-label"));

        
        // Methods
        
        public void NavigateToReportsAndSettings() 
        {

        }

        public void SearchReport() 
        {

        }

        public void RunReport() 
        {

        }

        public void VerifyResultsOfTheRun() 
        {

        }

        public static void SelectItemsOnComboBoxes() 
        {
        }

        public static void DeleteSelectedItems() 
        {

        }

        public void VerifyItemsAreDeleted() 
        {

        }


    }
}
