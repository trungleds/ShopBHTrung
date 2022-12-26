﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace DemoWebBanHang.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required (ErrorMessage ="Mời nhập User name")]
        public string UserName { get; set; }

        [Required (ErrorMessage ="Mời nhập password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}