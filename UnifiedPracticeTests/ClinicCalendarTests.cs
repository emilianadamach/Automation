using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation;
using UPAutomation.Navigation;
using UPAutomation.Pages;
using UPAutomation.Selenium;
using RelevantCodes.ExtentReports;


namespace UnifiedPracticeTests
{
    [TestClass]
    public class ClinicCalendarTests : UPBaseTest  
    {
        #region CC01_Appointment_With_New_Patient
        [TestMethod]
        public void CC01_Appointment_With_New_Patient()
        {
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC01 - Appointment with New Patient", "Appointment added from Clinic Calendar with a New Patient Created");  
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
            cal.Appointment_Practitioner("Ana Zina");  
            cal.Appointment_Location("Bear Mask Acupuncture");  
            cal.Appointment_Service("Acupuncture"); 
            cal.Appointment_Room("Black Room");
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC02_Appointment_With_Existing_Patient
        [TestMethod]
        public void CC02_Appointment_With_Existing_Patient()
        {
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(7));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC02 - Appointment with Existing Patient", "Appointment added from Clinic Calendar with an Existing Patient");
            cal.AddAppointmentButton();         
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Sean Hurley");         
            cal.Appointment_Complaint("Complaint 2");            
            cal.Appointment_PractitionerNotes("Note 2"); 
            cal.Appointment_Type("Insurance"); 
            cal.Appointment_Date_and_Time("07/10/2018", "17:30:00"); 
            cal.Appointment_Practitioner("Ana Zina");  
            cal.Appointment_Location("Canada Location");   
            cal.Appointment_Service("Needle Dancing");    
            cal.Appointment_Room("Test Room2");   
            cal.Appointment_Save();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC03_Appointment_Recurring_Daily_Every_3days_3NOO
        [TestMethod]
        public void CC03_Appointment_Recurring_Daily_Every_3days_3NOO()
        {
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC03 - Appointment Recurring Daily After No. of Occurences", "Appointment Recurring Daily added from Clinic Calendar After a No. of Occurences");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("THOMAS LOUIE MICHAEL");  
            cal.Appointment_Complaint("Complaint 3");   
            cal.Appointment_PractitionerNotes("Note 3");  
            cal.Appointment_Type("Promotion/Package");   
            cal.Appointment_Date_and_Time("07/10/2018", "16:30:00"); 
            cal.Appointment_Practitioner("Ana Zina");  
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

        #region CC04_Appointment_Recurring_Daily_Every_5days_EOD
        [TestMethod]
        public void CC04_Appointment_Recurring_Daily_Every_5days_EOD()
        {
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC04 - Appointment Recurring Daily till End of Date", "Appointment Recurring Daily added from Clinic Calendar till End of Date");
            cal.AddAppointmentButton();  
            Driver.Wait(TimeSpan.FromSeconds(2));    
            cal.Search_Existing_Patient("lavinia nuca");  
            cal.Appointment_Complaint("Complaint 4"); 
            cal.Appointment_PractitionerNotes("Note 4"); 
            cal.Appointment_Type("Pro-bono"); 
            cal.Appointment_Date_and_Time("07/10/2018", "10:30:00"); 
            cal.Appointment_Practitioner("Ana Zina");  
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

        #region CC05_Appointment_Recurring_Weekday_3NOO
        [TestMethod]
        public void CC05_Appointment_Recurring_Weekday_3NOO()
        {
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC05 - Appointment Recurring Weekday After No. of Occurences", "Appointment Recurring Weekday added from Clinic Calendar After a No. of Occurences");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));   
            cal.Search_Existing_Patient("Mad Pinguin");  
            cal.Appointment_Complaint("Complaint 5");  
            cal.Appointment_PractitionerNotes("Note 5"); 
            cal.Appointment_Type("Self-Pay");   
            cal.Appointment_Date_and_Time("07/10/2018", "09:00:00");  
            cal.Appointment_Practitioner("Ana Zina");  
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

        #region CC06_Appointment_Recurring_Weekday_EOD
        [TestMethod]
        public void CC06_Appointment_Recurring_Weekday_EOD()
        {
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC06 - Appointment Recurring Weekday till End of Date", "Appointment Recurring Weekday added from Clinic Calendar till End of Date");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Garfield Cat");  
            cal.Appointment_Complaint("Complaint 6"); 
            cal.Appointment_PractitionerNotes("Note 6"); 
            cal.Appointment_Type("Insurance"); 
            cal.Appointment_Date_and_Time("07/10/2018", "10:00:00");  
            cal.Appointment_Practitioner("Ana Zina");  
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
        
        #region CC07_Appointment_Recurring_Weekly_4days_Every_3Weeks_EOD
        [TestMethod]
        public void CC07_Appointment_Recurring_Weekly_4days_Every_3Weeks_EOD()
        {    
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC07 - Appointment Recurring Weekly till End of Date", "Appointment Recurring Weekly added from Clinic Calendar till End of Date");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Colette Smithica"); 
            cal.Appointment_Complaint("Complaint 7");  
            cal.Appointment_PractitionerNotes("Note 7"); 
            cal.Appointment_Type("Insurance"); 
            cal.Appointment_Date_and_Time("07/10/2018", "12:00:00"); 
            cal.Appointment_Practitioner("Ana Zina");  
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

        #region CC08_Appointment_Recurring_Weekly_3days_Every_2Weeks_after_5NOO
        [TestMethod]
        public void CC08_Appointment_Recurring_Weekly_3days_Every_2Weeks_after_5NOO()
        {
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC08 - Appointment Recurring Weekly After No. of Occurences", "Appointment Recurring Weekdly added from Clinic Calendar After a No. of Occurences");
            cal.AddAppointmentButton();  
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Michelangeo Antonini");  
            cal.Appointment_Complaint("Complaint 8");  
            cal.Appointment_PractitionerNotes("Note 8");  
            cal.Appointment_Type("Insurance");  
            cal.Appointment_Date_and_Time("07/10/2018", "15:00:00"); 
            cal.Appointment_Practitioner("Ana Zina");  
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

        #region CC09_Appointment_Recurring_Monthly_4NOO
        [TestMethod]
        public void CC09_Appointment_Recurring_Monthly_4NOO()
        {
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC09 - Appointment Recurring Monthly After No. of Occurences", "Appointment Recurring Monthly added from Clinic Calendar After a No. of Occurences");
            cal.AddAppointmentButton();  
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("WILLIAM OLIVER KATIE"); 
            cal.Appointment_Complaint("Complaint 9");  
            cal.Appointment_PractitionerNotes("Note 9"); 
            cal.Appointment_Type("Insurance");    
            cal.Appointment_Date_and_Time("07/10/2018", "13:30:00"); 
            cal.Appointment_Practitioner("Ana Zina");  
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

        #region CC10_Appointment_Recurring_Monthly_EOD
        [TestMethod]
        public void CC10_Appointment_Recurring_Monthly_EOD()
        {
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage cal = new ClinicCalendarPage();
            var test = cal.test = extent.StartTest("CC10 - Appointment Recurring Monthly till End of Date", "Appointment Recurring Monthly added from Clinic Calendar till End of Date");
            cal.AddAppointmentButton(); 
            Driver.Wait(TimeSpan.FromSeconds(2));
            cal.Search_Existing_Patient("Insurance Fresh"); 
            cal.Appointment_Complaint("Complaint 10"); 
            cal.Appointment_PractitionerNotes("Note 10"); 
            cal.Appointment_Type("Insurance"); 
            cal.Appointment_Date_and_Time("07/10/2018", "20:30:00"); 
            cal.Appointment_Practitioner("Ana Zina");  
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

        #region  CC11_Timeoff_5minutes
        [TestMethod]
        public void CC11_Timeoff_5minutes()
        {       
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
            var test = timeoff.test = extent.StartTest("CC11 - Timeoff 5 minutes", "Timeoff 5 minutes added from Clinic Calendar");
            timeoff.Book_TimeOff_Button();  
            timeoff.Timeofftitle("Test 1 5minutes");  
            timeoff.TimeoffDetails("Test Details 1");   
            timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); 
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "11:00:00", "15");   
            timeoff.TimeoffLocation("Bear Mask Acupuncture"); 
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC12_Timeoff_AllDay
        [TestMethod]
        public void CC12_Timeoff_AllDay()
        {

            var test = extent.StartTest("CC12 - Timeoff All Day", "Timeoff All Day added from Clinic Calendar");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff butt
                timeoff.Timeofftitle("Test 2 All Day");   // Timeoff Titl
                timeoff.TimeoffDetails("Test Details 2");   // Timeoff Details
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitioner
                timeoff.TimeoffRepeatAllDay();   // Timeoff Repeat All Da
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   // Timeoff StartDate & Time
                timeoff.TimeoffLocation("Locatie1");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC13_Timeoff_Recurring_Daily_Every_3days_3NOO
        [TestMethod]
        public void CC13_Timeoff_Recurring_Daily_Every_3days_3NOO()
        {
            var test = extent.StartTest("CC13 - Timeoff Recurring Daily Every 3 days After 3 no of occ", "Timeoff Recurring All Day added from Clinic Calendar Every every 3 days After 3 no of occ");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff butto
                timeoff.Timeofftitle("Test 3 recurring 5minutes");   // Timeof
                timeoff.TimeoffDetails("Test Details 3");   // Timeoff Details
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitio
                timeoff.TimeoffRepeat();   // Repeat
                timeoff.Repeats("Daily"); //  Repeats 
                timeoff.RepeatsEvery("3"); ; //  Repeats Eve
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "11:00:00", "25");   // Timeoff StartDate & Tim
                timeoff.AfterNumberOfOccuresces("3"); // After Number of Occuren
                timeoff.TimeoffLocation("Locatie2");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC14_Timeoff_Recurring_Daily_Every_5days_EOD
        [TestMethod]
        public void CC14_Timeoff_Recurring_Daily_Every_5days_EOD()
        {
            var test = extent.StartTest("CC14 - Timeoff Recurring Daily every 5 days till End of Date", "Timeoff Recurring All Day added from Clinic Calendar every 5 days till End of Date");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff button
                timeoff.Timeofftitle("Test 4 ");   // Timeoff Ti
                timeoff.TimeoffDetails("Test Details 4");   // Timeoff Deta
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitione
                timeoff.TimeoffRepeat();   // Repe
                timeoff.Repeats("Daily"); //  Repe
                timeoff.RepeatsEvery("5"); ; //  Repeats Every
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "11:00:00", "10");   // Timeoff StartDate & Time
                timeoff.Recurring_EndDate("07/30/2018"); // Recurring End Dat
                timeoff.TimeoffLocation("Ciuc Wellness");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC15_Timeoff_Recurring_Daily_Allday_Every_3days_3NOO
        [TestMethod]
        public void CC15_Timeoff_Recurring_Daily_Allday_Every_3days_3NOO()
        {
            var test = extent.StartTest("CC15 - Timeoff Recurring Daily All Day after no. of occ", "Timeoff Recurring Daily All Day added from Clinic Calendar Every 3 days after 3 no of Occurences ");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff button
                timeoff.Timeofftitle("Test 5 ");   // Timeoff Title
                timeoff.TimeoffDetails("Test Details 5");   // Timeoff Details
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitioner
                timeoff.TimeoffRepeatAllDay();   // Repeat All Day
                timeoff.TimeoffRepeat();   // Rep
                timeoff.Repeats("Daily"); //  Repeats
                timeoff.RepeatsEvery("3"); ; // Repeats Every
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   // Timeoff StartDate & Ti
                timeoff.AfterNumberOfOccuresces("3"); // After Number of Occur
                timeoff.TimeoffLocation("New York Place");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC16_Timeoff_Recurring_Daily_Allday_Every_5days_EOD
        [TestMethod]
        public void CC16_Timeoff_Recurring_Daily_Allday_Every_5days_EOD()
        {
            var test = extent.StartTest("CC16 - Timeoff Recurring Daily All Day till end of date", "Timeoff Recurring Daily All Day added from Clinic Calendar every 5 days till End of Date");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff
                timeoff.Timeofftitle("Test 6");   // Timeoff Ti
                timeoff.TimeoffDetails("Test Details 6");   // Timeoff Det
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitio
                timeoff.TimeoffRepeatAllDay();   // Repeat 
                timeoff.TimeoffRepeat();   // Repea
                timeoff.Repeats("Daily"); // 
                timeoff.RepeatsEvery("5"); ; //  Repeats Every
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   // Timeoff StartDate &
                timeoff.Recurring_EndDate("06/27/2018"); // Recurring End
                timeoff.TimeoffLocation("Buzau");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC17_Timeoff_Recurring_Weekday_3NOO
        [TestMethod]
        public void CC17_Timeoff_Recurring_Weekday_3NOO()
        {
            var test = extent.StartTest("CC17 - Timeoff Recurring Weekday after 3 no of occ", "Timeoff Recurring Weekday added from Clinic Calendar after 3 number of occurences");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff but
                timeoff.Timeofftitle("Test 7");   // Timeoff Title
                timeoff.TimeoffDetails("Test Details 7");   // Timeoff Detail
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitioner
                timeoff.TimeoffRepeat();   // Repeat
                timeoff.Repeats("Every weekday (Monday to Friday)"); // Repeats 
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "17:00:00", "30");   // Timeoff StartDate & Time
                timeoff.AfterNumberOfOccuresces("3"); // After Number of Occur
                timeoff.TimeoffLocation("New York Place");   // Timeoff Locati
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC18_Timeoff_Recurring_Weekday_EOD
        [TestMethod]
        public void CC18_Timeoff_Recurring_Weekday_EOD()

        {
            var test = extent.StartTest("CC18 - Timeoff Recurring Weekday till end of date", "Timeoff Recurring Weekday added from Clinic Calendar till End of Date");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff bu
                timeoff.Timeofftitle("Test 8");   // Timeoff Tit
                timeoff.TimeoffDetails("Test Details 8 ");   // Timeoff Details
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitioner
                timeoff.TimeoffRepeat();   // Repea
                timeoff.Repeats("Every weekday (Monday to Friday)"); // Rep
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "21:00:00", "40");   // Timeoff StartDate &
                timeoff.Recurring_EndDate("05/11/2018"); // Recurring End
                timeoff.TimeoffLocation("Mexican Squirrel Acutherapy");   // Timeoff Locat
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC19_Timeoff_Recurring_Weekday_Allday_3NOO
        [TestMethod]
        public void CC19_Timeoff_Recurring_Weekday_Allday_3NOO()
        {
            var test = extent.StartTest("CC19 - Timeoff Recurring Weekday All day after 3 no. of occ.", "Timeoff Recurring Weekday All Day added from Clinic Calendar after 3 number of occurences");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff b
                timeoff.Timeofftitle("Test 9");   // Timeoff Titl
                timeoff.TimeoffDetails("Test details 9");   // Timeoff Details
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practi
                timeoff.TimeoffRepeatAllDay(); //  Repeats All Da
                timeoff.TimeoffRepeat();   //  Repeat 
                timeoff.Repeats("Every weekday (Monday to Friday)"); // Repeats
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   // Timeoff StartDate & Time
                timeoff.AfterNumberOfOccuresces("3"); // After Number of Occurences
                timeoff.TimeoffLocation("Buzau");   // Timeoff Locatio
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC20_Timeoff_Recurring_Weekday_Allday_EOD
        [TestMethod]
        public void CC20_Timeoff_Recurring_Weekday_Allday_EOD()
        {
            var test = extent.StartTest("CC20 - Timeoff Recurring Weekday All Day till End of Date", "Timeoff Recurring Weekday All Day added from Clinic Calendar till End of Date");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff butto
                timeoff.Timeofftitle("Test 10");   // Timeoff Title
                timeoff.TimeoffDetails("Test details 10");   // Timeoff Details
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitioner
                timeoff.TimeoffRepeatAllDay(); // Repeats All Day
                timeoff.TimeoffRepeat();   // Repeat
                timeoff.Repeats("Every weekday (Monday to Friday)"); // Repeat
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   // Timeoff StartDate
                timeoff.Recurring_EndDate("11/06/2018"); // Recurring End Date
                timeoff.TimeoffLocation("Locatie5");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC21_Timeoff_Recurring_Weekly_Every_2Week_5NOO
        [TestMethod]
        public void CC21_Timeoff_Recurring_Weekly_Every_2Week_5NOO()
        {
            var test = extent.StartTest("CC21 - Timeoff Recurring Weekly every 2 weeks after 5 occurences", "Timeoff Recurring Weekly added from Clinic Calendar after 5 number of occurences");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff button
                timeoff.Timeofftitle("Test 11");   // Timeoff T
                timeoff.TimeoffDetails("Test Details 11");   // Timeoff Detail
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitio
                timeoff.TimeoffRepeat();   // Rep
                timeoff.Repeats("Weekly"); // Repeats 
                timeoff.RepeatsEvery("2"); ; //  Repeats Every
                timeoff.Mark_Tuesday();  // Mark Tu
                timeoff.Mark_Friday();   // Mark F
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "07:00:00", "60");   // Timeoff StartDate & Time
                timeoff.AfterNumberOfOccuresces("5"); // After Number of Occuren
                timeoff.TimeoffLocation("Ciuc Wellness");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC22_Timeoff_Recurring_Weekly_Every_Week_EOD
        [TestMethod]
        public void CC22_Timeoff_Recurring_Weekly_Every_Week_EOD()
        {
            var test = extent.StartTest("CC22 - Timeoff Recurring Weekly every week till end of date", "Timeoff Recurring Weekly added from Clinic Calendar every week till End of Date");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff button
                timeoff.Timeofftitle("Test 12");   // Timeoff Tit
                timeoff.TimeoffDetails("Test Details 12");   // Timeoff Detail
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitioner
                timeoff.TimeoffRepeat();   // Repeat 
                timeoff.Repeats("Weekly"); // Repeats 
                timeoff.Mark_Tuesday();   // Mark Tuesday
                timeoff.Mark_Saturday();   // Mark Saturda
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "20:00:00", "45");   // Timeoff StartDate & Ti
                timeoff.Recurring_EndDate("5"); // Recurring End of Date
                timeoff.TimeoffLocation("Canada Location");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC23_Timeoff_Recurring_Weekly_Every_2Week_Allday_3NOO
        [TestMethod]
        public void CC23_Timeoff_Recurring_Weekly_Every_2Week_Allday_3NOO()
        {
            var test = extent.StartTest("CC23 - Timeoff Recurring Weekly All Day every 2 weeks after 3 occurences", "Timeoff Recurring Weekly All Day added from Clinic Calendar every 2 weeks after 3 number of occurences");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff bu
                timeoff.Timeofftitle("Test 13");   // Timeoff Titl
                timeoff.TimeoffDetails("Test Details 13");   // Timeoff Details
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practition
                timeoff.TimeoffRepeatAllDay();   // Repeats All Day
                timeoff.TimeoffRepeat();   // Repe
                timeoff.Repeats("Weekly"); // Repeats 
                timeoff.RepeatsEvery("2"); //  Repeats Ev
                timeoff.Mark_Wednesday(); // Mark Wednesday
                timeoff.Mark_Saturday();  // Mark Satur
                timeoff.Mark_Sunday();  // Mark 
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   // Timeoff StartDate & Tim
                timeoff.AfterNumberOfOccuresces("5"); // After Number of 
                timeoff.TimeoffLocation("bucuresti");   // Timeoff L
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC24_Timeoff_Recurring_Weekly_Every_Week_Allday_EOD
        [TestMethod]
        public void CC24_Timeoff_Recurring_Weekly_Every_Week_Allday_EOD()
        {
            var test = extent.StartTest("CC24 - Timeoff Recurring Weekly All Day every week till end of date", "Timeoff Recurring Weekly All Day added from Clinic Calendar every week till End of Date");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff butt
                timeoff.Timeofftitle("Test 14");   // Timeoff Tit
                timeoff.TimeoffDetails("Test Details 14");   // Timeoff Detai
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitioner
                timeoff.TimeoffRepeatAllDay();   //  Repeats All
                timeoff.TimeoffRepeat();   //  Re
                timeoff.Repeats("Weekly"); // Repeat
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   // Timeoff StartDate & 
                timeoff.Recurring_EndDate("11/05/2018"); // Recurring En
                timeoff.TimeoffLocation("New York Place");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC25_Timeoff_Recurring_Monthly_4NOO
        [TestMethod]
        public void CC25_Timeoff_Recurring_Monthly_4NOO()
        {
            var test = extent.StartTest("CC25 - Timeoff Recurring Monthly after 4 no of occurences", "Timeoff Recurring Montly added from Clinic Calendar after 4 number of occurences");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff button
                timeoff.Timeofftitle("Test 15");   // Timeoff Tit
                timeoff.TimeoffDetails("Test Details 15");   // Timeoff Detail
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practi
                timeoff.TimeoffRepeat();   // Re
                timeoff.Repeats("Monthly"); // Repeat
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "04:00:00", "15");   // Timeoff StartDate & Tim
                timeoff.AfterNumberOfOccuresces("4"); // After Number of Occure
                timeoff.TimeoffLocation("Locatie1");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC26_Timeoff_Recurring_Monthly_EOD
        [TestMethod]
        public void CC26_Timeoff_Recurring_Monthly_EOD()
        {
            var test = extent.StartTest("CC26 - Timeoff Recurring Monthly till end of date", "Timeoff Recurring Monthly added from Clinic Calendar till End of Date");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff button
                timeoff.Timeofftitle("Test 16");   // Timeoff T
                timeoff.TimeoffDetails("Test Details 16");   // Timeoff Details
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practiti
                timeoff.TimeoffRepeat();   // Repeat
                timeoff.Repeats("Monthly"); //  
                timeoff.RepeatsEvery("2"); //  R
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "11:00:00", "70");   // Timeoff StartDate & Tim
                timeoff.Recurring_EndDate("11/05/2018"); // Recurring End Date
                timeoff.TimeoffLocation("Bear Mask Acupuncture");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC27_Timeoff_Recurring_Monthly_Allday_4NOO
        [TestMethod]
        public void CC27_Timeoff_Recurring_Monthly_Allday_4NOO()
        {
            var test = extent.StartTest("CC27 - Timeoff Recurring Monthly All Day after 4 no of occurences", "Timeoff Recurring Monthly All Day added from Clinic Calendar after 4 no of occurences");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
                timeoff.Book_TimeOff_Button();   //Book Timeoff b
                timeoff.Timeofftitle("Test 17");   // Timeoff 
                timeoff.TimeoffDetails("Test Details 17");   // Timeoff Detai
                timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitione
                timeoff.TimeoffRepeatAllDay();   // Repeats All Da
                timeoff.TimeoffRepeat();   // Rep
                timeoff.Repeats("Monthly"); //  Repeats 
                timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   // Timeoff StartDate & 
                timeoff.AfterNumberOfOccuresces("4"); // After Number of Occurences
                timeoff.TimeoffLocation("Bear Mask Acupuncture");   // Timeoff Location
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        #region CC28_Timeoff_Recurring_Monthly_Allday_EOD
        [TestMethod]
        public void CC28_Timeoff_Recurring_Monthly_Allday_EOD()
        {
            var test = extent.StartTest("CC28 - Timeoff Recurring Monthly All Day till end of date", "Timeoff Recurring Monthly All Day added from Clinic Calendar till End of Date");
            LeftNavigation.Calendar.ClinicCalendar.GoTo();
            Driver.Wait(TimeSpan.FromSeconds(5));
            ClinicCalendarPage timeoff = new ClinicCalendarPage();
            timeoff.Book_TimeOff_Button();   //Book Timeoff butto
            timeoff.Timeofftitle("Test 18");   // Timeoff Title
            timeoff.TimeoffDetails("Test Details 18");   // Timeoff De
            timeoff.Set_Timeoff_for_Practitioner("Tim Lucian Rogers"); // Timeoff Practitioner
            timeoff.TimeoffRepeatAllDay();   // Repeats All Day
            timeoff.TimeoffRepeat();   // Repeat
            timeoff.Repeats("Monthly"); // 
            timeoff.RepeatsEvery("2"); //  Repeats Ever
            timeoff.Timeoff_StartDate_and_Time("07/11/2018", "", "");   // Timeoff StartDate & Time
            timeoff.Recurring_EndDate("15/05/2018"); // Recurring End D
            timeoff.TimeoffLocation("Ciuc Wellness");   // Timeoff Location 
            timeoff.TimeoffSave();
            extent.EndTest(test);
            extent.Flush();
        }
        #endregion

        //[TestMethod]
        //public void Remove_Appointment()
        //{

        //    LeftNavigation.Calendar.ClinicCalendar.GoTo();
        //    Driver.Wait(TimeSpan.FromSeconds(5));
        //    ClinicCalendarPage timeoff = new ClinicCalendarPage();
        //   timeoff.Remove_all_timeoff_in_the_series("12/14/2017","IOnel Gaju");

        //}
        /// <summary>
        ///  de aici de vazut 
        /// </summary>

        //[TestMethod]
        //public void Remove_Test()
        //{
        //    LeftNavigation.Calendar.ClinicCalendar.GoTo();
        //    Driver.Wait(TimeSpan.FromSeconds(5));
        //    ClinicCalendarPage daily = new ClinicCalendarPage();
        //    daily.Remove_Timeoff_Recurring("Test1", "11/12/2017");
        //}

        //[TestMethod]
        //public void Remove_Timeoff_Simple_ClinicCalendar()
        //{
        //   // Timeoff_Simple_ClinicCalendar();
        //    ClinicCalendarPage c = new ClinicCalendarPage();
        //    c.Remove_Timeoff("11/11/2017","");
        //}

        //[TestMethod]
        //public void Remove_Timeoff_AllDay_ClinicCalendar()
        //{
        //      Timeoff_AllDay_ClinicCalendar();
        //      ClinicCalendarPage b = new ClinicCalendarPage();
        //      b.Remove_Timeoff("10/18/2017","");
        //}

        //[TestMethod]
        //public void Remove_Timeoff_Recurring_ClinicCalendar()
        //{
        //    //Timeoff_Recurring_ClinicCalendar();
        //    ClinicCalendarPage b = new ClinicCalendarPage();
        // //   b.Remove_Timeoff_Recurring("10/18/2017");
        //}


    }
}
