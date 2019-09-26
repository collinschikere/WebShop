using COLLINSWEBSHOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COLLINSWEBSHOOP.Pages.Management
{
    public partial class ManageproductTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductTypeModel model = new ProductTypeModel();
            productType pt = CreateproductType();

            lblResult.Text = model.InsertproductType(pt);
        }

        private productType CreateproductType()
        {
            productType p = new productType();
            p.Name = txtName.Text;
            return p;
        }
    }
}