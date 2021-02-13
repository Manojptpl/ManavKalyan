using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManavKalyanSevaSamiti.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string User_Password { get; set; }
        public string Confirm_Password { get; set; }
        public string Email_ID { get; set; }        
    }
}