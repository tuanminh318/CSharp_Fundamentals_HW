using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CRUD.Service
{
    public class LocationService
    {
        public List<string> ListPlace()
        {
            return new List<string>{
                "Lang Son",

                "Ha Noi",

                "Lao Cai"

            };
        }
    }
}