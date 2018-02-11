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
//
//
//        //create a reference for our browser
//        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            
        }

        //open brower
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            // Navigate to web page
            PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            Console.WriteLine("Opened URL");
        }

        //Execute the operation
        [Test] // needed to run the test
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown("TitleId","Ms.", "Id");

            //Initial
            SeleniumSetMethods.EnterText("Initial","EJN" ,"Name");

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDl("TitleId", "Id"));

            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", "Name"));

            //Click
            SeleniumSetMethods.Click("Save", "name" );
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
            PropertiesCollection.Driver.Close();
            Console.WriteLine("Closed the browser");

        }
    }
}
