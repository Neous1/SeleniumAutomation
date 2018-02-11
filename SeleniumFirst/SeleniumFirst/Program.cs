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
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            Console.WriteLine("Opened URL");
        }

        //Execute the operation
        [Test] // needed to run the test
        public void ExecuteTest()
        {

            //Enter(element targeted, value passed , type of DOM element)

            //Select a page element to navigate to
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perfom Operation
            element.SendKeys("This is a test");

            Console.WriteLine("Executed test");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Test");
        }
        //clean up
        [TearDown] // closes test
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");

        }
    }
}
