// SQL2X Generated 
// SQL2X Version: 0.d
// http://sql2x.azurewebsites.net/
// Generated Date: 23.12.2017 12:07:02
// Template ClassName: PrototypeASPNetCoreTemplateWebApplicationWithCrude
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrototypeASPNetCoreTemplateWebApplicationWithCrude.Models;

namespace PrototypeASPNetCoreTemplateWebApplicationWithCrude.Controllers
{
    public class TemplatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexDatabase() {
            return View();
        }
    }
}
