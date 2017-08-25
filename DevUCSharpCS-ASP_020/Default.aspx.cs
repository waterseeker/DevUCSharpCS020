using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_020
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState.Add("MyValue", "Bob");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string value = ViewState["MyValue"].ToString();
            resultLabel.Text = value;
        }
    }
}