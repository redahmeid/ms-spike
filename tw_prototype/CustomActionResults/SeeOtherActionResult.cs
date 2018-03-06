using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xunit.Sdk;

namespace ThamesWater.CustomActionResults
{
    public class SeeOtherActionResult:IActionResult
    {
        
        private string _url;
 
        public SeeOtherActionResult(string url)
        {
            _url = url;
        }
        
        
        public async Task ExecuteResultAsync(ActionContext context)
        {
            
            
            var result = new ObjectResult(null)
            {
                StatusCode = (int)HttpStatusCode.SeeOther
            };

           


            await result.ExecuteResultAsync(context);
        }

        
    }
}