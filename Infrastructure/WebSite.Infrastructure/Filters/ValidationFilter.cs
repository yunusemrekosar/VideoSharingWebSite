using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Featurs.Commands.CreateUser;
using WebSite.Application.ITablesRepositories.IUserRepository;

namespace WebSite.Infrastructure.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        readonly IUserRead _userRead;
        readonly IUserWrite _userWrite;

        public ValidationFilter(IUserWrite userWrite, IUserRead userRead)
        {
            _userWrite = userWrite;
            _userRead = userRead;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState
                    .Where(x => x.Value.Errors.Any())
                    .ToDictionary(x => x.Key, a => a.Value.Errors.Select(e => e.ErrorMessage))
                    .ToArray();

                context.Result = new BadRequestObjectResult(errors);
                return;
            }
            await next();
        }
    }
}
