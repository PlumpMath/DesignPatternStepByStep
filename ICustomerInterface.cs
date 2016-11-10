using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStepByStep
{
    public interface ICustomerInterface
    {
         string CustomerName { get; set; }
         string PhoneNumber { get; set; }
         decimal BillAmount { get; set; }
         DateTime BillDate { get; set; }
         string Address { get; set; }
         ICustomerInterface Clone(); //added an extra method clone.
    }
}
