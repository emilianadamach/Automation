using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UPAutomation;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace UPAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static readonly bool AcceptUntrustedCertificate;

        public static void Initialize()
        {
         
            //DesiredCapabilities capability = DesiredCapabilities.Chrome();
            //capability.SetCapability(CapabilityType.AcceptSslCertificates, true);
            Instance = new ChromeDriver();
            //  ChromeDriver.AcceptUntrustedCertificates = true;
            //   AcceptUntrustedCertificate = ChromeDriver.AcceptUntrustedCertificates;
            Instance.Manage().Window.Maximize();
          //  options = IWebDriver.chrome
            
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static void Wait(TimeSpan timespan)
        {
        
            Thread.Sleep((int)(timespan.TotalSeconds * 2000));
        }

        public static void WaitTest(IWebElement element)
        {
           
            // IWebElement element;
            var wait = new WebDriverWait(Instance, TimeSpan.FromMinutes(1));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(element));
            
         //   WebDriverWait wait = new WebDriverWait(Instance, timespan);
         //    wait.Until(e=> element.Displayed);
         //  IWait<IWebElement> element;
         //    Thread.Sleep((int)(timespan.TotalSeconds * 1000));
        }
    }

    
    }


