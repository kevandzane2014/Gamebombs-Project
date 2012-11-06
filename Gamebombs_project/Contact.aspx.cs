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
using System.Net.Mail;

public partial class contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string ToAddress = "nag.subhadeep@gmail.com";

            //Create a new mail message instance
            MailMessage mailMsg = new MailMessage(txtEmail.Text, ToAddress);

            //Set the require property
            mailMsg.Subject = txtSubject.Text;
            mailMsg.Body = "Name: " + txtName.Text + Environment.NewLine + txtEnquiry.Text;
            mailMsg.IsBodyHtml = false;

            //Create the new SmtpClient instance
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            System.Net.NetworkCredential cred = new System.Net.NetworkCredential("donkeybasketballusu", "usudonkeys");
            smtp.Credentials = cred;

            //Send the Mail Message to the specify smtp server.
            smtp.Send(mailMsg);


            Response.Redirect("~/Thanks.aspx");
        }

        catch (Exception ex)
        {
            Response.Write("Your file was not sent");
            
        }
    }
}