using System;
using System.Collections.Generic;
using System.Text;

namespace MarlonLtda.CursoWeb.Dominio.Entidades
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<Curso> Cursos { get; set; }
    }
}
