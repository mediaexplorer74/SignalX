﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XamarinSignalRExample.Server.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public System.Web.Mvc.ActionResult Index()
        {
            return View();
        }
    }
}