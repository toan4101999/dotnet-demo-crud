using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyworkMvc.Models;
using MyworkMvc.Services;
using System.IO; 
using System.Web;
using Microsoft.AspNetCore.Http;

namespace MyworkMvc.Controllers
{
    public class AdminController : Controller
    {
            private readonly IJobService _jobService;
        public AdminController(IJobService jobService)
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
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit(int jobId)
        {
            var job = _jobService.GetJobById(jobId);
            return View(job);
        }
        
         public IActionResult Delete(int jobId)
        {
            var job = _jobService.DeleteJob(jobId);
             return RedirectToAction("Index");
        }
     
        public IActionResult SaveJob(Job job)
        {
                
                _jobService.AddnewJob(job);
             
            return RedirectToAction("Index");
        }
        public IActionResult SaveUpdateJob(Job job)
        {
           
            _jobService.UpdateJob(job);
             
            return RedirectToAction("Index");
        } 
       
          public IActionResult Upload(int jobId)
{
    var job = _jobService.GetJobById(jobId);
            return View(job);
}

        [HttpPost]

      
      public async Task<IActionResult> UploadFile(IFormFile file,Job job)  
  {  
      if (file == null || file.Length == 0)  
          return Content("file not selected");  
    var fileName = System.IO.Path.GetFileName(file.FileName);
      var path = Path.Combine(  
                  Directory.GetCurrentDirectory(), "wwwroot",   
                  fileName);  
  
      using (var stream = new FileStream(path, FileMode.Create))  
      {  
          await file.CopyToAsync(stream);  
      }  
        _jobService.UpdateImages(job,fileName);
    
            return RedirectToAction("Index");
    
  }  
        
        
        

        
    
}
}