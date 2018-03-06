using System;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Moq;
using ThamesWater.api.Controllers;
using ThamesWater.CustomActionResults;
using ThamesWater.mocks;
using Xunit;

namespace Tests
{
    public class WhenRequestingAListOfJobs
    {
        [Fact]
        public  void TestGetAll()
        {
            var controller = new JobController();

            var result = controller.GetJobs();

            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;

            var response = okResult.Value.Should().BeAssignableTo<Halcyon.HAL.HALResponse>().Subject;
            
            
            var value = okResult.StatusCode.Should().Be(200);

        }
        
        
        
    }
    
    public class WhenRequestingAJob
    {
        [Fact]
        public  void AfterUpdatingStatusToCalled()
        {
            
            var controller = new JobController();
            var context = new Mock<ControllerContext>();
            var request = new Mock<RequestDelegate>();
            
            controller.ControllerContext = context.Object;
            
            
            var result = controller.CallCustomer("213321132") ;

            var redirectResult = result.Should().BeOfType<SeeOtherActionResult>().Subject;

            

        }
        
        [Fact]
        public  void GetAJobWithANextActionAndWorkQueue()
        {
            var controller = new JobController();
            var context = new Mock<ControllerContext>();
           
            
            controller.ControllerContext = context.Object;

            var result = controller.GetJob(JobMocks.ReturnPollutionIncidentCompleted().Id,"2");

            var okObjectResult = result.Should().BeOfType<OkObjectResult>().Subject;
         
            var response = okObjectResult.Value.Should().BeAssignableTo<Halcyon.HAL.HALResponse>().Subject;

            response.HasLink("next_action").Should().BeTrue();

            response.HasLink("work_queue").Should().BeTrue();
        }
        
        [Fact]
        public  void GetAJobWithNoNextActionAndWorkQueue()
        {
            var controller = new JobController();

            var result = controller.GetJob(JobMocks.ReturnPollutionIncidentCompleted().Id,"12");

            var okObjectResult = result.Should().BeOfType<OkObjectResult>().Subject;
         
            var response = okObjectResult.Value.Should().BeAssignableTo<Halcyon.HAL.HALResponse>().Subject;

            response.HasLink("next_action").Should().BeFalse();

            response.HasLink("work_queue").Should().BeTrue();
        }
        
        
    }
} 