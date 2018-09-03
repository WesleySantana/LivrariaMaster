using Livraria.Application.Interfaces;
using Livraria.Application.ViewModels;
using Livraria.Domain.Domains;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Livraria.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroApp _livroApp;
        private readonly IEditoraApp _editoraApp;

        public LivroController(ILivroApp livroApp, IEditoraApp editoraApp)
        {
            _livroApp = livroApp;
            _editoraApp = editoraApp;
        }

        // GET api/livro
        [HttpGet]
        public IActionResult Listar()
        {
            var livros = _livroApp.GetAll().OrderBy(x => x.Titulo);
            var viewModel = livros.Select(x => new LivroViewModel
            {
                Id = x.Id,
                Titulo = x.Titulo,
                Autor = x.Autor,
                Edicao = x.Edicao,
                Editora = _editoraApp.GetById(x.Editora.Id),
                Assuntos = x.Assuntos,
                Ano = x.Ano,
                QtdeEstoque = x.QtdeEstoque
            });
            return Ok(viewModel);
        }

        // GET api/livro/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var livro = _livroApp.GetById(id);
            var viewModel = new LivroViewModel
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                Autor = livro.Autor,
                Edicao = livro.Edicao,
                Editora = _editoraApp.GetById(livro.Editora.Id),
                Assuntos = livro.Assuntos,
                Ano = livro.Ano,
                QtdeEstoque = livro.QtdeEstoque
            };
            return Ok(viewModel);
        }

        // POST api/livro
        [HttpPost]
        public void Insert([FromBody] LivroViewModel livroModel)
        {
            var livro = new Livro
            {
                Ano = livroModel.Ano,
                Assuntos = livroModel.Assuntos,
                Autor = livroModel.Autor,
                Edicao = livroModel.Edicao,
                Editora = livroModel.Editora,
                QtdeEstoque = livroModel.QtdeEstoque,
                Titulo = livroModel.Titulo
            };
            _livroApp.Save(livro);
        }

        // PUT api/livro/5
        [HttpPut("{id}")]
        public void Edit([FromBody] int id)
        {
            var livro = _livroApp.GetById(id);

            //livro.Ano = livroModel.Ano;
            //livro.Assuntos = livroModel.Assuntos;
            //livro.Autor = livroModel.Autor;
            //livro.Edicao = livroModel.Edicao;
            //livro.Editora = livroModel.Editora;
            //livro.QtdeEstoque = livroModel.QtdeEstoque;
            //livro.Titulo = livroModel.Titulo;

            _livroApp.Update(livro);
        }

        // DELETE api/livro/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var livro = _livroApp.GetById(id);
            _livroApp.Delete(livro);
        }
    }
}