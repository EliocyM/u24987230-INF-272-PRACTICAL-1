using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u24987230_INF_272_PRACTICAL_1.Models;

namespace u24987230_INF_272_PRACTICAL_1.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            var members = new List<StudyGroupMember>
            {
                new StudyGroupMember { StudentNumber = 12345678, Name = "John", Surname = "Doe", EmailAddress = "john.doe@tuks.co.za" };
                new StudyGroupMember { StudentNumber = 23456789, Name = "Jane", Surname = "Doe", EmailAddress = "jane.doe@tuks.co.za" };
                new StudyGroupMember { StudentNumber = 34567890, Name = "Mark", Surname = "Smith", EmailAddress = "mark.smith@tuks.co.za" };
                new StudyGroupMember { StudentNumber = 45678901, Name = "Sarah", Surname = "Johnson", EmailAddress = "sarah.johnson@tuks.co.za" };
                new StudyGroupMember { StudentNumber = 56789012, Name = "Emily", Surname = "Brown", EmailAddress = "emily.brown@tuks.co.za" };
            };
            return View();
        }
    }
}