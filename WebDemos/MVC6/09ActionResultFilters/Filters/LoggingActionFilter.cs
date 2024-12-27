using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace _09ActionResultFilters.Filters
{
    public class LoggingActionFilter : IActionFilter
    {
        private Stopwatch _stopWatch;
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopWatch = Stopwatch.StartNew();
            if(context.Controller is Controller controller)
            {
                controller.ViewData["OnActionExecuting"] = "Action Execution Started..";
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopWatch.Stop();
            var time = _stopWatch.ElapsedTicks;
            if(context.Controller is Controller controller)
            {
                controller.ViewData["ElapsedTicks"] =$"Time Taken : {time} ticks";
                controller.ViewData["OnActionExecuted"] = "Action Execution Stopped";
            }
        }
    }
}
