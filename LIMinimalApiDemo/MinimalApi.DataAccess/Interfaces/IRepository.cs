using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalApi.Model;

namespace MinimalApi.DataAccess.Interfaces
{
    public interface IRepository
    {
        public List<Customer> GetAllCustomers();

        public Customer GetCustomerById(int id);

        public Customer? UpdateCustomer(Customer customer);

        public bool DeleteCustomerById(int id);
    }
}
