using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectExamplePage.WebDriver;
using WebDriver = TestProjectExamplePage.WebDriver;

namespace TestProjectExamplePage.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;


        public IWebElement FullName => driver.FindElement(By.Id("name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("Login"));


        public void LoginUser(string name, string pass)
        {
            FullName.SendKeys(name);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }
    }
}
