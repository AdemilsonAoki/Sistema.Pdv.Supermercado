using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PimPdvTelas
{
    class Conexao
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();


        private string conexao = "Server=localhost;Database=bancopim2semestre2020;Uid=root;Pwd=Brasileiro55@;";

        public Conexao()
        {
            con.ConnectionString = conexao;
        }
        public MySqlConnection AbrirBanco()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        public void FecharBanco()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }



        }


        public DataTable ListarColaborador()
        {
            cmd.CommandText = "Select *from Fornecedor";
            try
            {
                cmd.Connection = AbrirBanco();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return dtLista;

            }
            catch (Exception e)
            {
                throw;
            }
            finally
            { 
               FecharBanco();
            }

        }
    }
}
