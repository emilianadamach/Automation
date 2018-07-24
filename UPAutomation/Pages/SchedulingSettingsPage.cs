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
   public class SchedulingSettingsPage
    {
        public SchedulingSettingsPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        // Clinic Settings button
        [FindsBy(How = How.XPath, Using ="//ul[@id='nav']/li[4]")]
        private IWebElement clinicSettingsButton { get; set; }

        //Scheduling Settings button
        [FindsBy(How = How.XPath, Using ="//*[@id='nav']/li[4]/ul/li[7]/a")]
        private IWebElement SchedulingSettingsButton { get; set; }

        // Location
        [FindsBy(How = How.XPath, Using = "//*[@id='onlineBookingForm']/div[1]/div/div[1]/div[2]/div/button")]
        private IWebElement locatioN { get; set; }

        //Locations Dropdown
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div:nth-child(11) > div > div.row > div.col-lg-5.col-sm-12.col-md-6 > div > div> ul > li > a")]
        private IList<IWebElement> set_location { get; set; }

        //Patient Type
        [FindsBy(How = How.XPath, Using = "//*[@id='onlineBookingForm']/div[2]/div/div[1]/div[2]/div/button/span")]
        private IWebElement Patient_typ { get; set; }
        
        //New Patient from Dropdown 
        [FindsBy(How = How.XPath, Using = "//*[@id='onlineBookingForm']/div[2]/div/div[1]/div[2]/div/div/ul/li[1]/a")]
        private IWebElement New_Patient { get; set; }

        //Service
        [FindsBy(How = How.CssSelector, Using = "#service > div:nth-child(1) > div.col-lg-5.col-sm-12.col-md-6 > div > button")]
        private IWebElement service { get; set; }

        //Service Dropdown 
        [FindsBy(How = How.CssSelector, Using = "#service > div:nth-child(1) > div.col-lg-5.col-sm-12.col-md-6 > div > div> ul > li > a")]
        private IList<IWebElement> set_Service { get; set; }

        //Practitioner
        [FindsBy(How = How.CssSelector, Using = "#practitioner > div > div.col-lg-5.col-sm-12.col-md-6 > div > button")]
        private IWebElement practitioner { get; set; }

        //Practitioner Dropdown 
        [FindsBy(How = How.CssSelector, Using = "#practitioner > div > div.col-lg-5.col-sm-12.col-md-6 > div > div > ul > li > a")]
        private IList<IWebElement> set_Practitioner { get; set; }

        //Reason for Visit 
        [FindsBy(How = How.Id, Using = "NewAppointment_Reason")]
        private IWebElement reason_visit { get; set; }

        //Patient Name 
        [FindsBy(How = How.Id, Using = "NewAppointment_PersonalInformation_FirstName")]
        private IWebElement Patient_firstName { get; set; }

        //Middle Name 
        [FindsBy(How = How.Id, Using = "NewAppointment_PersonalInformation_MiddleName")]
        private IWebElement Patient_middleName { get; set; }

        //Last Name 
        [FindsBy(How = How.Id, Using = "NewAppointment_PersonalInformation_LastName")]
        private IWebElement Patient_LastName { get; set; }

        // Email Address
        [FindsBy(How = How.Id, Using = "NewAppointment_ContactInformation_EmailAddress1")]
        private IWebElement EmailAddress { get; set; }

        // Primary Phone
        [FindsBy(How = How.Id, Using = "NewAppointment_ContactInformation_PhoneNumber1")]
        private IWebElement PrimaryPhone { get; set; }

        // Primary Phone Type 
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div:nth-child(12) > div > div.row.js-ContactSection > div:nth-child(3) > div > button")]
        private IWebElement Primary_Phone_Type { get; set; }

        // Drop-down of Primary Phone Types
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div:nth-child(12) > div > div.row.js-ContactSection > div:nth-child(3) > div > div > ul > li > a")]
        private IList<IWebElement> select_Primary_Phone_Type { get; set; }

        // Secondary Phone 
        [FindsBy(How = How.Id, Using = "NewAppointment_ContactInformation_PhoneNumber2")]
        private IWebElement SecondaryPhone { get; set; }

        // Secondary Phone Type
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div:nth-child(12) > div > div.row.js-ContactSection > div:nth-child(5) > div > button")]
        private IWebElement Secondary_Phone_Type { get; set; }

        // Drop-down of Secondary Phone Types
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div:nth-child(12) > div > div.row.js-ContactSection > div:nth-child(5) > div > div > ul > li > a")]
        private IList<IWebElement> select_Secondary_Phone_Type { get; set; }

        // Gender 
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div:nth-child(12) > div > div.newPatient > div:nth-child(2) > div.col-lg-5.col-sm-12.col-md-6 > div > button")]
        private IWebElement Gender { get; set; }
        
        // Gender Drop-down
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div:nth-child(12) > div > div.newPatient > div:nth-child(2) > div.col-lg-5.col-sm-12.col-md-6 > div > div > ul > li > a")]
        private IList<IWebElement> select_gender { get; set; }

        // How did you hear about us?  
        [FindsBy(How = How.Id, Using = "NewAppointment_HowDidYouHearAboutUs")]
        private IWebElement How_did_you_hear_about_us { get; set; }

        // Insurance Verification
        [FindsBy(How = How.Id, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.row > div.col-lg-5.col-sm-12.col-md-6 > div > button")]
        private IWebElement insurance_verification { get; set; }

        // Insurance dropdown
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.row > div.col-lg-5.col-sm-12.col-md-6 > div > div")]
        private IList<IWebElement> Set_insurance_verification { get; set; }

        // Name of Insurance
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_InsuranceCompanyName")]
        private IWebElement Name_of_insurance { get; set; }

        //Plan Type
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_PlanType")]
        private IWebElement Plan_type { get; set; }

        // Insurance Card ID
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_InsuranceCardID")]
        private IWebElement Insurance_card_id { get; set; }

        // Group Number
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_GroupNumber")]
        private IWebElement group_number { get; set; }

        // Insurance Provider Phone Number
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_InsuranceProviderPhone")]
        private IWebElement insurance_provider_phone_number { get; set; }

        // Claim Address
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_ClaimAddress")]
        private IWebElement claim_address { get; set; }

        // City
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_City")]
        private IWebElement City { get; set; }

        // Zip Code
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_ZipCode")]
        private IWebElement Zip_code { get; set; }

        // State
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.insuranceVerify > div:nth-child(9) > div.col-lg-5.col-sm-12.col-md-3 > div > button")]
        private IWebElement State { get; set; }

        // State dropdown
        [FindsBy(How = How.CssSelector, Using = "body > div.btn-group.bootstrap-select.open > div > ul > li > a ")]
        private IList<IWebElement> Set_State { get; set; }

        // Covered under someone else's insurance plan?
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.insuranceVerify > div:nth-child(10) > div.col-lg-5.col-sm-12.col-md-6 > div > button")]
        private IWebElement someone_else_insurance_plan { get; set; }

        // Covered under someone else's insurance plan? dropdown
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.insuranceVerify > div:nth-child(10) > div.col-lg-5.col-sm-12.col-md-6 > div > div > ul > li > a ")]
        private IList<IWebElement> Set_someone_else_insurance_plan { get; set; }

        // Patient relationship to insured
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.insuranceVerify > div.insuranceOther > div:nth-child(1) > div.col-lg-5.col-sm-12.col-md-6 > div > button")]
        private IWebElement patient_relatioship_to_insured { get; set; }

        // Patient relationship to insured dropdown
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.insuranceVerify > div.insuranceOther > div:nth-child(1) > div.col-lg-5.col-sm-12.col-md-6 > div > div > ul > li > a ")]
        private IList<IWebElement> Set_patient_relatioship_to_insured { get; set; }

        // First Name of Insured Party
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_InsuredInfo_FirstName")]
        private IWebElement First_Name_of_Insured_Party { get; set; }

        // Middle Name of Insured Party
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_InsuredInfo_MiddleName")]
        private IWebElement Middle_Name_of_Insured_Party { get; set; }

        // Last Name of Insured Party
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_PrimaryInsurance_InsuredInfo_LastName")]
        private IWebElement Last_Name_of_Insured_Party { get; set; }

        // Auto Accident?
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.insuranceVerify > div:nth-child(12) > div.col-lg-5.col-sm-12.col-md-6 > div > button")]
        private IWebElement auto_accident { get; set; }

        // Auto Accident? dropdown
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.insuranceVerify > div:nth-child(12) > div.col-lg-5.col-sm-12.col-md-6 > div > div > ul > li > a ")]
        private IList<IWebElement> Set_auto_accident { get; set; }

        // Case/Claim #
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_AutoAccidentInsurance_CaseClaimNo")]
        private IWebElement Case_Claim_number_autoAccident { get; set; }

        // Case Manager's Name
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_AutoAccidentInsurance_CaseManagerName")]
        private IWebElement Case_Managers_Name { get; set; }

        // Case Manager's Phone #
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_AutoAccidentInsurance_CaseManagerPhone")]
        private IWebElement Case_Managers_Phone { get; set; }

        // Address to submit claims
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_AutoAccidentInsurance_CaseManagerAddress")]
        private IWebElement Address_to_submit_claims { get; set; }

        // Employment Accident?
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.insuranceVerify > div:nth-child(14) > div.col-lg-5.col-sm-12.col-md-6 > div > button")]
        private IWebElement employment_accident { get; set; }

        // Employment Accident? dropdown
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div.row.patientTypeNew > div > div.insurance > div.insuranceVerify > div:nth-child(14) > div.col-lg-5.col-sm-12.col-md-6 > div > div > ul > li > a ")]
        private IList<IWebElement> Set_employment_accident { get; set; }

        // Case/Claim # Employment
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_WorkersCompensationInsurance_CaseNo")]
        private IWebElement Case_Claim_number_EmploymentAccident { get; set; }

        // Employer's Name
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_WorkersCompensationInsurance_EmpName")]
        private IWebElement Employers_name { get; set; }

        // Employer's Address
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_WorkersCompensationInsurance_EmpAddress")]
        private IWebElement Employers_address { get; set; }

        // Insurance Company name
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_WorkersCompensationInsurance_InsName")]
        private IWebElement Insurance_company_name { get; set; }

        // Insurance Company phone
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_WorkersCompensationInsurance_InsPhone")]
        private IWebElement Insurance_company_phone { get; set; }

        // Insurance Company address
        [FindsBy(How = How.Id, Using = "NewAppointment_PatientInsuranceVerification_WorkersCompensationInsurance_InsAddress")]
        private IWebElement Insurance_company_address { get; set; }

        // I Have read and accept the Terms of Use and Privary Policy
        [FindsBy(How = How.ClassName, Using = "iCheck-helper")]
        private IWebElement Terms_of_use { get; set; }

        // Book Appointment
        [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div:nth-child(17) > p > input")]
        private IWebElement Book_appointment { get; set; }

        public void GoTo()
        {
            SetMethods.Click(clinicSettingsButton);
            Driver.Wait(TimeSpan.FromSeconds(1));
            SetMethods.Click(SchedulingSettingsButton);
        }

        public void Set_location(string location )
        {   
            SetMethods.Select_Value_from_List(locatioN, set_location, location);
        }

        public void Set_new_patient()
        {
            SetMethods.Click(Patient_typ);
            SetMethods.Click(New_Patient);
        }

        public void Set_Practitioner(string Practitioner)
        {
            SetMethods.Select_Value_from_List(practitioner, set_Practitioner, Practitioner);
        }

        public void Set_Service_Type(string Service)
        {
            SetMethods.Select_Value_from_List(service, set_Service, Service);
        }

        public void SelectGender(string gender)
        {
            SetMethods.Select_Value_from_List(Gender, select_gender, gender);
        }

        public void Select_Primary_Phone_Type(string PrimaryPhoneType)
        {
            SetMethods.Select_Value_from_List(Primary_Phone_Type, select_Primary_Phone_Type, PrimaryPhoneType);
        }

        public void Select_Second_Phone_Type(string SecondaryPhoneType )
        {
            SetMethods.Select_Value_from_List(Secondary_Phone_Type, select_Secondary_Phone_Type, SecondaryPhoneType);
        }

        public void Patient_Birthdate(string data)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('NewAppointment_PersonalInformation_BirthDate').value='" + data + "'");
        }

        public void Insured_Party_Date_of_Birth(string data)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('NewAppointment_PatientInsuranceVerification_PrimaryInsurance_InsuredInfo_DateOfBirth').value='" + data + "'");
        }

        public void Date_of_Accident(string data)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('NewAppointment_PatientInsuranceVerification_AutoAccidentInsurance_AccidentDate').value='" + data + "'");
        }

        public void Date_of_Injury(string data)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('NewAppointment_PatientInsuranceVerification_WorkersCompensationInsurance_Date').value='" + data + "'");
        }


        public void DateTimeSlot(string time)
        {
            // Aug 27, 2017
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
          //  js.ExecuteScript("document.getElementByClass('tsdays defaultWeek').data-date='" + data + "'");
            IList<IWebElement> raws = Driver.Instance.FindElements(By.CssSelector("col-lg-8 col-lg-offset-2 col-md-12 col-sm-12 col-xs-12 upform timeslots"));
            foreach (IWebElement raw in raws)
            {
                raw.FindElements(By.ClassName("col-lg-10 col-sm-10 col-md-10 wkdayslots"));
                IWebElement test = raw.FindElement(By.ClassName("ts"));
                js.ExecuteScript("document.getElementByClass('ts).data-time='" + time + "'.click();");
            }
        }
   

 // Insurance Company phone
 [FindsBy(How = How.CssSelector, Using = "#onlineBookingForm > div:nth-child(13) > div > div:nth-child(8) > div > div.col-lg-10.col-sm-10.col-md-10.wkdayslots > div:first-child > button")]
        private IWebElement first { get; set; }
        //# onlineBookingForm > div:nth-child(13) > div > div:nth-child(8) > div > div.col-lg-10.col-sm-10.col-md-10.wkdayslots > div:first-child > button
//# onlineBookingForm > div:nth-child(13) > div > div:nth-child(9) > div > div.col-lg-10.col-sm-10.col-md-10.wkdayslots > div:nth-child(1) > button
        public void OnlineBooking(string cc)
        {
           Driver.Instance.Navigate().GoToUrl("https://ehr.unifiedpractice.com/Public/OnlineBooking?ClinicUid=ce76b58b-dcbf-40ed-b912-ec9bc7cd0a59");
           Set_location("BearMaskAcupuncture");
         //  Set_new_patient();
           Set_Service_Type("Acupuncture");
         //  Set_Practitioner(ActivePractitioners.Collete_Zinna);
          // SetMethods.EnterText(reason_visit, "HeadAche");
        //   SetMethods.RandomName(Patient_firstName);
        //   SetMethods.RandomName(Patient_middleName);
        //   SetMethods.RandomName(Patient_LastName);
        //    Driver.Wait(TimeSpan.FromSeconds(3));
        //    Patient_Birthdate("05/20/1992");
        //    Driver.Wait(TimeSpan.FromSeconds(3));
       //     SetMethods.EnterText(EmailAddress, "emilian.adamache@omnisourcetech.com");
       //     Driver.Wait(TimeSpan.FromSeconds(3));
//SetMethods.EnterText(PrimaryPhone, "0720600610");
      //      Driver.Wait(TimeSpan.FromSeconds(3));
       //     Select_Primary_Phone_Type(SetMethods.Enumarations.PrimaryPhone.Home);
        //    Driver.Wait(TimeSpan.FromSeconds(3));
         //   SetMethods.EnterText(SecondaryPhone, "2");
       //     Driver.Wait(TimeSpan.FromSeconds(3));
          //  Select_Second_Phone_Type(SetMethods.Enumarations.SecondaryPhone.Cell);
        //    Driver.Wait(TimeSpan.FromSeconds(3));
         //   SelectGender(SetMethods.Enumarations.Gender.Male);
            Driver.Wait(TimeSpan.FromSeconds(3));
             DateTimeSlot("18:00:00");
            //SetMethods.Click(first);
            Driver.Wait(TimeSpan.FromSeconds(3));
        }
    }
}


