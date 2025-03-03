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
                new StudyGroupMember { StudentNumber = 24987230, Name = "Eliocy", Surname = "Mugabe", EmailAddress = "john.doe@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 23530325, Name = "Anke", Surname = "Hood", EmailAddress = "jane.doe@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 22566521, Name = "Liya", Surname = "Smith", EmailAddress = "mark.smith@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 22738241, Name = "Xolani", Surname = "Johnson", EmailAddress = "sarah.johnson@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 22558307, Name = "Emily", Surname = "Brown", EmailAddress = "emily.brown@tuks.co.za" },
            };
            return View("Index", members);
        }
    }
}