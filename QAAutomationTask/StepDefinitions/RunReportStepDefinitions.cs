using LivingDoc.Dtos;
using OpenQA.Selenium;
using QAAutomationTask.Page_Objects;
using System;
using TechTalk.SpecFlow;

namespace QAAutomationTask.StepDefinitions
{
    [Binding]
    public class RunReportStepDefinitions :BaseSteps
    {
        Reports _reports;
        LoginPage _loginPage;
        public RunReportStepDefinitions(Reports reports, LoginPage loginPage)
        {
            _reports = reports;
            _loginPage = loginPage;
            _loginPage.SetDriver(this._driver);
            _reports.SetDriver(this._driver);

        }

        [Given(@"Given I login to the CRM demo site")]
        public void GivenILoginToTheCRMDemoSite()
        {
            _loginPage.NavigateToHomepage();
            _loginPage.EnterUserName();
            _loginPage.EnterPassword();
            _loginPage.ClickLogIn();
        }

        [When(@"I navigate to Reports & Settings")]
        public void WhenINavigateToReportsSettings()
        {
            _reports.NavigateToReportsAndSettings();
        }


        [When(@"I select Reports")]
        public void WhenISelectReports()
        {
            Thread.Sleep(1000);
            _reports.SelectReportNavbar();
        }

        [When(@"I find Project Profitability report")]
        public void WhenIFindProjectProfitabilityReport()
        {
            _reports.SearchReport();
        }


        [When(@"I run the report")]
        public void WhenIRunTheReport()
        {
            _reports.RunReport();
        }

        [Then(@"I should verify the results returned")]
        public void ThenIShouldVerifyTheResultsReturned()
        {
            
        }

        [When(@"I click the Activity log")]
        public void WhenIClickTheActivityLog()
        {
            _reports.NavigateToActivityLog();
        }


        [When(@"I select the first three items in the table")]
        public void WhenISelectTheFirstThreeItemsInTheTable()
        {
            _reports.SelectItemsOnComboBoxes();
        }


        [When(@"I delete these actions")]
        public void WhenIDeleteTheseActions()
        {
          
        }

        [Then(@"I should verify these items are deleted")]
        public void ThenIShouldVerifyTheseItemsAreDeleted()
        {
            _reports.VerifyItemsAreDeleted();
        }







    }
}
