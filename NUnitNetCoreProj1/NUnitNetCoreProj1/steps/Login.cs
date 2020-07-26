using NUnit.Framework;
using NUnitNetCoreProj1.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NUnitNetCoreProj1.steps
{
    [Binding]
    class Login
    {
        LoginPage loginpage = null;
        IWebDriver webDriver = new ChromeDriver(@"C:\SpecflowProjects\NUnitNetCoreProj1\NUnitNetCoreProj1\driver\");
        [Given(@"I navigate to following application")]
        public void GivenINavigateToFollowingApplication(Table table)
        {
            
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            loginpage = new LoginPage(webDriver);
            
        }

        [Given(@"I click on Login link")]
        public void GivenIClickOnLoginLink()
        {
            loginpage.clickLogin();
            
        }

        [Given(@"I enter credentials as")]
        public void GivenIEnterCredentialsAs(Table table)
        {
            
            dynamic data = table.CreateDynamicInstance();
            loginpage.Login((string)data.UserName,(string)data.Password)    ;
            
        }

        [Given(@"I click on Login button")]
        public void GivenIClickOnLoginButton()
        {
            loginpage.clickLoginButton();
            
        }

        [Then(@"I should see home page")]
        public void ThenIShouldSeeHomePage()
        {

            Assert.That(loginpage.isHomePageDisplayed(), Is.True);
            webDriver.Quit();
        }

    }
}
