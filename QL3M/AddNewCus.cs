using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QL3M
{
    public partial class AddNewCus : DevExpress.XtraEditors.XtraForm
    {
        private bool isUpdate = false;
        

        public AddNewCus(int _cusID)
        {
            if (_cusID == -1)
                isUpdate = false;
            else isUpdate = true;
            InitializeComponent();
        }

        private void BindData()
        {
            if(isUpdate)
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(isUpdate)
            {

            }
            else
            {
                Customer customer = new Customer();
                customer.CusName = tbxName.Text;
                customer.CusCompanyName = tbxCompanyName.Text;
                customer.CusAddress = tbxAddress.Text;
                customer.CusAddressOffice = tbxAddressOffice.Text;
                customer.CusPhone = tbxPhone.Text;
                customer.CusTaxCode = tbxTaxCode.Text;
                customer.Buyer = chkBuy.Checked;
                customer.Seller = chkSell.Checked;
                customer.Description = tbxDes.Text;
                customer.Status = 1;
                customer.IsDeleted = false;
            }
        }
    }
}