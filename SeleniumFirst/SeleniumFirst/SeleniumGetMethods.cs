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
        public static string GetText( IWebElement element)
        {
               return element.GetAttribute("value");
          
        }

        // Create a different method for control who can't use 
        public static string GetTextFromDDl(IWebElement element)
        {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            
        }

    }
}
