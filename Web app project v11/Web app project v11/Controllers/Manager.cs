using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;
using Web_app_project_v11.Models;

namespace Web_app_project_v11.Controllers
{
    public class Manager
    {
        // Reference to the data context
        private DataContext ds = new DataContext();

        public Manager()
        {
            // If necessary, add constructor code here
        }

        // Add methods below
        // Controllers will call these methods
        // Ensure that the methods accept and deliver ONLY view model objects and collections
        // The collection return type is almost always IEnumerable<T>

        // Suggested naming convention: Entity + task/action
        // For example:
        // ProductGetAll()
        // ProductGetById()
        // ProductAdd()
        // ProductEdit()
        // ProductDelete()

        public IEnumerable<CustomerBase> CustomerGetAll()
        {
            var customers = ds.Customers;
            return Mapper.Map<IEnumerable<CustomerBase>>(customers);
        }

        public CustomerBase CustomerGetById(int id)
        {
            var customer = ds.Customers.Find(id);

            return (customer == null) ? null : Mapper.Map<CustomerBase>(customer);
        }

<<<<<<< HEAD
        public CustomerBase CustomerAdd(CustomerAdd newCustomer)
        {
            var addedCustomer = ds.Customers.Add(Mapper.Map<Customer>(newCustomer));
            ds.SaveChanges();

            return (addedCustomer == null) ? null : Mapper.Map<CustomerBase>(addedCustomer);
        }

=======
>>>>>>> 784cf35933bec011f9dfc3ff0388ea983da893b5
    }
}