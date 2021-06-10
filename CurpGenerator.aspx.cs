using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurpGenerator
{
    public partial class CurpGenerator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }

        protected void miniCalendar_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible) Calendar1.Visible = false;
            else Calendar1.Visible = true;

            Calendar1.Attributes.Add("styles", "position:absolute");
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtBirth.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.Visible = false;
        }
    }
}