using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebSite.Application.Featurs.Commands.CreateUser;
using WebSite.Application.Featurs.Commands.UpdateUser;
using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Domain.Entities;
using System.Linq;
using WebSite.Application.Featurs.Commands.LoginUser;

namespace WebSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usersController : ControllerBase
    {
        private readonly IUserRead _UserRead;
        private readonly IUserWrite _UserWrite;
        readonly IMediator _MediatR;
        public usersController(IUserRead UserRead, IUserWrite UserWrite, IMediator mediatR)
        {
            _UserRead = UserRead;
            _UserWrite = UserWrite;
            _MediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Ok(_UserRead.GetAll(false));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            return Ok(await _UserRead.GetByIdAsync(id, false));
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

        [HttpPut]
        public async Task<IActionResult> Put(UpdateUserCommandRequest request)
        {
            UpdateUserCommandResponse response = await _MediatR.Send(request); // await _MediatR.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _UserWrite.RemoveByIdAsync(id);
            await _UserWrite.SaveAsync();
            return StatusCode((int)HttpStatusCode.OK);
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
    }
}
