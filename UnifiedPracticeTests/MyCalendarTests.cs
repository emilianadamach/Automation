using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation;
using UPAutomation.Navigation;
using UPAutomation.Selenium;

namespace UnifiedPracticeTests
{
    [TestClass]
    public class MyCalendarTests : UPBaseTest
    {
        #region MC01_Appointment_With_New_Patient 
        [TestMethod]
        public void MC01_Appointment_With_New_Patient()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC01 - Appointment with New Patient", "Appointment added from My Calendar with a New Patient Created");
            cal.AddAppointmentButton();   
            Driver.Wait(TimeSpan.FromSeconds(2));     
            cal.NewPatient();      
            cal.PatientFirstName();   
            cal.PatientLastName();                   
            cal.PatientEmail("emilian.adamache@omnisourcetech.com"); 
            cal.Patient_Birthdate("01/26/1992"); 
            cal.PatientPrimaryPhone("0720600610"); 
            cal.PatientPrimaryPhoneType("Cell");    
            cal.PatientSecondaryPhone("123"); 
            cal.PatientSecondaryPhoneType("Home"); 
            cal.PatientGender("Male"); 
            cal.PatientContinue();   
            cal.Appointment_Complaint("Complaint 1");
            cal.Appointment_PractitionerNotes("Note 1"); 
            cal.Appointment_Type("Self-Pay"); 
            cal.Appointment_Date_and_Time("07/10/2018", "18:30:00"); 
            cal.Appointment_Location("Bear Mask Acupuncture"); 
            cal.Appointment_Service("Acupuncture"); 
            cal.Appointment_Room("Black Room");  
            cal.Appointment_Save();
            extent.EndTest(test);
              extent.Flush();
        }
        #endregion

        #region MC02_Appointment_With_Existing_Patient
        [TestMethod]
        public void MC02_Appointment_With_Existing_Patient()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC02 - Appointment with Existing Patient", "Appointment added from My Calendar with an Existing Patient");
            cal.AddAppointmentButton();        
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Kosmos Pavel");          
            cal.Appointment_Complaint("Complaint 2");            
            cal.Appointment_PractitionerNotes("Note 2");
            cal.Appointment_Type("Insurance"); 
            cal.Appointment_Date_and_Time("07/10/2018", "17:30:00"); 
            cal.Appointment_Location("Canada Location");   
            cal.Appointment_Service("Needle Dancing");    
            cal.Appointment_Room("Test Room2");    
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC03_Appointment_Recurring_Daily_Every_3days_3NOO
        [TestMethod]
        public void MC03_Appointment_Recurring_Daily_Every_3days_3NOO()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC03 - Appointment Recurring Daily After No. of Occurences", "Appointment Recurring Daily added from My Calendar After a No. of Occurences");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Pamela Johnson");   
            cal.Appointment_Complaint("Complaint 3");   
            cal.Appointment_PractitionerNotes("Note 3");  
            cal.Appointment_Type("Promotion/Package");   
            cal.Appointment_Date_and_Time("07/10/2018", "16:30:00"); 
            cal.Appointment_Location("Bear Mask Acupuncture");  
            cal.Appointment_Service("Butterfly Wrap"); 
            cal.Appointment_Room("Room #1-1");   
            cal.Reoccur();             
            cal.Repeats("Daily");     
            cal.RepeatsEvery("3");   
            cal.AfterNumberOfOccuresces("3");  
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC04_Appointment_Recurring_Daily_Every_5days_EOD
        [TestMethod]
        public void MC04_Appointment_Recurring_Daily_Every_5days_EOD()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC04 - Appointment Recurring Daily till End of Date", "Appointment Recurring Daily added from My Calendar till End of Date");
            cal.AddAppointmentButton();  
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Alexa Johnson");  
            cal.Appointment_Complaint("Complaint 4"); 
            cal.Appointment_PractitionerNotes("Note 4"); 
            cal.Appointment_Type("Pro-bono");  
            cal.Appointment_Date_and_Time("07/10/2018", "10:30:00"); 
            cal.Appointment_Location("Bear Mask Acupuncture"); 
            cal.Appointment_Service("Deep Tissue Massage");  
            cal.Appointment_Room("Black Room");  
            cal.Reoccur();             
            cal.Repeats("Daily");     
            cal.RepeatsEvery("5");   
            cal.Recurring_EndDate("05/17/2018");        
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region  MC05_Appointment_Recurring_Weekday_3NOO
        [TestMethod]
        public void MC05_Appointment_Recurring_Weekday_3NOO()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC05 - Appointment Recurring Weekday After No. of Occurences", "Appointment Recurring Weekday added from My Calendar After a No. of Occurences");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("JAMES EMILY CAMERON");  
            cal.Appointment_Complaint("Complaint 5");  
            cal.Appointment_PractitionerNotes("Note 5"); 
            cal.Appointment_Type("Self-Pay");   
            cal.Appointment_Date_and_Time("07/10/2018", "09:00:00");  
            cal.Appointment_Location("Ciuc Wellness");  
            cal.Appointment_Service("Chisinau Back Massage"); 
            cal.Appointment_Room("Yellow Room");  
            cal.Reoccur();         
            cal.Repeats("Every weekday(Monday to Friday)");   
            cal.AfterNumberOfOccuresces("3"); 
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC06_Appointment_Recurring_Weekday_EOD
        [TestMethod]
        public void MC06_Appointment_Recurring_Weekday_EOD()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC06 - Appointment Recurring Weekday till End of Date", "Appointment Recurring Weekday added from My Calendar till End of Date");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Hugo Dark");  
            cal.Appointment_Complaint("Complaint 6");  
            cal.Appointment_PractitionerNotes("Note 6"); 
            cal.Appointment_Type("Insurance"); 
            cal.Appointment_Date_and_Time("07/10/2018", "10:00:00");  
            cal.Appointment_Location("Ciuc Wellness");  
            cal.Appointment_Service("Cupping"); 
            cal.Appointment_Room("Room #1-3"); 
            cal.Reoccur();         
            cal.Repeats("Every weekday(Monday to Friday)");   
            cal.Recurring_EndDate("05/17/2018");
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion
        
        #region MC07_Appointment_Recurring_Weekly_4days_Every_3Weeks_EOD
        [TestMethod]
        public void MC07_Appointment_Recurring_Weekly_4days_Every_3Weeks_EOD()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC07 - Appointment Recurring Weekly till End of Date", "Appointment Recurring Weekly added from My Calendar till End of Date");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Thor Hammer"); 
            cal.Appointment_Complaint("Complaint 7");  
            cal.Appointment_PractitionerNotes("Note 7"); 
            cal.Appointment_Type("Insurance"); 
            cal.Appointment_Date_and_Time("07/10/2018", "12:00:00"); 
            cal.Appointment_Location("Ciuc Wellness"); 
            cal.Appointment_Service("Cupping"); 
            cal.Appointment_Room("Room #2-3");  
            cal.Reoccur(); ;  
            cal.RepeatsEvery("3");   
            cal.Mark_Wednesday();  
            cal.Mark_Thrusday();  
            cal.Mark_Friday();  
            cal.Mark_Saturday();  
            cal.Recurring_EndDate("07/30/2018");  
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC08_Appointment_Recurring_Weekly_3days_Every_2Weeks_5NOO
        [TestMethod]
        public void MC08_Appointment_Recurring_Weekly_3days_Every_2Weeks_5NOO()
        { 
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC08 - Appointment Recurring Weekly After No. of Occurences", "Appointment Recurring Weekdly added from My Calendar After a No. of Occurences");
            cal.AddAppointmentButton();  
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Stephanie Ingle");  
            cal.Appointment_Complaint("Complaint 8");  
            cal.Appointment_PractitionerNotes("Note 8");  
            cal.Appointment_Type("Insurance");  
            cal.Appointment_Date_and_Time("07/10/2018", "15:00:00"); 
            cal.Appointment_Location("Chief Grand Cherokee Wellness Center"); 
            cal.Appointment_Service("Bear Massage"); 
            cal.Appointment_Room("Room #1-4"); 
            cal.Reoccur(); ;  
            cal.RepeatsEvery("2");   
            cal.Mark_Tuesday();  
            cal.Mark_Friday();  
            cal.Mark_Sunday();  
            cal.AfterNumberOfOccuresces("5");  
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC09_Appointment_Recurring_Monthly_4NOO
        [TestMethod]
        public void MC09_Appointment_Recurring_Monthly_4NOO()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC09 - Appointment Recurring Monthly After No. of Occurences", "Appointment Recurring Monthly added from My Calendar After a No. of Occurences");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Kyle Carpenter"); 
            cal.Appointment_Complaint("Complaint 9");  
            cal.Appointment_PractitionerNotes("Note 9"); 
            cal.Appointment_Type("Insurance"); 
            cal.Appointment_Date_and_Time("07/10/2018", "13:30:00"); 
            cal.Appointment_Location("Chief Grand Cherokee Wellness Center"); 
            cal.Appointment_Service("Butterfly Wrap"); 
            cal.Appointment_Room("Room #3-4"); 
            cal.Reoccur();            
            cal.Repeats("Monthly");     
            cal.AfterNumberOfOccuresces("3");
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC10_Appointment_Recurring_Monthly_EOD
        [TestMethod]
        public void MC10_Appointment_Recurring_Monthly_EOD()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage cal = new MyCalendarPage();
            var test = cal.test = extent.StartTest("MC10 - Appointment Recurring Monthly till End of Date", "Appointment Recurring Monthly added from My Calendar till End of Date");
            cal.AddAppointmentButton();   
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Patricia Jacklin"); 
            cal.Appointment_Complaint("Complaint 10");  
            cal.Appointment_PractitionerNotes("Note 10"); 
            cal.Appointment_Type("Insurance"); 
            cal.Appointment_Date_and_Time("07/10/2018", "20:30:00"); 
            cal.Appointment_Location("Chief Grand Cherokee Wellness Center"); 
            cal.Appointment_Service("Wolf Massage"); 
            cal.Appointment_Room("Room #1-4"); 
            cal.Reoccur();             
            cal.Repeats("Monthly");     
            cal.RepeatsEvery("2");   
            cal.Recurring_EndDate("10/30/2018"); 
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region  MC11_Timeoff_5minutes
        [TestMethod]
        public void MC11_Timeoff_5minutes()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC11 - Timeoff 5 minutes", "Timeoff 5 minutes added from My Calendar");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 1 5minutes");   
            timeoff.TimeoffDetails("Test Details 1");   
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "11:00:00", "15");   
            timeoff.TimeoffLocation("Bear Mask Acupuncture");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC12_Timeoff_AllDay
        [TestMethod]
        public void MC12_Timeoff_AllDay()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC12 - Timeoff All Day", "Timeoff All Day added from My Calendar");
            timeoff.Book_TimeOff_Button();  
            timeoff.Timeofftitle("Test 2 All Day");   
            timeoff.TimeoffDetails("Test Details 2");   
            timeoff.TimeoffRepeatAllDay();   
            timeoff.Timeoff_StartDate_and_Time("07/11/2018","","");   
            timeoff.TimeoffLocation("Locatie1");  
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC13_Timeoff_Recurring_Daily_Every_3days_3NOO
        [TestMethod]
        public void MC13_Timeoff_Recurring_Daily_Every_3days_3NOO()
        {   
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC13 - Timeoff Recurring Daily Every 3 days After 3 no of occ", "Timeoff Recurring All Day added from My CalendarEvery every 3 days After 3 no of occ");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 3 recurring 5minutes");   
            timeoff.TimeoffDetails("Test Details 3");   
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Daily"); 
            timeoff.RepeatsEvery("3"); ; 
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "11:00:00", "25");  
            timeoff.AfterNumberOfOccuresces("3"); 
            timeoff.TimeoffLocation("Locatie2");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion
        
        #region MC14_Timeoff_Recurring_Daily_Every_5days_EOD
        [TestMethod]
        public void MC14_Timeoff_Recurring_Daily_Every_5days_EOD()
        { 
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC14 - Timeoff Recurring Daily every 5 days till End of Date", "Timeoff Recurring All Day added from My Calendar every 5 days till End of Date");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 4 ");   
            timeoff.TimeoffDetails("Test Details 4");  
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Daily");  
            timeoff.RepeatsEvery("5"); ; 
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "11:00:00", "10");   
            timeoff.Recurring_EndDate("07/30/2018"); 
            timeoff.TimeoffLocation("Ciuc Wellness");  
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region  MC15_Timeoff_Recurring_Daily_Allday_Every_3days_3NOO
        [TestMethod]
        public void MC15_Timeoff_Recurring_Daily_Allday_Every_3days_3NOO()
        {   
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC15 - Timeoff Recurring Daily All Day after no. of occ", "Timeoff Recurring Daily All Day added from My Calendar Every 3 days after 3 no of Occurences ");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 5 ");   
            timeoff.TimeoffDetails("Test Details 5");   
            timeoff.TimeoffRepeatAllDay();   
            timeoff.TimeoffRepeat();  
            timeoff.Repeats("Daily"); 
            timeoff.RepeatsEvery("3"); ; 
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   
            timeoff.AfterNumberOfOccuresces("3"); 
            timeoff.TimeoffLocation("New York Place");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC16_Timeoff_Recurring_Daily_Allday_Every_5days_EOD
        [TestMethod]
        public void MC16_Timeoff_Recurring_Daily_Allday_Every_5days_EOD()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC16 - Timeoff Recurring Daily All Day till end of date", "Timeoff Recurring Daily All Day added from My Calendar every 5 days till End of Date");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 6");   
            timeoff.TimeoffDetails("Test Details 6");   
            timeoff.TimeoffRepeatAllDay();   
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Daily"); 
            timeoff.RepeatsEvery("5"); ; 
            timeoff.Timeoff_StartDate_and_Time("07/11/2018","","");   
            timeoff.Recurring_EndDate("06/27/2018"); 
            timeoff.TimeoffLocation("Buzau");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC17_Timeoff_Recurring_Weekday_3NOO
        [TestMethod]
        public void MC17_Timeoff_Recurring_Weekday_3NOO()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC17 - Timeoff Recurring Weekday after 3 no of occ", "Timeoff Recurring Weekday added from My Calendar after 3 number of occurences");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 7");  
            timeoff.TimeoffDetails("Test Details 7");   
            timeoff.TimeoffRepeat();    
            timeoff.Repeats("Every weekday (Monday to Friday)");  
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "17:00:00", "30");   
            timeoff.AfterNumberOfOccuresces("3"); 
            timeoff.TimeoffLocation("New York Place");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC18_Timeoff_Recurring_Weekday_EOD
        [TestMethod]
        public void MC18_Timeoff_Recurring_Weekday_EOD()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC18 - Timeoff Recurring Weekday till end of date", "Timeoff Recurring Weekday added from My Calendar till End of Date");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 8");   
            timeoff.TimeoffDetails("Test Details 8 ");   
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Every weekday (Monday to Friday)");  
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "21:00:00", "40");   
            timeoff.Recurring_EndDate("05/11/2018"); 
            timeoff.TimeoffLocation("Mexican Squirrel Acutherapy");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC19_Timeoff_Recurring_Weekday_Allday_3NOO
        [TestMethod]
        public void MC19_Timeoff_Recurring_Weekday_Allday_3NOO()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC19 - Timeoff Recurring Weekday All day after 3 no. of occ.", "Timeoff Recurring Weekday All Day added from My Calendar after 3 number of occurences");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 9");   
            timeoff.TimeoffDetails("Test details 9");  
            timeoff.TimeoffRepeatAllDay(); 
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Every weekday (Monday to Friday)");  
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   
            timeoff.AfterNumberOfOccuresces("3"); 
            timeoff.TimeoffLocation("Buzau");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC20_Timeoff_Recurring_Weekday_Allday_EOD
        [TestMethod]
        public void MC20_Timeoff_Recurring_Weekday_Allday_EOD()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC20 - Timeoff Recurring Weekday All Day till End of Date", "Timeoff Recurring Weekday All Day added from My Calendar till End of Date");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 10");   
            timeoff.TimeoffDetails("Test details 10");   
            timeoff.TimeoffRepeatAllDay(); 
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Every weekday (Monday to Friday)"); 
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "","");   
            timeoff.Recurring_EndDate("11/06/2018"); 
            timeoff.TimeoffLocation("Locatie5");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC21_Timeoff_Recurring_Weekly_Every_2Week_5NOO
        [TestMethod]
        public void MC21_Timeoff_Recurring_Weekly_Every_2Week_5NOO()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC21 - Timeoff Recurring Weekly every 2 weeks after 5 occurences", "Timeoff Recurring Weekly added from My Calendar after 5 number of occurences");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 11");  
            timeoff.TimeoffDetails("Test Details 11");    
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Weekly"); 
            timeoff.RepeatsEvery("2"); ; 
            timeoff.Mark_Tuesday();  
            timeoff.Mark_Friday();   
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "07:00:00", "60");   
            timeoff.AfterNumberOfOccuresces("5"); 
            timeoff.TimeoffLocation("Ciuc Wellness");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region  MC22_Timeoff_Recurring_Weekly_Every_Week_EOD
        [TestMethod]
        public void MC22_Timeoff_Recurring_Weekly_Every_Week_EOD()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC22 - Timeoff Recurring Weekly every week till end of date", "Timeoff Recurring Weekly added from My Calendar every week till End of Date");
            timeoff.Book_TimeOff_Button();  
            timeoff.Timeofftitle("Test 12");   
            timeoff.TimeoffDetails("Test Details 12");   
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Weekly"); 
            timeoff.Mark_Monday();   
            timeoff.Mark_Saturday();   
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "20:00:00", "45"); 
            timeoff.Recurring_EndDate("5"); 
            timeoff.TimeoffLocation("Canada Location");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC23_Timeoff_Recurring_Weekly_Every_2Week_Allday_3NOO
        [TestMethod]
        public void MC23_Timeoff_Recurring_Weekly_Every_2Week_Allday_3NOO()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC23 - Timeoff Recurring Weekly All Day every 2 weeks after 3 occurences", "Timeoff Recurring Weekly All Day added from My Calendar every 2 weeks after 3 number of occurences");
            timeoff.Book_TimeOff_Button();  
            timeoff.Timeofftitle("Test 13");  
            timeoff.TimeoffDetails("Test Details 13");  
            timeoff.TimeoffRepeatAllDay();   
            timeoff.TimeoffRepeat();    
            timeoff.Repeats("Weekly"); 
            timeoff.RepeatsEvery("2");   
            timeoff.Mark_Wednesday();  
            timeoff.Mark_Saturday();  
            timeoff.Mark_Sunday();  
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   
            timeoff.AfterNumberOfOccuresces("5"); 
            timeoff.TimeoffLocation("bucuresti");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC24_Timeoff_Recurring_Weekly_Every_Week_Allday_EOD
        [TestMethod]
        public void MC24_Timeoff_Recurring_Weekly_Every_Week_Allday_EOD()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC24 - Timeoff Recurring Weekly All Day every week till end of date", "Timeoff Recurring Weekly All Day added from My Calendar every week till End of Date");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 14");   
            timeoff.TimeoffDetails("Test Details 14");   
            timeoff.TimeoffRepeatAllDay();   
            timeoff.TimeoffRepeat();    
            timeoff.Repeats("Weekly"); 
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");  
            timeoff.Recurring_EndDate("11/05/2018"); 
            timeoff.TimeoffLocation("New York Place");     
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC25_Timeoff_Recurring_Monthly_4NOO
        [TestMethod]
        public void MC25_Timeoff_Recurring_Monthly_4NOO()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC25 - Timeoff Recurring Monthly after 4 no of occurences", "Timeoff Recurring Montly added from My Calendar after 4 number of occurences");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 15");   
            timeoff.TimeoffDetails("Test Details 15");   
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Monthly"); 
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "04:00:00", "15");       
            timeoff.AfterNumberOfOccuresces("4"); 
            timeoff.TimeoffLocation("Locatie1");    
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC26_Timeoff_Recurring_Monthly_EOD
        [TestMethod]
        public void MC26_Timeoff_Recurring_Monthly_EOD()
        { 
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC26 - Timeoff Recurring Monthly till end of date", "Timeoff Recurring Monthly added from My Calendar till End of Date");
            timeoff.Book_TimeOff_Button();   
            timeoff.Timeofftitle("Test 16");   
            timeoff.TimeoffDetails("Test Details 16");   
            timeoff.TimeoffRepeat();    
            timeoff.Repeats("Monthly"); 
            timeoff.RepeatsEvery("2");   
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "11:00:00", "70");       
            timeoff.Recurring_EndDate("11/05/2018");  
            timeoff.TimeoffLocation("Bear Mask Acupuncture");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC27_Timeoff_Recurring_Monthly_Allday_4NOO
        [TestMethod]
        public void MC27_Timeoff_Recurring_Monthly_Allday_4NOO()
        {
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC27 - Timeoff Recurring Monthly All Day after 4 no of occurences", "Timeoff Recurring Monthly All Day added from My Calendar after 4 no of occurences");
            timeoff.Book_TimeOff_Button();  
            timeoff.Timeofftitle("Test 17");   
            timeoff.TimeoffDetails("Test Details 17");   
            timeoff.TimeoffRepeatAllDay();   
            timeoff.TimeoffRepeat();    
            timeoff.Repeats("Monthly");  
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");  
            timeoff.AfterNumberOfOccuresces("4");   
            timeoff.TimeoffLocation("Bear Mask Acupuncture");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region MC28_Timeoff_Recurring_Monthly_Allday_EOD
        [TestMethod]
        public void MC28_Timeoff_Recurring_Monthly_Allday_EOD()
        {  
            LeftNavigation.Calendar.MyCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            MyCalendarPage timeoff = new MyCalendarPage();
            var test = timeoff.test = extent.StartTest("MC28 - Timeoff Recurring Monthly All Day till end of date", "Timeoff Recurring Monthly All Day added from My Calendar till End of Date");
            timeoff.Book_TimeOff_Button();      
            timeoff.Timeofftitle("Test 18");   
            timeoff.TimeoffDetails("Test Details 18");   
            timeoff.TimeoffRepeatAllDay();    
            timeoff.TimeoffRepeat();   
            timeoff.Repeats("Monthly");  
            timeoff.RepeatsEvery("2");
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   
            timeoff.Recurring_EndDate("15/05/2018"); 
            timeoff.TimeoffLocation("Ciuc Wellness");   
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        // de aici de inlocuit 

        //[TestMethod]
        //public void Remove_SimpleTimeoff()
        //{
        //    LeftNavigation.Calendar.MyCalendar.GoTo();
        //    Driver.Wait(TimeSpan.FromSeconds(5));
        //    MyCalendarPage daily = new MyCalendarPage();
        //    daily.Remove_Timeoff("02/15/2018", "time off 5min");
        //    daily.Remove_this_timeoff();
        // //   daily.Remove_Timeoff_Recurring("rtest", "02/15/2017");
        //}

        //[TestMethod]
        //public void Remove_TimeoffAllSeries()
        //{
        //    LeftNavigation.Calendar.MyCalendar.GoTo();
        //    Driver.Wait(TimeSpan.FromSeconds(5));
        //    MyCalendarPage daily = new MyCalendarPage();
        //    daily.Remove_Timeoff("02/15/2018", "test recurring");
        //    daily.Remove_all_timeoff_in_the_series();
        //    //   daily.Remove_Timeoff_Recurring("rtest", "02/15/2017");
        //}

        //[TestMethod]
        //public void Remove_TimeoffAllSeriesFoward()
        //{
        //    LeftNavigation.Calendar.MyCalendar.GoTo();
        //    Driver.Wait(TimeSpan.FromSeconds(5));
        //    MyCalendarPage daily = new MyCalendarPage();
        //    daily.Remove_Timeoff("02/15/2018", "test111");
        //    daily.Remove_all_timeoff_in_the_series_foward();
        //    //   daily.Remove_Timeoff_Recurring("rtest", "02/15/2017");
        //}

        //[TestMethod]
        //public void Remove_Appointment()
        //{
        //    LeftNavigation.Calendar.MyCalendar.GoTo();
        //    Driver.Wait(TimeSpan.FromSeconds(5));
        //    MyCalendarPage daily = new MyCalendarPage();
        //    daily.Remove_Appointment();
          
        //    //   daily.Remove_Timeoff_Recurring("rtest", "02/15/2017");
        //}



        //[TestMethod]
        //public void Remove_Timeoff_Simple_MyCalendar()
        //{
        //    // LeftNavigation.Calendar.MyCalendar.GoTo();
        //    Timeoff_5minutes();
        //    MyCalendarPage c = new MyCalendarPage();
        //    c.Remove_Timeoff("11/18/2017","");
        //}

        //[TestMethod]
        //public void Remove_Timeoff_AllDay_MyCalendar()
        //{
        //    LeftNavigation.Calendar.MyCalendar.GoTo();
        //    Driver.Wait(TimeSpan.FromSeconds(5));
        //    MyCalendarPage c = new MyCalendarPage();
        //    c.Remove_Timeoff("12/13/2017","test");
        //}


        //[TestMethod]
        //public void Remove_Timeoff_Recurring_MyCalendar()
        //{
        //    //Timeoff_Recurring_MyCalendar();
        //    MyCalendarPage c = new MyCalendarPage();
        //  //  c.Remove_Timeoff_Recurring("10/18/2017");
        //}
    }
}
