
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Halcyon.HAL;
using com.thameswater.Models;
using Halcyon.WebApi.HAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tests.mocks;
using tw_prototype.Services;


namespace com.thameswater.api.Controllers
{
    [Route("/jobs")]
    public class JobController : Controller
    {
        private readonly ILogger _logger;

        public JobController(ILogger<JobController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult getJobs()
        {


            _logger.LogInformation("Getting all jobs for.....");
            WorkQueue queue = JobService.getWorkQueue();
            Link[] links =
            {
                new Link("self","/jobs")
            };
            Link[] nextJoblinks =
            {
                new Link("start_job","/jobs/"+queue.nextJob.Id+"/start","Start", WebRequestMethods.Http.Put)
            };
            
            var response = new HALResponse(null)
                .AddLinks(links)
                .AddEmbeddedResource("next_job",queue.nextJob,nextJoblinks)
                .AddEmbeddedCollection("jobs",queue.queue);
            
            
            return this.Ok(response);
        }

        [HttpGet("{jobNumber}")]
        public IActionResult getJob(string jobNumber, string status)
        {

            
            
            List<Link> links = new List<Link>();
            

            Job job = job = JobMocks.returnPriority1BlockageInvestigationNotStartedJob();

            if (status == null)
            {
                links.Add( new Link("call_customer", "/jobs/"+job.Id+"/call_customer","Call Customer",WebRequestMethods.Http.Put));
            }
            
            if (status!=null&&status.Equals("1"))
            {
                job = JobMocks.returnPriority1BlockageInvestigationNotStartedJob();
                links.Add( new Link("call_customer", "/jobs/"+job.Id+"/call_customer","Call Customer",WebRequestMethods.Http.Put));
            }

            if (status!=null&&status.Equals("2"))
            {
                job = JobMocks.returnPriority1BlockageInvestigationCustomerCalledJob();
                links.Add( new Link("start_travel", "/jobs/"+job.Id+"/start_travel","Start Travel",WebRequestMethods.Http.Put));
            }
            
            if (status!=null&&status.Equals("3"))
            {
                job = JobMocks.returnPriority1BlockageInvestigationCustomerCalledJob();
                links.Add( new Link("arrived", "/jobs/"+job.Id+"/arrived","Arrived",WebRequestMethods.Http.Put));
            }
            if (status!=null&&status.Equals("4"))
            {
                job = JobMocks.returnPriority1BlockageInvestigationCustomerCalledJob();
                links.Add( new Link("arrived", "/jobs/"+job.Id+"/arrived","Arrived",WebRequestMethods.Http.Put));
            }
            
            links.Add(  new Link("self", "/jobs/"+job.Id));
            links.Add(  new Link("work_queue", "/jobs"));
            var response = new HALResponse(job).AddLinks(links);
            
            
            return Ok(response);
        }
        
        
        [HttpPut("{jobNumber}/call_customer")]
        public IActionResult callCustomer(string jobNumber, string status)
        {
            return Redirect("/jobs/"+jobNumber+"?status=2");
        }
        
        [HttpPut("{jobNumber}/start_travel")]
        public IActionResult startTravel(string jobNumber, string status)
        {
            return Redirect("/jobs/"+jobNumber+"?status=3");
        }
        
        [HttpPut("{jobNumber}/start")]
        public IActionResult startJob(string jobNumber, string status)
        {
            _logger.LogInformation("Starting job {jobNumber}",jobNumber);
            return Redirect("/jobs/"+jobNumber+"?status=1");
        }
        
        
    }
    
    
    
    
}
