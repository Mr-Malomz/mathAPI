using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mathAPI.NetCore.Models
{
    public class Response
    {
        public string Status { get; set; }

        public string Description { get; set; }

        public dynamic Data { get; set; }
    }
}
