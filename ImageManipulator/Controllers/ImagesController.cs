using ImageManipulator.Models.Request;
using ImageManipulator.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageManipulator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
        private readonly ILogger<ImagesController> _logger;

        public ImagesController(ILogger<ImagesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<ProcessedResponseModel>> ProcessAsync(ProcessingRequestModel model)
        {
            // Need to FiltersManager here (better to inject) in which I will have
            // the processing one by one so each time we have a new plugin, we just need 
            // to implement IFIlter and IPlugin

            return new ProcessedResponseModel
            {
                ImageString = model.ImageString,
            };
        }
    }
}
