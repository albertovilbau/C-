using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Net;

namespace databaseconect
{

    public class database
    {


        SqlConnection conn;
        String query;
        DataSet dts;

        public void conectar()
        {
            string cnx;
            string database = "SecureCore";
            cnx = "Data Source=" + Dns.GetHostName() + "\\SQLEXPRESS;Initial Catalog=" + database + ";Integrated Security=True";
            conn = new SqlConnection(cnx);
        }

        public DataSet portarDades(String taula)
        {
            conectar();
            SqlDataAdapter adapter;
            dts = new DataSet();

            query = "select * from " + taula;
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, taula);

            conn.Close();

            return dts;
        }

        public DataSet portarDadesConsulta(String consulta, String taula)
        {
            conectar();
            SqlDataAdapter adapter;
            dts = new DataSet();

            adapter = new SqlDataAdapter(consulta, conn);
            conn.Open();

            adapter.Fill(dts, taula);

            conn.Close();

            return dts;
        }

        public int Actualitzar(DataSet changeddts, String tabla)
        {
            conectar();
            conn.Open();

            int result = 0;

            SqlDataAdapter adapter;
            query = "select * from " + tabla;

            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder;
            commandBuilder = new SqlCommandBuilder(adapter);

            if (changeddts.HasChanges())
            {
                result = adapter.Update(changeddts.Tables[tabla]);
            }


            conn.Close();

            return result;

        }

        public void executa (String consulta)
        {
            conectar();
            conn.Open();
        
            SqlCommand cmd = new SqlCommand(consulta, conn);

            cmd.ExecuteNonQuery();
        
            cmd.Dispose();

            conn.Close();
            
        }

        public DataSet portarDadesLogin(String consulta)
        {
            conectar();
            SqlDataAdapter adapter;
            dts = new DataSet();

            adapter = new SqlDataAdapter(consulta, conn);
            conn.Open();

            adapter.Fill(dts, "Users");

            conn.Close();

            return dts;
        }

    }
    
}
