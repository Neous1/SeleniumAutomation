using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class EAPageObjects
    {

        //initialize the controls
        public EAPageObjects()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        //controls targeted on our page

        //identify the ID
        [FindsBy(How = How.Id, Using = "TitleID")]
        public IWebElement ddlTitleId { get; set; }
        
        //identify the textbox
        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }
        
        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }
        
        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }
        
        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }


        //create a method to fill the form
        public void FillUserForm(string inital, string firstName, string middleName)
        {
            txtInitial.SendKeys(inital);
            txtFirstName.SendKeys(firstName);
            txtMiddleName.SendKeys(middleName);

            btnSave.Submit();
        }
    }
}
