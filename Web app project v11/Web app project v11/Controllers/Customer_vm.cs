using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_app_project_v11.Controllers
{
    public class CustomerBase : CustomerAdd
    {
        public CustomerBase()
        {

        }

        [Key]
        public int CustomerId { get; set; }

       
    }
}