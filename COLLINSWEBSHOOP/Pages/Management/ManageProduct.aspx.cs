using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COLLINSWEBSHOOP.Pages.Management
{
    public partial class ManageProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetImage();
        }
        private void GetImage()
        {
            try
            {
                //Get all filepaths
                string[] images = Directory.GetFiles(Server.MapPath("~/Images/Product/"));

                //Get all filenames and add them to an arraylist
                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {
                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }
                //set the arrayList as the dropdownview's datasource and refresh
                ddlImage.DataSource = imageList;
                ddlImage.AppendDataBoundItems = true;
                ddlImage.DataBind();
            }
            catch(Exception e)
            {
                lblResult.Text = e.ToString();
            }
        }
        private product CreateProduct()
        {
            product product = new product();

            product.Name = txtName.Text;
            product.price = Convert.ToDouble(txtPrice.Text);
            product.TypeId = Convert.ToInt32(ddlType.SelectedValue);
            product.Description = txtDescription.Text;
            product.Image = ddlImage.SelectedValue;

            return product;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            productModel productModel = new ProductModel();
            product product = CreateProduct();

            lblResult.Text = productModel.InsertProduct(product);

        }
    }
}