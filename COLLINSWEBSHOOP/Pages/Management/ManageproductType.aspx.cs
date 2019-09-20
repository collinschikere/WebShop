using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COLLINSWEBSHOOP.Pages.Management
{
    public partial class ManageproductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bntSubmit_Click(object sender, EventArgs e)
        {
            Product_TypeModel model= new product_TypeModel();
            Product_Type pt = createProductType();

            lblResult.Text = model.InsertproductType(pt);
            
                
        }
        private Product_Type createProductType()
        {
            Product_Type p = new Product_Type();
            p.Name = txtName.Text;
            return p;
        }

    }

    internal class product_TypeModel
    {
        public product_TypeModel()
        {
        }
    }
}