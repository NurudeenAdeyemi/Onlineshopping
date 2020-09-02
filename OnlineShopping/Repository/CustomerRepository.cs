using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping.Models;

namespace OnlineShopping.Repository
{
    public class CustomerRepository: ICustomerRepository
    {

        private ShoppingContext  database = new ShoppingContext();

        public List<Customer> GetAll()
        {
            return database.Customers.ToList();
        }

        public bool Create(string firstName, string lastName, string phone, string email, string address)
        {
            var customer = new Customer
            {
                Email = email,
                Address = address,
                FirstName = firstName,
                LastName = lastName,
                Phone = phone
            };
            database.Customers.Add(customer);
            database.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var customer = new Customer
            {
                Id = id
            };
            database.Customers.Remove(customer);
            database.SaveChanges();
            return true;
        }

        public Customer FindById(int id)
        {

            return database.Customers.Find(id);

        }

        public Customer FindByEmail(string email)
        {
            return database.Customers.First(c => c.Email == email);
        }

        public bool Update(int id, string firstName, string lastName, string phone, string email, string address)
        {
            var customer = database.Customers.Find(id);
            if (customer == null)
            {
                return false;
            }
            else
            {
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.Email = email;
                customer.Phone = phone;
                customer.Address = address;
            }
            
            database.Customers.Update(customer);
            database.SaveChanges();
            return true;
        }
    }
}
