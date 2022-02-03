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

        //This method was not in the blog post; I've added it
        public Customer? UpdateCustomer(Customer customer)
        {
            //first, look for customer
            var customerFound = _customerList.FirstOrDefault(c => c.Id == customer.Id);
            if (customerFound == null)
            { return null; }

            customerFound.FirstName = customer.FirstName;
            customerFound.LastName = customer.LastName;
            customerFound.Age = customer.Age;

            return customerFound;
        }
    }
}
