using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        //get text from control
        public static string GetText(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {//use the getAttribute to get the value becuase .text doesn't work to get the data 
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            if (elementType == "Name")
            {
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            }

            else return String.Empty; // if no connection are met retun empty string.
        }

        // Create a different method for control who can't use 
        public static string GetTextFromDDl(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                //use the allSelectedOption because it allows the return of IWebElement datatype
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            if (elementType == "Name")
            {
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }

            else return String.Empty; // if no connection are met retun empty string.
        }

    }
}
