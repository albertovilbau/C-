using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DBConnect
{
    public class dbconnect
    {
        SqlConnection conn;
        String query;
        DataSet dts;

        public void conectar()
        {
            String connectionString = "Data Source = 91.134.211.186; Initial Catalog = SecureCoreG8; Persist Security Info = True; User ID = G8; Password = 12345aAG8";
            conn = new SqlConnection(connectionString);
        }

        public DataSet portarDades(String query)
        {
            conectar();
            SqlDataAdapter adapter;
            dts = new DataSet();

            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, query);

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
                result = adapter.Update(changeddts.Tables[0]);
            }

            conn.Close();

            return result;

        }

        public int executa(String consulta)
        {
            conectar();
            conn.Open();

            SqlCommand cmd = new SqlCommand(consulta, conn);
            int registresAfectats = cmd.ExecuteNonQuery();

            cmd.Dispose();

            conn.Close();

            return registresAfectats;


        }
    }
}
