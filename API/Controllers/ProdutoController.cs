using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context; // sendo readonly o objeto pode receber algo (valor) apenas na sua criação ou no construtor.
        public ProdutoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/produtp/create
        [HttpPost]
        [Route("create")]
        public Produto Create(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto;
        }

        //GET: api/produtp/list
        [HttpGet]
        [Route("list")]
        public List<Produto> List() => _context.Produtos.ToList(); // ToList pega todos os registros da tabela de Produtos e converter para uma lista de produtos
    }
}