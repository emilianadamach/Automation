using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation;
using UPAutomation.Navigation;
using UPAutomation.Pages;
using UPAutomation.Selenium;

namespace UnifiedPracticeTests
{
    [TestClass]  
    public class BusinessInformationTests : UPBaseTest
    {
        [TestMethod]
        public void Business()
        {
            var test = extent.StartTest("Business Information Update", "Business Information details are updated");
            LeftNavigation.ClinicSettings.BusinessInformation.GoTo();
            BusinessInformationPage business = new BusinessInformationPage();
            try
            {
                business.PracticeName.Clear();
                business.Practice_Name("My Test Clinic");
                test.Log(LogStatus.Pass, "Practice Name is addedokoko");
                //practice name etc
            }
            catch(Exception e)
            {
                test.Log(LogStatus.Fail, "Practice Name is not added", e);
            }
            try
            {
                business.Owner_Manager.Clear();
                business.Owner("Emilian");
                test.Log(LogStatus.Pass, "Owner Name is added");
            }
            catch(Exception e)
            {
                test.Log(LogStatus.Fail, "Owner Name is not added", e);
            }
            try
            {
                business.Primary_contact("Ana Zina");
                test.Log(LogStatus.Pass, "Primary Contact is selected");
            }
            catch(Exception e)
            {
                test.Log(LogStatus.Fail, "Primary Contact is not selected", e);
            }
            try
            {
                business.FormsOfPayment("Cash", "Amex", "Check");
                test.Log(LogStatus.Pass, "Forms of payment are selected");
            }
            catch(Exception e)
            {
                test.Log(LogStatus.Fail, "Forms of payment are not selected", e);
            }
            try
            {
                business.Street_adress.Clear();
                business.Address("Parintele Galeriu 6c");
                test.Log(LogStatus.Pass, "Street Address is added");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "Street Address is not added", e);
            }
            try
            {
                business.Street_adress_line2.Clear(); 
                business.AddressLine2("Vasile Lascar 144-146");
                test.Log(LogStatus.Pass, "Street Address 2 is added");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "Street Address 2 is not added", e);
            }
            try
            {
                business.Country_("Australia");
                test.Log(LogStatus.Pass, "Country is selected");
            }
            catch(Exception e)
            {
                test.Log(LogStatus.Fail, "Country is not selected", e);
            }
            try
            {
                business.State_("Victoria");
                test.Log(LogStatus.Pass, "State is selected");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "State is not selected", e);
            }
            try
            {
                business.City.Clear();
                business.City_("Virginia Victory");
                test.Log(LogStatus.Pass, "City is added");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "City is not added", e);
            }
            try
            {
                business.Zip_Code.Clear();
                business.ZipCode("52235335");
                test.Log(LogStatus.Pass, "ZipCode is added");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "ZipCode is not added", e);
            }
            try
            {
                business.Phone.Clear();
                business.Phonse_("0743422424");
                test.Log(LogStatus.Pass, "Phone is added");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "Phone is not added", e);
            }
            try
            {
                business.Fax.Clear();
                business.Fax_("343352252");
                test.Log(LogStatus.Pass, "Fax is added");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "Fax is not added", e);
            }
            try
            {
                business.Primary_email_address.Clear();
                business.Primary_email("emilian.adamache@yahoo.com");
                test.Log(LogStatus.Pass, "Primary Email Address is added");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "Primary Email Address is not added", e);
            }
            try
            {
                business.Primary_website_address.Clear();
                business.Primary_Website_Address("www.unifiedpractice.com");
                test.Log(LogStatus.Pass, "Primary Website Address is added");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "Primary Website Address is not added", e);
            }
            try
            {
                business.Submit();
                test.Log(LogStatus.Pass, "Submit button is clicked");
            }
            catch (Exception e)
            {
                test.Log(LogStatus.Fail, "Submit button is not clicked", e);
            }     
              business.Add_BusinessInformation("B", "B", "B", "B", "", "Alaska", "Col", "B", "1", "123", "a", "www", "Vlad Petre","Cash, Amex, Check, MasterCard");
            extent.EndTest(test);
            extent.Flush();
        }
    }
}
