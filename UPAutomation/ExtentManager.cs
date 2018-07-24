using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPAutomation
{
    public class ExtentManager
    {
        private static ExtentReports extent;

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                extent = new ExtentReports("D:\\UP Automation\\UPAutomation Angular\\UnifiedPracticeTests\\Reports\\TestReport.html");
                extent.LoadConfig(Directory.GetCurrentDirectory() + "extent-config.xml");
                extent.AddSystemInfo("Selenium version", "2.53").AddSystemInfo("Enviroment", "QA").AddSystemInfo("Theme", "Dark");
            }

            return extent;
        }
    }
}
