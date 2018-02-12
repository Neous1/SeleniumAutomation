using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFirst
{

    enum PropertType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    class PropertiesCollection
    {
        //
        public static IWebDriver Driver { get; set; }
    }
}
