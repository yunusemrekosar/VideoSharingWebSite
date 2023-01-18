using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Application.ViewModels;
using WebSite.Domain.Entities;


namespace WebSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usersController : ControllerBase
    {
        private readonly IUserRead _UserRead;
        private readonly IUserWrite _UserWrite;
        public usersController(IUserRead UserRead, IUserWrite UserWrite)
        {
            _UserRead = UserRead;
            _UserWrite = UserWrite;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() //ı dont know ı need this when done check
        {
            return Ok(_UserRead.GetAll(false));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            return Ok(await _UserRead.GetByIdAsync(id, false));

        }

        [HttpPost]
        public async Task<IActionResult> Post(VMUserPost model)
        {
            await _UserWrite.AddAsync(new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password,
                TelNumber = model.TelNumber,
                Address = model.Address,
                Country = model.Country,
                City = model.City,
                UserName = model.UserName,
                DateOfBirth = model.DateOfBirth,
                MemberIsWomen = model.MemberIsWomen,
                ProfilePhoto = model.ProfilePhoto,
                IsActive =model.IsActive
            });
            await _UserWrite.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(VMUserPost model)
        {
            User user = await _UserRead.GetByIdAsync(model.Id);
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.Password = model.Password;
            user.TelNumber = model.TelNumber;
            user.Address = model.Address;
            user.Country = model.Country;
            user.City = model.City;
            user.UserName = model.UserName;
            user.DateOfBirth = model.DateOfBirth;
            user.MemberIsWomen = model.MemberIsWomen;
            user.ProfilePhoto = model.ProfilePhoto;
            await _UserWrite.SaveAsync();
            return StatusCode((int)HttpStatusCode.OK);
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
