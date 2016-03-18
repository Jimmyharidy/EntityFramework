using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityFrameworkExam
{
    public partial class AdvancedSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUltimateSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchAuthorsResultGridView();
        }

        protected void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchAuthorsResultGridView();
        }

        protected void btnTitleSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchTitlesResultGridView();
        }

        private void PopupateSearchAuthorsResultGridView()
        {
            using (var ctx = new BooksEntities1())
            {
               var authorsQuery = MyHelpers.SearchForAnAuthor(txtAuthorSearchText.Text);
                authorsResultGridView.DataSource = authorsQuery;
                authorsResultGridView.DataBind();
            }


        }

        private void PopupateSearchTitlesResultGridView()
        {
            var titlesQuery = MyHelpers.SearchForTitles(txtAuthorSearchText.Text);
            titlesResultGridView.DataSource = titlesQuery;
            titlesResultGridView.DataBind();

        }
    }
}