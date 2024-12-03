using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class CustomerDAL
    {
        private readonly BankDataContext db;

        public CustomerDAL()
        {
            db = new BankDataContext(); 
        }

        // Thêm khách hàng
        public bool AddCustomer(Customer customer)
        {
            try
            {
                db.Customers.InsertOnSubmit(customer);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding customer: " + ex.Message);
                return false;
            }
        }

        // Xóa khách hàng
        public bool DeleteCustomer(string customerId)
        {
            try
            {
                var customerToDelete = db.Customers.SingleOrDefault(c => c.customer_id == customerId);
                if (customerToDelete != null)
                {
                    db.Customers.DeleteOnSubmit(customerToDelete);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting customer: " + ex.Message);
                return false;
            }
        }

        // Sửa khách hàng
        public bool UpdateCustomer(Customer updatedCustomer)
        {
            try
            {
                var customerToUpdate = db.Customers.SingleOrDefault(c => c.customer_id == updatedCustomer.customer_id);
                if (customerToUpdate != null)
                {
                    customerToUpdate.credit_score = updatedCustomer.credit_score;
                    customerToUpdate.country = updatedCustomer.country;
                    customerToUpdate.gender = updatedCustomer.gender;
                    customerToUpdate.age = updatedCustomer.age;
                    customerToUpdate.tenure = updatedCustomer.tenure;
                    customerToUpdate.balance = updatedCustomer.balance;
                    customerToUpdate.products_number = updatedCustomer.products_number;
                    customerToUpdate.credit_card = updatedCustomer.credit_card;
                    customerToUpdate.active_member = updatedCustomer.active_member;
                    customerToUpdate.estimated_salary = updatedCustomer.estimated_salary;
                    customerToUpdate.churn = updatedCustomer.churn;

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating customer: " + ex.Message);
                return false;
            }
        }

        // Lấy tất cả khách hàng
        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }
    }
}
