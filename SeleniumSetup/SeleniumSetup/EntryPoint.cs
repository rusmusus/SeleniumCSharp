
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main(string[] args)
    {

        string URL = "http://testing.todorvachev.com/selectors/id";
        string ID = "testImage";

        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(URL);

        IWebElement element = driver.FindElement(By.Id(ID));
        if (element.Displayed)
        {
            GreenMessage("Yes! I can see the element.");
        }
        else
        {
            RedMessage("NO! I do NOT see the element!");
        }

        //Thread.Sleep(3000);
        //driver.Quit();
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
