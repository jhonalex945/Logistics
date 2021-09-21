﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public BaseController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
    }
}
