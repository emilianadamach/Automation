using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Selenium;

namespace UPAutomation
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "Parameter_UserName")]
        public IWebElement usernameTextfield { get; set; }

        [FindsBy(How = How.Id, Using = "Parameter_Password")]
        private IWebElement passwordTextfield { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement loginButton { get; set; }

        [FindsBy(How = How.Id, Using = "forgot-password")]
        private IWebElement forgotPasswordButton { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement forgotUsernameTextfield { get; set; }

        [FindsBy(How = How.Id, Using = "EmailAddress")]
        private IWebElement forgotEmailTextfield { get; set; }

        [FindsBy(How = How.Id, Using = "forgot-password-check")]
        private IWebElement recoverPasswordButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h6[contains(text(),'instructions to change')]")]
        private IWebElement passwordRecoveryEmailSentFlashmessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//h6[contains(text(),'The Username field is required')]")]
        private IWebElement usernameRequiredFlashmessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//h6[contains(text(),'The Password field is required')]")]
        private IWebElement passwordRequiredFlashmessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//h6[contains(text(),'Invalid credentials, check again your user name and password')]")]
        private IWebElement InvalidCrentialsFlashmessage { get; set; }

        //[FindsBy(How = How.CssSelector, Using = "#nav > li:nth-child(3) > a > i")]
        // public IWebElement patientbutton { get; set; }
        
        public static void GoTo()
        {
      //      Driver.Instance.Navigate().GoToUrl("http://staging.unifiedpractice.com/PublicAngular/Account/Login");
            Driver.Instance.Navigate().GoToUrl("https://ehr.unifiedpractice.com/Public/Account/Login?ReturnUrl=%2fPublic%2f");
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "Parameter_UserName");
        }

        public static LoginCommand LoginAs(string username)
        {
            return new LoginCommand(username);
        }

        public class LoginCommand
        {
            private string password;
            private readonly string userName;


            public LoginCommand(string userName)
            {
                this.userName = userName;
            }

            public LoginCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void Login()
            {
                var loginInput = Driver.Instance.FindElement(By.Id("Parameter_UserName"));
                loginInput.SendKeys(userName);

                var passwordInput = Driver.Instance.FindElement(By.Id("Parameter_Password"));
                passwordInput.SendKeys(password);

                var loginButton = Driver.Instance.FindElement(By.XPath("//button[contains(text(),'Login')]"));
                loginButton.Click();
            }

        }

    }
   }
