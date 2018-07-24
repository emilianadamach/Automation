using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation;
using UPAutomation.Navigation;

namespace UnifiedPracticeTests
{
    [TestClass]
   public class FeeScheduleTests : UPBaseTest
    {
        [TestMethod]
        public void Add_CPT_Item()
        {
            LeftNavigation.ClinicSettings.FeeSchedule.GoTo();
            FeeSchedulePage a = new FeeSchedulePage();
            a.AddCPT(); 

            
        }

        [TestMethod]
        public void Edit_CPT_Item()
        {
            LeftNavigation.ClinicSettings.FeeSchedule.GoTo();
            FeeSchedulePage a = new FeeSchedulePage();
            a.EditCPT();
        }
    }
}
