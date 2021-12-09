using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Captcha.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}