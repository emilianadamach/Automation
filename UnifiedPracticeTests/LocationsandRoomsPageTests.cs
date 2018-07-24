using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
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
   public class LocationsandRoomsPageTests : UPBaseTest
    {
        [TestMethod]
        public void Add_Location()
        {
            LeftNavigation.ClinicSettings.LocationsandRooms.GoTo();
            LocationsandRoomsPage loc = new LocationsandRoomsPage();
            loc.AddLocation();
            loc.Location_Name("Locatie5");
            loc.Location_Timezone("(UTC-09:00) Alaska");
            loc.Contact_Information("", "", "Buzau", "zip", "adresa1", "adresa2", "0720600610", "0720611", "fax", "emilian.adamache@omnisourcetech.com", "www");
            loc.Billing_Provider("OA");
            loc.ScrollDown();
            Driver.Wait(TimeSpan.FromSeconds(3));
            loc.Facility_Code("34 Hospice");
            Driver.Wait(TimeSpan.FromSeconds(3));
            loc.FacilityNPI("aaa");
            Driver.Wait(TimeSpan.FromSeconds(2));
            loc.Location_Save();
        }
       
        [TestMethod]
        public void Add_Location_SameAs_Primary()
        {
            LeftNavigation.ClinicSettings.LocationsandRooms.GoTo();
            LocationsandRoomsPage loc = new LocationsandRoomsPage();
            loc.AddLocation();
            loc.Location_Name("Locatie2");
            loc.Location_Timezone("(UTC-05:00) Indiana (East)");
            loc.SameAddressAsPrimaryClinic();
            loc.ScrollDown();
            loc.Location_Save();
        }

        [TestMethod]
        public void Add_Room()
        {
            LeftNavigation.ClinicSettings.LocationsandRooms.GoTo();
            LocationsandRoomsPage rm = new LocationsandRoomsPage();
            rm.Rooms();
            rm.Add_Room();
            rm.Room_Name("Test2");
            rm.Room_Description("Green Room");
            rm.Room_Save();
        }


        [TestMethod]
        public void Room()
        {
            LeftNavigation.ClinicSettings.LocationsandRooms.GoTo();
            LocationsandRoomsPage rm = new LocationsandRoomsPage();
            rm.Rooms();
            rm.Add_Room();
            rm.Room_Name("Test");
            rm.Room_Description("Green Room");
            rm.Room_Inactive();
            rm.Room_Save();
        }

    }
}
