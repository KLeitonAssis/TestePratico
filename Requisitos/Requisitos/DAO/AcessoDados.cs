using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Requisitos.DAO
{
    public class AcessoDados
    {


        public static DataSet preencheGrid()
        {

            string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=SSPI;";

            try
            {
                DataSet ds = new DataSet();
                string sql = "STP_TESTE";

                using (SqlConnection cn = new SqlConnection(strConexao))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 360000;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            da.Dispose();
                        }
                    }
                }
                return ds;
                //SqlConnection con = new SqlConnection(strConexao);
                //con.Open();
                //SqlCommand cmd = new SqlCommand("sproc_GetClientes", con);
                //SqlDataReader dr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //exibe os dados no GridView

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}