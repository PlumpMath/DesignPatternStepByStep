using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStepByStep
{
    interface ICustomerInterface
    {
         string CustomerName { get; set; }
         string PhoneNumber { get; set; }
         decimal BillAmount { get; set; }
         DateTime BillDate { get; set; }
         string Address { get; set; }
         void Validate();
         ICustomerInterface Clone(); //added an extra method clone.
    }
}
