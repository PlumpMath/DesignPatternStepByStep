using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStepByStep
{
    public static class FactoryCustomer
    {
        private static List<ICustomerInterface> customers = null;


        private static void LoadCustomers()
        {
            customers = new List<ICustomerInterface>();
            customers.Add(new Lead());
            customers.Add(new Customer());
        }

        public static ICustomerInterface Create(int CustomerType)
        {
            if (customers == null)
            {
                LoadCustomers();
            }
            return customers[CustomerType];
        }
    }
}
