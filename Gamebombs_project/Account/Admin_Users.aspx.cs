using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Account_Admin_Games : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = Membership.GetAllUsers();
        if (!IsPostBack)
            GridView1.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            CheckBox cb = (CheckBox)e.Row.FindControl("CheckBox1");
            string username = DataBinder.Eval(e.Row.DataItem, "UserName").ToString();

            if (Roles.IsUserInRole(username, "admins"))
            {
                cb.Checked = true;
            }
            else
            {
                cb.Checked = false;

            }
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridView1.DataBind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GridView1.DataBind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        CheckBox cb = (CheckBox)GridView1.Rows[e.RowIndex].FindControl("CheckBox1");

        //two ways to get username
        string username = GridView1.Rows[e.RowIndex].Cells[0].Text;
        //string username = GridView1.DataKeys[e.RowIndex].Value.ToString();

        if (!Roles.IsUserInRole(username, "admins") && cb.Checked)
            Roles.AddUserToRole(username, "admins");
        else if (Roles.IsUserInRole(username, "admins") && !cb.Checked)
            Roles.RemoveUserFromRole(username, "admins");

        GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string username = GridView1.Rows[e.RowIndex].Cells[0].Text;
        Membership.DeleteUser(username);
        GridView1.DataSource = Membership.GetAllUsers();
        GridView1.DataBind();
    }
}