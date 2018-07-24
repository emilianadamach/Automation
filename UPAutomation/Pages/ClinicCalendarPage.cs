using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Navigation;
using UPAutomation.Selenium;

namespace UPAutomation.Pages
{
    public class ClinicCalendarPage : MyCalendarPage 
    {
        public ClinicCalendarPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        //Navigation

            //Calendar Button
        [FindsBy(How = How.CssSelector, Using = ".menu-level-1:nth-child(2)")]
        private IWebElement calendarButton { get; set; }

        //Clinic Calendar Button
        [FindsBy(How = How.CssSelector, Using = "#nav > li.menu-level-1.open > ul > li:nth-child(3) > a > span")]
        private IWebElement clinicCalendarButton { get; set; }

        //Practitioner
        [FindsBy(How = How.CssSelector, Using = "#appointmentData > div.newAppointmentControls > div:nth-child(11) > div > div > div > div > button")]
        private IWebElement practitioner { get; set; }

        //Drop-down of Practitioner
        [FindsBy(How = How.XPath, Using = "//*[@id='appointmentData']/div[3]/div[6]/div/div/div/div/div/ul/li/a")]
        private IList<IWebElement> select_practitioner { get; set; }
      
        //Timeoff Practitioner
        [FindsBy(How = How.XPath, Using = "//*[@id='personalAppointmentData']/div[2]/div[4]/div/div/div/div")]
        private IWebElement timeoff_practitioner { get; set; }
      
        //List of Timeoff Practitioner
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'dropdown-menu')]/ul//span")]
        private IList<IWebElement> select_timeoff_practitioner { get; set; }


        public void GoTo()
        {
            SetMethods.Click(calendarButton);
            Driver.Wait(TimeSpan.FromSeconds(1));
            SetMethods.Click(clinicCalendarButton);
        }

        public void Appointment_Practitioner(string Practitioner)
        {
            try { SetMethods.Select_Value_from_List(practitioner, select_practitioner, Practitioner);
                test.Log(LogStatus.Pass, "Appointment Practitioner is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Appointment Practitioner is not selected", e); }
        }

        public void Set_Timeoff_for_Practitioner(string Practitioner)
        {
            SetMethods.Select_Value_from_List(timeoff_practitioner, select_timeoff_practitioner, Practitioner);
        }  
    }
}
