using System.Collections.Generic;
using System.Net;
using Halcyon.HAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ThamesWater.mocks;
using ThamesWater.Services;

namespace ThamesWater.api.Controllers
{
    [Route("jobs")]
    public class JobController : Controller
    {
        private readonly ILogger _logger;

        public JobController(ILogger<JobController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetJobs()
        {
            _logger.LogInformation("Getting all jobs for.....");
            var queue = JobService.GetWorkQueue();
            var links = new[]
            {
                new Link("self", "/jobs")
            };
            var nextJoblinks = new[]
            {

                new Link("next_action","/jobs/"+queue.NextJob.Id+"/start","Start", WebRequestMethods.Http.Put)

            };

            var response = new HALResponse(null)
                           .AddLinks(links)
                           .AddEmbeddedResource("next_job", queue.NextJob, nextJoblinks)
                           .AddEmbeddedCollection("jobs", queue.Queue);

            return Ok(response);
        }

        [HttpGet("{jobNumber}")]
        public IActionResult GetJob(string jobNumber, string status)
        {
            var links = new List<Link>();

            var job = JobMocks.ReturnPriority1BlockageInvestigationNotStartedJob();

            if (status == null)
            {

                links.Add( new Link("next_action", "/jobs/"+job.Id+"/call_customer","Call Customer",WebRequestMethods.Http.Put));


            }

            if (status != null && status.Equals("1"))
            {

                job = JobMocks.ReturnPriority1BlockageInvestigationNotStartedJob();
                links.Add( new Link("next_action", "/jobs/"+job.Id+"/call_customer","Call Customer",WebRequestMethods.Http.Put));

            }

            if (status != null && status.Equals("2"))
            {

                job = JobMocks.ReturnPriority1BlockageInvestigationCustomerCalledJob();
                links.Add( new Link("next_action", "/jobs/"+job.Id+"/start_travel","Start Travel",WebRequestMethods.Http.Put));

            }

            if (status != null && status.Equals("3"))
            {

                job = JobMocks.ReturnPriority1BlockageInvestigationCustomerCalledJob();
                links.Add( new Link("next_action", "/jobs/"+job.Id+"/arrived","Arrived",WebRequestMethods.Http.Put));

            }

            if (status != null && status.Equals("4"))
            {

                job = JobMocks.ReturnPriority1BlockageInvestigationCustomerCalledJob();
                links.Add( new Link("next_action", "/jobs/"+job.Id+"/arrived","Arrived",WebRequestMethods.Http.Put));

            }

            links.Add(new Link("self", $"/jobs/{job.Id}"));
            links.Add(new Link("work_queue", "/jobs"));
            var response = new HALResponse(job).AddLinks(links);

            return Ok(response);
        }

        [HttpPut("{jobNumber}/call_customer")]
        public IActionResult CallCustomer(string jobNumber, string status)
        {
            return Redirect($"/jobs/{jobNumber}?status=2");
        }
        
        [HttpPut("{jobNumber}/start_travel")]
        public IActionResult StartTravel(string jobNumber, string status)
        {
            return Redirect($"/jobs/{jobNumber}?status=3");
        }
        
        [HttpPut("{jobNumber}/start")]
        public IActionResult StartJob(string jobNumber, string status)
        {
            _logger.LogInformation("Starting job {jobNumber}", jobNumber);
            return Redirect($"/jobs/{jobNumber}?status=1");
        }
        
        
    }
    
    
    
    
}
