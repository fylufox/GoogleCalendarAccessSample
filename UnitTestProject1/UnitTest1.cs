using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoogleCalendarAccess;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sa_service = new Serviceaccount("CalendarLiblaryTest", Serviceaccount.Access.FULLACCSESS, "./Auth/ServiceAccount.json");
            Serviceaccount.ReadingRequest request = new GoogleCalendar.ReadingRequest();
            request.calendar_id = "nndevelop1999@gmail.com";
            request.number_of_event = 10;

            var c = sa_service.GetEventList(request);
            foreach(var item in c)
            {
                Console.WriteLine(item.summary);
            }

            var auth_service = new Myaccount("calendarLibraryTest", Myaccount.Access.FULLACCSESS, "./Auth/OAuth.json");
            c = auth_service.GetEventList(request);
            foreach (var item in c)
            {
                Console.WriteLine(item.summary);
            }
            var co = auth_service.GetColorList();
        }
    }
}
