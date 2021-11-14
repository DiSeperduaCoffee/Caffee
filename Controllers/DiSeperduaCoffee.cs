using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DiSeperduaCoffee.Models;
using Microsoft.AspNetCore.Identity;
using DiSeperduaCoffee.Data;


namespace DiSeperduaCoffee.Controllers
{

    public class DiSeperduaCoffeeController : Controller
    {
      
         public IActionResult Index()
        {
            return View();
        }
          public IActionResult Pengguna()
        {
            return View();
        }
    }
}