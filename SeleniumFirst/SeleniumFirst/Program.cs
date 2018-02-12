using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class Program
    {

        static void Main(string[] args)
        {
            
        }

        //open brower
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            // Navigate to web page
            PropertiesCollection.Driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            //PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            Console.WriteLine("Opened URL");
        }

        //Execute the operation
        [Test] // needed to run the test
        public void ExecuteTest()
        {
            //Login to Application and instantiate EAPageObject
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObjects pageEA =  pageLogin.Login("Yvon", "EA9817");

            pageEA.FillUserForm("YJN", "Yvon-Joel", " ");



            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId","Ms.", How.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial","EJN" ,How.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDl("TitleId", How.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", How.Name));

            ////Click
            //SeleniumSetMethods.Click("Save", How.Name);
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
