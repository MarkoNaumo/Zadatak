using NUnit.Framework;
using OpenQA.Selenium;
using TestProjectExamplePage.Page;
using TestProjectExamplePage.WebDriver;

namespace TestProjectExamplePage
{
    public class Tests
    {
        public class TestClass
        {
            private LoginPage _loginPage;
            private HomePage _homePage;

            [SetUp]

            public void BeforeScenario()
            {
                WebDrivers.Initialize();
                _loginPage = new LoginPage();
                _homePage = new HomePage();

            }

            [TearDown]
            public void AfterScenario()
            {
                WebDrivers.CleanUp();
            }

          

            [Test]

            public void TC01_FillInAllData()
            {

                Login("Jovana", "12345");

                _homePage.SelectCoutry("Serbia");
                _homePage.Address.SendKeys("Beograd");
                _homePage.Email.SendKeys("mail@email.com");
                _homePage.Phone.SendKeys("12345678");
                _homePage.ButtonSave.Click();

                Assert.That("Saved",Is.EqualTo(_homePage.SaveText.Text));

            }

            public void Login(string name, string pass)
            {
                _loginPage.LoginUser(name, pass);
            }

        }
    }
}