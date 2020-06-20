using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject1.steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the browser")]
        public void GivenIHaveEnteredIntoTheCalculator(string url)
        {
            //ScenarioContext.Current.Pending();
                     
            IWebDriver webDriver = new ChromeDriver(@"C:\SpecflowProjects\NUnitTestProject1\NUnitTestProject1\driver\");
            //string baseURL = "https://gmail.com";
            webDriver.Navigate().GoToUrl(url);
            //webDriver.Navigate("www.youtube.com");
            webDriver.Close();
        }

        [When(@"I press add")]
        public void WhenIPressAdd() =>
            //ScenarioContext.Current.Pending();
            Console.WriteLine("how are you");

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
           // ScenarioContext.Current.Pending();
            Console.WriteLine("how are you");
        }
    }
}
