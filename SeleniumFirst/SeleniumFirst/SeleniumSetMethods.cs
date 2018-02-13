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
    public static class  SeleniumSetMethods
    {
        //<summary>
        //Extended method for entering text in the control
        //</summary>
        //<params name = "element"></params>
        public static void EnterText( this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //<summary>
        //Click into a button, checkbox, option etc
        //</summary>
        //<params name = "element"></params>
        public static void Clicks(this IWebElement element)
        {
           element.Click(); 
        }

        //<summary>
        //Selecting a dropdown control
        //</summary>
        //<params name = "element"></params>
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
