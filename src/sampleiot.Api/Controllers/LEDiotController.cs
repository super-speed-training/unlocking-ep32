using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Devices;

namespace sampleiot.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LEDiotController : ControllerBase
    {
        private string connectionString = "{Your service connection string}";

        [HttpGet]
        public async Task<string> Start()
        {
            var serviceClient = ServiceClient.CreateFromConnectionString(connectionString);    
            try{
                await serviceClient.InvokeDeviceMethodAsync("pisim", new CloudToDeviceMethod("start"));
                return "success";
            }catch{
                return "fail";
            }           
        }

        [HttpGet]
        public async Task<string> Stop()
        {
            var serviceClient = ServiceClient.CreateFromConnectionString(connectionString);    
            try{
                await serviceClient.InvokeDeviceMethodAsync("pisim", new CloudToDeviceMethod("stop"));
                return "success";
            }catch{
                return "fail";
            }           
        }
    }
}
