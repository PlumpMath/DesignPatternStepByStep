using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternStepByStep
{
    public partial class WindowLibrary : Form
    {
        public WindowLibrary()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
{
            ICustomerInterface custbase = null;
            custbase = FactoryCustomer.Create(cmbCustomerType.SelectedIndex);
            custbase.CustomerName = txtCustomerName.Text;
            custbase.Address = txtAddress.Text;
            custbase.PhoneNumber = txtPhoneNumber.Text;
            custbase.BillDate = Convert.ToDateTime(txtBillingDate.Text);
            custbase.BillAmount = Convert.ToDecimal(txtBillingAmount.Text);
}
    }
}
