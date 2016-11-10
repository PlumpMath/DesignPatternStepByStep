using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStepByStep
{
    public interface IValidationStrategy<anytype>
    {
        void Validate(anytype obj);
    }

    public class CustomerAllValidation : IValidationStrategy<ICustomerInterface>
    {
        public void Validate(ICustomerInterface obj)
        {
            if (obj.CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
            if (obj.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
            if (obj.BillAmount == 0)
            {
                throw new Exception("Bill Amount is required");
            }
            if (obj.BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date  is not proper");
            }
        }
    

    public class LeadValidation : IValidationStrategy<ICustomerInterface>
    {
        public void Validate(ICustomerInterface obj)
        {
            if (obj.CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
            if (obj.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
        }
    }

}
