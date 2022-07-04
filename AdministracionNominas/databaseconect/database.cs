using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace databaseconect
{

    public class database
    {


        SqlConnection conn;
        String query;
        DataSet dts;

        public void conectar()
        {
            String conexionString = "Data Source=tcp:10.12.12.9,49172;Initial Catalog=Nominas;User ID=user;Password=password";
            //ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["Nominas"];
            //conexionString = conf.ConnectionString;
            conn = new SqlConnection(conexionString);
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

        public int executa (String consulta)
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
