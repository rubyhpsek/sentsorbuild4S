using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sentsor.Demo_Folder
{
    public partial class htmlServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_ServerClick(object sender, EventArgs e)
        {
            Response.Write("Hello " + Text1.Value);
        }
    }
}