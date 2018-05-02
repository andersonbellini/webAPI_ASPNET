using System.Web.Http;
using webAPI.Dal;

namespace webAPI.Controllers
{
    public class HomeController : ApiController
    {
        Conexao conexao = new Conexao();

        [HttpPost]
        public bool Post()
        {
            //insert
            return true;
        }

        [HttpGet]
        public string Get()
        {
            return "Aqui a página  principal da API!! ";        
        }

    }
}
