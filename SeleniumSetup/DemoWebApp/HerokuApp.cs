using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
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
            IWebElement element = driver.FindElement(By.XPath("//a[contains(text(), 'A/B Testing')]"));
            element.Click();
            Assert.Equal("http://the-internet.herokuapp.com/abtest", driver.Url);
            Thread.Sleep(5000);
            driver.Dispose();
        }

        [Fact]
        public void LoginTest()
        {
            driver = new FirefoxDriver();
            //driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            IWebElement login = driver.FindElement(By.XPath("//a[contains(text(), 'Basic Auth')]"));
            login.Click();

            driver.SwitchTo().Alert().SendKeys("admin" + Keys.Tab + "admin");
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(3000);
            Assert.Equal("Congratulations! You must have the proper credentials.", driver.FindElement(By.XPath("//*[@id='content']/div/p")).Text);
            Thread.Sleep(5000);
            driver.Dispose();
        }
    }
}
