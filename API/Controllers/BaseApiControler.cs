using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]//ścieżka do ządan
    public class BaseApiControler : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator =>_mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}