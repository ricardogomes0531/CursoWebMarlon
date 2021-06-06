using MarlonLtda.CursoWeb.Aplicacao.Interface;
using MarlonLtda.CursoWeb.Dominio.Entidades;
using MarlonLtda.CursoWeb.Infra.Interface;
using System.Collections;
using System.Collections.Generic;

namespace MarlonLtda.CursoWeb.Aplicacao.Servicos
{
    public class CursoServico:ICursoServico
    {
        private readonly ICursoRepositorio _repositorio;
        public CursoServico(ICursoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public bool InserirCurso(string nome, string professor)
        {
            var resultado = _repositorio.Inserir(nome, professor);
            return resultado;
        }

        public IList<Curso> ListarCursos(string nome)
        {
            IList<Curso> curso = _repositorio.ListarCursos(nome);
                        return curso;
                }
    }
}
