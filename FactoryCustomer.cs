using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStepByStep
{
    public static class FactoryCustomer
    {
        private static Lazy<List<ICustomerInterface>> customers = null;

        public FactoryCustomer()
        {
            customers = new Lazy<List<ICustomerInterface>>(() => LoadCustomers() );
        }
        private List<ICustomerInterface> LoadCustomers()
        {
            List<ICustomerInterface> customers = new List<ICustomerInterface>();
            customers.Add(new Lead());
            customers.Add(new Customer());
            return customers
        }

        public static ICustomerInterface Create(int CustomerType)
        {
            return customers[CustomerType];
        }
    }
}
