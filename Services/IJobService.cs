using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyworkMvc.Models;
namespace MyworkMvc.Services
{
    public interface IJobService
    {
        public List<Job> GetJobs();
        public Job GetJobById(int jobId);
        public Job AddnewJob(Job jobinput);
        public Job UpdateJob(Job jobinput);
        public bool DeleteJob(int studentId);
          public Job UpdateImages(Job jobInput,String images);
    }
}