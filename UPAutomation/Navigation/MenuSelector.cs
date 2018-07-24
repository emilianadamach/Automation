using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Selenium;

namespace UPAutomation.Navigation
{
    public class MenuSelector
    {
        public MenuSelector()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        [FindsBy(How =How.Id, Using = "calendar - content - wrap") ]
        private IWebElement Calendartable { get; set; }

       public static void Select(IWebElement element)
        {
       //     calendar - content - wrap
         //       table: upCalContent
        //        th(columns)
        //        tr(row)
         //       td = table data 
        }

       
    }
}
