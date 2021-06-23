using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyworkMvc.Models;
using MyworkMvc.Services;
namespace MyworkMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobService _jobService;

        public HomeController(IJobService jobService)
         {
            _jobService=jobService;
        }
        public IActionResult Index()
        {
           List<Job> jobs = _jobService.GetJobs();
            
           ViewData["Jobs"]=jobs;
           ViewBag.Jobs=jobs;
            return View(jobs);    
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
