using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        //get text from control
        public static string GetText(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                return driver.FindElement(By.Id(element)).Text;
            }
            if (elementType == "Name")
            {
                return driver.FindElement(By.Name(element)).Text;
            }

            else return String.Empty; // if no connection are met retun empty string.
        }
    }
}
