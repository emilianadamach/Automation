using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Selenium;


namespace UPAutomation.Pages
{
   
    public class MyPatientsPage
    {
      
        public MyPatientsPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
           
        }

        // Patient List button
        [FindsBy(How = How.CssSelector, Using = ".menu-level-1:nth-child(3)")]
        private IWebElement PatientListButton { get; set; }

        //My Patients button
        [FindsBy(How = How.PartialLinkText, Using = "My Patients")]
        private IWebElement MyPatientsButton { get; set; }

        //Navigation Search Bar
        [FindsBy(How = How.Id, Using = "navbar-patient-search")]
        private IWebElement NavigationBar { get; set; }

        //Patient selected from Search Bar
        [FindsBy(How = How.CssSelector, Using = "#upHeaderMenu > li.navbar-search-container > div > span.twitter-typeahead > span > div")]
        private IWebElement patientsearch { get; set; }
        //# upHeaderMenu > li.navbar-search-container > div > span.twitter-typeahead > span
        //*[@id='upHeaderMenu']/li[1]/div/span[2]/span/div
//# upHeaderMenu > li.navbar-search-container > div > span.twitter-typeahead > span > div
        //Chart button
        [FindsBy(How = How.CssSelector, Using = "#tableAppointments > tbody > tr.js-appointmentInfo.clickable > td.js-intakeActionsContainer > a")]
        private IWebElement Chart_button { get; set; }

        //Late button
        [FindsBy(How = How.CssSelector, Using = "#tableAppointments > tbody > tr.js-appointmentInfo.clickable > td.js-intakeActionsContainer > a.intake-arrive-status.js-intakeActionLate")]
        private IWebElement Late { get; set; }

        //On Time button
        [FindsBy(How = How.CssSelector, Using = "#tableAppointments > tbody > tr.js-appointmentInfo.clickable > td.js-intakeActionsContainer > a.intake-arrive-status.js-intakeActionOnTime")]
        private IWebElement On_Time { get; set; }

        #region Billing Info

        //Appointment Info Tab

        //First Patient of the Today Tab
        [FindsBy(How = How.CssSelector, Using = "#today-patientList a:first-child")]
        private IWebElement First_PatientOnToday { get; set; }

        //Return to Patient File
        [FindsBy(How = How.CssSelector, Using = "#js-intakeActionsContainer a:first-child")]
        private IWebElement First_Patient { get; set; }

        //click on Intake - BillingInfo
        [FindsBy(How = How.XPath, Using = "//*[@id='tableAppointments']/tbody/tr[2]/td[2]")]
        private IWebElement BillingInfo { get; set; }

        //Add CPT Line
        [FindsBy(How = How.Id, Using = "billingCPT_autocomplete")]
        private IWebElement Add_CPT_Line { get; set; }

//# appointmentbillinginfotab > div.billing_wrapper > div:nth-child(12) > div > div > span > span > div

        //Add CPT Line
        [FindsBy(How = How.CssSelector, Using = "#billingCPT_autocomplete pre:first-child")]
        private IWebElement Add_CPT_Linesa { get; set; }


        //Add CPT Line
        [FindsBy(How = How.CssSelector, Using = "#appointmentbillinginfotab > div.billing_wrapper > div:nth-child(13) > div > div > span > span")]
        private IWebElement Add_CPT_Lines { get; set; }
        //#appointmentbillinginfotab > div.billing_wrapper > div:nth-child(13) > div > div > span > span
//# appointmentbillinginfotab > div.billing_wrapper > div:nth-child(13) > div > div > span > span
        //Billing Save button
        [FindsBy(How = How.XPath, Using = "input[value='Save']")]
        private IWebElement Billing_Save { get; set; }
        #endregion

        #region Intake Body

        // Close and Print Chart
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div[5]/div[1]/ul/li[1]")]
        private IWebElement Sign_and_Print_Chart { get; set; }

        //Unlock Chart
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div[5]/div[1]/ul/li[2]")]
        private IWebElement Unlock_Chart { get; set; }

        //Return to Patient File
        [FindsBy(How = How.CssSelector, Using = "#container > div.crumbs.js-breadcrumbsContainer > div.js-pageActions > ul > li.option.js-returnToPatientFileAction")]
        private IWebElement Return_to_PatientFile { get; set; }

        //Vital Signs File
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-vitalSigns.js-editVitalSigns.cursor-pointer")]
        private IWebElement Vital_Signs_edit { get; set; }

        //Heart_Rate_BPM
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(2) > div:nth-child(1) > div > input.js-genericKnownInput.form-control")]
        private IWebElement Heart_Rate_BPM { get; set; }

        //Respiratory Rate BRPM
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(2) > div:nth-child(2) > div > input.js-genericKnownInput.form-control")]
        private IWebElement Respiratory_Rate_BRPM { get; set; }

        //Blood_Pressure_mm_Hg
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(2) > div:nth-child(3) > div > input.js-genericKnownInput.form-control")]
        private IWebElement Blood_Pressure_mm_Hg { get; set; }

        //Body_weights_lbs
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(3) > div:nth-child(1) > div > input.js-genericKnownInput.form-control")]
        private IWebElement Body_weights_lbs { get; set; }

        //Temperature-F
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(3) > div:nth-child(2) > div > input.js-genericKnownInput.form-control")]
        private IWebElement Temperature_F { get; set; }

        //Height
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(3) > div:nth-child(3) > div > input.js-genericKnownInput.form-control")]
        private IWebElement Height { get; set; }

        //Save
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }
    
        //Intake_Back
        [FindsBy(How = How.XPath, Using = "//input[@value='Back']")]
        private IWebElement Intake_Back { get; set; }

        //Intake_Cancel
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement Intake_Cancel { get; set; }

        //Chief Complaint
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-chiefComplaint.js-editChiefComplaint.cursor-pointer")]
        private IWebElement Chief_Complaint_edit { get; set; }

        //Chief Complaint 1
        [FindsBy(How = How.Name, Using = "[0].FreeText")]
        private IWebElement Chief_Complaint_1 { get; set; }

        //Chief Complaint 2
        [FindsBy(How = How.Name, Using = "[1].FreeText")]
        private IWebElement Chief_Complaint_2 { get; set; }

        //Chief Complaint 3
        [FindsBy(How = How.Name, Using = "[2].FreeText")]
        private IWebElement Chief_Complaint_3 { get; set; }

        //Chief Complaint 4
        [FindsBy(How = How.Name, Using = "[3].FreeText")]
        private IWebElement Chief_Complaint_4 { get; set; }

        //Subjective Edit
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-subjective.js-editSubjective.cursor-pointer")]
        private IWebElement Subjective_edit { get; set; }

        //Subjective Channel Edit
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-subjectiveChannel.js-editSubjectiveChannel.cursor-pointer")]
        private IWebElement Subjective_Channel_edit { get; set; }

        //Free Text(Subjective,Objective,Channel Palpation)
        [FindsBy(How = How.Id, Using = "FreeText")]
        private IWebElement FreeText { get; set; }

        //Objective Edit
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-objective.js-editObjective.cursor-pointer")]
        private IWebElement Objective_edit { get; set; }

        //Tongue Section
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-tongue.js-editTongue.cursor-pointer")]
        private IWebElement _Tongue { get; set; }

        //General Observations
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(2) > div:nth-child(1) > div > textarea")]
        private IWebElement General_Observations { get; set; }

        //Coating
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(2) > div:nth-child(2) > div > textarea")]
        private IWebElement Coating { get; set; }

        //Body Shape
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(2) > div:nth-child(3) > div > textarea")]
        private IWebElement Body_Shape { get; set; }

        //Coating Color
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(3) > div:nth-child(1) > div > textarea")]
        private IWebElement Coating_color { get; set; }

        //Body Color
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(3) > div:nth-child(2) > div > textarea")]
        private IWebElement Body_color { get; set; }

        //Sublingual
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(3) > div:nth-child(3) > div > textarea")]
        private IWebElement Sublingual { get; set; }

        //Pulse section
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-pulse.js-editPulse.cursor-pointer")]
        private IWebElement Pulse { get; set; }

        //General Pulse
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(2) > div > div > div > textarea")]
        private IWebElement General_Pulse { get; set; }

        //L Cun
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(3) > div:nth-child(1) > div > input.js-genericKnownInput.form-control")]
        private IWebElement L_Cun { get; set; }

        //L Guan
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(3) > div:nth-child(2) > div > input.js-genericKnownInput.form-control")]
        private IWebElement L_Guan { get; set; }

        //L Chi
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(3) > div:nth-child(3) > div > input.js-genericKnownInput.form-control")]
        private IWebElement L_Chi { get; set; }

        //R Cun
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(4) > div:nth-child(1) > div > input.js-genericKnownInput.form-control")]
        private IWebElement R_Cun { get; set; }

        //R Guan
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(4) > div:nth-child(2) > div > input.js-genericKnownInput.form-control")]
        private IWebElement R_Guan { get; set; }

        //R Chi
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-12.col-md-12.col-sm-12.col-xs-12.js-genericScreenFormForKnownInputsContainer > form > div:nth-child(4) > div:nth-child(3) > div > input.js-genericKnownInput.form-control")]
        private IWebElement R_Chi { get; set; }

        //Channel Palpation
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-channelPalpation.js-editChannelPalpation.cursor-pointer")]
        private IWebElement Channel_Palpation { get; set; }

        //Physical Exam
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-physicalExam.js-editPhysicalExam.cursor-pointer")]
        private IWebElement Physical_Exam { get; set; }

        //Assessment
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-assessment.js-editAssessment.cursor-pointer")]
        private IWebElement _Assessment { get; set; }

        //Acu RX
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-acuRx.js-editAcuRx.cursor-pointer")]
        private IWebElement Acu_Rx { get; set; }

        //Add new Set
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-5.col-md-5.col-sm-5.col-xs-5 > input.button.default.no-select.pull-right.js-addNewAcuRxSet")]
        private IWebElement Add_new_Set { get; set; }

        //Save order
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div > div > div.col-lg-5.col-md-5.col-sm-5.col-xs-5 > input.button.default.no-select.pull-right.js-saveOrderInSets")]
        private IWebElement Save_order { get; set; }

        //External Therapy
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-externalRx.js-editExternalRx.cursor-pointer")]
        private IWebElement External_Rx { get; set; }

        //Herbs Rx
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-herbsRx.js-editHerbsRx.cursor-pointer")]
        private IWebElement Herbs_Rx { get; set; }

        //Treatment Principle
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-treatmentPrinciple.js-editTreatmentPrinciple.cursor-pointer")]
        private IWebElement Treatment_Principle { get; set; }

        //Advice Rx
        [FindsBy(How = How.CssSelector, Using = "#intake-body > div.intake-section.js-adviceRx.js-editAdviceRx.cursor-pointer")]
        private IWebElement Advice_Rx { get; set; }
        #endregion

        #region Add Patient
        [FindsBy(How = How.CssSelector, Using = "#content > div.crumbs.js-breadcrumbsContainer > div.js-pageActions > ul > li")]
        private IWebElement Add_Patient { get; set; }

        // First Name
        [FindsBy(How = How.Id, Using = "FirstName")]
        private IWebElement FirstName { get; set; }

        //  Middle Name
        [FindsBy(How = How.Id, Using = "MiddleName")]
        private IWebElement MiddleName { get; set; }

        // Last Name
        [FindsBy(How = How.Id, Using = "LastName")]
        private IWebElement LastName { get; set; }

        // BirthDate
        [FindsBy(How = How.Name, Using = "BirthDate")]
        private IWebElement datepicker { get; set; }

        // Email Address
        [FindsBy(How = How.Id, Using = "EmailAddress")]
        private IWebElement EmailAddress { get; set; }

        // Gender 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Gender']")]
        private IWebElement Gender { get; set; }

        // Drop-down of Gender Types
        [FindsBy(How = How.XPath, Using = "//*[@id='addPatient']/div[2]/div[2]/div[4]/div/div/ul/li/a")]
        private IList<IWebElement> select_gender { get; set; }
   
        // Primary Phone
        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        private IWebElement PhoneNumber { get; set; }

        // Primary Phone Type 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='PhoneNumberTypeId']")]
        private IWebElement Phone_Type { get; set; }

        // Select Phone Type 
        [FindsBy(How = How.XPath, Using = "//*[@id='addPatient']/div[2]/div[2]/div[3]/div/div/ul/li/a")]
        private IList<IWebElement> select_Phone_type { get; set; }

        //Save
    //    [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
    //    private IWebElement Save { get; set; }
        #endregion

        #region Insurance Tab
        //Insurance
        [FindsBy(How = How.XPath, Using = "//a[@href='#insurance']")]
        private IWebElement Insurance { get; set; }

        //Secondary Insurance
        [FindsBy(How = How.XPath, Using = "//a[@href='#secondary_insurance']")]
        private IWebElement SecondaryInsurance { get; set; }

        //Auto Accident Insurance
        [FindsBy(How = How.XPath, Using = "//a[@href='#auto_accident']")]
        private IWebElement AutoAccidentInsurance { get; set; }

        //Workers Compesation Insurance
        [FindsBy(How = How.XPath, Using = "//a[@href='#worker_compensation']")]
        private IWebElement WorkersCompesation { get; set; }
//# auto_accident > div > div:nth-child(3) > div:nth-child(1) > div > div.col-xs-7 > div > button
        // Insurance Plan
        [FindsBy(How = How.CssSelector, Using = "div > div:nth-child(3) > div:nth-child(1) > div > div.col-xs-7 > div > button")]
        private IWebElement InsurancePlan { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#secondary_insurance > div > div:nth-child(3) > div:nth-child(1) > div > div.col-xs-7 > div > button")]
        private IWebElement InsurancePlan1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > div:nth-child(3) > div:nth-child(1) > div > div.col-xs-7 > div > div")]
        private IList<IWebElement> InsurancePlanList { get; set; }


        //div[contains(@class,'js-selectInsuranceCompany')]/button
        //Insurance PLan List
        [FindsBy(How = How.CssSelector, Using = "#secondary_insurance > div > div:nth-child(3) > div:nth-child(1) > div > div.col-xs-7 > div > div > ul > li > a")]
        private IList<IWebElement> InsurancePlanList1 { get; set; }
        //div[contains(@class,'js-selectInsuranceCompany')]/div//span
        //Copay
        [FindsBy(How = How.Id, Using = "EligibilityDetails_Copay")]
        private IWebElement Copay { get; set; }

        //Coinsurance
        [FindsBy(How = How.Id, Using = "EligibilityDetails_Coinsurance")]
        private IWebElement Coinsurance { get; set; }

        //Deductible Annual
        [FindsBy(How = How.Id, Using = "EligibilityDetails_DeductibleAnnual")]
        private IWebElement Deductible_Annual { get; set; }

        //Deductible Remaining
        [FindsBy(How = How.Id, Using = "EligibilityDetails_DeductibleRemaining")]
        private IWebElement Deductible_Remaining { get; set; }

        //Number Of Visits Per Year Or Duration
        [FindsBy(How = How.Id, Using = "EligibilityDetails_NoOfVisitsPerYearOrDuration")]
        private IWebElement NoOfVisitsPerYearOrDuration { get; set; }

        //Codes Covered
        [FindsBy(How = How.Id, Using = "EligibilityDetails_CodesCovered")]
        private IWebElement CodesCovered { get; set; }

        //EligibilityDetails Notes
        [FindsBy(How = How.Id, Using = "EligibilityDetails_Notes")]
        private IWebElement Notes { get; set; }

        // Card Information

        //Plan Name
        [FindsBy(How = How.Id, Using = "InsuranceCompanyName")]
        private IWebElement PlanName { get; set; }

        //Payer ID
        [FindsBy(How = How.Id, Using = "ElectronicPayerId")]
        private IWebElement PayerID { get; set; }

        //ID on Card
        [FindsBy(How = How.Id, Using = "InsuranceCardID")]
        private IWebElement ID_on_Card { get; set; }

        //Group #
        [FindsBy(How = How.Id, Using = "GroupNumber")]
        private IWebElement Group_number { get; set; }

        //Claim Address
        [FindsBy(How = How.Id, Using = "ClaimAddress")]
        private IWebElement ClaimAddress { get; set; }

        //City
        [FindsBy(How = How.Id, Using = "City")]
        private IWebElement City { get; set; }

        //Zip Code
        [FindsBy(How = How.Id, Using = "ZipCode")]
        private IWebElement ZipCode { get; set; }

        //State
        [FindsBy(How = How.XPath, Using = "//button[@data-id='State']")]
        private IWebElement State { get; set; }

        //State List
        [FindsBy(How = How.CssSelector, Using = "body > div.btn-group.bootstrap-select.dropup.open > div > ul > li > a")]
        private IList<IWebElement> StateList { get; set; }

        //Phone
        [FindsBy(How = How.Id, Using = "InsuranceProviderPhone")]
        private IWebElement InsuranceProviderPhone { get; set; }

        //Covered under someone else's insurance plan?
        [FindsBy(How = How.CssSelector, Using = "div > div:nth-child(15) > div > div.col-md-3.col-sm-3.col-xs-3 > div > div")]
        private IWebElement InsuranceIsCoveredByOther { get; set; }
        //*[@id="primary_insurance"]/div/div[9]/div/div[2]/div/div
        //Patient relationship to insured 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='InsuredInfo_PatientRelationtionshipToInsuredType']")]
        private IWebElement patient_relationship_to_insured { get; set; }
 //div > div:nth-child(1) > div:nth-child(1) > div.col-xs-7 > div > div > ul > li > a
        //Patient relationship to insured 
        [FindsBy(How = How.CssSelector, Using = "div > div:nth-child(1) > div:nth-child(1) > div.col-xs-7 > div > div > ul > li > a")]
        private IList<IWebElement> patient_relationship_to_insured_list { get; set; }
        //*[@id="primary_insurance"]/div/div[10]/div/div[1]/div[1]/div[2]/div/div/ul
        //Insured FirstName
        [FindsBy(How = How.Id, Using = "InsuredInfo_FirstName")]
        private IWebElement Insured_FirstName { get; set; }

        //Insured MiddleName
        [FindsBy(How = How.Id, Using = "InsuredInfo_MiddleName")]
        private IWebElement Insured_MiddleName { get; set; }

        //Insured LastName
        [FindsBy(How = How.Id, Using = "InsuredInfo_LastName")]
        private IWebElement Insured_LastName { get; set; }

        //Insured Gender
        [FindsBy(How = How.XPath, Using = "//button[@data-id='InsuredInfo_Gender']")]
        private IWebElement Insured_Gender { get; set; }

        //Insured Gender List
        [FindsBy(How = How.CssSelector, Using = "div > div:nth-child(1) > div:nth-child(6) > div.col-xs-7 > div > div > ul > li > a")]
        private IList<IWebElement> Insured_GenderList { get; set; }

        //Insured PhoneNumber
        [FindsBy(How = How.Id, Using = "InsuredInfo_PhoneNumber")]
        private IWebElement Insured_PhoneNumber { get; set; }

        //Insured Address
        [FindsBy(How = How.Id, Using = "InsuredInfo_Address")]
        private IWebElement Insured_Address { get; set; }

        //Insured City
        [FindsBy(How = How.Id, Using = "InsuredInfo_City")]
        private IWebElement Insured_City { get; set; }

        //Insured ZipCode
        [FindsBy(How = How.Id, Using = "InsuredInfo_ZipCode")]
        private IWebElement Insured_ZipCode { get; set; }

        //Insured Gender
        [FindsBy(How = How.CssSelector, Using = "#primary_insurance > div > div.js-otherInsured-1 > div > div:nth-child(2) > div:nth-child(5) > div.col-xs-7 > div > button")]
        private IWebElement Insured_State { get; set; }

        //Insured Gender List
        [FindsBy(How = How.CssSelector, Using = "body > div.btn-group.bootstrap-select.dropup.open > div > ul > li > a")]
        private IList<IWebElement> Insured_StateList { get; set; }

        //Prior Authorization
        [FindsBy(How = How.CssSelector, Using = "div > div:nth-child(17) > div > div.col-md-3.col-sm-3.col-xs-3 > div > div")]
        private IWebElement Prior_Authorization { get; set; }

        //Authorization Number
        [FindsBy(How = How.Id, Using = "PriorAuthorization")]
        private IWebElement Authorization_Number { get; set; }

        //Authorization Number of Visits
        [FindsBy(How = How.Id, Using = "AuthNoOfVists")]
        private IWebElement Authorization_Number_of_Visits { get; set; }

        //Authorization Contact Phone
        [FindsBy(How = How.Id, Using = "AuthContactName")]
        private IWebElement Authorization_ContactName { get; set; }

        //Authorization Contact Phone
        [FindsBy(How = How.Id, Using = "AuthContactPhone")]
        private IWebElement Authorization_ContactPhone { get; set; }

        // Case Details

        //Case/Claim Number Auto Accident 
        [FindsBy(How = How.Id, Using = "CaseClaimNo")]
        private IWebElement Case_Claim_Number_AutoAccident { get; set; }

        //Case/Claim Number Worker's Compesation
        [FindsBy(How = How.Id, Using = "CaseNo")]
        private IWebElement Case_Claim_Number_WorkersCompesation { get; set; }

        //Address to Submit Claims Auto Accident
        [FindsBy(How = How.Id, Using = "CaseManagerAddress")]
        private IWebElement Address_to_Submit_Claims_AutoAccident { get; set; }

        //Address to Submit Claims Worker's Compesation
        [FindsBy(How = How.Id, Using = "AddressToSubmitClaims")]
        private IWebElement Address_to_Submit_Claims_WorkersCompesation { get; set; }

        //Case Manager's Name
        [FindsBy(How = How.Id, Using = "CaseManagerName")]
        private IWebElement Case_ManagerName { get; set; }

        //Case Manager's Phone#
        [FindsBy(How = How.Id, Using = "CaseManagerPhone")]
        private IWebElement Case_Manager_Phone { get; set; }

        //Insurance Company Name
        [FindsBy(How = How.Id, Using = "InsName")]
        private IWebElement Insurance_Company_Name { get; set; }

        //Insurance Company Address
        [FindsBy(How = How.Id, Using = "InsAddress")]
        private IWebElement Insurance_Company_Address { get; set; }

        //Employer's Name
        [FindsBy(How = How.Id, Using = "EmpName")]
        private IWebElement Employers_Name { get; set; }

        //Employer's Address
        [FindsBy(How = How.Id, Using = "EmpAddress")]
        private IWebElement Employers_Address { get; set; }
        #endregion

        #region Personal Tab
        [FindsBy(How = How.XPath, Using = "//a[@href='#personal']")]
        private IWebElement PersonalTab { get; set; }

        //Personal Edit
        [FindsBy(How = How.CssSelector, Using = "#personal > a > i")]
        private IWebElement PersonalEdit { get; set; }

        //Personal First Name
        [FindsBy(How = How.Id, Using = "PersonalInformation_FirstName")]
        private IWebElement Personal_FirstName { get; set; }

        //Personal Middle Name
        [FindsBy(How = How.Id, Using = "PersonalInformation_MiddleName")]
        private IWebElement Personal_MiddleName { get; set; }

        //Personal Last Name
        [FindsBy(How = How.Id, Using = "PersonalInformation_LastName")]
        private IWebElement Personal_LastName { get; set; }

        // Personal Gender 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='PersonalInformation_Gender']")]
        private IWebElement Personal_Gender { get; set; }

        // List of Personal Gender Types
        [FindsBy(How = How.XPath, Using = "//*[@id='staffDetail']/form/div[3]/div[1]/div[1]/div/div/ul/li/a")]
        private IList<IWebElement> Personal_select_gender { get; set; }

        //Personal New Patient
        [FindsBy(How = How.Id, Using = "PatientIsExistingFalse")]
        private IWebElement NewPatient { get; set; }

        //Personal New Patient
        [FindsBy(How = How.Id, Using = "PatientIsExistingTrue")]
        private IWebElement ExistingPatient { get; set; }

        //Heard About Clinic
        [FindsBy(How = How.Id, Using = "ContactInformation_HeardAboutClinic")]
        private IWebElement Heard_About_Clinic { get; set; }

        //Occupation
        [FindsBy(How = How.Id, Using = "Demographic_Occupation")]
        private IWebElement Occupation { get; set; }

        //Employed 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Demographic_Employed']")]
        private IWebElement Employed { get; set; }

        //List of Employed Types
        [FindsBy(How = How.CssSelector, Using = "#staffDetail > form > div:nth-child(7) > div:nth-child(3) > div > div > ul > li > a")]
        private IList<IWebElement> select_employed { get; set; }

        //Marital Status  
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Demographic_MaritalStatus']")]
        private IWebElement MaritalStatus { get; set; }

        //List of Marital Status Types
        [FindsBy(How = How.XPath, Using = "//*[@id='staffDetail']/form/div[5]/div[4]/div/div/ul/li/a")]
        private IList<IWebElement> select_maritalStatus { get; set; }

        //Race 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Demographic_Race']")]
        private IWebElement Race { get; set; }

        //List of Race Types
        [FindsBy(How = How.XPath, Using = "//*[@id='staffDetail']/form/div[5]/div[5]/div/div/ul/li/a")]
        private IList<IWebElement> select_race { get; set; }

        //Ethnicity 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Demographic_Ethnicity']")]
        private IWebElement Ethnicity { get; set; }

        //List of Ethnicity Types
        [FindsBy(How = How.XPath, Using = "//*[@id='staffDetail']/form/div[5]/div[6]/div/div/ul/li/a")]
        private IList<IWebElement> select_ethnicity { get; set; }

        //Country 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='ContactInformation_CountryCode']")]
        private IWebElement Country { get; set; }

        //List of Country Types
        [FindsBy(How = How.XPath, Using = "//*[@id='staffDetail']/form/div[7]/div[1]/div/div/ul/li/a")]
        private IList<IWebElement> select_country { get; set; }

        //State 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='ContactInformation_CountryCode']")]
        private IWebElement Personal_State { get; set; }

        //List of State Types
        [FindsBy(How = How.XPath, Using = "//*[@id='staffDetail']/form/div[7]/div[1]/div/div/ul/li/a")]
        private IList<IWebElement> Personal_select_state { get; set; }

        //Personal Street Address
        [FindsBy(How = How.Id, Using = "ContactInformation_AddressLine1")]
        private IList<IWebElement> personal_street_address { get; set; }

        //Personal Street Address2
        [FindsBy(How = How.Id, Using = "ContactInformation_AddressLine2")]
        private IList<IWebElement> personal_street_address2 { get; set; }

        //Personal City
        [FindsBy(How = How.Id, Using = "ContactInformation_City")]
        private IList<IWebElement> personal_city { get; set; }

        //Personal ZipCode
        [FindsBy(How = How.Id, Using = "ContactInformation_ZipCode")]
        private IList<IWebElement> personal_Zipcode { get; set; }

        //Personal Primary Phone
        [FindsBy(How = How.Id, Using = "PhoneNumber1")]
        private IList<IWebElement> personal_primaryPhone { get; set; }

        // Primary Phone Type 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='ContactInformation_PhoneNumber1TypeId']")]
        private IWebElement Personal_primaryPhoneType { get; set; }

        //List of Primary Phone Types
        [FindsBy(How = How.XPath, Using = "//*[@id='staffDetail']/form/div[8]/div[6]/div/div/ul/li/a")]
        private IList<IWebElement> Personal_select_primaryPhoneType { get; set; }

        //Opt In Patient
        [FindsBy(How = How.CssSelector, Using = "#linkPatientOpt3 > label")]
        private IList<IWebElement> Opt_in_Patient { get; set; }

        //Opt In OK
        [FindsBy(How = How.CssSelector, Using = "body > div.bootbox.modal.fade.bootbox-confirm.in > div > div > div.modal-footer > button.btn.btn-primary")]
        private IList<IWebElement> Opt_in_OK { get; set; }

        //Personal Secondary Phone
        [FindsBy(How = How.Id, Using = "PhoneNumber2")]
        private IList<IWebElement> personal_secondaryPhone { get; set; }

        //Secondary Phone Type 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='ContactInformation_PhoneNumber2TypeId']")]
        private IWebElement Personal_secondaryPhoneType { get; set; }

        //List of Secondary Phone Types
        [FindsBy(How = How.XPath, Using = "//*[@id='staffDetail']/form/div[8]/div[9]/div/div/ul/li/a")]
        private IList<IWebElement> Personal_select_secondaryPhoneType { get; set; }

        //Personal Fax
        [FindsBy(How = How.Id, Using = "ContactInformation_FaxNumber1")]
        private IWebElement personal_fax { get; set; }

        //Personal Primary Email Address
        [FindsBy(How = How.Id, Using = "ContactInformation_EmailAddress1")]
        private IWebElement personal_primaryEmail { get; set; }

        //Personal Email Notification
        [FindsBy(How = How.Id, Using = "ContactInformation_ReceiveEmail")]
        private IWebElement personal_email_notification { get; set; }

        //Emergency Contact Name
        [FindsBy(How = How.Id, Using = "EmergencyContact_Name")]
        private IWebElement EmergencyContact_Name { get; set; }

        //Emergency Contact Email
        [FindsBy(How = How.Id, Using = "EmergencyContact_Email")]
        private IWebElement EmergencyContact_Email { get; set; }

        //Emergency Contact PhoneNumber
        [FindsBy(How = How.Id, Using = "EmergencyContact_PhoneNumber1")]
        private IWebElement EmergencyContact_PhoneNumber { get; set; }

        //Alternate Contact Phone
        [FindsBy(How = How.Id, Using = "EmergencyContact_PhoneNumber2")]
        private IWebElement Alternate_ContactPhone { get; set; }

        //Emergency Relationship Type 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='EmergencyContact_Relationship']")]
        private IWebElement Emergency_Relationship { get; set; }

        //List of Emergency Relationship Types
        [FindsBy(How = How.XPath, Using = "//*[@id='staffDetail']/form/div[10]/div[5]/div/div/ul/li/a")]
        private IList<IWebElement> select_emergency_relationship { get; set; }

        //Have you had acupuncture before?
        [FindsBy(How = How.Id, Using = "Medical_AdditionalInfo_HadAccupunctureBefore")]
        private IWebElement Acupuncture_before { get; set; }

        //Is there anything else you would like to mention?
        [FindsBy(How = How.Id, Using = "Medical_AdditionalInfo_Notes")]
        private IWebElement Personal_Notes { get; set; }

        //Have you had Chinise herbal medicine before?
        [FindsBy(How = How.Id, Using = "Medical_AdditionalInfo_HadChineseHerbalMedicineBefore")]
        private IWebElement Herbal_Medicine_before { get; set; }

        //Primary Physician Name
        [FindsBy(How = How.Id, Using = "PrimaryPhysician_Name")]
        private IWebElement Primary_Physician_Name { get; set; }

        //Primary Physician Phone
        [FindsBy(How = How.Id, Using = "PrimaryPhysician_Phone")]
        private IWebElement Primary_Physician_Phone { get; set; }

        //Primary Physician Specialty
        [FindsBy(How = How.Id, Using = "PrimaryPhysician_Specialty")]
        private IWebElement Primary_Physician_Specialty{ get; set; }

        //Primary Physician Current Treatment Plan
        [FindsBy(How = How.Id, Using = "PrimaryPhysician_CurrentTreatmentPlan")]
        private IWebElement Primary_Physician_Current_TreatmentPlan { get; set; }

        //Are you currently seeing an MD?
        [FindsBy(How = How.Id, Using = "Medical_CurrentTherapiesAndConditions_CurrentlySeeingMD")]
        private IWebElement Seeing_an_MD { get; set; }

        //What condition is your MD treating?
        [FindsBy(How = How.Id, Using = "Medical_CurrentTherapiesAndConditions_ConditionTreated")]
        private IWebElement Condition_Treated { get; set; }

        //Current therapy prescribed by your MD?
        [FindsBy(How = How.Id, Using = "Medical_CurrentTherapiesAndConditions_TherapyPrescribed")]
        private IWebElement Therapy_Prescribed { get; set; }

        //Primary Save button
        [FindsBy(How = How.CssSelector, Using = "#primary_insurance > div > input")]
        private IWebElement Primary_Save { get; set; }

        //Secondary Save button
        [FindsBy(How = How.CssSelector, Using = "#secondary_insurance > div > input.button.default.no-select.js-btnSave")]
        private IWebElement Secondary_Save { get; set; }

        //AutoAccident Save button
        [FindsBy(How = How.CssSelector, Using = "#auto_accident > div > input")]
        private IWebElement AutoAccident_Save { get; set; }

        //WorkersCompensation Save button
        [FindsBy(How = How.CssSelector, Using = "#worker_compensation > div > input")]
        private IWebElement WorkersCompensation_Save { get; set; }

        #endregion

        public ExtentTest test;
     
        public void GoTo()
        {
            SetMethods.Click(PatientListButton);
            SetMethods.Click(MyPatientsButton);
        }

        public void SearchPatient(string name)
        {
           // SetMethods.EnterText(NavigationBar, a.GetPatient());
            SetMethods.EnterText(NavigationBar, name);
            SetMethods.Click(patientsearch);
        }

        public void Patients_By_Date(string data)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('appointmentsDate').value='" + data + "'");
        }

        public void GetSelectedElement(string data)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('').value=' " + data + "'");
        }
        #region Billing Implementation
        public void Select_CPT_Lines(int selectorIndexNumber)
        {
            try
            {
                System.Threading.Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Time out");
            }
            SetMethods.Click(Add_CPT_Line);
            //SetMethods.Click(Add_CPT_Lines[selectorIndexNumber]);
        }

        public void BIlling(string cpt,string cpt2)
        {
            SetMethods.Click(BillingInfo);
            SetMethods.EnterText(Add_CPT_Line, cpt); //good
            Driver.Wait(TimeSpan.FromSeconds(2));
            SetMethods.Click(Add_CPT_Lines); //good

            SetMethods.EnterText(Add_CPT_Line, cpt2);
            Driver.Wait(TimeSpan.FromSeconds(2));
            SetMethods.Click(Add_CPT_Lines);
            Driver.Wait(TimeSpan.FromSeconds(2));

            //   SetMethods.Select_Value_from_List(Add_CPT_Line, Add_CPT_Lines, cpt);
            //      SetMethods.Select_Value_from_List(Add_CPT_Line, Add_CPT_Lines, cpt2);
            SetMethods.ScrollDown(Billing_Save);
            SetMethods.Click(Billing_Save);
        }

        public void Billing_Info_Save_CPT()
        {
            Driver.Wait(TimeSpan.FromSeconds(3));
            SetMethods.Click(BillingInfo);
              Select_CPT_Lines(1);
            //SetMethods.Click(Add_CPT_Line);
        //    SetMethods.SelectDropDown_ByIndex(Add_CPT_Line, 2);
          //   Select_CPT_Lines(2);
            SetMethods.Click(Billing_Save);
        }
        #endregion

        public void Click_Chart_Button()
        {
            SetMethods.Click(Chart_button);
        }

        public void Begin_Intake()
        {
            Driver.Wait(TimeSpan.FromSeconds(2));
            if (Chart_button.Text == "BEGIN INTAKE")
            {
                SetMethods.Click(Chart_button);
                SetMethods.Click(On_Time);
                Driver.Wait(TimeSpan.FromSeconds(3));
            }
            else if (Chart_button.Text == "CONTINUE INTAKE")
            {
                SetMethods.Click(Chart_button);
                Driver.Wait(TimeSpan.FromSeconds(2));
            }
            else if (Chart_button.Text == "VIEW CHART")
            {
                SetMethods.Click(Chart_button);
                Driver.Wait(TimeSpan.FromSeconds(2));
                SetMethods.Click(Unlock_Chart);
            }
        }
        public void Close_and_Sign_Chart()
        {
            Driver.Wait(TimeSpan.FromSeconds(2));
            if (Chart_button.Text == "BEGIN INTAKE")
            {
                SetMethods.Click(Chart_button);
                SetMethods.Click(On_Time);
                Driver.Wait(TimeSpan.FromSeconds(3));
                SetMethods.Click(Sign_and_Print_Chart);
                Driver.Wait(TimeSpan.FromSeconds(3));
                SetMethods.Click(Sign_and_Print_Chart);   
            }
            else if (Chart_button.Text == "CONTINUE INTAKE")
            {
                SetMethods.Click(Chart_button);
                Driver.Wait(TimeSpan.FromSeconds(2));
                SetMethods.Click(Sign_and_Print_Chart);
                Driver.Wait(TimeSpan.FromSeconds(2));
                SetMethods.Click(Sign_and_Print_Chart);
            }
            else if (Chart_button.Text == "VIEW CHART")
            {
                Driver.Wait(TimeSpan.FromSeconds(2));
                SetMethods.Click(Chart_button);
                Driver.Wait(TimeSpan.FromSeconds(2));
                SetMethods.Click(Sign_and_Print_Chart);
            }
        }

        public void First_Patient_On_Today()
        {
            SetMethods.Click(First_PatientOnToday);      
        }

        #region Intake Body Implementation

        public void SaveButton()
        {
          try{ SetMethods.Click(Save);
                test.Log(LogStatus.Pass, "Save button is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Save button is not clicked", e);}
        }

        public void BackButton()
        {
          try{ SetMethods.Click(Intake_Back);
                test.Log(LogStatus.Pass, "Back button is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Back button is not clicked", e);}
        }

        public void Add_Vital_Signs(string heart_Rate, string respiratory_Rate, string blood_Pressure, string body_weights, string temperature, string height)
        {
          try{ SetMethods.Click(Vital_Signs_edit);
                test.Log(LogStatus.Pass, "Vital Signs section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Vital Signs section is not clicked", e);}
          try{ SetMethods.EnterText(Heart_Rate_BPM, heart_Rate);
                test.Log(LogStatus.Pass, "Heart Rate BPM is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Heart Rate BPM is not added", e);}
          try{ SetMethods.EnterText(Respiratory_Rate_BRPM, respiratory_Rate);
                test.Log(LogStatus.Pass, "Respiratory Rate - BRPM is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Respiratory Rate - BRPM is not added", e);}
          try{ SetMethods.EnterText(Blood_Pressure_mm_Hg, blood_Pressure);
                test.Log(LogStatus.Pass, "Blood Pressure - mm Hg is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Blood Pressure - mm Hg is not added", e);}
          try{ SetMethods.EnterText(Body_weights_lbs, body_weights);
                test.Log(LogStatus.Pass, "Body Weight - lbs is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Body Weight - lbs is not added", e);}
          try{ SetMethods.EnterText(Temperature_F, temperature);
                test.Log(LogStatus.Pass, "Temperature - F is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Temperature - F is not added", e);}
           try{ SetMethods.EnterText(Height, height);
                test.Log(LogStatus.Pass, "Height is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Height is not added", e);}
            SaveButton();
            Driver.Wait(TimeSpan.FromSeconds(3));
            BackButton();
        }

        public void Add_Chief_Complaint(string CC1, string CC2, string CC3, string CC4)
        {
          try{ SetMethods.Click(Chief_Complaint_edit);
                test.Log(LogStatus.Pass, "Chief Complaint section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Chief Complaint section is not clicked", e);}
          try{ SetMethods.EnterText(Chief_Complaint_1, CC1);
                test.Log(LogStatus.Pass, "Chief Complaint 1 is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Chief Complaint 1 is not added", e);}
          try{ SetMethods.EnterText(Chief_Complaint_2, CC2);
                test.Log(LogStatus.Pass, "Chief Complaint 2 is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Chief Complaint 2 is not added", e);}
          try{ SetMethods.EnterText(Chief_Complaint_3, CC3);
                test.Log(LogStatus.Pass, "Chief Complaint 3 is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Chief Complaint 3 is not added", e);}
          try{ SetMethods.EnterText(Chief_Complaint_4, CC4);
                test.Log(LogStatus.Pass, "Chief Complaint 4 is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Chief Complaint 4 is not added", e);}
            SaveButton();
            Driver.Wait(TimeSpan.FromSeconds(2));
            BackButton();
        }

        public void Intake_FreeText(string name_1,string name_2,string name_3)
        {
            SetMethods.EnterText(FreeText,name_1);
            SaveButton();
            Driver.Wait(TimeSpan.FromSeconds(2));
            SetMethods.EnterText(FreeText,name_2);
             try{ SetMethods.Click(Intake_Cancel);
                test.Log(LogStatus.Pass, "Free Text is canceled");}
            catch(Exception e) {    test.Log(LogStatus.Fail, "Free Text is not canceled", e);}  
            Driver.Wait(TimeSpan.FromSeconds(2));
            SetMethods.EnterText(FreeText,name_3);
            SaveButton();
            Driver.Wait(TimeSpan.FromSeconds(2));
            BackButton();
        }

        public void Subjective(string name_1, string name_2, string name_3)
        {
          try { SetMethods.Click(Subjective_edit);
                test.Log(LogStatus.Pass, "Subjective Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Subjective Section is not clicked", e);}
            Intake_FreeText(name_1,name_2,name_3);
        }

         public void SubjectiveChannel(string name_1, string name_2, string name_3)
        {
          try { SetMethods.Click(Subjective_Channel_edit);
                test.Log(LogStatus.Pass, "Subjective Channel Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Subjective Channel Section is not clicked", e);}
            Intake_FreeText(name_1,name_2,name_3);
        }

        public void Objective(string name_1, string name_2, string name_3)
        {
            try { SetMethods.Click(Objective_edit);
                test.Log(LogStatus.Pass, "Objective Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Objective Section is not clicked", e);}
            Intake_FreeText(name_1, name_2,name_3);
        }

        public void Tongue(string generalObservations, string coating, string body_shape, string coating_color, string body_color, string sublingual)
        {
          try { SetMethods.Click(_Tongue);
                test.Log(LogStatus.Pass, "Tongue Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Tongue Section is not clicked", e);}
          try { SetMethods.EnterText(General_Observations, generalObservations);
                test.Log(LogStatus.Pass, "General Observations is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "General Observations is not added", e);}
          try { SetMethods.EnterText(Coating, coating);
                test.Log(LogStatus.Pass, "Coating is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Coating is not added", e);}
          try { SetMethods.EnterText(Body_Shape, body_shape);
                test.Log(LogStatus.Pass, "Body Shape is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Body Shape is not added", e);}
          try { SetMethods.EnterText(Coating_color, coating_color);
                test.Log(LogStatus.Pass, "Coating Color is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Coating Color is not added", e);}
          try { SetMethods.EnterText(Body_color, body_color);
                test.Log(LogStatus.Pass, "Body Color is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Body Color is not added", e);}
          try { SetMethods.EnterText(Sublingual, sublingual);
                test.Log(LogStatus.Pass, "Sublingual is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Sublingual is not added", e);}
            SaveButton();
            Driver.Wait(TimeSpan.FromSeconds(2));
            BackButton();

        }

        public void Add_Pulse(string generalPulse, string L_cun, string L_guan,string L_chi,string R_cun,string R_guan,string R_chi)
        {
            ScrollDown();
          try { SetMethods.Click(Pulse);
                test.Log(LogStatus.Pass, "Pulse Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Pulse Section is not clicked", e);}
          try { SetMethods.EnterText(General_Pulse, generalPulse);
                test.Log(LogStatus.Pass, "General Pulse is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "General Pulse is not added", e);}
          try { SetMethods.EnterText(L_Cun, L_cun);
                test.Log(LogStatus.Pass, "L Cun is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "L Cun is not added", e);}
          try { SetMethods.EnterText(L_Guan, L_guan);
                test.Log(LogStatus.Pass, "L Guan is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "L Guan is not added", e);}
          try { SetMethods.EnterText(L_Chi, L_chi);
                test.Log(LogStatus.Pass, "L Chi is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "L Chi is not added", e);}
          try { SetMethods.EnterText(R_Cun, R_cun);
                test.Log(LogStatus.Pass, "R Cun is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "R Cun is not added", e);}
          try { SetMethods.EnterText(R_Guan, R_guan);
                test.Log(LogStatus.Pass, "R Guan is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "R Guan is not added", e);}
          try { SetMethods.EnterText(R_Chi, R_chi);
                test.Log(LogStatus.Pass, "R Chi is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "R Chi is not added", e);}
            SaveButton();
            Driver.Wait(TimeSpan.FromSeconds(2));
            BackButton();
        }

        public void ChannelPalpation(string name_1, string name_2, string name_3)
        {
            Driver.Wait(TimeSpan.FromSeconds(3));
            ScrollDown();
          try { SetMethods.Click(Channel_Palpation);
                test.Log(LogStatus.Pass, "Channel Palpation Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Channel Palpation Section is not clicked", e);}
            Intake_FreeText(name_1, name_2, name_3);
        }

        public void PhysicalExam(string name_1, string name_2, string name_3)
        {
            Driver.Wait(TimeSpan.FromSeconds(3));
            ScrollDown();
          try { SetMethods.Click(Physical_Exam);
                test.Log(LogStatus.Pass, "Physical Exam Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Physical Exam Section is not clicked", e);}
            Intake_FreeText(name_1, name_2, name_3);
        }

        public void Assessment(string name_1, string name_2, string name_3)
        {
            Driver.Wait(TimeSpan.FromSeconds(3));
            ScrollDown();
          try { SetMethods.Click(_Assessment);
                test.Log(LogStatus.Pass, "Assessment Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Assessment Section is not clicked", e);}
            Intake_FreeText(name_1, name_2, name_3);
        }

        public void AcuRx(string name_1, string name_2, string name_3)
        {
            Driver.Wait(TimeSpan.FromSeconds(3));
            ScrollDown();
          try { SetMethods.Click(Acu_Rx);
                test.Log(LogStatus.Pass, "Acu Rx Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Acu Rx Section is not clicked", e);}
            Intake_FreeText(name_1, name_2, name_3);
        }

        public void ExternalRx(string name_1, string name_2, string name_3)
        {
            Driver.Wait(TimeSpan.FromSeconds(3));
            ScrollDown();
          try { SetMethods.Click(External_Rx);
                test.Log(LogStatus.Pass, "External Rx Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "External Rx Section is not clicked", e);}
            Intake_FreeText(name_1, name_2, name_3);
        }

        public void HerbsRx(string name_1, string name_2, string name_3)
        {
            Driver.Wait(TimeSpan.FromSeconds(3));
            ScrollDown();
          try { SetMethods.Click(Herbs_Rx);
                test.Log(LogStatus.Pass, "Herbs Rx Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Herbs Rx Section is not clicked", e);}
            Intake_FreeText(name_1, name_2, name_3);
        }

        public void TreatmentPrinciple(string name_1, string name_2, string name_3)
        {
            Driver.Wait(TimeSpan.FromSeconds(3));
            ScrollDown();
          try { SetMethods.Click(Treatment_Principle);
                test.Log(LogStatus.Pass, "Treatment Principle Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Treatment Principle Section is not clicked", e);}
            Intake_FreeText(name_1, name_2, name_3);
        }

        public void AdviceRx(string name_1, string name_2, string name_3)
        {
            Driver.Wait(TimeSpan.FromSeconds(3));
            ScrollDown();
          try { SetMethods.Click(Advice_Rx);
                test.Log(LogStatus.Pass, "Advice Rx Section is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Advice Rx Section is not clicked", e);}
            Intake_FreeText(name_1, name_2, name_3);
        }
        #endregion

        #region Scripts
        public void Patient_Birthdate(string data)
        {
           try {IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
                js.ExecuteScript("document.getElementById('BirthDate').value='" + data + "'");
                test.Log(LogStatus.Pass, "Patient BirthDate is selected"); }
           catch (Exception e) { test.Log(LogStatus.Fail, "Patient BirthDate is not selected", e); }
        }

        public void Personal_Patient_Birthdate(string data)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('PersonalInformation_BirthDate').value='" + data + "'");
        }

        public void Date_checked(string data)
        {
            try{IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
                js.ExecuteScript("document.getElementById('EligibilityDetails_DateChecked').value='" + data + "'");
                test.Log(LogStatus.Pass, "Date Checked is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Date Checked is not selected", e); }
        }

        public void Valid_From(string data)
        {
            try{IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('EligibilityDetails_ValidFrom').value='" + data + "'");
            test.Log(LogStatus.Pass, "Valid From is selected");}
            catch (Exception e) { test.Log(LogStatus.Fail, "Valid From is not selected", e); }
        }

        public void Valid_Until(string data)
        {
            try{IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('EligibilityDetails_ValidUntil').value='" + data + "'");
            test.Log(LogStatus.Pass, "Valid Until is selected");}
            catch (Exception e) { test.Log(LogStatus.Fail, "Valid Until is not selected", e); }
        }

        public void Insurance_Birthdate(string data)
        {
            try{IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('InsuredInfo_DateOfBirth').value='" + data + "'");
            test.Log(LogStatus.Pass, "Insured Date of Birth is selected");}
            catch (Exception e) { test.Log(LogStatus.Fail, "Insured Date of Birth is not selected", e); }
        }

        public void Effective_Start(string data)
        {
            try{IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('AuthStartDate').value='" + data + "'");
            test.Log(LogStatus.Pass, "Efective Start is selected");}
            catch (Exception e) { test.Log(LogStatus.Fail, "Efective Start is not selected", e); }
        }

        public void Effective_End(string data)
        {
            try{IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('AuthEndDate').value='" + data + "'");
            test.Log(LogStatus.Pass, "Efective End is selected");}
            catch (Exception e) { test.Log(LogStatus.Fail, "Efective End is not selected", e); }
        }

        public void Date_Of_Accident(string data)
        {
            try{IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('AccidentDate').value='" + data + "'");
                test.Log(LogStatus.Pass, "Date of Accident is selected");}
            catch (Exception e) { test.Log(LogStatus.Fail, "Date of Accident is not selected", e); }
        }

        public void Date_Of_Injury(string data)
        {
            try{IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript("document.getElementById('Date').value='" + data + "'");
            test.Log(LogStatus.Pass, "Date of Injury is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Date of Injury is not selected", e); }
        }

        public void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            Driver.Wait(TimeSpan.FromSeconds(1));
            js.ExecuteScript("window.scrollBy(0,750);");
            Driver.Wait(TimeSpan.FromSeconds(3));
        }
        public void ScrollTest()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            Driver.Wait(TimeSpan.FromSeconds(1));
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            Driver.Wait(TimeSpan.FromSeconds(3));
        }
        #endregion

        #region Add Patient Implementation
        public void AddPatientbutton()
        {
          try { SetMethods.Click(Add_Patient);
                test.Log(LogStatus.Pass, "Add Patient button is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Add Patient button is not clicked", e);}
        }
        public void AddPatient(string date, string number, string phonetype, string email, string gender)
        {
          try { SetMethods.RandomName(FirstName);
                test.Log(LogStatus.Pass, "Patient First Name is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Patient First Name is not added", e);}
          try { SetMethods.RandomName(MiddleName);
                test.Log(LogStatus.Pass, "Patient Middle Name is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Patient Middle Name is not added", e);}
          try { SetMethods.RandomName(LastName);
                test.Log(LogStatus.Pass, "Patient Last Name is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Patient Last Name is not added", e);}
            Patient_Birthdate(date);
          try { SetMethods.EnterText(PhoneNumber, number);
                test.Log(LogStatus.Pass, "Patient Phone Number is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Patient Phone Number is not added", e);}
          try { SetMethods.Select_Value_from_List(Phone_Type, select_Phone_type, phonetype);
                test.Log(LogStatus.Pass, "Patient Phone Type is selected");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Patient Phone Type is not selected", e);}
          try { SetMethods.EnterText(EmailAddress, email);
                test.Log(LogStatus.Pass, "Email is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Email is not added", e);}
          try { SetMethods.Select_Value_from_List(Gender, select_gender, gender);
                test.Log(LogStatus.Pass, "Gender is selected");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Gender is not selected", e);}
            SaveButton();
        }
        #endregion

        #region Insurance Implementation

        public void Secondary_Plan(string insuranceplan)
        {
            try { SetMethods.Select_Value_from_List(InsurancePlan1, InsurancePlanList1, insuranceplan);
                  test.Log(LogStatus.Pass, "Insurance Plan is selected");}
            catch(Exception e) {    test.Log(LogStatus.Fail, "Insurance Plan is not selected", e);}
        }




        public void InsuranceTab()
        {
          try { SetMethods.Click(Insurance);
                test.Log(LogStatus.Pass, "Insurance Tab is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insurance Tab is not clicked", e);}
        }

        public void Secondary_Insurance()
        {
          try { SetMethods.Click(SecondaryInsurance);
                test.Log(LogStatus.Pass, "Secondary Insurance is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Secondary Insurance is not clicked", e);}
        }

        public void Auto_Accident_Insurance()
        {
          try { SetMethods.Click(AutoAccidentInsurance);
                test.Log(LogStatus.Pass, "Auto Accident Insurance is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Auto Accident Insurance is not clicked", e);}
        }

        public void Workers_Compesation_Insurance()
        {
          try { SetMethods.Click(WorkersCompesation);
                test.Log(LogStatus.Pass, "Worker's Compensation Insurance is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Worker's Compensation Insurance is not clicked", e);}
        }
        public void PrimarySave()
        {
            SetMethods.Click(Primary_Save);
        }

        public void SecondarySave()
        {
            SetMethods.Click(Secondary_Save);
        }

        public void AutoAccidentSave()
        {
            SetMethods.Click(AutoAccident_Save);
        }

        public void WorkersComepnsationSave()
        {
            SetMethods.Click(WorkersCompensation_Save);
        }

        public void Insurance_Plan_Eligibility(string date_checked, string copay, string coinsurance, string deductible_annual, string deductible_remaining,
                                               string number_visits, string codes_covered, string valid_from, string valid_until, string notes)
        {
          //try { SetMethods.Select_Value_from_List(InsurancePlan, InsurancePlanList, insuranceplan);
          //      test.Log(LogStatus.Pass, "Insurance Plan is selected");}
          //catch(Exception e) {    test.Log(LogStatus.Fail, "Insurance Plan is not selected", e);}
            Date_checked(date_checked);
          try { SetMethods.EnterText(Copay, copay);
                test.Log(LogStatus.Pass, "Copay is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Copay is not added", e);}
          try { SetMethods.EnterText(Coinsurance, coinsurance);
                test.Log(LogStatus.Pass, "Coinsurance % is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Coinsurance % is not added", e);}
          try { SetMethods.EnterText(Deductible_Annual, deductible_annual);
                test.Log(LogStatus.Pass, "Deductible Annual is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Deductible Annual is not added", e);}
          try { SetMethods.EnterText(Deductible_Remaining, deductible_remaining);
                test.Log(LogStatus.Pass, "Deductible Remaining is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Deductible Remaining is not added", e);}
          try { SetMethods.EnterText(NoOfVisitsPerYearOrDuration, number_visits);
                test.Log(LogStatus.Pass, "No. of Visits is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "No. of Visits is not added", e);}
          try { SetMethods.EnterText(CodesCovered, codes_covered);
                test.Log(LogStatus.Pass, "Codes Covered is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Codes Covered is not added", e);}
            Valid_From(valid_from);
            Valid_Until(valid_until);
          try { SetMethods.EnterText(Notes, notes);
                test.Log(LogStatus.Pass, "Notes is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Notes is not added", e);}
            ScrollDown();
        }

        public void Insurance_Card_Information(string planName, string payer_id, string id_on_card, string group_number, string claim_address,
                                               string city, string zipcode, string state, string insurance_phone)
        {
          try { SetMethods.EnterText(PlanName, planName);
               test.Log(LogStatus.Pass, "Plan Name is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Plan Name is not added", e);}
          try { SetMethods.EnterText(PayerID, payer_id);
                test.Log(LogStatus.Pass, "Payer ID is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Payer ID is not added", e);}
          try { SetMethods.EnterText(ID_on_Card, id_on_card);
                test.Log(LogStatus.Pass, "ID on Card is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "ID on Card is not added", e);}
          try { SetMethods.EnterText(Group_number, group_number);
                test.Log(LogStatus.Pass, "Group # is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Group # is not added", e);}
          try {  SetMethods.EnterText(ClaimAddress, claim_address);
                test.Log(LogStatus.Pass, "Claim Address is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Claim Address is not added", e);}
          try {  SetMethods.EnterText(City, city);
                test.Log(LogStatus.Pass, "City is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "City is not added", e);}
          try { SetMethods.EnterText(ZipCode, zipcode);
                test.Log(LogStatus.Pass, "Zip Code is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Zip Code is not added", e);}
          try { SetMethods.Select_Value_from_List(State, StateList, state);
                test.Log(LogStatus.Pass, "State is selected");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "State is not selected", e);}
            ScrollDown();
          try { SetMethods.EnterText(InsuranceProviderPhone, insurance_phone);
                test.Log(LogStatus.Pass, "Phone is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Phone is not added", e);}
       
        }
         
        public void Insurance_Case_Details_AutoAccident(string date_of_accident, string case_number, string manager_name, string phone, string address_to_submit_claim)
        {
            ScrollDown();
            Date_Of_Accident(date_of_accident);
          try { SetMethods.EnterText(Case_Claim_Number_AutoAccident, case_number);
                test.Log(LogStatus.Pass, "Case/Claim # is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Case/Claim # is not added", e);}
          try { SetMethods.EnterText(Address_to_Submit_Claims_AutoAccident, address_to_submit_claim);
                test.Log(LogStatus.Pass, "Address to submit claims is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Address to submit claims is not added", e);}
          try { SetMethods.EnterText(Case_ManagerName, manager_name);
                test.Log(LogStatus.Pass, "Case Manager's Name is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Case Manager's Name is not added", e);}
          try { SetMethods.EnterText(Case_Manager_Phone, phone);
                test.Log(LogStatus.Pass, "Case Manager's Phone # is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Case Manager's Phone # is not added", e);}
            ScrollDown();
        }

        public void Insurance_Case_Details_WorkersCompesation(string date_of_Injury, string case_number, string manager_name, string phone, string address_to_submit_claim,
                                                              string insurance_companyName, string insurance_companyaddress, string employersName, string employersaddress)
        {
            ScrollDown();
            Date_Of_Injury(date_of_Injury);
          try { SetMethods.EnterText(Case_Claim_Number_WorkersCompesation, case_number);
                test.Log(LogStatus.Pass, "Case/Claim # is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Case/Claim # is not added", e);}
          try { SetMethods.EnterText(Case_ManagerName, manager_name);
                test.Log(LogStatus.Pass, "Case Manager's Name is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Case Manager's Name is not added", e);}
          try { SetMethods.EnterText(Case_Manager_Phone, phone);
                test.Log(LogStatus.Pass, "Case Manager's Phone # is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Case Manager's Phone # is not added", e);}
          try { SetMethods.EnterText(Address_to_Submit_Claims_WorkersCompesation, address_to_submit_claim);
                test.Log(LogStatus.Pass, "Address to submit claims is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Address to submit claims is not added", e);}
          try { SetMethods.EnterText(Insurance_Company_Name, insurance_companyName);
                test.Log(LogStatus.Pass, "Insurance Company Name is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insurance Company Name is not added", e);}
          try { SetMethods.EnterText(Insurance_Company_Address, insurance_companyaddress);
                test.Log(LogStatus.Pass, "Insurance Company Address is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insurance Company Address is not added", e);}
          try { SetMethods.EnterText(Employers_Name, employersName);
                test.Log(LogStatus.Pass, "Employer's Name is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Employer's Name is not added", e);}
          try { SetMethods.EnterText(Employers_Address, employersaddress);
                test.Log(LogStatus.Pass, "Employer's Address is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Employer's Address is not added", e);}
            ScrollDown();
        }

        public void Insurance_Is_Covered_By_Someone_else(string relationship, string insured_firstName, string insured_middleName, string insured_lastName, string insured_birthdate, string insured_gender,
                                                         string insured_Phonenumber, string insured_address, string insured_city, string insured_zipCode, string insured_state)
        {
            SetMethods.ScrollDown(InsuranceIsCoveredByOther);
            //string Css = InsuranceIsCoveredByOther.GetCssValue("data-val");
         //   if (Css == "false") { 
              try { SetMethods.Click(InsuranceIsCoveredByOther);
                    test.Log(LogStatus.Pass, "Covered under someone else's insurance plan? slider is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Covered under someone else's insurance plan? slider is not clicked", e);}//}
            ScrollDown();
          try {SetMethods.Select_Value_from_List(patient_relationship_to_insured, patient_relationship_to_insured_list, relationship);
               test.Log(LogStatus.Pass, "Patient relationship to insured is selected");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Patient relationship to insured is not selected", e);}
          try {SetMethods.EnterText(Insured_FirstName, insured_firstName);
                test.Log(LogStatus.Pass, "Insured FirstName is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insured FirstName is not added", e);}
          try {SetMethods.EnterText(Insured_MiddleName, insured_middleName);
                test.Log(LogStatus.Pass, "Insured MiddleName is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insured MiddleName is not added", e);}
          try {SetMethods.EnterText(Insured_LastName, insured_lastName);
                test.Log(LogStatus.Pass, "Insured LastName is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insured LastName is not added", e);}  
            Insurance_Birthdate(insured_birthdate);
          try {SetMethods.Select_Value_from_List(Insured_Gender, Insured_GenderList, insured_gender);
                test.Log(LogStatus.Pass, "Insured Gender is selected");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insured Gender is not selected", e);}  
          try {SetMethods.EnterText(Insured_PhoneNumber, insured_Phonenumber);
                test.Log(LogStatus.Pass, "Insured Phone Number is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insured Phone Number is not added", e);}  
          try {SetMethods.EnterText(Insured_Address, insured_address);
                test.Log(LogStatus.Pass, "Insured Address is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insured Address is not added", e);}
          try {SetMethods.EnterText(Insured_City, insured_city);
                test.Log(LogStatus.Pass, "Insured City is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insured City is not added", e);}
          try {SetMethods.EnterText(Insured_ZipCode, insured_zipCode);
                test.Log(LogStatus.Pass, "Insured ZipCode is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insured Zipcode is not added", e);}
          try {SetMethods.Select_Value_from_List(Insured_State, Insured_StateList, insured_state);
                test.Log(LogStatus.Pass, "Insured State is selected");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Insured State is not selected", e);}
            ScrollDown();
        }

        public void Insurance_Prior_Authization(string authorization_number, string effective_start, string effective_end, string authorization_number_of_visits,
                                                string authorization_ContactName, string authorization_ContactPhone)
        {
          
            SetMethods.ScrollDown(Prior_Authorization);
            //string Css = Prior_Authorization.GetCssValue("data-val");
            //if (Css == "false"){
             try {SetMethods.Click(Prior_Authorization);
               test.Log(LogStatus.Pass, "Prior Authorization slider is clicked");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Prior Authorization slider is not clicked", e);}//}
            SetMethods.ScrollDown(Authorization_Number);
          try {SetMethods.EnterText(Authorization_Number, authorization_number);
               test.Log(LogStatus.Pass, "Authorization # is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Authorization # is not added", e);}
            Effective_Start(effective_start);
            Effective_End(effective_end);
          try {SetMethods.EnterText(Authorization_Number_of_Visits, authorization_number_of_visits);
               test.Log(LogStatus.Pass, "Authorization # of visits is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Authorization # of visits is not added", e);}
            SetMethods.ScrollDown(Authorization_ContactName);
            try {SetMethods.EnterText(Authorization_ContactName, authorization_ContactName);
               test.Log(LogStatus.Pass, "Authorization Contact Name is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Authorization Contact Name is not added", e);}
            SetMethods.ScrollDown(Authorization_ContactPhone);
            try {SetMethods.EnterText(Authorization_ContactPhone, authorization_ContactPhone);
               test.Log(LogStatus.Pass, "Authorization Contact Phone is added");}
          catch(Exception e) {    test.Log(LogStatus.Fail, "Authorization Contact Phone is not added", e);}         
            SetMethods.ScrollDown(Primary_Save);
        }
        #endregion
    }
}