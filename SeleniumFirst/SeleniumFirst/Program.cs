using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {


        //create a reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {

            


        }

        //open brower
        [SetUp]
        public void Initialize()
        {
            // Navigate to web page
            driver.Navigate().GoToUrl("https://www.google.com/");


        }

        //Execute the operation
        [Test] // needed to run the test
        public void ExecuteTest()
        {
            //Select a page element to navigate to
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perfom Operation
            element.SendKeys("This is a test");


        }

        //clean up
        [TearDown] // closes test
        public void CleanUp()
        {
            driver.Close();

        }
    }
}
