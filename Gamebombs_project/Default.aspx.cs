using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void lstGames_ItemCreated(object sender, ListViewItemEventArgs e)
    {
        (e.Item.FindControl("imgGame") as ImageButton).PostBackUrl = "Games/Games.aspx?name=" + DataBinder.Eval(e.Item.DataItem, "gameName");
    }




}
