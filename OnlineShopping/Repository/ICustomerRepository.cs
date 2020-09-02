using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping.Models;

namespace OnlineShopping.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();

        bool Create(string firstName, string lastName, string phone, string email, string address);

        bool Delete(int id);

        Customer FindById(int id);

        Customer FindByEmail(string email);

        bool Update(int id, string firstName, string lastName, string phone, string email, string address);
    }
}
