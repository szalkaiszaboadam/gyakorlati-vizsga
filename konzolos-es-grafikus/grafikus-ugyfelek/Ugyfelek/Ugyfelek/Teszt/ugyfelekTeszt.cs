using NUnit.Framework;
using Ugyfelek;

namespace ugyfelekTeszt
{
    [TestFixture]
    public class Tesztek
    {     
        private CustomerManager ugy;

        [SetUp]
        public void SetUp()
        {   
             ugy = new CustomerManager();
        }


        [TestCase]
        public void AddCustomerTest()
        {
            Customer customer = new Customer("Pista", "kukac", "1234");
            ugy.AddCustomer(customer);

        }

        [TestCase]
        public void SearchCustomersTeszt()
        {
            ugy.SearchCustomers("Pista");

        }

        [TestCase]
        public void DeleteCustomerTeszt()
        {
            Customer customer = new Customer("Pista", "kukac", "1234");

            ugy.AddCustomer(customer);
            ugy.DeleteCustomer(customer);

            


        }


        [TestCase]
        public void GetCustomersTeszt()
        {
            ugy.GetCustomers();

        }
    }
}