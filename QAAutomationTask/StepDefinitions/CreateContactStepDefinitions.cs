using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using QAAutomationTask.Page_Objects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace QAAutomationTask.StepDefinitions
{
    
    [Binding]
     public class CreateContactStepDefinitions: BaseSteps
    {
        
        LoginPage _loginPage;
        SalesAndMarketing _salesAndMarketing;

        public CreateContactStepDefinitions(LoginPage loginPage, SalesAndMarketing salesAndMarketing)
        {
            _loginPage = loginPage;
            _salesAndMarketing = salesAndMarketing;
            _loginPage.SetDriver(this._driver);
            _salesAndMarketing.SetDriver(this._driver);
        }

        [Given(@"I login to the CRM demo site")]
        public void GivenILoginToTheCRMDemoSite()
        {
            _loginPage.NavigateToHomepage();
            _loginPage.EnterUserName();         
            _loginPage.EnterPassword();
            _loginPage.ClickLogIn();
            
        }

        [Given(@"I navigate to Sales & Marketing")]
        public void GivenINavigateTo()
        {
    
           _salesAndMarketing.ClickSalesAndMarketing();

        }

        [Given(@"I select Contacts")]
        public void GivenISelectContacts()
        {
            
        }


        [When(@"I create a new contact")]
        public void WhenICreateANewContact()
        {
            _salesAndMarketing.CreateNewContact();
        }

        [When(@"I open the created contact")]
        public void WhenIOpenTheCreatedContact()
        {
            
        }

        [Then(@"I should verify the data matches these details")]
        public void ThenIShouldVerifyTheDataMatchesTheseDetails()
        {
           
        }

    }
}
