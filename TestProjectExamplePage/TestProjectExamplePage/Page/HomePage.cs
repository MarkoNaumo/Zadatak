using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProjectExamplePage.WebDriver;

namespace TestProjectExamplePage.Page
{
    public class HomePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Address => driver.FindElement(By.Id("address"));
        public IWebElement Email => driver.FindElement(By.Id("email"));
        public IWebElement Phone => driver.FindElement(By.Id("phone"));
        public IWebElement ButtonSave => driver.FindElement(By.Id("save"));
        public IWebElement LogoutButton => driver.FindElement(By.Id("logout"));
        public IWebElement SaveText => driver.FindElement(By.ClassName("tp-saved"));

        public void SelectCoutry(string option)
        {
            SelectElement select = new SelectElement(driver.FindElement(By.Id("country")));
            select.SelectByText(option);
        }
    }
}
