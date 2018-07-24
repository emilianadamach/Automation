using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Navigation;
using UPAutomation.Selenium;

namespace UPAutomation
{
    public class DashboardPage
    {
        public DashboardPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#nav > li:nth-child(1) > a > i")]
        private IWebElement Dashboardbutton { get; set; }


        public void GoTo()
        {
            SetMethods.Click(Dashboardbutton);
            System.Threading.Thread.Sleep(5000);
        }

        //public static bool IsAt
        //{

        //    get
        //    {
        //        var h2s = Driver.Instance.FindElement(By.Id("breadcrumbs"));
        //        return true;
        //    }

            
        //}
    }
}
