using MusicApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicApp.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> members = new List<Member>();
        private DbContext _myDbContext;
        //[RequireHttps]
        [HttpPost]
        public ActionResult Create(Member member)
        {
            member.id = DateTime.Now.Millisecond;
            members.Add(member);
            return new JsonResult()
            {
                Data = member
            };
        }
        //[RequireHttps]
        [HttpGet]
        public ActionResult List()
        {
            return new JsonResult()
            {
                Data = members,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
        [HttpPut]
        public ActionResult Update(Member updateMember)
        {

            return new JsonResult()
            {
                Data = updateMember,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
            };
        }
    }
}