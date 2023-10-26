using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Requisitos
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();


            ds = DAO.AcessoDados.preencheGrid();

            GridDevedor.DataSource = ds;
            GridDevedor.DataBind();

        }

        protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Deletar"))
            {
                Session.Add("IdProduto", e.CommandArgument.ToString());
                this.Response.Redirect("DetalheProduto.aspx");
            }
        }

    }
}