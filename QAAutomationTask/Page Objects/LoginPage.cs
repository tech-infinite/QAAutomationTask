using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAAutomationTask.Page_Objects;

namespace QAAutomationTask
{
    public class LoginPage : BasePage
    {

        public LoginPage()
        {
            // base.MaximizeWindow();
        }

            // Web elements
        
        private IWebElement txtFieldUsername => driver.FindElement(By.Id("login_user"));
        private IWebElement txtFieldPassword => driver.FindElement(By.Id("login_pass"));
        private IWebElement btnLogin => driver.FindElement(By.Id("login_button"));
        
        public void EnterUserName() 
        {
            txtFieldUsername.Clear();         
            txtFieldUsername.SendKeys("admin");
            
        }

        public void EnterPassword() 
        {
            txtFieldPassword.Clear();
            txtFieldPassword.SendKeys("admin");
        }

        public void ClickLogIn() 
        {
            btnLogin.Click();
        }


    }
}
