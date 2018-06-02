using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Xunit;

namespace DemoWebApp
{
    public class HerokuApp
    {
        IWebDriver driver;

        [Fact]
        public void StartApp()
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        }
    }
}
