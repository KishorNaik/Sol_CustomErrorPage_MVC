﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Custom_Error_Page.Filters
{
    public class HandleExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "ErrorFilter" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(
                    modelMetadata, context.ModelState);
            result.ViewData.Add("HandleException",
                    context.Exception);
            context.Result = result;
            context.ExceptionHandled = true;
        }
    }
}