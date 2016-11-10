using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStepByStep
{
    public abstract class CustomerBase : ICustomerInterface
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

       // public IValidationStrategy<ICustomerInterface> _ValidationType = null;

        public IValidationStrategy<ICustomerInterface> _ValidationType { get; set; }
        public CustomerBase(IValidationStrategy<ICustomerInterface> validationType)
        {
            this._ValidationType = validationType;
        }
       
        public ICustomerInterface Clone()
        {
           return (ICustomerInterface) this.MemberwiseClone();
        }
    }
    public class Customer : CustomerBase
    {
        public Customer(IValidationStrategy<ICustomerInterface> validationType) : base(validationType)
        {
        }
    }

    public class Lead : CustomerBase
    {
        public Lead(IValidationStrategy<ICustomerInterface> validationType) : base(validationType)
        {
        }
    }
}
