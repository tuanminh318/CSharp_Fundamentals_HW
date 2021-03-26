using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CRUD.Models;
using CRUD.Repository;

namespace CRUD.Controllers
{
    public class MemberController : Controller
    {
        MemberRepository rep = new MemberRepository();
        public ActionResult Index()
        {
            IEnumerable<Member> obj = rep.SelectAllEmployees();
            return View(obj); 
        }
        public ActionResult Details(int id)
        {
            Member obj = rep.SelectMemberById(id);
            return View(obj);
        }

        [Authorize("Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                rep.InsertMember(member);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [Authorize("Admin")]

        public ActionResult Edit(int id)
        {
            Member obj = rep.SelectMemberById(id);
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member member)
        {
            try
            {
                rep.UpdateMember(member);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [Authorize("Admin")]

        public ActionResult Delete(int id)
        {
            Member obj = rep.SelectMemberById(id);
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                rep.DeleteMember(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}