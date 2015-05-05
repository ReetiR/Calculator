using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Cal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn1.Text;
            else
                text_result.Text = text_result.Text + bttn1.Text;
        }

        protected void bttn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn2.Text;
            else
                text_result.Text = text_result.Text + bttn2.Text;
        }

        protected void bttn3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn3.Text;
            else
                text_result.Text = text_result.Text + bttn3.Text;
        }

        protected void bttn4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn4.Text;
            else
                text_result.Text = text_result.Text + bttn4.Text;
        }

        protected void bttn5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn5.Text;
            else
                text_result.Text = text_result.Text + bttn5.Text;
        }

        protected void bttn6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn6.Text;
            else
                text_result.Text = text_result.Text + bttn6.Text;
        }

        protected void bttn7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn7.Text;
            else
                text_result.Text = text_result.Text + bttn7.Text;
        }

        protected void bttn8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn8.Text;
            else
                text_result.Text = text_result.Text + bttn8.Text;
        }

        protected void bttn9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn9.Text;
            else
                text_result.Text = text_result.Text + bttn9.Text;
        }

        protected void bttn0_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_result.Text))
                text_result.Text = bttn0.Text;
            else
                text_result.Text = text_result.Text + bttn0.Text;
        }

        protected void bttn_add_Click(object sender, EventArgs e)
        {
            ViewState["CurrentValue"] = text_result.Text;
            ViewState["CurrentOperator"] = bttn_add.Text;
            text_result.Text = "";
        }

        protected void bttn_sub_Click(object sender, EventArgs e)
        {
            ViewState["CurrentValue"] = text_result.Text;
            ViewState["CurrentOperator"] = bttn_sub.Text;
            text_result.Text = "";


        }

        protected void bttn_prod_Click(object sender, EventArgs e)
        {
            ViewState["CurrentValue"] = text_result.Text;
            ViewState["CurrentOperator"] = bttn_prod.Text;
            text_result.Text = "";


        }

        protected void bttn_div_Click(object sender, EventArgs e)
        {
            ViewState["CurrentValue"] = text_result.Text;
            ViewState["CurrentOperator"] = bttn_div.Text;
            text_result.Text = "";


        }

        protected void bttn_eq_Click(object sender, EventArgs e)
        {
            if (ViewState["CurrentOperator"].ToString() == "+")
            {
                text_result.Text = Convert.ToString(Convert.ToInt32(ViewState["CurrentValue"].ToString()) + Convert.ToInt32(text_result.Text));
            }
            else if(ViewState["CurrentOperator"].ToString() == "-")
            {
                text_result.Text = Convert.ToString(Convert.ToInt32(ViewState["CurrentValue"].ToString()) - Convert.ToInt32(text_result.Text));
            }
            else if (ViewState["CurrentOperator"].ToString() == "*")
            {
                text_result.Text = Convert.ToString(Convert.ToInt32(ViewState["CurrentValue"].ToString()) * Convert.ToInt32(text_result.Text));
            }
            else
            {
                text_result.Text = Convert.ToString(Convert.ToInt32(ViewState["CurrentValue"].ToString()) / Convert.ToInt32(text_result.Text));
            }
        }

        protected void bttn_clr_Click(object sender, EventArgs e)
        {
            text_result.Text = "";
        }
    }
}