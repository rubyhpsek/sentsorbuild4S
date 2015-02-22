using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sentsor.Demo_Folder
{
    public partial class javascript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FirstNameTextBox2.Focus();
        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }
    }
}