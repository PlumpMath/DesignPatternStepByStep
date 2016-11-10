using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DesignPatternStepByStep
{
    public static class Factory<anytype>
    {
        static IUnityContainer container = null;

        public static anytype Create(string type)
        {
            if (container == null)
            {
                container = new UnityContainer();
                container.RegisterType<ICustomerInterface, Customer = "">("Customer",
                    new InjectionConstructor(new CustomerAllValidation()));
                container.RegisterType< ICustomerInterface, Customer = "" > ("Customer",
                    new InjectionConstructor(new LeadValidation()));
            }
            return container.Resolve<anytype>(type.ToString());
        }
    }
}
