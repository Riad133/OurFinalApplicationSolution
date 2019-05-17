using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.RequestResponse.RequestViewModel
{
    public class RegistrationRequestViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
       
    }
}
