using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Requisitos.Controllers
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Recupere o valor inserido no TextBox
            string CPF = txtCpf.Text;
            string Contrato = txtContrato.Text;
            string Data = txtData.Text;
            string ValorPrincipal = txtValorP.Text;
            string ValorAtualizado = txtValorA.Text;

            DAO.AcessoDados.CadastrarDevedor(CPF, Contrato, Data, ValorPrincipal, ValorAtualizado);
        }

    }
}