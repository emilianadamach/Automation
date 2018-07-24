using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Selenium;


namespace UPAutomation
{
    public class MyCalendarPage
    {
        public MyCalendarPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        //Navigation

        // Calendar Button
        [FindsBy(How = How.CssSelector, Using = ".menu-level-1:nth-child(2)")]
        private IWebElement calendarButton { get; set; }

        //My Calendar Button
        [FindsBy(How = How.PartialLinkText, Using = "My Calendar")]
        private IWebElement myCalendarButton { get; set; }

        // Clinic Calendar Button
        [FindsBy(How = How.PartialLinkText, Using = "Clinic Calendar")]
        private IWebElement clinicCalendarButton { get; set; }

        //Add Appointment Modal

        // Add Appointment Button
        [FindsBy(How = How.Id, Using = "addPatientAppointmentBtn")]
        private IWebElement addAppointmentButton { get; set; }

        // Create New Patient Link from Appointment  
        [FindsBy(How = How.Id, Using = "a1")]
        private IWebElement createNewPatientLink { get; set; }

        // Select Existing Patient 
        [FindsBy(How = How.ClassName, Using = "pull-left")]
        private IWebElement selectExistingPatient { get; set; }

        // Existing Patient Search
        [FindsBy(How = How.ClassName, Using = "js-patientSearch")]
        private IWebElement Existing_Patient_Search { get; set; }

        // Existing Patient Search First Result
        [FindsBy(How = How.CssSelector, Using = "#existingPatientTab > div.upform-tab-container > div > div > div > div > div > div:nth-child(1) > div.patients-wrap > div:nth-child(1)")]
        private IWebElement Existing_Patient_Search_First_Result { get; set; }

        // Existing Patient Search First Result Name
        [FindsBy(How = How.XPath, Using = "//h3[@data-bind='text: fullName']")]
        //patients-wrap(working in progress)
        private IWebElement existingPatientSearchFirstResultName { get; set; }


        #region Create a new Patient 
        //Create new patient in Calendar

        // First Name
        [FindsBy(How = How.Id, Using = "Patient_FirstName")]
        private IWebElement FirstName { get; set; }

        //  Middle Name
        [FindsBy(How = How.Id, Using = "Patient_MiddleName")]
        private IWebElement MiddleName { get; set; }

        // Last Name
        [FindsBy(How = How.Id, Using = "Patient_LastName")]
        private IWebElement LastName { get; set; }

        // BirthDate
        [FindsBy(How = How.Name, Using = "Patient.BirthDate")]
        private IWebElement datepicker { get; set; }

        // Email Address
        [FindsBy(How = How.Id, Using = "Patient_EmailAddress")]
        private IWebElement EmailAddress { get; set; }

        // Gender 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Patient_Gender']")]
        private IWebElement Gender { get; set; }

        // Gender List
        [FindsBy(How = How.XPath, Using = "//*[@id='newPatientContainer']/div[1]/div[2]/div[3]/div/div/ul/li/a")]
        private IList<IWebElement> genderlist { get; set; }

        // Primary Phone
        [FindsBy(How = How.Id, Using = "Patient_PrimaryPhoneNumber")]
        private IWebElement PrimaryPhone { get; set; }

        // Primary Phone Type 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Patient_PrimaryPhoneNumberTypeId']")]
        private IWebElement Primary_Phone_Type { get; set; }

        //  Primary Phone Types List
        [FindsBy(How = How.XPath, Using = "//*[@id='newPatientContainer']/div[1]/div[2]/div[4]/div/div/ul/li/a")]
        private IList<IWebElement> PrimaryPhoneTypeList { get; set; }

        // Secondary Phone 
        [FindsBy(How = How.Id, Using = "Patient_SecondaryPhoneNumber")]
        private IWebElement SecondaryPhone { get; set; }

        // Secondary Phone Type
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Patient_SecondaryPhoneNumberTypeId']")]
        private IWebElement Secondary_Phone_Type { get; set; }

        // Secondary Phone Types List
        [FindsBy(How = How.XPath, Using = "//*[@id='newPatientContainer']/div[1]/div[2]/div[5]/div/div/ul/li/a")]
        private IList<IWebElement> SecondaryPhoneTypeList { get; set; }

        // New Patient Radio button ( working on path later)
        [FindsBy(How = How.Id, Using = "PatientIsExistingFalse")]
        private IWebElement newpatient_radio { get; set; }

        // Recurring Patient Radio button (working on path later)
        [FindsBy(How = How.Name, Using = "Patient.IsExisting")]
        private IWebElement recurringpatient_radio { get; set; }

        #endregion

        // Text Patient reminders and other helpfull updates 
        [FindsBy(How = How.XPath, Using = "//*[@id='newPatientContainer']/div[2]/div/div/div/ins")]
        private IWebElement TextPatient_checkbox { get; set; }

        // Text Patient Ok Pop-up   ( working on path later) 
        [FindsBy(How = How.XPath, Using = "//html/body/div[20]/div/div/div[2]/button[2]")]
        private IWebElement TextPatient_OK { get; set; }

        // Continue button 
        [FindsBy(How = How.XPath, Using = "//input[@value='Continue']")]
        private IWebElement Continue_button { get; set; }

        [FindsBy(How = How.ClassName, Using = "bootstrap-timepicker-widget")]
        private IWebElement timePickerWidget { get; set; }

        #region Appointment Details

        // Complaints
        [FindsBy(How = How.Id, Using = "Appointment_Complaint")]
        private IWebElement appointmentComplaint { get; set; }

        // Clinic Notes
        [FindsBy(How = How.Id, Using = "Appointment_PractitionerNotes")]
        private IWebElement practitionerNotes { get; set; }

        //Appointment Type 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Appointment_AppointmentInfoTypeId']")]
        private IWebElement AppointmentType { get; set; }

        // Appointment Type List
        [FindsBy(How = How.XPath, Using = "//*[@id='appointmentData']/div[3]/div[4]/div[2]/div/div/ul/li/a")]
        private IList<IWebElement> AppointmentTypeList { get; set; }

        //Appointment Details

        //Appointment Date 
        [FindsBy(How = How.Name, Using = "Appointment.StartDateDay")]
        private IWebElement Appointment_Date { get; set; }

        //Appointment Time
        [FindsBy(How = How.XPath, Using = "//*[@id='appointmentData']/div[3]/div[5]/div/div[2]/div/input[1]")]
        private IWebElement Appointment_Time { get; set; }

        //Location
        [FindsBy(How = How.CssSelector, Using = "#res-edit > div:nth-child(1) > div > div > div > div > button")]
        private IWebElement Location { get; set; }

        //Location List
        [FindsBy(How = How.CssSelector, Using = "#res-edit > div:nth-child(1) > div > div > div > div > div > ul > li > a")]
        private IList<IWebElement> LocationList { get; set; }

        //Service Type
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'js-selectService')]/button")]
        private IWebElement ServiceType { get; set; }
        //*[@id="res-edit"]/div[2]/div/div/div/div/button
        //Service Type List
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'js-selectService')]/div//span")]
        private IList<IWebElement> ServiceTypeList { get; set; }

        //Room
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'js-selectRoom')]/button")]
        private IWebElement Room { get; set; }

        //Room List
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'js-selectRoom')]/div//span")]
        private IList<IWebElement> RoomList { get; set; }

        // Save Button
        [FindsBy(How = How.Id, Using = "addAppConfirm")]
        private IWebElement SaveButton { get; set; }

        //Appointment Errors Found! I know, Continue with selection 
        [FindsBy(How = How.XPath, Using = "//*[@id='cmtPopupFooter']/input[2]")]
        private IWebElement continue_with_selection { get; set; }

        #endregion

        // Location timeoff List
        [FindsBy(How = How.CssSelector, Using = "body > div.btn-group.bootstrap-select.show-tick.open > div > ul > li > a")]
        private IList<IWebElement> LocationbooktimeoffList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='appointmentData']/div[3]/div[6]/div/div[2]/div/input[1]")]
        private IWebElement addAppointmentTimeAmount { get; set; }

        //Edit Appointment Modal
        [FindsBy(How = How.XPath, Using = "//td[@data-bind = \"attr: { id: $parent.slotId() + '_' + $data.Id }\"]")]
        private IList<IWebElement> calendarTimeRows { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@data-bind='text: 'Book appointment on : ' + calendarCellClickDateFormated()']")]
        private IWebElement popUpBookAppointment { get; set; }
        [FindsBy(How = How.XPath, Using = "//td[@id='slot_60_0']")]
        private IWebElement appointment3Pm;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'3:00 PM')]")]
        private IWebElement popUpappointment3Pm { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#dropDownMenu > li:nth-child(1) > a > span")]
        private IWebElement popupTime { get; set; }

        //Book timeoff Modal

        #region Book Timeoff

        //Book TimeOff Button
        [FindsBy(How = How.Id, Using = "addPersonalAppointmentBtn")]
        private IWebElement book_TimeOff_Button { get; set; }

        //Title
        [FindsBy(How = How.Id, Using = "Appointment_Title")]
        private IWebElement title_timeoff { get; set; }

        //Details
        [FindsBy(How = How.Id, Using = "Appointment_Details")]
        private IWebElement details_timeoff { get; set; }

        //All Day checkbox
        [FindsBy(How = How.ClassName, Using = "grey")]
        private IWebElement All_Day_checkbox { get; set; }

        //Repeat checkbox
        [FindsBy(How = How.CssSelector, Using = "#personalAppointmentData > div.newAppointmentControls > div:nth-child(6) > div:nth-child(2) > div > div > div > div")]
        private IWebElement Repeat_checkbox { get; set; }

        //Repeats 
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Appointment_RepeatModel_RepeatsValue']")]
        private IWebElement RepeatsValue { get; set; }

        //Repeats list
        [FindsBy(How = How.CssSelector, Using = "body > div.btn-group.bootstrap-select.open > div > ul > li > a")]
        private IList<IWebElement> RepeatsList { get; set; }

        //Repeat every
        [FindsBy(How = How.XPath, Using = "//button[@data-id='Appointment_RepeatModel_RepeatEvery']")]
        private IWebElement Repeatevery { get; set; }

        //Repeats every list
        [FindsBy(How = How.CssSelector, Using = "body > div.btn-group.bootstrap-select.dropup.open > div > ul > li > a")]
        private IList<IWebElement> RepeateveryList { get; set; }

        //Repeat_on_Sunday checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='0']")]
        private IWebElement Sunday { get; set; }

        //Repeat_on_Monday checkbox
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), ' Mon')]")]
        private IWebElement Monday { get; set; }

        //Repeat_on_Tuesday checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='2']")]
        private IWebElement Tuesday { get; set; }

        //Repeat_on_Wednesday checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='3']")]
        private IWebElement Wednesday { get; set; }

        //Repeat_on_Thrisday checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='4']")]
        private IWebElement Thrusday { get; set; }

        //Repeat_on_Friday checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='5']")]
        private IWebElement Friday { get; set; }

        //Repeat_on_Saturday  checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='6']")]
        private IWebElement Saturday { get; set; }

        //Number of Occuresces
        [FindsBy(How = How.Id, Using = "Appointment_RepeatModel_EndsAfterOccurences")]
        private IWebElement Number_Occuresces { get; set; }

        //Number of Occuresces
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), ' On date')]")]
        private IWebElement On_Date { get; set; }

        #endregion

        //Repeat 
        [FindsBy(How = How.XPath, Using = "//div[@data-toggle-selector='.RepeatEvent']")]
        private IWebElement RepeatEvent { get; set; }

        //On Date radiobutton My Calendar
        [FindsBy(How = How.XPath, Using = "//*[@id='personalAppointmentData']/div[2]/div[7]/div/div/div/div[1]/label[2]")]
        private IWebElement On_Date_MyCalendar { get; set; }


        //*[@id="radioButtonEnd"]
        //On Date radiobutton Clinic Calendar
        [FindsBy(How = How.XPath, Using = "//*[@id='personalAppointmentData']/div[2]/div[8]/div/div/div/div[1]/label[2]")]
        private IWebElement On_Date_ClinicCalendar { get; set; }

        //Remove Button
        [FindsBy(How = How.ClassName, Using = "js-removeTimeOff")]
        private IWebElement Remove_button { get; set; }

        //Remove timeoff Button
        [FindsBy(How = How.CssSelector, Using = "body > div.bootbox.modal.fade.in > div > div > div.modal-footer > button")]
        private IWebElement Remove_timeoff { get; set; }

        //Remove All timeoff in the series Button
        [FindsBy(How = How.CssSelector, Using = "body > div.bootbox.modal.fade.in > div > div > div.modal-footer > button:nth-child(2)")]
        private IWebElement Remove_alltimeoff_in_the_series { get; set; }

        //Remove All timeoff in the series Button foward
        [FindsBy(How = How.CssSelector, Using = "body > div.bootbox.modal.fade.in > div > div > div.modal-footer > button:nth-child(3)")]
        private IWebElement Remove_alltimeoff_in_the_series_foward { get; set; }

        //Calendar Date time picker
        [FindsBy(How = How.CssSelector, Using = "#calendar-filter > li.option.no-brd > form > div.date-picker.pull-left.clearfix > input")]
        private IWebElement Calendar_datetime_picker { get; set; }

        //Calendar Weekly
        [FindsBy(How = How.XPath, Using = "//input[@value='Weekly']")]
        private IWebElement Weekly { get; set; }

        //input[@value='6']"
        ///   "calendar-button-selected"
        //The title of timeoff 
        [FindsBy(How = How.XPath, Using = "//span[@data-bind='text: Title']")]
        private IWebElement event_title_timeoff { get; set; }

        [FindsBy(How = How.ClassName, Using = "calendar-event-details")]
        private IWebElement appointment_title { get; set; }
        //#app_6102 > div.calendar-event-details > div.medicalProblem.content-blur > span
        [FindsBy(How = How.CssSelector, Using = "#appointmentData > div.upform-header > div:nth-child(4) > div.col-md-4.col-sm-4.col-xs-12 > div > a")]
        private IWebElement Cancel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.bootbox.modal.fade.in > div > div > div.modal-footer > button:nth-child(1)")]
        private IWebElement CancelAppointment { get; set; }

        //# app_1550639 > div.calendar-event-header.content-blur-color > div:nth-child(1) > span

        //# //app_1563652 > div.calendar-event-header.content-blur-color > div:nth-child(2) > span
        //span[contains(@class,'title')][contains(text(),'Administration'
        //*[@id="app_1563649"]/div[1]/div[2]/span
        [FindsBy(How = How.CssSelector, Using = "div.calendar-event-header.content-blur-color > div:nth-child(1) > span")]
        private IWebElement Appt_TILE { get; set; }



        //      patientName content-blur pull-left
        //      text: Patient? Patient.InversedFullName : ''
        //Calendar Weekly
        [FindsBy(How = How.CssSelector, Using = "//div[@class='patientName content-blur pull-left']/span[@data-bind='text: Title']")]
        private IList<IWebElement> Calendarcontainer { get; set; }



        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='0']")]
        private IList<IWebElement> RawCalendar { get; set; }



        //THE GOOD ONE     "//div[@class='patientName content-blur pull-left']/span[@data-bind='text: Title']"
        //span[contains(@class,'title')]  [contains(text(),'Administration')]
        // span[contains(data - bind = 'text: Title')]
        //   "//div[@class='patientName content-blur pull-left']/span[@data-bind='text: Title']"
        //# app_1220132
        //D
        //    [FindsBy(How = How.CssSelector, Using = "#res-edit > div:nth-child(16) > div:nth-child(1) > div > div > div > div > div > label")]
        //       private IWebElement Reoccur { get; set; }


        public ExtentTest test;
        Random r;

        public void GoTo()
        {
            SetMethods.Click(calendarButton);
            SetMethods.Click(myCalendarButton);
        }

        public void AddAppointmentButton()
        {
            try { SetMethods.Click(addAppointmentButton);
                test.Log(LogStatus.Pass, "Add Appointment button is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Add Appointment button is not clicked", e); }
        }

        public void Book_TimeOff_Button()
        {
            try { SetMethods.Click(book_TimeOff_Button);
                test.Log(LogStatus.Pass, "Book Timeoff button is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Book Timeoff button is not clicked", e); }
        }

        #region Create NewPatient Implementation

        public void NewPatient()
        {
            try { SetMethods.Click(createNewPatientLink);
                test.Log(LogStatus.Pass, "Create a New Patient is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Create a New Patient is not clicked", e); }
        }

        public void PatientFirstName()
        {
            try { SetMethods.RandomName(FirstName);
                test.Log(LogStatus.Pass, "Patient First Name is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Patient First Name is not added", e); }
        }

        public void PatientMiddleName()
        {
            try { SetMethods.RandomName(MiddleName);
                test.Log(LogStatus.Pass, "Patient Middle Name is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Patient Middle Name is not added", e); }
        }

        public void PatientLastName()
        {
            try { SetMethods.RandomName(LastName);
                test.Log(LogStatus.Pass, "Patient Last Name is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Patient Last Name is not added", e); }
        }

        public void PatientEmail(string email)
        {
            try { SetMethods.EnterText(EmailAddress, email);
                test.Log(LogStatus.Pass, "Email is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Email is not added", e); }
        }

        public void PatientPrimaryPhone(string primaryphone)
        {
            try { SetMethods.EnterText(PrimaryPhone, primaryphone);
                test.Log(LogStatus.Pass, "Primary Phone is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Primary Phone is not added", e); }
        }

        public void PatientPrimaryPhoneType(string primaryPhoneType)
        {
            try { SetMethods.Select_Value_from_List(Primary_Phone_Type, PrimaryPhoneTypeList, primaryPhoneType);
                test.Log(LogStatus.Pass, "Primary Phone Type is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Primary Phone Type is not selected", e); }
        }

        public void PatientGender(string gender)
        {
            try { SetMethods.Select_Value_from_List(Gender, genderlist, gender);
                test.Log(LogStatus.Pass, "Gender is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Gender is not selected", e); }
        }

        public void PatientSecondaryPhone(string secondaryphone)
        {
            try { SetMethods.EnterText(SecondaryPhone, secondaryphone);
                test.Log(LogStatus.Pass, "Secondary Phone is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Secondary Phone is not added", e); }
        }

        public void PatientSecondaryPhoneType(string SecondaryPhoneType)
        {
            try { SetMethods.Select_Value_from_List(Secondary_Phone_Type, SecondaryPhoneTypeList, SecondaryPhoneType);
                test.Log(LogStatus.Pass, "Secondary Phone Type is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Secondary Phone Type is not selected", e); }
        }

        public void PatientContinue()
        {
            try { SetMethods.Click(Continue_button);
                test.Log(LogStatus.Pass, "Continue button is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Continue button is not clicked", e); }
        }

        #endregion

        public void CreateNewPatient(string birthdate, string email, string primaryPhone, string PrimaryPhoneType, string gender, string secondaryPhone, string SecondaryPhoneType)
        {
            NewPatient();
            SetMethods.RandomName(FirstName);
            SetMethods.RandomName(MiddleName);
            SetMethods.RandomName(LastName);
            Patient_Birthdate(birthdate);
            PatientEmail(email);
            PatientPrimaryPhone(primaryPhone);
            PatientPrimaryPhoneType(PrimaryPhoneType);
            PatientGender(gender);
            PatientSecondaryPhone(secondaryPhone);
            PatientSecondaryPhoneType(SecondaryPhoneType);
            PatientContinue();
        }

        #region Appointment Details Implementation

        public void Appointment_Complaint(string Complaint)
        {
            try { SetMethods.EnterText(appointmentComplaint, Complaint);
                test.Log(LogStatus.Pass, "Appointment Complaints is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Appointment Complaints is not added", e); }
        }

        public void Appointment_PractitionerNotes(string PractitionerNotes)
        {
            try { SetMethods.EnterText(practitionerNotes, PractitionerNotes);
                test.Log(LogStatus.Pass, "Appointment Practitioner Notes is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Appointment Practitioner Notes is not added", e); }
        }

        public void Appointment_Type(string appointmentType)
        {
            try { SetMethods.Select_Value_from_List(AppointmentType, AppointmentTypeList, appointmentType);
                test.Log(LogStatus.Pass, "Appointment Type is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Appointment Type is not selected", e); }
        }

        public void Appointment_Location(string location)
        {
            try { SetMethods.Select_Value_from_List(Location, LocationList, location);
                test.Log(LogStatus.Pass, "Appointment Location is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Appointment Location is not selected", e); }
        }

        public void Appointment_Service(string service)
        {
            try { SetMethods.Select_Value_from_List(ServiceType, ServiceTypeList, service);
                test.Log(LogStatus.Pass, "Appointment Service is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Appointment Service is not selected", e); }
        }

        public void Appointment_Room(string room)
        {
            try { SetMethods.Select_Value_from_List(Room, RoomList, room);
                test.Log(LogStatus.Pass, "Appointment Room is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Appointment Room is not selected", e); }
        }

        public void Appointment_Save()
        {
            try { SetMethods.Click(SaveButton);
                test.Log(LogStatus.Pass, "Appointment Save is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Appointment Save is not clicked", e); }
            Driver.Wait(TimeSpan.FromSeconds(5));
            if (continue_with_selection.Displayed)
            {
                try { SetMethods.Click(continue_with_selection);
                    test.Log(LogStatus.Pass, "Continue button is clicked"); }
                catch (Exception e) { test.Log(LogStatus.Fail, "Continue button is not clicked", e); }
                Driver.Wait(TimeSpan.FromSeconds(2));
            }
        }

        //First Patient result from Search Bar
        public void FirstPatientfromList()
        {
            SetMethods.Click(existingPatientSearchFirstResultName);
        }

        //Select existing patient 
        public void Search_Existing_Patient(string existingPatient)
        {
            SetMethods.EnterText(Existing_Patient_Search, existingPatient);
            Driver.Wait(TimeSpan.FromSeconds(2));
            FirstPatientfromList();
        }

        public void Confirm_Appointment(string Complaint, string Notes, string Appt_Type, string location, string serviceType, string room)
        {
            Appointment_Complaint(Complaint);
            Appointment_PractitionerNotes(Notes);
            Appointment_Type(Appt_Type);
            Appointment_Location(location);
            Appointment_Service(serviceType);
            Appointment_Room(room);
            Appointment_Save();
        }

        #endregion

        #region Scripts 

        //Scripts
        public void Patient_Birthdate(string data)
        {
            try { IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
                js.ExecuteScript("document.getElementById('Patient_BirthDate').value='" + data + "'");
                test.Log(LogStatus.Pass, "Patient Birthdate is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Patient Birthdate is not selected", e); }
        }

        public void Appointment_Date_and_Time(string data, string time)
        {
            try { IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
                js.ExecuteScript("document.getElementById('startDateDay').value='" + data + "'");
                js.ExecuteScript("document.getElementById('startDateTime').value='" + time + "'");
                test.Log(LogStatus.Pass, "Appointment Date & Time is selected");}
            catch (Exception e) { test.Log(LogStatus.Fail, "Appointment Date & Time is not selected", e); }
        }
    

        public void Timeoff_StartDate_and_Time(string data, string time, string duration)
        {
            try{   IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
                js.ExecuteScript("document.getElementById('Appointment_StartDateDay').value='" + data + "'");
                js.ExecuteScript("document.getElementById('Appointment_StartDateTime').value='" + time + "'");
                js.ExecuteScript("document.getElementById('Appointment_Duration').value='" + duration + "'");
                test.Log(LogStatus.Pass, "Timeoff StartDate & Time is selected");}
            catch (Exception e) { test.Log(LogStatus.Fail, "Timeoff StartDate & Time is not selected", e); }
        }

        public void Recurring_EndDate(string End_date)
        {
            try { EndsOnDate();
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
                js.ExecuteScript("document.getElementById('Appointment_RepeatModel_EndsOnDate').value='" + End_date + "'");
                test.Log(LogStatus.Pass, "Recurring End Date is selected"); }
           catch (Exception e) { test.Log(LogStatus.Fail, "Recurring End Date is not selected", e); }
        }

        #endregion

        #region Book Timeoff Implementation

        public void Timeofftitle(string title)
        {
           try { SetMethods.EnterText(title_timeoff, title);
                test.Log(LogStatus.Pass, "Timeoff Title is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Timeoff Title is not added", e); }
        }

        public void TimeoffDetails(string details)
        {
            try { SetMethods.EnterText(details_timeoff, details);
                test.Log(LogStatus.Pass, "Timeoff Details is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Timeoff Details is not added", e); }
        }

        public void TimeoffLocation(string location)
        {
             try { SetMethods.Select_Value_from_List(Location, LocationbooktimeoffList, location);
                test.Log(LogStatus.Pass, "Timeoff Location is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Timeoff Location is not selected", e); }
        }

        public void TimeoffRepeatAllDay()
        {
            try { SetMethods.Click(All_Day_checkbox);
                test.Log(LogStatus.Pass, "Timeoff Repeat All Day is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Timeoff Repeat All Day is not clicked", e); }
        }

        public void TimeoffRepeat()
        {
            try { SetMethods.Click(Repeat_checkbox);
                test.Log(LogStatus.Pass, "Timeoff Repeat is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Timeoff Repeat is not clicked", e); }
        }

        public void Mark_Sunday()
        {
            try {  SetMethods.Click(Sunday);
                test.Log(LogStatus.Pass, "Sunday is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Sunday is not clicked", e); }
        }

        public void Mark_Monday()
        {
            try {  SetMethods.Click(Monday);
                test.Log(LogStatus.Pass, "Monday is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Monday is not clicked", e); }
        }

        public void Mark_Tuesday()
        {
            try {  SetMethods.Click(Tuesday);
                test.Log(LogStatus.Pass, "Tuesday is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Tuesday is not clicked", e); }
        }

        public void Mark_Wednesday()
        {
            try {  SetMethods.Click(Wednesday);
                test.Log(LogStatus.Pass, "Wednesday is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Wednesday is not clicked", e); }
        }

        public void Mark_Thrusday()
        {
            try {  SetMethods.Click(Thrusday);
                test.Log(LogStatus.Pass, "Thrusday is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Thrusday is not clicked", e); }
        }

        public void Mark_Friday()
        {
            try {  SetMethods.Click(Friday);
                test.Log(LogStatus.Pass, "Friday is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Friday is not clicked", e); }
        }

        public void Mark_Saturday()
        {
            try {  SetMethods.Click(Saturday);
                test.Log(LogStatus.Pass, "Saturday is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Saturday is not clicked", e); }
        }
        
        public void AfterNumberOfOccuresces(string numberofOccuresces)
        {
            try {  SetMethods.EnterText(Number_Occuresces, numberofOccuresces);
                test.Log(LogStatus.Pass, " After Number of Occurences is added"); }
            catch (Exception e) { test.Log(LogStatus.Fail, " After Number of Occurences is not added", e); }
        }

        public void All_Week()
        {
            Mark_Sunday();
            Mark_Monday();
            Mark_Tuesday();
            Mark_Wednesday();
            Mark_Thrusday();
            Mark_Friday();
            Mark_Saturday();
        }

        public void Reoccur()
        {
            try {  SetMethods.Click(RepeatEvent);
                test.Log(LogStatus.Pass, "Reoccur is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Reoccur is not clicked", e); }
            Driver.Wait(TimeSpan.FromSeconds(3));
        }

        public void Repeats(string daily)
        {
            try {  SetMethods.Select_Value_from_List(RepeatsValue, RepeatsList, daily);
                test.Log(LogStatus.Pass, "Repeats is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, " Repeats is not selected", e); }
        }

        public void RepeatsEvery(string numberofdays)
        {
            try {  SetMethods.Select_Value_from_List(Repeatevery, RepeateveryList, numberofdays);
                test.Log(LogStatus.Pass, "Repeats every is selected"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Repeats every is not selected", e); }
        }

        public void EndsOnDate()
        {
            SetMethods.ScrollDown(On_Date);
            SetMethods.Click(On_Date);
        }

        public void TimeoffSave()
        {
            try {  SetMethods.Click(SaveButton);
                test.Log(LogStatus.Pass, "Save button is clicked"); }
            catch (Exception e) { test.Log(LogStatus.Fail, "Save button is not clicked", e); }
        }

        // Remove Timeoff 2h + All Day
        public void Remove_Timeoff(string date, string title)
        {
            Calendar_datetime_picker.SendKeys(Keys.Control + "a");
            Calendar_datetime_picker.SendKeys(Keys.Delete);
            SetMethods.EnterText(Calendar_datetime_picker, date);
            Driver.Wait(TimeSpan.FromSeconds(3));
            SetMethods.Click(Weekly);
            Driver.Wait(TimeSpan.FromSeconds(3));
            SetMethods.Click(event_title_timeoff);
            SetMethods.Click(Remove_button);
        }

        public void Remove_this_timeoff()
        {
            SetMethods.Click(Remove_timeoff);
        }

        public void Remove_all_timeoff_in_the_series()
        {
            SetMethods.Click(Remove_alltimeoff_in_the_series);
        }

        public void Remove_all_timeoff_in_the_series_foward()
        {
            SetMethods.Click(Remove_alltimeoff_in_the_series_foward);
        }

        #endregion

        public void Remove_Appointment()
        {
            SetMethods.Click(appointment_title);
            SetMethods.Click(Cancel);
            SetMethods.Click(CancelAppointment);
        }


        //Remove Timeoff Recurring
        //public void Remove_Timeoff_Recurring(string title,string date)
        //{
        //    Driver.Wait(TimeSpan.FromSeconds(3));
        //    Calendar_datetime_picker.SendKeys(Keys.Control + "a");
        //    Calendar_datetime_picker.SendKeys(Keys.Delete);
        //    SetMethods.EnterText(Calendar_datetime_picker, date);
        ////    Driver.Wait(TimeSpan.FromSeconds(3));
        //  //  SetMethods.Click(Weekly);
        //    Driver.Wait(TimeSpan.FromSeconds(3));
        //    SetMethods.Click(event_title_timeoff);
        //    Driver.Wait(TimeSpan.FromSeconds(3));
        //     // Event_Title(title);
        //    SetMethods.Click(Remove_button);
        //    SetMethods.Click(Remove_alltimeoff_in_the_series);
        //}

   

        public void clickRandomCalendarTime()
        {
            r = new Random();
            // int i = sizeof(calendarTimeRows - 1) +1;
            //  int i = Convert.ToInt32(calendarTimeRows.IndexOf(r) - 1) + 1;
            // r.nextInt(calendarTimeRows.size() - 1) + 1;
            //  SetMethods.Click(calendarTimeRows.Find(i));
        }

        public void clickPopUpBookAppointment()
        {
            SetMethods.Click(popUpBookAppointment);

        }
        //Workflow actions
        public void bookAppointmentFromCalendarRow()
        {
            clickRandomCalendarTime();
            clickPopUpBookAppointment();

        }

        
    }
}
