using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class CustomerBLL
    {
        private readonly CustomerDAL customerDAL;

        public CustomerBLL()
        {
            customerDAL = new CustomerDAL();
        }

        public bool AddCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.customer_id))
            {
                throw new System.Exception("Mã khách hàng không được để trống.");
            }
            return customerDAL.AddCustomer(customer);   
        }

        public bool DeleteCustomer(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                throw new System.Exception("Mã khách hàng không được để trống.");
            }
            return customerDAL.DeleteCustomer(customerId);
        }

        public bool UpdateCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.customer_id))
            {
                throw new System.Exception("Mã khách hàng không được để trống.");
            }
            return customerDAL.UpdateCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerDAL.GetAllCustomers();
        }
    }
}
