using System.ComponentModel.DataAnnotations;

namespace MyworkMvc.Models
{
    public class Job 
    {
        [Key]
        public int JobId{get;set;}
        public string imageCompany{get;set;}
        public string nameJob {get;set;}
        public string nameCompany{get; set;}
        public string salary {get ;set ;}
        public string location {get;set; }
    }
}