using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bonus_Assignment
{
    public partial class question1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                coordinate_summary.InnerHtml = "";
                //collecting X-axis and Y-axis value

                int xaxis_value = Convert.ToInt32(Xaxis_value.Text);
                int yaxis_value = Convert.ToInt32(Yaxis_value.Text);

                //How do I know if the values are in the Ist Quadrant?
                if (xaxis_value > 0)
                {
                    if (yaxis_value > 0)
                    {
                        coordinate_summary.InnerHtml = "Values (" + xaxis_value + "," + yaxis_value + ") are in 1st Quadrant";
                    }
                    //How do I know if the values are in the 4th Quadrant ?
                    else if (yaxis_value < 0)
                    {
                        coordinate_summary.InnerHtml = "Values (" + xaxis_value + "," + yaxis_value + ") are in 4th Quadrant";
                    }
                    //How do I know if values are on X-axis?
                    else
                    {
                        coordinate_summary.InnerHtml = "Values (" + xaxis_value + "," + yaxis_value + ") are on X-axis";
                    }
                }

                //How do I know if the values are in the 2nd Quadrant ?
                else if (xaxis_value < 0)
                {
                    if (yaxis_value > 0)
                    {
                        coordinate_summary.InnerHtml = "Values (" + xaxis_value + "," + yaxis_value + ") are in 2nd Quadrant";
                    }
                    ////How do I know if the values are in the 3rd Quadrant ?
                    else if (yaxis_value < 0)
                    {
                        coordinate_summary.InnerHtml = "Values (" + xaxis_value + "," + yaxis_value + ") are in 3rd Quadrant";
                    }
                    //How do I know if the values are on X-axis ?
                    else
                    {
                        coordinate_summary.InnerHtml = "Values (" + xaxis_value + "," + yaxis_value + ") are on X-axis";
                    }
                }

                //How do I know if the values are on Y-axis?
                else
                {
                    if (yaxis_value > 0 || yaxis_value < 0)
                    {
                        coordinate_summary.InnerHtml = "Values (" + xaxis_value + "," + yaxis_value + ") are on Y-axis";
                    }
                    //how do I know values are at origin?
                    else
                    {
                        coordinate_summary.InnerHtml = "Values (" + xaxis_value + "," + yaxis_value + ") are at origin";

                    }
                }

            }

        }
    }
}