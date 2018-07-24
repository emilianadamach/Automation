using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

using NUnit.Framework.Api;
using NUnit.Framework.Constraints;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;

namespace UnifiedPracticeTests
{
   
   public class UPBaseTest 
    {
        // public ExtentReports extent = ExtentManager.getInstance();
        public ExtentReports extent = ExtentManager.getInstance();
        
        //public void ElementReport(IWebElement element, string meg1, string meg2)
        //{
        //    try
        //    {
        //        test.Log(LogStatus.Pass, "Add Appointment button is clicked");
        //    }
        //    catch (Exception e)
        //    {
        //        test.Log(LogStatus.Pass, "Add Appointment button is clicked");
        //    }
        //}

        [TestInitialize]
        public void Init()
        {
            
            Driver.Initialize();
          //  options = ChromeDriver.AcceptUntrustedCertificates;
            LoginPage.GoTo();
           // LoginPage.LoginAs("practitioner1").WithPassword("password1").Login();
            LoginPage.LoginAs("acuzinna").WithPassword("1234567").Login();
            Driver.Wait(TimeSpan.FromSeconds(3));
            
        }
          
        [TestCleanup]
        public void Cleanup()
        {

            //Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

            //foreach (var chromeDriverProcess in chromeDriverProcesses)
            //{
            //    chromeDriverProcess.Kill();
            //}
           
     
            

            Driver.Instance.Close();

            Driver.Instance.Quit();
            //Driver.Instance.Close();

            //   Driver.Wait(TimeSpan.FromSeconds(5));
            //   Driver.Close();
        }



        //public void SetUp(String browserName)
        //{
        //    if (browserName.Equals("ie"))
        //        Driver.Instance = new InternetExplorerDriver();
        //    else if (browserName.Equals("chrome"))
        //        Driver.Instance = new ChromeDriver();
        //    else if (browserName.Equals("safari"))
        //        Driver.Instance = new SafariDriver();
        //    else if (browserName.Equals("opera"))
        //        Driver.Instance = new OperaDriver();
        //    else
        //        Driver.Instance = new FirefoxDriver();



        //    // Instance = new ChromeDriver();
        //    Driver.Instance.Manage().Window.Maximize();
        //}

        //public static IEnumerable<String> BrowserToRunWith()
        //{
        //    String[] browsers = { "chrome", "firefox", "ie", "safari", "opera" };
        //    foreach(String b in browsers)
        //    {
        //        yield return b;
        //    }
        //}
    }
}

