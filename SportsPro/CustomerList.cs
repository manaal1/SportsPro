using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsPro
{
    public class CustomerList
    {
        private List<Customer> objCustomers;

        public int Count()
        {
            return objCustomers.Count;
        }
        public CustomerList() 
        {
            objCustomers = new List<Customer>();
        }
        
        public Customer this[int index]
        {
            get
            {
                return objCustomers[index];
            }
            set
            {
                objCustomers[index] = value;
            }
        }

        public Customer this[string name]
        {
            get
            {
                foreach (Customer c in objCustomers)
                {
                    if (c.Name == name)
                    {
                        return c;
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < objCustomers.Count; i++)
                {
                    if (objCustomers[i].Name == name)
                    {
                        objCustomers[i] = value;
                        return;
                    }
                }
            }
        }

        public static CustomerList GetCustomers()
        {
            return new CustomerList();
        }

        public void AddItem(Customer customer)
        {
            objCustomers.Add(customer);
        }

        public void RemoveAt(int index)
        {
            objCustomers.RemoveAt(index);
        }

        public void Clear()
        {
            objCustomers.Clear();
        }
    }
}