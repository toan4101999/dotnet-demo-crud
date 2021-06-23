using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyworkMvc.Models;
namespace MyworkMvc.Services {
    public class JobService : IJobService 
    {
         private readonly DataContext _context;
            public JobService(DataContext context)
        {
            _context = context;
        }
        
        public Job AddnewJob(Job jobInput)
        {
            _context.Add(jobInput);
            _context.SaveChanges();
            return jobInput;
        }

        public bool DeleteJob(int jobId)
        {
            var student = GetJobById(jobId);
            _context.Remove(student);
            _context.SaveChanges();
            return true;
        }

        public Job GetJobById(int jobId)
        {
            return _context.Jobs.FirstOrDefault(s => s.JobId == jobId);
        }

        public List<Job> GetJobs()
        {
            return _context.Jobs.ToList();
        }

        public Job UpdateJob(Job jobInput)
        {
            var job = GetJobById(jobInput.JobId);
            job.nameJob=jobInput.nameJob;
            job.nameCompany=jobInput.nameCompany;
            job.salary=jobInput.salary;
            job.location=jobInput.location;
            _context.SaveChanges();
            return job;
        }
        public Job UpdateImages(Job jobInput,String images)
        {
            var job = GetJobById(jobInput.JobId);
            job.imageCompany=images;
            _context.SaveChanges();
            return job;
        }
    }
}