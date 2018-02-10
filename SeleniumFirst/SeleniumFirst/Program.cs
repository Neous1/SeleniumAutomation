using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a reference for our browser
            IWebDriver driver = new ChromeDriver();


            // Navigate to web page
            driver.Navigate().GoToUrl("https://www.google.com/");

            //Select a page element to navigate to
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perfom Operation
            element.SendKeys("This is a test");
        }
    }
}
