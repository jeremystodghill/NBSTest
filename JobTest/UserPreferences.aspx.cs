using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobTest
{
  public partial class UserPreferences : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Page.IsPostBack == false)
      {
        //hard-coding UserID just for test, assuming it came over from login
        Session["UserId"] = 1;

        int intUserID = Convert.ToInt16(Session["UserId"]);
        //Load Users preferences
        LoadUser(intUserID);

      }
    }



    public void LoadUser(int UserID)
    {
      NationalBuilderSupplyData.NBSDataDataContext mydb = new NationalBuilderSupplyData.NBSDataDataContext();
      NationalBuilderSupplyData.NBSUser user = mydb.NBSUsers.Single(u => u.UserID == UserID);
      txtEmail.Text = user.email;
    }



     public bool UpdateUser(string email)
    {
      if (txtEmail.Text != "")
      {
        bool blSuccess = true;
        try
        {
          NationalBuilderSupplyData.NBSDataDataContext mydb = new NationalBuilderSupplyData.NBSDataDataContext();

          var users = from a in mydb.NBSUsers
                  where a.UserID == Convert.ToInt16(Session["UserId"].ToString())
                  select a;

          foreach (NationalBuilderSupplyData.NBSUser us in users)
          {
            us.email = email;
          }

          // Submit the changes to the database.

            mydb.SubmitChanges();
          lblResult.Visible = true;
          lblResult.Text = "user email updated!";
        
        }
        catch (Exception ex)
        {
          //log error somewhere
          blSuccess = false;
        }
        return blSuccess;
      }
      else
      {

        return false;
      }
    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
      UpdateUser(txtEmail.Text);
    }

  



  }
}