using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityFrameworkExam
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUltimateSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchResultsGridViews();
        }

        private void PopupateSearchResultsGridViews()
        {
            
                //string searchText = txtSearchText.Text;

                //ctx.Authors.Load();
                //ctx.Titles.Load();
            var authorsQuery = MyHelpers.SearchForAnAuthor(txtSearchText.Text);
            var titlesQuery = MyHelpers.SearchForTitles(txtSearchText.Text);

            authorsResultGridView.DataSource = authorsQuery;
            authorsResultGridView.DataBind();

            titlesResultGridView.DataSource = titlesQuery;
            titlesResultGridView.DataBind();

        }
    }
}