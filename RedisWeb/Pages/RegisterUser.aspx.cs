using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using PACS.Models;
using Redis.Model;

namespace RedisWeb.Pages
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [WebMethod(EnableSession = true)]
        public dynamic SaveUsers(string Id, string fullName, string email, string username, byte gender,string password)
        {
            email = email.Trim().ToLower();
            fullName = fullName.Trim();
            username = username.Trim().ToLower();
            Result result = new Result();
            result.Errors = new List<ErrorObject>();
            ErrorObject objError = new ErrorObject();
            var kt = true;
            int _id = 0;
            
            result.IsValid = kt;
            using (var db = new registerEntities())
            {
                var lstUser = db.Users.AsNoTracking().ToList();
                User user = new User()
                {
                    UserName = username,
                    Password = password,
                    FullName = fullName,
                    Gender = gender,
                    Gmail = email

                };
                db.Users.Add(user);
                db.SaveChanges();
                result.IsValid = true;
            }
           
            return result;
        }
    }
}