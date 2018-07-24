using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Selenium;

namespace UPAutomation.Pages
{
    public class AllClinicPatientsPage : MyPatientsPage
    {
        public AllClinicPatientsPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".menu-level-1:nth-child(3)")]
        private IWebElement PatientListButton { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Clinic Patients")]
        private IWebElement ClinicPatientsButton { get; set; }

        public void GoTo()
        {
            SetMethods.Click(PatientListButton);
            Driver.Wait(TimeSpan.FromSeconds(2));
            SetMethods.Click(ClinicPatientsButton);
        }
    }
}
