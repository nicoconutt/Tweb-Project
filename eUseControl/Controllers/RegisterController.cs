using eUseControl.BussinesLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using eUseControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Controllers
{
   
        // GET: Register
        public class RegisterController : Controller
        {
            // GET: Register
            private readonly ISession _session;
            public RegisterController()
            {
                var bl = new BussinesLogic.BussinesLogic();
                _session = bl.GetSessionBL();
            }

            // GET: Login
            public ActionResult Index()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Index(UserRegister login)
            {
                if (ModelState.IsValid)
                {
                    URegisterData data = new URegisterData
                    {
                        Email = login.Email,
                        Credential = login.Credential,
                        Password = login.Password,
                        LoginIp = Request.UserHostAddress,
                        LoginDataTime = DateTime.Now
                    };

                    var userLogin = _session.UserRegister(data);
                    if (userLogin.Status)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", userLogin.StatusMsg);
                        return View();
                    }
                }

                return View();
            }
        }
 }
