﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCore_Conference.Controllers
{
    public class ConferenceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}