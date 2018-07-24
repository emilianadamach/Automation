using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using NUnit.Framework.Interfaces;
using System.IO;

namespace UnifiedPracticeTests
{
   
    public class ExtentManagers
    {

        private static ExtentReports extent;
      

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                extent = new ExtentReports("D:\\UP Automation\\UPAutomation Angular\\UnifiedPracticeTests\\Reports\\MyOwnReport.html");
                extent.LoadConfig(Directory.GetCurrentDirectory() + "extent-config.xml");
                extent.AddSystemInfo("Selenium version", "2.53").AddSystemInfo("Enviroment", "QA");
            }

            return extent;
        }

        //[OneTimeSetUp]
        //public static void StartReport()
        //{
        //    string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        //    string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
        //    string projectPath = new Uri(actualPath).LocalPath;

        //    string reportPath = projectPath + "Reports\\MyOwnReport.html";

        //    extent = new ExtentReports(reportPath, true);
        //    extent.AddSystemInfo("HostName", "Emilian");
        //    extent.AddSystemInfo("Environment", "QA");
        //    extent.AddSystemInfo("User Name", "EM ADAM");

        //    extent.LoadConfig(projectPath + "extent-config.xml");
        //}

        //[Test]
        //public void TestMethod()
        //{
        //    test = extent.StartTest("TestMethod");
        //    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(true);
        //    test.Log(LogStatus.Pass, "Assert Pass as condition Is True");
        //}

        //[Test]
        //public void TestMethod1()
        //{
        //    test = extent.StartTest("TestMethod21");
        //    Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(false);
        //    test.Log(LogStatus.Pass, "Assert Pass as condition Is True");
        //}
        //[TearDown]
        //public static void GetResults()
        //{
        //    var status = NUnit.Framework.TestContext.CurrentContext.Result.Outcome.Status;
        //    var stacktrace = string.IsNullOrEmpty(NUnit.Framework.TestContext.CurrentContext.Result.StackTrace)
        //            ? ""
        //            : string.Format("<pre>{0}</pre>", NUnit.Framework.TestContext.CurrentContext.Result.StackTrace);
        //    LogStatus logstatus;

        //    switch (status)
        //    {
        //        case TestStatus.Failed:
        //            logstatus = LogStatus.Fail;
        //            break;
        //        case TestStatus.Inconclusive:
        //            logstatus = LogStatus.Warning;
        //            break;
        //        case TestStatus.Skipped:
        //            logstatus = LogStatus.Skip;
        //            break;
        //        default:
        //            logstatus = LogStatus.Pass;
        //            break;
        //    }
        //    var test = extent.StartTest("Timeoff", "timeoff check");
        //     test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
           
        //    extent.EndTest(test);
        //    extent.Flush();
        //}


        //public void GetResults()
        //{
        //    var status = NUnit.Framework.TestContext.CurrentContext.Result.Outcome.Status;
        //    var stackTrace = "<pre>" + NUnit.Framework.TestContext.CurrentContext.Result.StackTrace + "</pre";
        //    var errorMessage = NUnit.Framework.TestContext.CurrentContext.Result.Message;
        //    if (status == TestStatus.Passed)
        //    {
        //        test.Log(LogStatus.Pass, status + "");
        //    }
        //    else if (status == TestStatus.Failed)
        //    {
        //        test.Log(LogStatus.Fail, status + errorMessage);
        //    }

        //    //  //  extent.EndTest(test);
        //    //   // extent.Flush();
        //    //}
        //}

            //[OneTimeTearDown]
            //public void EndReport()
            //    {
            //        extent.Flush();
            //        extent.Close();
            //    }
        }
    }
