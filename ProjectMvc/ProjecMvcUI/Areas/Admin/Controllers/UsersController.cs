using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.Data;
using Project.Domin;
using Project.Data.Context;

namespace ProjecMvcUI.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
       private Pro_DBEntitis db = new Pro_DBEntitis();
       private IUserRepository userRepository;
       private IRoleRepository roleRepository;

        public UsersController()
        {
            userRepository = new UserRepository(db);
            roleRepository = new RoleRepository(db);
        }
        // GET: Admin/Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Roles);
            return View(users.ToList());
        }
        // GET: Admin/Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = userRepository.FindUserId(id.Value);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleID = new SelectList(roleRepository.GetAllRole(), "RoleID", "RoleName", user.RoleID);
            return View(user);
        }

        // POST: Admin/Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,RoleID,UserName,Password,Email,PhonNumber,ActiveCode,IsActive,RegisterDate")] User user)
        {
            if (ModelState.IsValid)
            {
                userRepository.Update(user);
                userRepository.save();
                return RedirectToAction("Index");
            }
            ViewBag.RoleID = new SelectList(roleRepository.GetAllRole(), "RoleID", "RoleName", user.RoleID);
            return View(user);
        }

        // GET: Admin/Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = userRepository.FindUserId(id.Value);
            userRepository.Delete(user);
            userRepository.save();
            return RedirectToAction("Index");


        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
