using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using webAPI.Dal;
using webAPI.Models;

namespace webAPI.Controllers
{
    public class GetBookController : ApiController
    {
        Conexao conexao = new Conexao();

        [HttpGet]
        public List<Usuario> GetBook()
        {
            List<Usuario> ltUser = new List<Usuario>();

            DataTable dt = new DataTable();

            //adiciona o usuario no bando de dados.
            dt = conexao.dt("usrenggpx", "SELECT U.NUM_COD_USUARIO,U.STR_NOME,U.STR_LOGIN,U.STR_CHAPA,U.STR_CELL,U.STR_RAMAL,U.STR_IMG,A.STR_AREA, upper(U.STR_EMAIL) as Email ,U.STATUS FROM usrenggpx.APP_USUARIOS AS U,  usrenggpx.APP_AREA AS A  WHERE A.NUM_COD_AREA = U.NUM_COD_AREA AND  U.NUM_COD_AREA IN(1,2,3,6,7,8) AND status ='A'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltUser.Add(new Usuario
                {
                    ID = Convert.ToInt32(dt.Rows[i][0]),
                    Login = dt.Rows[i][2].ToString(),
                    Chapa = dt.Rows[i][3].ToString(),
                    Email = dt.Rows[i][8].ToString(),
                    Ramal = dt.Rows[i][5].ToString(),
                    celular = dt.Rows[i][4].ToString(),
                    Area = dt.Rows[i][7].ToString(),
                    Nome = dt.Rows[i][1].ToString(),
                    Foto = "http://app.emb/eng/APP_USER/" + dt.Rows[i][6].ToString(),
                    base64 = ""
                });
            }

            return ltUser;
        }

        public List<Usuario> GetBook(int id)
        {
            List<Usuario> ltUser = new List<Usuario>();

            DataTable dt = new DataTable();

            //adiciona o usuario no bando de dados.
            dt = conexao.dt("usrenggpx", "SELECT U.NUM_COD_USUARIO,U.STR_NOME,U.STR_LOGIN,U.STR_CHAPA,U.STR_CELL,U.STR_RAMAL,U.STR_IMG,A.STR_AREA, upper(U.STR_EMAIL) as Email ,U.STATUS FROM usrenggpx.APP_USUARIOS AS U,  usrenggpx.APP_AREA AS A  WHERE A.NUM_COD_AREA = U.NUM_COD_AREA AND  U.NUM_COD_AREA IN(1,2,3,6,7,8) AND status ='A' and U.NUM_COD_USUARIO='"+id+"' ");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltUser.Add(new Usuario
                {
                    ID = Convert.ToInt32(dt.Rows[i][0]),
                    Login = dt.Rows[i][2].ToString(),
                    Chapa = dt.Rows[i][3].ToString(),
                    Email = dt.Rows[i][8].ToString(),
                    Ramal = dt.Rows[i][5].ToString(),
                    celular = dt.Rows[i][4].ToString(),
                    Area = dt.Rows[i][7].ToString(),
                    Nome = dt.Rows[i][1].ToString(),
                    Foto = "http://app.emb/eng/APP_USER/" + dt.Rows[i][6].ToString(),
                    base64 = ""
                });
            }

            return ltUser;
        }

    }


}
