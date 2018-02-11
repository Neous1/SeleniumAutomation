using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {

        //Enter Text
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
        }
        //Click into a button, checkbox, option etc
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Id(element)).Click();
            }
        }


        //Selecting a dropdown control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                //Pass the text clicked in the dropdown as a paramter for SelectElement

               new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
                //this method is used because the selectDropDown method uses string as an element datatype instead of IWebElement.
            }
            if (elementType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }
}
