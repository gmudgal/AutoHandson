using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnitTestProject1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\SpecflowProjects\NUnitTestProject1\NUnitTestProject1\driver\");

        [Given(@"I have navigated to (.*) acme site")]
        public void GivenIHaveNavigatedToHttpsAcme_Test_Uipath_ComAcmeSite(string URL)
        {
            //IWebDriver webDriver = new ChromeDriver(@"C:\SpecflowProjects\NUnitTestProject1\NUnitTestProject1\driver\");
            webDriver.Navigate().GoToUrl(URL);
            webDriver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            //webDriver.Navigate("www.youtube.com");
            webDriver.Close();

        }
        
        [When(@"I enter credentials '(.*)' and password '(.*)'")]
        public void WhenIEnterCredentialsAndPassword(string p0, string p1)
        {
            //IWebDriver webDriver = new ChromeDriver(@"C:\SpecflowProjects\NUnitTestProject1\NUnitTestProject1\driver\");
            IWebElement searchField = webDriver.FindElement(By.Id("search"));
            //IWebElement passwordElement = webDriver.FindElement(By.Id("password"));
            searchField.SendKeys("C# Tutorial");
            //asswordElement.SendKeys("Market@2st");
        }

        [Then(@"I click on Login button")]
        public void ThenIClickOnLoginButton()
        {
            IWebElement SearchButton = webDriver.FindElement(By.XPath("//*[@id='search - icon - legacy']/yt-icon"));
            SearchButton.Click();
        }
        
        [Then(@"I should see the homepage")]
        public void ThenIShouldSeeTheHomepage()
        {
            /*IWebElement homePageText = webDriver.FindElement(By.XPath("//*[@id='dashmenu']/div[1]/button"));
            if (homePageText.Displayed)
            {
                Console.WriteLine("Login successful");

            }
            else
            { 
                Console.WriteLine("Login not successful");
            }*/
        } 
    }
}
