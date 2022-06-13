using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PROJETOWEB.Models
{
    public class Arquivo
    {
        private string connString = "";
        private int administrador_id = 0;

        public Arquivo()
        {
            connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }
        public Arquivo(int _administradorId)
        {
            connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            administrador_id = _administradorId;
        }

        public DataTable Lista(string Titulo)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Arquivo";
                if (!string.IsNullOrEmpty(Titulo))
                {
                    sql += " where Titulo like '%" + Titulo + "%'";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                {
                    a.Fill(table);
                }
            }
            return table;
        }
    }
}