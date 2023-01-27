using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Security.Cryptography;
using NUnit.Framework;

namespace QAAutomationTask.Page_Objects
{
    public class SalesAndMarketing : BasePage
    {
        // #grouptab-1 > div
        //private IWebElement lblSalesAndMarketing => driver.FindElement(By.CssSelector("#grouptab-1 > div"));
        private IWebElement lnkContacts => driver.FindElement(By.XPath("/html/body/nav/div[2]/div[2]/div[3]/a"));
        private IWebElement lnkCreateContact => driver.FindElement(By.XPath("//*[@id=\'left-sidebar\']/div[2]/a"));
        private IWebElement lblFirstNameInput => driver.FindElement(By.XPath("//*[@id=\'DetailFormfirst_name-input\']"));
        private IWebElement lblLastNameInput => driver.FindElement(By.XPath("//*[@id=\'DetailFormlast_name-input\']"));
        private IWebElement lblTitle => driver.FindElement(By.XPath("//*[@id=\'DetailFormtitle-input\']"));
        private IWebElement categoryDropDown => driver.FindElement(By.XPath("//*[@id=\'DetailFormcategories-input\']"));

        private IWebElement categorySearchTextField => driver.FindElement(By.XPath("//*[@id=\'DetailFormcategories-input-search-text\']/input"));
        private IWebElement btnSave => driver.FindElement(By.Id("DetailForm_save2-label"));
        private IWebElement txtCategoriesSummary => driver.FindElement(By.XPath("//li[.='CategoryCustomers, Suppliers']"));

        

        public void ClickSalesAndMarketing() 
        {
            // //*[@id="grouptab-1"]
            Thread.Sleep(1000);
            var element = driver.FindElement(By.XPath("//*[@id='grouptab-1']"));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);
            lnkContacts.Click();

        }

        public void CreateNewContact() 
        {
            //WaitForElement(lnkContacts);
              
            lnkCreateContact.Click();
            Thread.Sleep(1000);
            lblFirstNameInput.Click();
            NamesData nd = new NamesData();
            var randomName = nd.Generate(6);
            lblFirstNameInput.SendKeys(randomName);
            Thread.Sleep(1000);
            lblLastNameInput.Click();
            lblLastNameInput.SendKeys("Doe");
            Thread.Sleep(1000);
  
            lblTitle.SendKeys("Vice President");
            Thread.Sleep(1000);
            categoryDropDown.Click();
             categorySearchTextField.SendKeys("Customers");
            Thread.Sleep(1000);
            categorySearchTextField.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            categoryDropDown.Click();
            
            categorySearchTextField.SendKeys("Suppliers");
            Thread.Sleep(1000);
            categorySearchTextField.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            btnSave.Click();

            Thread.Sleep(1000);
            var checkText = txtCategoriesSummary.Text;          
            Assert.AreEqual(checkText, false);
        }

        

        public void VerifyDataMatchesCreatedContact() 
        {

        }


           
        }
    }

