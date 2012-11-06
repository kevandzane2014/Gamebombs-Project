using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Register : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
    }

    protected void RegisterUser_CreatedUser(object sender, EventArgs e)
    {
        // Username is getting authenticated here
        FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie */);

        //Usernames are added to the roles
        Roles.AddUserToRole(RegisterUser.UserName, "users");

        string continueUrl = RegisterUser.ContinueDestinationPageUrl;
        if (String.IsNullOrEmpty(continueUrl))
        {
            continueUrl = "~/";
        }
        Response.Redirect(continueUrl);

        
    }

}
