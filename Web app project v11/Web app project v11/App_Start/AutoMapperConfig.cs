using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;

namespace Web_app_project_v11
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            // Add map creation statements here
            // Mapper.CreateMap< FROM , TO >();

            Mapper.CreateMap<Models.Customer, Controllers.CustomerBase>();
<<<<<<< HEAD
            Mapper.CreateMap<Controllers.CustomerAdd, Models.Customer>();
=======
>>>>>>> 784cf35933bec011f9dfc3ff0388ea983da893b5
        }
    }
}