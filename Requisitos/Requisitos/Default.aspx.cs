using System;
using System.Collections.Generic;
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
            //GridDevedor.RowDataBound += new GridViewRowEventHandler(GridDevedor_RowDataBound);
            //GridDevedor.Columns[0].HeaderText = "Código";
            //GridDevedor.Columns[1].HeaderText = "Nome do Produto";
            //GridDevedor.Columns[2].HeaderText = "Preço Unitário";
            //GridDevedor.Columns[3].HeaderText = "Unidades em Estoque";
        }

        protected void GridDevedor_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Altero o nome das colunas
                GridDevedor.Columns[0].HeaderText = "Código";
                GridDevedor.Columns[1].HeaderText = "Nome do Produto";
                GridDevedor.Columns[2].HeaderText = "Preço Unitário";
                GridDevedor.Columns[3].HeaderText = "Unidades em Estoque";

                //Registros das colunas Código, Preço Unitário e Unidades em Estoque centralizados
                GridDevedor.Columns[0].ItemStyle.HorizontalAlign = HorizontalAlign.Center;
                GridDevedor.Columns[2].ItemStyle.HorizontalAlign = HorizontalAlign.Center;
                GridDevedor.Columns[3].ItemStyle.HorizontalAlign = HorizontalAlign.Center;

                //Todos registros em negrito
                GridDevedor.Style.Add("font-weight", "bold");

                //Registros da coluna Preço Unitário em cor vermelha
                GridDevedor.Columns[2].ItemStyle.ForeColor = Color.Red;
            }
        }
    }
}