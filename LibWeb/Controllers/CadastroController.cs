using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.Client;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibWeb.Models;


namespace LibWeb.Controllers
{
    public class CadastroController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        // GET: Cadastro
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "Server=us-cdbr-east-04.cleardb.com;Port=3306;database=heroku_9a31470bc943cfe;user id=b2f2676fa0b9f7;password=dedb93a0";
            //con.ConnectionString = "data source=dedb93a0@us-cdbr-east-04.cleardb.com/heroku_9a31470bc943cfe; database=heroku_9a31470bc943cfe; integrated security=SSPI;";
        }
        [HttpPost]
        public ActionResult verify(User user)
        {

            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into Usuario(nome, senha, email, data_nasc, usuario) values(nome" + user.nome + ", senha" + user.senha + ", email" + user.email + ",data_nasc" + user.date + ",usuario" + user.nome_user + ");";
            dr = com.ExecuteReader();

            if(dr.Read())
            {
                con.Close();
                return View("Sucesso");
            }
            else 
            {
                con.Close();
                return View("Erro");
            }

        }
    }
}