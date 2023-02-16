using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebSite.Application.Abstractions.StorageAbs;
using WebSite.Application.Featurs.Commands.CreateUser;
using WebSite.Application.Featurs.Commands.LoginUser;

namespace WebSite.API.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        readonly IMediator _MediatR;
        readonly IStorageService _storageService;


        public LoginController(IMediator mediator, IStorageService storageService)
        {
            _MediatR = mediator;
            _storageService = storageService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload()
        {
            await _storageService.UploadAsync("testss", Request.Form.Files);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserCommandRequest request)
        {
            LoginUserCommandResponse response = await _MediatR.Send(request);
            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return new BadRequestObjectResult(response.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateUserCommandRequest request)
        {
            CreateUserCommandResponse response = await _MediatR.Send(request);
            if (response.Error is not null)
            {
                return new BadRequestObjectResult(response.Error);
            }
            else
            {
                return Ok(response);
            }
        }
    }
}
