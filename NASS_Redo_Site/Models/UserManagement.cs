using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using NASS_Redo_Site.Models;
using System.Web.WebPages;
using System.Diagnostics;

namespace NASS_Redo_Site.Models
{
    public class UserManagement
    {
        //rather than use JOIN
        //for moment will get email id and role id and search the claims to see if exists with both
        public static bool IsInRole(string useremail, string role)
        {
            var ctx = new NASS_RedoContext();
            var userid = ctx.AspNetUsers.FromSqlRaw("SELECT Id FROM AspNetUsers WHERE Email = " + useremail).First();
            var roleid = ctx.AspNetRoles.FromSqlRaw("SELECT Id FROM AspNetRoles WHERE Name = " + role).First();

            Debug.WriteLine("User: " + userid);
            Debug.WriteLine("Role: " + roleid);

            return false;
        }

    }
}
