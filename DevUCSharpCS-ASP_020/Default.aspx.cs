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
                ViewState.Add("MyValue", "");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //takes whatever is already stored in MyValue
            string value = ViewState["MyValue"].ToString();
            //adds whatever is in the valueTextBox and a space
            value += valueTextBox.Text + " ";
            //sets the new value of.. uh value to MyValue
            ViewState["MyValue"] = value;
            //outputs the new value to the resultLabel
            resultLabel.Text = value;

            //clears the valueTextBox
            valueTextBox.Text = "";
        }
    }
}