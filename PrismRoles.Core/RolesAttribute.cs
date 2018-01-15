﻿using System;

namespace PrismRoles.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class RolesAttribute : Attribute
    {
        public string[] Roles { get; set; }

        public RolesAttribute(params string[] roles)
        {
            Roles = roles;
        }
    }
}
