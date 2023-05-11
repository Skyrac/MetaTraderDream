using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Default.Utils.Exceptions;


public class WebExceptionFilter : IAsyncExceptionFilter
{
    public Task OnExceptionAsync(ExceptionContext context)
    {
        //Business exception-More generics for external world
        var error = new ErrorDetails()
        {
            StatusCode = 500,
            Message = context.Exception.Message
        };
        //Logs your technical exception with stack trace below

        context.Result = new BadRequestObjectResult(error);
        return Task.CompletedTask;
    }
}
