using Microsoft.AspNetCore.Mvc;
﻿using Microsoft.AspNetCore.Mvc;
using TODO_Correction.ViewModels;
using System.Collections.Generic;
using System.Text.Json;

namespace TODO_Correction.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AuthVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            if (HttpContext.Session.GetString("login") == null)
            {
                if (vm.login == "admin" && vm.password == "admin")
                {
                    HttpContext.Session.SetString("login", vm.login);
                    return RedirectToAction("Add", "Todos");
                }
            }
           
            return RedirectToAction("Index","Auth");

        }


    }
}