using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityFrameworkExam
{
    public partial class ListBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadDropDownMenu();
            }

        }

        protected void authorsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopupateBooksGridView();
        }

        private void PopupateBooksGridView()
        {

           
           
             
           
               var titlesQuery =
                  MyHelpers.PopulateGridviewWithBooksFromASelectedAuthor(authorsDropDownList.SelectedValue);

               
                titlesGridView.DataSource = titlesQuery;
                titlesGridView.DataBind();

            


        }


        private void   LoadDropDownMenu()
        {
           
                //Todo: Get all authors and bind them to the dropdown menu
            using (var ctx = new BooksEntities1())
            {
                ctx.Authors.Load();

                var authorsQuery = ctx.Authors.Local.OrderBy(a => a.LastName).ThenBy(a => a.FirstName).
                    Select(a => new
                    {
                        Name = a.LastName + "," + a.FirstName, a.AuthorID
                    });

                authorsDropDownList.DataValueField = "AuthorID";
                authorsDropDownList.DataTextField = "Name";
                authorsDropDownList.DataSource = authorsQuery;
                authorsDropDownList.DataBind();
            }

                
            
        }
    }
}