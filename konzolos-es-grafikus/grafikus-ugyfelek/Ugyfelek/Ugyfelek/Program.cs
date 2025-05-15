using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugyfelek
{
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Customer(string Name, string Email, string Phone) {
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
        }
    }

    class CustomerManager
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public List<Customer> SearchCustomers(string s) { 
            List<Customer> list = new List<Customer>();
            foreach (Customer customer in Customers)
            {
                if (s.Contains(customer.Name) || s.Contains(customer.Email) || s == customer.Phone)
                {
                    list.Add(customer);
                }
            }
            return list;
        }

        public void DeleteCustomer(Customer customer) { 
            Customers.Remove(customer);
        }

        public List<Customer> GetCustomers()
        {
            return Customers;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
