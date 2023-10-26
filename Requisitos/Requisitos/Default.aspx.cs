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
            CarregarDadosNoGridView();
        }

       
        protected void GridDevedor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = GridDevedor.Rows[rowIndex];
            TableCell cell = row.Cells[0];

            if (e.CommandName == "Deletar")
            {
                int valor = Convert.ToInt32(cell.Text);

                DAO.AcessoDados.DeletarDevedor(valor);
            }

            if (e.CommandName == "Editar")
            {
                int valor = Convert.ToInt32(cell.Text);

                string url = "PaginaDeEdicao.aspx?ID=" + valor;
                Response.Redirect(url);

            }
            CarregarDadosNoGridView();

        }

        private void CarregarDadosNoGridView()
        {
            DataSet ds = new DataSet();
            ds = DAO.AcessoDados.preencheGrid();

            GridDevedor.DataSource = ds;
            GridDevedor.DataBind();
        }

    }
}