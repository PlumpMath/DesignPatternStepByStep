using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStepByStep
{
    class FactoryCustomer
    {
        private List<ICustomerInterface> customers = new List<ICustomerInterface>();
        public FactoryCustomer()
        {
            customers.Add(new Lead());
            customers.Add(new Customer());
        }
        public ICustomerInterface Create(int CustomerType)
        {
            return customers[CustomerType];
        }
    }
}
