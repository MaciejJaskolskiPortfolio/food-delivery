using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApp.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        override public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid && context.HttpContext.Request.Path.StartsWithSegments("/Api", StringComparison.OrdinalIgnoreCase))
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }

        override public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
