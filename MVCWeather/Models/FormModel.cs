using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCWeather.Models
{
    public class FormModel
    {
        [DisplayName("city Name")]
        public string cityName { get; set; }
    }
}