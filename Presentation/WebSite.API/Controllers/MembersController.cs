using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Persistence.Concretes;
using WebSite.Persistence.Concretes.UserRepository;


namespace WebSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IUserRead _UserRead;
        private readonly IUserWrite _UserWrite;
        public MembersController(IUserRead UserRead, IUserWrite UserWrite)
        {
            _UserRead = UserRead;
            _UserWrite = UserWrite;
        }

        [HttpGet]
        public async void Getall()
        {
            await _UserWrite.AddRangeAsync(new()
            {
                new() { Email ="ddds@gmail.com", FirstName = " ıedjıdf", IsActive= true, CreatedDate= DateTime.Now, DateOfBirth= DateTime.Now, LastName = "dd", Password= "dfdfd", MemberIsWomen =false , TelNumber = "12345678912" , UpdatedDate = DateTime.Now,  UserName = " fdkfdkkfdsmkf" }
            });
            var c = await _UserWrite.SaveAsync(); 

        }

    }
}
