using MarlonLtda.CursoWeb.Aplicacao.Interface;
using MarlonLtda.CursoWeb.Web.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarlonLtda.CursoWeb.Web.Controllers
{
    [Route("api/curso")]
    public class CursoController : Controller
    {
        private readonly ICursoServico _servico;
        public CursoController(ICursoServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult InserirCurso([FromBody] CursoRequest request)
        {
            var resultado = _servico.InserirCurso(request.Nome, request.Professor);
            return Ok(resultado);
        }
        [HttpGet]
        public IActionResult ListarCursos([FromQuery] string nome)
        {
            var resultado = _servico.ListarCursos(nome);
            return Ok(resultado);
        }
    }
}