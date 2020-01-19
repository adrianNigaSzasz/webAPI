using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public ErrorController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        [Route("/error-development")]
        public IActionResult ErrorLocalDevelopment()
        {
            if (this.webHostEnvironment.EnvironmentName != "Development")
            {
                throw new InvalidOperationException(
                    "This shouldn't be invoked in non-development environments.");
            }

            var context = this.HttpContext.Features.Get<IExceptionHandlerFeature>();

            return this.Problem(
                detail: context.Error.StackTrace,
                title: context.Error.Message);
        }

        // GET: api/Error/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }


        [Route("/error")]
        public IActionResult Error() => this.Problem();
    }
}
