using System.Collections.Generic;
using Halcyon.HAL;
using Microsoft.AspNetCore.Mvc;

namespace ThamesWater.api.Controllers
{
    [Route("api/foo")]
    public class FooController : Controller {

        
        [HttpGet("{fooId:int}/bars")]
        public IActionResult GetBar(int fooId) {
            // A collection of bars related to foo
            var bars = new List<object> {
                new { id = 1, fooId = fooId, type = "bar" },
                new { id = 2, fooId = fooId, type = "bar" }
            };

            // data about the bars related to foo
            var fooBarModel = new {
                fooId = fooId,
                count = bars.Count
            };

            // Return a fooBar resource with embedded bars
            var response = new HALResponse(fooBarModel)
                .AddLinks(new Link[] {
                    new Link("self", "/api/foo/{fooId}/bar")
                })
                .AddEmbeddedCollection("bars", bars, new Link[] {
                    new Link("self", "/api/bar/{id}")
                });

            return this.Ok(response);
        }
    }
}
