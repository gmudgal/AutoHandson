using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NUnitNetCoreProj1.pages
{
    class LoginPage
    {
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver) {
            WebDriver = webDriver;
        }


        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtusrName => WebDriver.FindElement(By.Name("UserName"));
        public IWebElement txtpassword => WebDriver.FindElement(By.Name("Password"));
        public IWebElement loginButton => WebDriver.FindElement(By.CssSelector(".btn-default"));
        public IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee Details"));


        public void clickLogin() => lnkLogin.Click();

        public void Login(string username, string password)
        {
            txtusrName.SendKeys(username);
            txtpassword.SendKeys(password);

            
        }

        public void clickLoginButton() => loginButton.Click();

        public bool isHomePageDisplayed() => lnkEmployeeDetails.Displayed;




    }
}
