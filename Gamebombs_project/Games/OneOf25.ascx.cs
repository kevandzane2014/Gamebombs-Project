using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class OneOf25 : System.Web.UI.UserControl
{

    public string Card
    {
        get { return (ViewState["Card"] == null) ? "" : (string)ViewState["Card"]; }
        set { ViewState["Card"] = value; }
    }

    public delegate void OnClickEventHandler(object sender, EventArgs e);
    public event OnClickEventHandler OnClick;


    protected void Page_PreRender(object sender, EventArgs e)
    {
        CardButton.Visible = (Card.Equals(""));
        CardImage.Visible = !(Card.Equals(""));
        if (CardImage.Visible)
        {
            CardImage.ImageUrl = "~/Cards/" + Card + ".gif";
        }
    }


    protected void CardButton_Click(object sender, EventArgs e)
    {
        if (OnClick != null) OnClick(this, e);
    }
}
