using MarlonLtda.CursoWeb.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarlonLtda.CursoWeb.Aplicacao.Interface
{
    public interface ICursoServico
    {
        bool InserirCurso(string nome, string professor);
        IList<Curso> ListarCursos(string nome);
    }
}
