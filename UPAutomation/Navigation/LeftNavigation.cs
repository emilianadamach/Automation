using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPAutomation.Pages;
using UPAutomation.Selenium;

namespace UPAutomation.Navigation
{
   
    public class LeftNavigation
    {
        public class Dashboard
        {
                public static void GoTo()
                {
                    new DashboardPage().GoTo();
                }
        }

        public class Calendar
        {
            public class MyCalendar
            {
                public static void GoTo()
                {

                    new MyCalendarPage().GoTo();
                    
                }
            }

            public class ClinicCalendar
            {
                public static void GoTo()
                {
                    new ClinicCalendarPage().GoTo();
                }
            }
        }

        public class PatientList
        {
            public class MyPatients
            {
                public static void GoTo()
                {

                    new MyPatientsPage().GoTo();
                }
            }
            public class AllClinicPatients
            {
                public static void GoTo()
                {
                    new AllClinicPatientsPage().GoTo();
                }
            }
        }

        public class Billing
        {
            public class PaymentList
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
            public class ClaimList
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class DaySheet
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class BalanceDue
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
            public class UnbilledVisits
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
            public class ProductSale
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
        }

        public class Reports
        {
            public class ClinicActivityDetails
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
            public class ClinicActivityAggregate
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class PatientSummary
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class InventoryOnHand
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
            public class SalesHistory
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
            public class SalesTax
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
            public class SMSManagement
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
            public class NotificationsReport
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
            public class NotificationsAggregate
            {
                public static void GoTo()
                {

                    //  new MyPatients().GoTo();
                }
            }
        }
        public class Inventory
        {
            public static void GoTo()
            {

                // DashboardPage a;

            }
        }
        public class ClinicSettings
        {
            public class BusinessInformation
            {
                public static void GoTo()
                {

                    new BusinessInformationPage().GoTo();
                }
            }
            public class LocationsandRooms
            {
                public static void GoTo()
                {
                    new LocationsandRoomsPage().GoTo();
                }
            }
            public class ClinicBusinessHours
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class ClinicStaff
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class ClinicStaffScheduling
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class ClinicServices
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class SchedulingSettings
            {
                public static void GoTo()
                {
                    new SchedulingSettingsPage().GoTo();
                }
            }
            public class InsuranceInformation
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class BilingInformation
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class FeeSchedule
            {
                public static void GoTo()
                {
                    new FeeSchedulePage().GoTo();

                }
            }
            public class OnBoardingForms
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class ImportPatients
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
            public class InsuranceCompanies
            {
                public static void GoTo()
                {
                    //  new AllClinicPatients().GoTo();
                }
            }
        }
    }
}
