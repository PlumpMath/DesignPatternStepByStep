using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStepByStep
{
    public static class FactoryCustomer
    {
        private static List<ICustomerInterface> customers = new List<ICustomerInterface>();
        static FactoryCustomer()
        {
            customers.Add(new Lead());
            customers.Add(new Customer());
        }
        public static ICustomerInterface Create(int CustomerType)
        {
            return customers[CustomerType];
        }
    }
}
