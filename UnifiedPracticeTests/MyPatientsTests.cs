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

namespace UnifiedPracticeTests
{
    [TestClass]
    public class MyPatientsTests : UPBaseTest
    {
        [TestMethod]
        public void MP01_Add_New_Patient()
        {
            LeftNavigation.PatientList.MyPatients.GoTo();
            MyPatientsPage myPatients = new MyPatientsPage();
            Driver.Wait(TimeSpan.FromSeconds(3));
            var test = myPatients.test = extent.StartTest("Add new Patient", "Patient Details saved");
            myPatients.AddPatientbutton();
            myPatients.AddPatient("04/26/1992", "0720600610", "Home", "emilian.adamache@omnisourcetech.com", "Other");
            extent.EndTest(test);
            extent.Flush();
        }

        [TestMethod]
        public void MP02_Complete_Chart()
        {
            MyPatientsPage myPatients = new MyPatientsPage();
            Driver.Wait(TimeSpan.FromSeconds(3));
            var test = myPatients.test = extent.StartTest("test1", "test22");
            myPatients.SearchPatient("Jerry Tomas");
            Driver.Wait(TimeSpan.FromSeconds(3));
            myPatients.Click_Chart_Button();
            Driver.Wait(TimeSpan.FromSeconds(2));
            myPatients.Add_Vital_Signs("aa", "bb", "cc", "dd", "ee", "ff");
            myPatients.Add_Chief_Complaint("c1", "c2", "c3", "c4");
            myPatients.Subjective("adsa", "gggg", "rrrrr");
            myPatients.SubjectiveChannel("Test1", "Test2", "Test3");
            myPatients.Objective("adad", "dffdd", "jjjjjj");
            myPatients.Tongue("aa", "bb", "cc", "dd", "ee", "ff");
            myPatients.Add_Pulse("aa", "aa", "bb", "cc", "dd", "ee", "ff");
            myPatients.ChannelPalpation("sfsf", "sfsf", "adad");
            myPatients.PhysicalExam("adad", "adadd", "adada");
            myPatients.Assessment("adad", "adadd", "adadad");
            myPatients.AcuRx("aaa", "llljhj", "hfdh");
            myPatients.ExternalRx("adadad", "adada", "adadad");
            myPatients.HerbsRx("adada", "addad", "adadad");
            myPatients.TreatmentPrinciple("adada", "adadad", "adadad");
            myPatients.AdviceRx("adada", "adadad", "adadd");
            extent.EndTest(test);
            extent.Flush();
        }
        //[TestMethod]
        //public void First_Patient_Gets_Chart_Close_and_Sign()
        //{
        //    LeftNavigation.PatientList.MyPatients.GoTo();
        //    MyPatientsPage a = new MyPatientsPage();
        //      a.First_Patient_On_Today();
        //      a.Close_and_Sign_Chart();
        //}

        [TestMethod]
        public void BIllingg()
        {
           LeftNavigation.PatientList.MyPatients.GoTo();
            MyPatientsPage a = new MyPatientsPage();
            Driver.Wait(TimeSpan.FromSeconds(5));
            a.SearchPatient("Jerry Tom");
            a.BIlling("123", "12");
           
            //  a.Close_and_Sign_Chart();
        }

        [TestMethod]
        public void Search_Patient_Close_and_Sign_Chart()
        {
           // MyCalendarTests myCalendar = new MyCalendarTests();
          //  myCalendar.Appointment_With_Existing_Patient_in_MyCalendar();
         //   Driver.Wait(TimeSpan.FromSeconds(3));
            MyPatientsPage myPatients = new MyPatientsPage();
            Driver.Wait(TimeSpan.FromSeconds(3));
            myPatients.SearchPatient("Jerry Tom");
            Driver.Wait(TimeSpan.FromSeconds(3));
            myPatients.Close_and_Sign_Chart();
            // myPatients.Billing_Info_Save_CPT();
            //*[@id="intake-body"]/div[2]/div[1]/a/i
        }

        [TestMethod]
        public void M03_Add_Primary_Insurance()
        {
         //   LeftNavigation.PatientList.MyPatients.GoTo();
            MyPatientsPage myPatients = new MyPatientsPage();
            Driver.Wait(TimeSpan.FromSeconds(3));
            var test = myPatients.test = extent.StartTest("Primary Insurance", "Primary Insuranchhfe");
            myPatients.SearchPatient("Radu Arhan");
            Driver.Wait(TimeSpan.FromSeconds(3));
            myPatients.InsuranceTab();
            myPatients.Insurance_Plan_Eligibility("05/08/2018","5","12.34%","30","40","6","7123", "05/08/2018", "06/08/2018","Just Primary Insurance");
        //    myPatients.Insurance_Card_Information("Primary Plan","007","2242","Alpha","Sperantei","Bz","5100", "Kansas","0720501231");
            myPatients.Insurance_Is_Covered_By_Someone_else("Child","Popescu","Gigel","Dan", "05/10/2000","Male","072065101","Verii","BZ","5100","Arizona");
            myPatients.Insurance_Prior_Authization("34535", "05/18/2018", "05/23/2019","3","TanaseION","023425533");
            myPatients.PrimarySave();
            extent.EndTest(test);
            extent.Flush();
        }

        [TestMethod]
        public void M04_Add_Secondary_Insurance()
        {
           // LeftNavigation.PatientList.MyPatients.GoTo();
            MyPatientsPage myPatients = new MyPatientsPage();
            Driver.Wait(TimeSpan.FromSeconds(3));
            var test = myPatients.test = extent.StartTest("Secondary Insurance", "Primary Insurafhfhfnce");
            myPatients.SearchPatient("Radu Arhan");
            Driver.Wait(TimeSpan.FromSeconds(3));
            myPatients.InsuranceTab();
            myPatients.Secondary_Insurance();
            Driver.Wait(TimeSpan.FromSeconds(2));
            myPatients.Secondary_Plan("Fresh");
      //      myPatients.Insurance_Plan_Eligibility("05/08/2018", "5", "12.34%", "30", "40", "6", "7123", "05/08/2018", "06/08/2018", "Just Primary Insurance");
           // myPatients.Insurance_Card_Information("Primary Plan", "007", "2242", "Alpha", "Sperantei", "Bz", "5100", "Kansas", "0720501231");
            myPatients.Insurance_Is_Covered_By_Someone_else("Child", "Popescu", "Gigel", "Dan", "05/10/2000", "Male", "072065101", "Verii", "BZ", "5100", "Arizona");
            myPatients.Insurance_Prior_Authization("34535", "05/18/2018", "05/23/2019", "3", "TanaseION", "023425533");
            myPatients.SecondarySave();
            extent.EndTest(test);
            extent.Flush();
        }

        [TestMethod]
        public void M05_Add_AutoAccident_Insurance()
        {
      //      LeftNavigation.PatientList.MyPatients.GoTo();
            MyPatientsPage myPatients = new MyPatientsPage();
            Driver.Wait(TimeSpan.FromSeconds(3));
            var test = myPatients.test = extent.StartTest("Autoaccident Insurance", "Primaryfghfhf Insurance");
            myPatients.SearchPatient("Radu Arhan");
            Driver.Wait(TimeSpan.FromSeconds(3));
            myPatients.InsuranceTab();
            myPatients.Auto_Accident_Insurance();
            Driver.Wait(TimeSpan.FromSeconds(1));
            myPatients.Insurance_Plan_Eligibility("05/08/2018", "5", "12.34%", "30", "40", "6", "7123", "05/08/2018", "06/08/2018", "Just Primary Insurance");
            myPatients.Insurance_Case_Details_AutoAccident("05/08/2018","3532","Stone","02525252","Bucuresti");
            myPatients.Insurance_Is_Covered_By_Someone_else("Child", "Popescu", "Gigel", "Dan", "05/10/2000", "Male", "072065101", "Verii", "BZ", "5100", "Arizona");
            myPatients.Insurance_Prior_Authization("34535", "05/18/2018", "05/23/2019", "3", "TanaseION", "023425533");
            myPatients.AutoAccidentSave();
            extent.EndTest(test);
            extent.Flush();
        }

        [TestMethod]
        public void M06_Add_WorkersCompesation_Insurance()
        {
        //    LeftNavigation.PatientList.MyPatients.GoTo();
            MyPatientsPage myPatients = new MyPatientsPage();
            Driver.Wait(TimeSpan.FromSeconds(3));
            var test = myPatients.test = extent.StartTest("Workers Insurance", "Primaryfghfhf Insurance");
            myPatients.SearchPatient("yammy 1");
            Driver.Wait(TimeSpan.FromSeconds(3));
            myPatients.InsuranceTab();
            myPatients.Workers_Compesation_Insurance();
            Driver.Wait(TimeSpan.FromSeconds(1));
            myPatients.Insurance_Plan_Eligibility("05/08/2018", "5", "12.34%", "30", "40", "6", "7123", "05/08/2018", "06/08/2018", "Just Primary Insurance");
            myPatients.Insurance_Case_Details_WorkersCompesation("05/18/2018","234242","Flinstone","0234222","BZ","Omnisource","Parintele Galeriu","LIV Alex","Cotroceni");
            myPatients.Insurance_Prior_Authization("34535", "05/18/2018", "05/23/2019", "3", "TanaseION", "023425533");
            myPatients.WorkersComepnsationSave();
            extent.EndTest(test);
            extent.Flush();
        }
    }
}
