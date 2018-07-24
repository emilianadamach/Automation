using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Selenium;

namespace UPAutomation
{
    public class FeeSchedulePage
    {
        public FeeSchedulePage()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        // Clinic Settings button
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[4]")]
        public IWebElement clinicSettingsButton { get; set; }

        // Fee Schedule button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Fee Schedule')]")]
        public IWebElement feeScheduleButton { get; set; }

        // Add CPT button
        [FindsBy(How = How.Id, Using = "addCPTItem")]
        public IWebElement addCPTbutton { get; set; }

        // Tax Rate TextField
        [FindsBy(How = How.Id, Using = "InputTaxRate")]
        public IWebElement taxRateTextField { get; set; }

        // Tax Slider Button On-OFF  
        [FindsBy(How = How.ClassName, Using = "grey")]
        public IWebElement taxSliderButton { get; set; }

        // Refresh button  
        [FindsBy(How = How.ClassName, Using = "glyphicon-refresh")]
        public IWebElement refreshButton { get; set; }      

 
       // [FindsBy(How = How.Id, Using = "HasServicesTaxRateConfigured")]
       // public IWebElement taxStatusLabel { get; set; }


        // CPT Code
        [FindsBy(How = How.Id, Using = "Code")]
        public IWebElement CPT_Code { get; set; }

        // CPT Description
        [FindsBy(How = How.Id, Using = "Description")]
        public IWebElement CPT_Description { get; set; }

        //  CPT Price
        [FindsBy(How = How.Id, Using = "Price")]
        public IWebElement CPT_Price { get; set; }

        //  CPT Modifier A
        [FindsBy(How = How.Id, Using = "Modifiers_ModA")]
        public IWebElement CPT_Modifier_A { get; set; }

        //  CPT Modifier B
        [FindsBy(How = How.Id, Using = "Modifiers_ModB")]
        public IWebElement CPT_Modifier_B { get; set; }

        //  CPT Modifier C   
        [FindsBy(How = How.Id, Using = "Modifiers_ModC")]
        public IWebElement CPT_Modifier_C { get; set; }

        //  CPT Modifier D
        [FindsBy(How = How.Id, Using = "Modifiers_ModD")]
        public IWebElement CPT_Modifier_D { get; set; }

        //  CPT Save
        [FindsBy(How = How.CssSelector, Using = "input[value = 'Save']")]
        public IWebElement CPT_Save { get; set; }

        //  CPT Cancel
        [FindsBy(How = How.CssSelector, Using = "input[value = 'Cancel']")]
        public IWebElement CPT_Cancel { get; set; }

        //  CPT Edit
        [FindsBy(How = How.CssSelector, Using = "#grid-data-clinicCTP > tbody > tr:nth-child(2) > td:nth-child(8) > a.editCPTItem")]
        public IWebElement CPT_Edit { get; set; }

        //  Deactivate
        [FindsBy(How = How.XPath, Using = "//*[@id=grid - data - clinicCTP]/tbody/tr[1]/td[8]/a")]
        public IWebElement Deactivate { get; set; }

        //  Deactivate
        [FindsBy(How = How.CssSelector, Using = "#grid-data-clinicCTP > tbody > tr:nth-child(2) > td:nth-child(8) > a")]
        public IWebElement Activate { get; set; }

        public void GoTo()
        {
            SetMethods.Click(clinicSettingsButton);
            SetMethods.Click(feeScheduleButton);
        }

        public void AddCPTButton()
        {
            SetMethods.Click(addCPTbutton);
        }

        public void AddCPT()
        {
            SetMethods.GetRandomNumber(CPT_Code);
            SetMethods.EnterText(CPT_Description,"aa");
            CPT_Price.Clear();
            SetMethods.GetRandomNumber(CPT_Price);
            SetMethods.EnterText(CPT_Modifier_A,"g");
            SetMethods.EnterText(CPT_Modifier_B,"hh");
            SetMethods.EnterText(CPT_Modifier_C,"jj");
            SetMethods.EnterText(CPT_Modifier_D,"kkk");
            SetMethods.Click(CPT_Save);
        }

        public void EditCPT()
        {
            SetMethods.Click(CPT_Edit);
            Driver.Wait(TimeSpan.FromSeconds(1));
            SetMethods.GetRandomNumber(CPT_Code);
            SetMethods.EnterText(CPT_Description, "aa");
            CPT_Price.Clear();
            SetMethods.GetRandomNumber(CPT_Price);
            SetMethods.EnterText(CPT_Modifier_A, "g");
            SetMethods.EnterText(CPT_Modifier_B, "hh");
            SetMethods.EnterText(CPT_Modifier_C, "jj");
            SetMethods.EnterText(CPT_Modifier_D, "kkk");
            SetMethods.Click(CPT_Save);
        }


        public void Tax_Rate()
        {
            SetMethods.Click(taxSliderButton);
            SetMethods.EnterText(taxRateTextField, "65.1234");
        }

        public void ActivateCPT()
        {
            SetMethods.Click(Activate);
            Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.Last());
            Driver.Instance.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
          
        }

        public void DeactivateCPT()
        {
            SetMethods.Click(Deactivate);
            // Driver.Instance.SwitchTo().Window(Driver.Instance.WindowHandles.Last());
            // Driver.Instance.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            IAlert alert = Driver.Instance.SwitchTo().Alert();
            alert.Accept();
        }

    }
}
