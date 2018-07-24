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
    public class BusinessInformationPage
    {
        public BusinessInformationPage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        // Clinic Settings button
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[7]")]
        public IWebElement clinicSettingsButton { get; set; }

        // Business Information button
        [FindsBy(How = How.XPath, Using = "//*[@id='nav']/li[7]/ul/li[2]/a/span")]
        public IWebElement BusinessInformationButton { get; set; }
       
        // Practice Name
        [FindsBy(How = How.Id, Using = "ClinicInfo_OrganizationName")]
        public IWebElement PracticeName { get; set; }

        // Owner or manager Name
        [FindsBy(How = How.Id, Using = "ClinicInfo_ProviderName")]
        public IWebElement Owner_Manager { get; set; }

        // Street Adress
        [FindsBy(How = How.Id, Using = "OrganizationContact_AddressLine1")]
        public IWebElement Street_adress { get; set; }

        // Street Adress Line 2 
        [FindsBy(How = How.Id, Using = "OrganizationContact_AddressLine2")]
        public IWebElement Street_adress_line2 { get; set; }

        // Country
        [FindsBy(How = How.CssSelector, Using = "#form > div > div:nth-child(6) > div > div:nth-child(3) > div > button")]
        public IWebElement Country { get; set; }

        // Country List
        [FindsBy(How = How.CssSelector, Using = "#form > div > div:nth-child(6) > div > div:nth-child(3) > div > div > ul > li > a")]
        public IList<IWebElement> CountryList { get; set; }

        // State
        [FindsBy(How = How.CssSelector, Using = "#statesSelectWrapper > div > button")]
        public IWebElement State { get; set; }

        //button[@data-id='OrganizationContact_StateCode']
        // State List
        [FindsBy(How = How.CssSelector, Using = "#statesSelectWrapper > div > div > ul > li > a")]
          public IList<IWebElement> StateList { get; set; }

        // City
        [FindsBy(How = How.Id, Using = "OrganizationContact_City")]
        public IWebElement City { get; set; }

        // Zip Code
        [FindsBy(How = How.Id, Using = "OrganizationContact_ZipCode")]
        public IWebElement Zip_Code { get; set; }

        // Phone
        [FindsBy(How = How.Id, Using = "OrganizationContact_PhoneNumber1")]
        public IWebElement Phone { get; set; }

        // Fax
        [FindsBy(How = How.Id, Using = "OrganizationContact_FaxNumber1")]
        public IWebElement Fax { get; set; }

        // Primary email address
        [FindsBy(How = How.Id, Using = "OrganizationContact_EmailAddress1")]
        public IWebElement Primary_email_address { get; set; }

        // Primary website address
        [FindsBy(How = How.Id, Using = "OrganizationContact_WebAddress1")]
        public IWebElement Primary_website_address { get; set; }

        // Primary Contact
        [FindsBy(How = How.CssSelector, Using = "#form > div > div:nth-child(4) > div:nth-child(2) > div > div > div > button")]
        public IWebElement Primary_Contact { get; set; }

        // Primary Contact select
        [FindsBy(How = How.CssSelector, Using = "#form > div > div:nth-child(4) > div:nth-child(2) > div > div > div > div > ul > li > a")]
        public IList<IWebElement> Select_Primary_Contact { get; set; }

        // Forms of Payment We Accept
        [FindsBy(How = How.CssSelector, Using = "#form > div > div:nth-child(5) > div > div > div > button")]
        public IWebElement Forms_of_payment_we_accept { get; set; }

        // Forms of Payment We Accept select
        [FindsBy(How = How.CssSelector, Using = "#form > div > div:nth-child(5) > div > div > div > div > ul > li > a")]
        public IList<IWebElement> Select_Forms_of_payment_we_acceptt { get; set; }

        // View Tutorial
        [FindsBy(How = How.CssSelector, Using = "#container > div.crumbs.js-breadcrumbsContainer > div.pull-right.viewTutorialLink.js-tutorialLink")]
        public IWebElement View_Tutorial { get; set; }

        // Submit button
        [FindsBy(How = How.CssSelector, Using = "#form > div > p > input")]
        public IWebElement submit { get; set; }

        public void GoTo()
        {
            SetMethods.Click(clinicSettingsButton);
            SetMethods.Click(BusinessInformationButton);
        }

        public void Practice_Name(string practiceName)
        {
            SetMethods.EnterText(PracticeName, practiceName);
        }

        public void Owner(string Owner)
        {
            SetMethods.EnterText(Owner_Manager, Owner);
        }

        public void Address(string streetaddress)
        {
            SetMethods.EnterText(Street_adress, streetaddress);
        }

        public void AddressLine2(string streetaddress2)
        {
            SetMethods.EnterText(Street_adress_line2, streetaddress2);
        }

        public void Country_(string country)
        {
            Driver.Wait(TimeSpan.FromSeconds(10));
            SetMethods.Select_Value_from_List(Country, CountryList, country);
            Driver.Wait(TimeSpan.FromSeconds(10));
        }

        public void State_(string state)
        {
            SetMethods.Select_Value_from_List(State, StateList, state);

        }

        public void City_(string city)
        {
            SetMethods.EnterText(City, city);
        }

        public void ZipCode(string zipcode)
        {
            SetMethods.EnterText(Zip_Code, zipcode);
        }

        public void Phonse_(string phone)
        {
            SetMethods.EnterText(Phone, phone);
        }

        public void Fax_(string fax)
        {
            SetMethods.EnterText(Fax, fax);
        }

        public void Primary_email(string email)
        {
            SetMethods.EnterText(Primary_email_address, email);
        }

        public void Primary_Website_Address(string websiteAddress)
        {
            SetMethods.EnterText(Primary_website_address, websiteAddress);
        }

        public void Primary_contact(string primary_contact)
        {
            SetMethods.Select_Value_from_List(Primary_Contact, Select_Primary_Contact, primary_contact);
        }

        public void FormsOfPayment(params string[] payment)
        {
            SetMethods.Select_All_Elements(Forms_of_payment_we_accept, Select_Forms_of_payment_we_acceptt);
        }

        public void Submit()
        {
            SetMethods.Click(submit);
        }

        public void Add_BusinessInformation(string practiceName,   string Manager,         string streetaddress,   string streetaddress2, 
                       string country,        string state,           string city,            string zipcode,
                       string phone,          string fax,             string primary_email,
                       string primary_website,string primary_contact, string payment )
        {
            Practice_Name(practiceName);
            Owner(Manager);
            Address(streetaddress);
            AddressLine2(streetaddress2);
         //   Country_(country);
            State_(state);
            City_(city);
            ZipCode(zipcode);
            Phonse_(phone);
            Fax_(fax);
            Primary_email(primary_email);
            Primary_Website_Address(primary_website);
            Primary_contact(primary_contact);
            Driver.Wait(TimeSpan.FromSeconds(1));
            FormsOfPayment(payment);
        }
    }
}
