using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace webAPI.Dal
{
    public class Conexao
    {
        private String ip_server = "gpxap04"; //IP Servidor BD
        private String uid = "processo";  //Usuário BD
        private String pwd = "processoca"; //Senha BD

        private MySqlConnection cn = null;
        private string schemmaCon = "";

        private void ConexaoBD(string schemma)
        {
            if ((schemmaCon != schemma))
            {
               cn = new MySqlConnection((("Persist Security Info=False;server="
                                + (ip_server + (";database="
                                + (schemma + (";uid="
                                + (uid + (";pwd="
                                + (pwd + ";Pooling=false;"))))))))
                                + "default command timeout=999"));
                schemmaCon = schemma;
            }

        }

        public DataTable dt(string schemma, string sqlQuery)
        {
            try
            {
                this.ConexaoBD(schemma);
                MySqlDataAdapter da = new MySqlDataAdapter(sqlQuery, cn);
                DataTable dtt = new DataTable();
                cn.Open();
                da.Fill(dtt);
                cn.Close();
                return dtt;
                // s.Tables(0)
            }
            catch (Exception erro)
            {
                cn.Close();
                throw erro;
            }

        }

    }

}