using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class Account_User_Management : System.Web.UI.Page
{
    private string connectionString = WebConfigurationManager.ConnectionStrings["siteInfoString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        lblLastPlayed.Text = "";
        FillGamesMostPlayed();
        FillLastGamePlayed();
    }
    private void FillGamesMostPlayed()
    {
        string username = HttpContext.Current.User.Identity.Name.ToString();
        string selectSQL = "SELECT [gameName], [userName], [amountPlayed] FROM [gamesPlayed] WHERE ([userName] = '" + username + "') AND amountPlayed=(SELECT MAX([amountPlayed]) FROM [gamesPlayed] WHERE ([userName] = '" + username + "'));";
        
        
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
            lblLastPlayed.Text = "Error reading list of names. ";
            lblLastPlayed.Text += err.Message;
            lblPlayedMost.Text = lblLastPlayed.Text;
        }
        finally
        {
            con.Close();
        }


        //check if we have played a game
        try
        {
            lblPlayedMost.Text = dt.Rows[0]["gameName"].ToString();
            lblPlayedMost.Text += " (" + dt.Rows[0]["amountPlayed"].ToString() + " games)";
        }
        catch (Exception err)
        {

            lblPlayedMost.Text = "No games played";
        }

    }
    private void FillLastGamePlayed()
    {
        string username = HttpContext.Current.User.Identity.Name.ToString();
        string selectSQL = "SELECT [gameName], [userName] FROM [lastPlayed] WHERE [userName]= '" + username + "';";


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
            lblLastPlayed.Text = "Error reading list of names: ";
            lblLastPlayed.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        //check if we have played a game
        try
        {
            lblLastPlayed.Text = dt.Rows[0]["gameName"].ToString();
        }
        catch (Exception err)
        {
            lblLastPlayed.Text = "No games played";
        }

    }
}