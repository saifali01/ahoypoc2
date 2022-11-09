using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AhoyAssessment.Models
{
    public class RequestData
    {

        public DateTime Todate { get; set; }

        public DateTime Fromdate { get; set; }
        public string SearchTerm { get; set; }
    }

}