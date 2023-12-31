﻿using System;
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
            try
            {
            //string connectionString = Properties.Settings.Default.strConexao;
            string connectionString = Properties.Settings.Default.strConexao15;

                DataSet ds = new DataSet();
                string sql = "STP_SELECT_LISTA_DEVEDOR";

                using (SqlConnection cn = new SqlConnection(connectionString))
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

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void CadastrarDevedor(String CPF,String Contrato,String Data, String ValorPagamento, String ValorAtualizado)
        {
            try
            {
                //string connectionString = Properties.Settings.Default.strConexao;
                string connectionString = Properties.Settings.Default.strConexao15;

                DataSet ds = new DataSet();
                string sql = "STP_CADASTRAR_NOVO_DEVEDOR";

                using (SqlConnection cn = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cn.Open();

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@CPF", SqlDbType.VarChar));
                        cmd.Parameters["@CPF"].Value = CPF; 

                        cmd.Parameters.Add(new SqlParameter("@CONTRATO", SqlDbType.VarChar, 50));
                        cmd.Parameters["@CONTRATO"].Value = Contrato; 

                        cmd.Parameters.Add(new SqlParameter("@DATA", SqlDbType.DateTime));
                        cmd.Parameters["@DATA"].Value = Data; 

                        cmd.Parameters.Add(new SqlParameter("@VALORPAG", SqlDbType.VarChar, 50));
                        cmd.Parameters["@VALORPAG"].Value = ValorPagamento; 

                        cmd.Parameters.Add(new SqlParameter("@VALORATUA", SqlDbType.VarChar, 50));
                        cmd.Parameters["@VALORATUA"].Value = ValorAtualizado;

                        cmd.CommandTimeout = 360000;

                        cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void DeletarDevedor(int CODIGO)
        {
            try
            {
                //string connectionString = Properties.Settings.Default.strConexao;
                string connectionString = Properties.Settings.Default.strConexao15;

                DataSet ds = new DataSet();
                string sql = "STP_DELETAR_DEVEDOR";

                using (SqlConnection cn = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cn.Open();

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@CODIGO", SqlDbType.VarChar));
                        cmd.Parameters["@CODIGO"].Value = CODIGO;

                        cmd.CommandTimeout = 360000;

                        // Executar a stored procedure
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}