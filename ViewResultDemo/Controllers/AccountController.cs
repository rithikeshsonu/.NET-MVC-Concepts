﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewResultDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Dashboard()
        {
            return View();
        }
    }
}