using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Selenium;

namespace UPAutomation.Pages
{
    public class LocationsandRoomsPage
    {
        public LocationsandRoomsPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        // Clinic Settings button
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[4]")]
        public IWebElement clinicSettingsButton { get; set; }

        //Locations & Rooms button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Locations & rooms')]")]
        public IWebElement LocationsandRoomsButton { get; set; }

        //Add Location button
        [FindsBy(How = How.CssSelector, Using = "#container > div.crumbs.js-breadcrumbsContainer > div.js-pageActions > ul > li")]
        public IWebElement AddLocationButton { get; set; }

        //Location Name
        [FindsBy(How = How.Id, Using = "LocationName")]
        public IWebElement LocationName { get; set; }

        //TimeZone
        [FindsBy(How = How.XPath, Using = "//button[@data-id='TimeZoneId']")]
        public IWebElement TimeZone { get; set; }

        //TimeZone List
        [FindsBy(How = How.CssSelector, Using = "#addClinicLocation > div:nth-child(5) > div > div > div > div > div > ul > li > a")]
        public IList<IWebElement> TimeZoneList { get; set; }

        //Clinic Location is Active ?
        [FindsBy(How = How.Id, Using = "IsActive")]
        public IWebElement LocationActive { get; set; }

        //Allow Online Scheduling ?
        [FindsBy(How = How.Id, Using = "AllowOnlineScheduling")]
        public IWebElement AllowOnlineScheduling { get; set; }

        //Select "yes" if this clinic’s location is the same as your primary clinic's address
        //  If you only have one location, select "yes
        [FindsBy(How = How.XPath, Using = "//div[@data-toggle-selector='#locationContact']")]
        public IWebElement SameContactAsClinic { get; set; }

        //Country
        [FindsBy(How = How.XPath, Using = "//button[@data-id='LocationContact_CountryCode']")]
        public IWebElement Country { get; set; }

        //Country List
        [FindsBy(How = How.CssSelector, Using = "#locationContact > div > div > div:nth-child(2) > div:nth-child(1) > div > div > div > ul > li > a")]
        public IList<IWebElement> CountryList { get; set; }

        //State
        [FindsBy(How = How.Id, Using = "LocationContact_StateName")]
        public IWebElement State { get; set; }

        //State United StatesLocationContact_StateName
        [FindsBy(How = How.XPath, Using = "//button[@data-id='LocationContact_StateCode']")]
        public IWebElement Stateclick { get; set; }

        //State List
        [FindsBy(How = How.CssSelector, Using = "#statesSelectWrapper > div > div > ul > li > a")]
        public IList<IWebElement> StateList { get; set; }

        // City
        [FindsBy(How = How.Id, Using = "LocationContact_City")]
        public IWebElement City { get; set; }

        // Zip Code
        [FindsBy(How = How.Id, Using = "LocationContact_ZipCode")]
        public IWebElement ZipCode { get; set; }

        // Street Adress
        [FindsBy(How = How.Id, Using = "LocationContact_AddressLine1")]
        public IWebElement Street_adress { get; set; }

        // Street Adress Line 2 
        [FindsBy(How = How.Id, Using = "LocationContact_AddressLine2")]
        public IWebElement Street_adress_line2 { get; set; }

        // Phone #
        [FindsBy(How = How.Id, Using = "LocationContact_PhoneNumber1")]
        public IWebElement Phone { get; set; }

        // Phone #2
        [FindsBy(How = How.Id, Using = "LocationContact_PhoneNumber2")]
        public IWebElement Phone2 { get; set; }

        // Fax
        [FindsBy(How = How.Id, Using = "LocationContact_FaxNumber1")]
        public IWebElement Fax { get; set; }

        // Email address
        [FindsBy(How = How.Id, Using = "LocationContact_EmailAddress1")]
        public IWebElement Emailaddress { get; set; }

        // Website address
        [FindsBy(How = How.Id, Using = "LocationContact_WebAddress1")]
        public IWebElement Websiteaddress { get; set; }

        // Location Name to print in box 32 of HCFA form (claim)
        [FindsBy(How = How.Id, Using = "BillingProviderOffice")]
        public IWebElement BillingProviderOA { get; set; }

        //Facility Code
        [FindsBy(How = How.XPath, Using = "//button[@data-id='LocationFacilityId']")]
        public IWebElement FacilityCode { get; set; }

        //Facility Code List
        [FindsBy(How = How.CssSelector, Using = "#addClinicLocation > div.form-group.locationFacilityId > div > div > div > ul > li > a")]
        public IList<IWebElement> FacilityCodeList { get; set; }

        // Use service facility NPI number in box 32a of HCFA form? (claim)
        [FindsBy(How = How.XPath, Using = "//div[@data-toggle-selector='.NPInumberBox32a']")]
        public IWebElement UseFacilityNumber { get; set; }

        // Use service facility NPI number in box 32a of HCFA form? (claim)
        [FindsBy(How = How.Id, Using = "LocationData_NPIData_NPI32a")]
        public IWebElement FacilityNumber { get; set; }

        // Cancel button 
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement Cancelbutton { get; set; }

        // Save button 
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Savebutton { get; set; }

        // Room
        [FindsBy(How = How.CssSelector, Using = "#locationsList > div:nth-child(8) > div.card-footer > div > div.card-button.card-properties.footer-right-button > span")]
        private IWebElement Room { get; set; }

        // Add room button 
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddRoom { get; set; }

        // Close room button 
        [FindsBy(How = How.XPath, Using = "//input[@value='Close']")]
        private IWebElement CloseRoom { get; set; }

        // Room Name 
        [FindsBy(How = How.Id, Using = "RoomName")]
        private IWebElement RoomName { get; set; }

        // Room Description 
        [FindsBy(How = How.Id, Using = "RoomDescription")]
        private IWebElement RoomDescription { get; set; }

        //RoomActive ?
        [FindsBy(How = How.Id, Using = "IsActive")]
        public IWebElement RoomActive { get; set; }

        public void GoTo()
        {
            SetMethods.Click(clinicSettingsButton);
            SetMethods.Click(LocationsandRoomsButton);
        }

        public void AddLocation()
        {
            SetMethods.Click(AddLocationButton);
        }

        public void Location_Name(string name)
        {
            SetMethods.EnterText(LocationName, name);
        }

        public void Location_Timezone(string timezone)
        {
            SetMethods.Select_Value_from_List(TimeZone, TimeZoneList, timezone);
        }

        public void Location_Inactive()
        {
            SetMethods.Click(LocationActive);
        }

        public void Location_InactiveScheduling()
        {
            SetMethods.Click(AllowOnlineScheduling);
        }

        public void SameAddressAsPrimaryClinic()
        {
            SetMethods.Click(SameContactAsClinic);
        }

        public void Contact_Country(string country)
        {
            SetMethods.Select_Value_from_List(Country, CountryList, country);
        }

        public void Contact_State(string state)
        {
            SetMethods.EnterText(State, state);
        }

        public void Contact_City(string city)
        {
            SetMethods.EnterText(City, city);
        }

        public void Contact_ZipCode(string zipCode)
        {
            SetMethods.EnterText(ZipCode, zipCode);
        }

        public void Contact_Address(string address)
        {
            SetMethods.EnterText(Street_adress, address);
        }

        public void Contact_AddressLine2(string address)
        {
            SetMethods.EnterText(Street_adress_line2, address);
        }

        public void Contact_Phone(string phone)
        {
            SetMethods.EnterText(Phone, phone);
        }

        public void Contact_Phone2(string phone)
        {
            SetMethods.EnterText(Phone2, phone);
        }

        public void Contact_Fax(string fax)
        {
            SetMethods.EnterText(Fax, fax);
        }

        public void Contact_Emailaddress(string email)
        {
            SetMethods.EnterText(Emailaddress, email);
        }

        public void Contact_WebsiteAddress(string website)
        {
            SetMethods.EnterText(Websiteaddress, website);
        }

        public void ScrollDown()
        {
            Actions actions = new Actions(Driver.Instance);
            actions.MoveToElement(Savebutton);
            actions.Perform();
        }

        public void Contact_Information(string country, string state,string city, string zipCode, string address, string address2, string phone, string phone2,string fax, string email, string website)
        {
          //Contact_Country(country);
          //Contact_State(state);
            Contact_City(city);
            Contact_ZipCode(zipCode);
            Contact_Address(address);
            Contact_AddressLine2(address2);
            Contact_Phone(phone);
            Contact_Phone2(phone2);
            Contact_Fax(fax);
            Contact_Emailaddress(email);
            Contact_WebsiteAddress(website);
        }

        public void Billing_Provider(string OA)
        {
            SetMethods.EnterText(BillingProviderOA, OA);
        }

        public void Facility_Code(string facilityCode)
        {
            SetMethods.Select_Value_from_List(FacilityCode, FacilityCodeList, facilityCode);
        }

  
        public void FacilityNPI(string facilityNumber)
        {
            
            SetMethods.Click(UseFacilityNumber);
            SetMethods.EnterText(FacilityNumber, facilityNumber);
        }

        public void Location_Save()
        {
            SetMethods.Click(Savebutton);
        }

        public void Rooms()
        {
            SetMethods.Click(Room);
        }

        public void Add_Room()
        {
            SetMethods.Click(AddRoom);
        }

        public void Room_Name(string roomName)
        {
            SetMethods.EnterText(RoomName, roomName);
        }

        public void Room_Description(string description)
        {
            SetMethods.EnterText(RoomDescription, description);
        }

        public void Room_Inactive()
        {
            SetMethods.Click(RoomActive);
        }

        public void Room_Save()
        {
            SetMethods.Click(Savebutton);
        }



        public void Desen()
        {
            //   SetMethods.Select_Value_from_DropDown(Forms_of_payment_we_accept, Select_Forms_of_payment_we_acceptt, payment);
            //      SetMethods.Select_All_Elements(Forms_of_payment_we_accept, Select_Forms_of_payment_we_acceptt, payment);
            Driver.Wait(TimeSpan.FromSeconds(3));
         //   SetMethods.Deselect_All_Elements(Forms_of_payment_we_accept, Select_Forms_of_payment_we_acceptt);
            // SetMethods.Deselect_All_Elements(Forms_of_payment_we_accept, Select_Forms_of_payment_we_acceptt);
        }
    }
}
