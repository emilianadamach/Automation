using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;

namespace UPAutomation.Selenium
{
    public  class SetMethods 
    {

        public static void EnterText(IWebElement element, string value)
        {
            ElementDisplayed(element);
            element.SendKeys(value);

        }

        //Click into a button, Checkbox, option, etc
        public static void Click(IWebElement element)
        {
            ElementDisplayed(element);
        }

        public static void Select_Value_from_List(IWebElement element, IList<IWebElement> elements, string value)
        {
          //  Driver.Wait(TimeSpan.FromSeconds(2));
            element.Click();
            foreach (IWebElement e in elements)
            {
                if (e.Text.Trim() == value)
                    e.Click();
                Driver.Wait(TimeSpan.FromSeconds(1));
            }
        }

        public static void Select_All_Elements(IWebElement element, IList<IWebElement> elements)
        {
            element.Click();
            foreach (IWebElement e in elements)
            {
                if (e.Selected == false)
                    e.Click();
            }
        }

        public static void Deselect_All_Elements(IWebElement element, IList<IWebElement> elements)
        {
            element.Click();
            foreach (IWebElement e in elements)
            {
                if (e.Selected == true)
                    e.Click();
            }
        }

        public static void ValoriSelectate(IWebElement element, IList<IWebElement> elements, params string[] value)
        {
            element.Click();
            foreach (IWebElement e in elements)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    string p = value[i];
                // Console.WriteLine(s);
                    
                
                if (e.Text == value[i] && e.Selected == false)
                    e.Click();
                else if
                    (e.Text != value[i] && e.Selected != false)
                    continue;
                }
            }
        }

        public static string RandomName(IWebElement element)
        {
            string[] names =
            {
   "EARL","AMELIA", "OLIVIA","EMILY","AVA","ISLA","JESSICA","POPPY","ISABELLA","SOPHIE","MIA","RUBY","LILY","GRACE","EVIE","SOPHIA","ELLA","SCARLETT","CHLOE",
"ISABELLE"," FREYA","CHARLOTTE","SIENNA","DAISY","PHOEBE","MILLIE","EVA","ALICE","LUCY","FLORENCE","SOFIA","LAYLA","LOLA","HOLLY","IMOGEN","MOLLY",
"MATILDA","LILLY","ROSIE","ELIZABETH","ERIN","MAISIE","LEXI","ELLIE","HANNAH","EVELYN","ABIGAIL","ELSIE","SUMMER","MEGAN","JASMINE","MAYA","AMELIE",
"LACEY","WILLOW","EMMA","BELLA","ELEANOR","ESME","ELIZA","GEORGIA","HARRIET","GRACIE","ANNABELLE","EMILIA","AMBER","IVY","BROOKE","ROSE","ANNA",
"ZARA","LEAH","MOLLIE","MARTHA","FAITH","HOLLIE","AMY","BETHANY","VIOLET","KATIE","MARYAM","FRANCESCA","JULIA","MARIA","DARCEY","ISABEL","TILLY",
"MADDISON","VICTORIA","ISOBEL","NIAMH","SKYE","MADISON","DARCY","AISHA","BEATRICE","SARAH","ZOE","PAIGE","HEIDI","LYDIA","SARA","OLIVER","JACK",
"HARRY","JACOB","CHARLIE","THOMAS","OSCAR","WILLIAM","JAMES","GEORGE","ALFIE","JOSHUA","NOAH","ETHAN","MUHAMMAD","ARCHIE","LEO","HENRY","JOSEPH",
"SAMUEL","RILEY","DANIEL","MOHAMMED","ALEXANDER","MAX","LUCAS","MASON","LOGAN","ISAAC","BENJAMIN","DYLAN","JAKE","EDWARD","FINLEY","FREDDIE","HARRISON",
"TYLER","SEBASTIAN","ZACHARY","ADAM","THEO","JAYDEN","ARTHUR","TOBY","LUKE","LEWIS","MATTHEW","HARVEY","HARLEY","DAVID","RYAN","TOMMY","MICHAEL","REUBEN",
"NATHAN","BLAKE","MOHAMMAD","JENSON","BOBBY","LUCA","CHARLES","FRANKIE","DEXTER","KAI","ALEX","CONNOR","LIAM","JAMIE","ELIJAH","STANLEY","LOUIE","JUDE",
"CALLUM","HUGO","LEON","ELLIOT","LOUIS","THEODORE","GABRIEL","OLLIE","AARON","FREDERICK","EVAN","ELLIOTT","OWEN","TEDDY","FINLAY","CALEB","IBRAHIM",
"RONNIE","FELIX","AIDEN","CAMERON","AUSTIN","KIAN","RORY","SETH","ROBERT","ALBERT","SONNY",
            };
            Random random = new Random();
            String result = names[random.Next(names.Length)];
            element.SendKeys(result);
            return result;
        }

        public static int GetRandomNumber(IWebElement element)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            element.SendKeys(randomNumber.ToString());
            return randomNumber;
        }

        public static void ScrollDown(IWebElement element)
        {
            Actions actions = new Actions(Driver.Instance);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public static void ElementDisplayed(IWebElement element)
        {
            //   var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));
            //      var clickable = wait.Until(ExpectedConditions.ElementToBeClickable(element));
            //    ElementNotVisibleException a;
          //  Driver.Wait(TimeSpan.FromSeconds(3));
            if (element.Displayed == true)
           {
                element.Click();
              Driver.Wait(TimeSpan.FromSeconds(1));
            }
            else if (element.Displayed == false)
            {
                Driver.WaitTest(element);
                ElementDisplayed(element);
            }
            //ElementDisplayed(element);

         //   var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromMinutes(1));
//var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(element));
//
            // Driver.Wait(TimeSpan.FromSeconds(50));

            //  clickable.Displayed();
            // Console.WriteLine("Element" + element  + "is not visible!!!");

        }    
        
    }
}
