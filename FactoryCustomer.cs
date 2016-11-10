using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DesignPatternStepByStep
{
    public static class FactoryCustomer
    {
        private static IUnityContainer cont = null;

        public FactoryCustomer()
        {
            cont = new UnityContainer();
            cont.RegisterType<ICustomerInterface, Lead="">("0");
            cont.RegisterType<ICustomerInterface, Customer="" > ("1");
        }

        public static ICustomerInterface Create(int CustomerType)
        {
            return cont.Resolve<ICustomerInterface>(CustomerType.ToString());
        }
    }
}
