using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBE.Models
{
    public class Policies
    {
        public const string Admin = "Admin";
        public const string User = "User";

        //public static AuthorizationPolicy AdminPolicy()
        //{
        //    //return new AuthorizationPolicyBuilder().re
        //}
    }
}
