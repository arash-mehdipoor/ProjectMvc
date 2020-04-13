using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Application;
using Project.Data.Context;
using Project.Data;
using Project.Domin;
using System.Web.Security;
namespace ProjecMvcUI.Controllers
{
    public class AccountController : Controller
    {
        private Pro_DBEntitis db = new Pro_DBEntitis();
        private IUserRepository userRepository;

        public AccountController()
        {
            userRepository = new UserRepository(db);
        }
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                if (!db.Users.Any(u => u.Email == register.Email && u.PhonNumber == register.PhonNumber))
                {
                    var Hashpass = FormsAuthentication.HashPasswordForStoringInConfigFile(register.Password, "MD5");
                    User user = new User()
                    {
                        UserName = register.UserName,
                        Password = Hashpass,
                        ActiveCode = Guid.NewGuid().ToString(),
                        RoleID = 2,
                        RegisterDate = DateTime.Now,
                        IsActive = false,
                        Email = register.Email,
                        PhonNumber = register.PhonNumber,
                    };
                    userRepository.AddUser(user);
                    userRepository.save();
                    return Redirect("/");
                }
            }
            else
            {
                ModelState.AddModelError("UserName", "لطفا اطلاعات را درست وارد نمایید");
            }

            return View(register);
        }
    }
}