using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace CRUD.Filter
{
    public class AuthorizeActionFilter: IAuthorizationFilter
    {
        private readonly string _permission;
        public AuthorizeActionFilter(string permission)
        {
            _permission = permission;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            String role = context.HttpContext.Session.GetString("role");
            if (!isAuthorized(role))
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool isAuthorized(string role)
        {
            if (String.IsNullOrWhiteSpace(role)) return false;
            return role == _permission || role == "Admin";
        }
    }
}