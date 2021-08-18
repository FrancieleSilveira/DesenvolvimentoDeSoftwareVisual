using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        //POST: api/produtp/create
        [HttpPost]
        [Route("create")]
        public Produto Create(Produto produto)
        {
            produto.Nome += " Alterado";
            return produto;
        }
    }
}