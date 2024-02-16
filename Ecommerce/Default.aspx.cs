using System;
using System.Web.UI;

namespace Ecommerce
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                rptArticoli.DataSource = Magazzino.Articoli;
                rptArticoli.DataBind();
            }
        }
    }
}