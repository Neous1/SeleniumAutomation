using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        //get text from control
        public static string GetText( string element, How elementType)
        {
            if (elementType == How.Id)
            {//use the getAttribute to get the value becuase .text doesn't work to get the data 
                return PropertiesCollection.Driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            if (elementType == How.Name)
            {
                return PropertiesCollection.Driver.FindElement(By.Name(element)).GetAttribute("value");
            }

            else return String.Empty; // if no connection are met retun empty string.
        }

        // Create a different method for control who can't use 
        public static string GetTextFromDDl(string element, How elementType)
        {
            if (elementType == How.Id)
            {
                //use the allSelectedOption because it allows the return of IWebElement datatype
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            if (elementType == How.Name)
            {
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }

            else return String.Empty; // if no connection are met retun empty string.
        }

    }
}
