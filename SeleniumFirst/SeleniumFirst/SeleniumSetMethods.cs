﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {

        //Enter Text
        public static void EnterText(string element, string value, How elementType)
        {
            if (elementType == How.Id)
            {
                PropertiesCollection.Driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == How.Name)
            {
                PropertiesCollection.Driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }
        //Click into a button, checkbox, option etc
        public static void Click(string element, How elementType)
        {
            if (elementType == How.Id)
            {
                PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == How.Name)
            {
                PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
            }
        }


        //Selecting a dropdown control
        public static void SelectDropDown(string element, string value, How elementType)
        {
            if (elementType == How.Id)
            {
                //Pass the text clicked in the dropdown as a paramter for SelectElement

               new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).SelectByText(value);
                //this method is used because the selectDropDown method uses string as an element datatype instead of IWebElement.
            }
            if (elementType == How.Name)
            {
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }
}
