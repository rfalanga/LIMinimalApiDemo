using MinimalApi.DataAccess.Interfaces;
using MinimalApi.Model;

namespace MinimalApi.DataAccess
{
    public class CustomerRepository : IRepository
    {
        private readonly List<Customer> _customerList;

        public CustomerRepository()
        {
            _customerList = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "George", LastName = "Jones", Age = 70 },
                new Customer { Id = 2, FirstName = "Bill", LastName = "Smith", Age = 50 },
                new Customer { Id = 3, FirstName = "Juanita", LastName = "Lopez", Age = 35 }
            };
        }
        public List<Customer> GetAllCustomers()
        {
            return _customerList;
        }

        public Customer GetCustomerById(int id)
        {
            var result =  _customerList.SingleOrDefault(c => c.Id == id);

            if (result == null)
            {
                return new Customer();
            }

            return result;
        }
    }
}
