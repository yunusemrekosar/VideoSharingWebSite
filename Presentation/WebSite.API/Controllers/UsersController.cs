using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebSite.Application.Featurs.Commands.CreateUser;
using WebSite.Application.Featurs.Commands.UpdateUser;
using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Domain.Entities;
using System.Linq;
using WebSite.Application.Featurs.Commands.LoginUser;
using WebSite.Application.Abstractions.StorageAbs;
using Microsoft.AspNetCore.Authorization;

namespace WebSite.API.Controllers
{
    [Authorize(AuthenticationSchemes = "user")]
    [Route("api/[controller]")]
    [ApiController]
    public class usersController : ControllerBase
    {
        readonly IStorageService _storageService;
        readonly IUserRead _UserRead;
        readonly IUserWrite _UserWrite;
        readonly IMediator _MediatR;
        public usersController(IUserRead UserRead, IUserWrite UserWrite, IMediator mediatR, IStorageService storageService)
        {
            _UserRead = UserRead;
            _UserWrite = UserWrite;
            _MediatR = mediatR;
            _storageService = storageService;
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

    }
}
