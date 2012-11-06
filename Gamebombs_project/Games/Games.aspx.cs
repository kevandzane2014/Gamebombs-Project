using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Games_GameTest : System.Web.UI.Page
{
    private string connectionString = WebConfigurationManager.ConnectionStrings["siteInfoString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Request.QueryString["name"].ToString();
        
        Game gm = new Game(name, "GameImages/" +name+ ".jpg ");
        getHtml.Text = gm.GetHtml();

        if (User.IsInRole("users"))
        {
            //Save.Visible = true;
            //Reset.Visible = true;
            Start.Visible = true;
        }

        if (User.IsInRole("admins"))
        {
            //Save.Visible = true;
            //Reset.Visible = true;
            Start.Visible = true;
        }

    }
    protected void Instructions_Click(object sender, EventArgs e)
    {
        string name = Request.QueryString["name"].ToString();

        string popup = "<script language='javascript'>" + "window.open('Instructions.aspx?name=" + HttpUtility.UrlEncode(name.ToString()) + "','CustomPopUp', " + "'fullscreen=no,height=330,width=350,top=250,left=250,scrollbars=yes, dependant = yes, alwaysRaised = yes, menubar=no,resizable=no')" + "</script>";
        ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "PopupScript", popup, false); 
        
        //Response.Write("<SCRIPT language=javascript>var w=window.open('Instructions.aspx','OrderStatus','height=800,width=800');</SCRIPT>");
    }
    protected void Start_Click(object sender, EventArgs e)
    {
        //updates the database
        GamePlayed();


        //starts the game
        string name = Request.QueryString["name"].ToString();
        if (name == "CARDS")
        {
            Response.Redirect("~/Games/Cards.aspx");
        }

        else
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Request.MapPath("" + name + ".exe");
            try
            {
                p.Start();
            }
            catch (Exception err)
            {
                //lblError.Text = "Unable to start game: ";
                //lblError.Text += err.Message;
            }
        }
        
    }
    private void GamePlayed()
    {
        string username = HttpContext.Current.User.Identity.Name.ToString();
        string gamename = Request.QueryString["name"].ToString();

        string selectSQL = "SELECT [gameName], [userName], [amountPlayed] FROM [gamesPlayed] WHERE ([userName] = '" + username + "') AND ([gameName]='" + gamename + "');";


        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;

        DataTable dt = new DataTable();

        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            dt.Load(reader);
            reader.Close();
        }
        catch (Exception err)
        {
            lblError.Text = "Error retrieving game data: ";
            lblError.Text += err.Message;
        }
        finally
        {
            con.Close();
        }


        //check if we have played a game
        try
        {
            int played = (int)(dt.Rows[0]["amountPlayed"]);
            //we are here if a game has been played (getting int successful). we must increment the games played
            updateGameOngamesPlayed(username, gamename, played + 1);
            updateLastGamePlayed(username, gamename);
        }
        catch (Exception err)
        {
            //we get here if there has never been a game played. we must create a database entry
            insertGameOngamesPlayed(username, gamename);
            insertLastGamePlayed(username, gamename);
        }


    }
    private void insertGameOngamesPlayed(string username, string gamename)
    {
        string insertSQL = "INSERT INTO [gamesPlayed] ([gameName], [userName], [amountPlayed]) VALUES ('" + gamename + "','" + username + "',1);";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insertSQL, con);
        SqlDataReader reader;

        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Close();
        }
        catch (Exception err)
        {
            //lblError.Text += "Error inserting game data: ";
            //lblError.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }
    private void updateGameOngamesPlayed(string username, string gamename, int played)
    {
        string updateSQL = "UPDATE [gamesPlayed] SET [amountPlayed] = " + played + " WHERE userName = '" + username + "' AND [gameName] = '" + gamename + "';";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(updateSQL, con);
        SqlDataReader reader;

        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Close();
        }
        catch (Exception err)
        {
            //lblError.Text = "Error updating game data: ";
            //lblError.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }
    private void updateLastGamePlayed(string username, string gamename)
    {
        string updateSQL = "UPDATE [lastPlayed] SET [gameName] = '" + gamename + "' WHERE userName = '" + username + "';";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(updateSQL, con);
        SqlDataReader reader;

        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Close();
        }
        catch (Exception err)
        {
            //needs a new database entry
            //lblError.Text = "update error: ";
            //lblError.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }
    private void insertLastGamePlayed(string username, string gamename)
    {
        string insertSQL = "INSERT INTO [lastPlayed] ([userName], [gameName]) VALUES ('" + username + "','" + gamename + "');";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insertSQL, con);
        SqlDataReader reader;

        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Close();
        }
        catch (Exception err)
        {
            //lblError.Text = "Error inserting last game played: ";
            //lblError.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }
}
