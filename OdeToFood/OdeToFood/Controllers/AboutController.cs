using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    //about
    [Route("company/[controller]/[action]")]
    public class AboutController{
        public string Phone() {
            return "133133133";
        }
        public string Address() {
            return "USA";
        }
    }
} 
