using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilityControllers.Models
{
    public class ResultDataModel
    {
        public bool success { get; set; }
        public string errorMessage { get; set; }
        public string returnRunno { get; set; }
    }
}