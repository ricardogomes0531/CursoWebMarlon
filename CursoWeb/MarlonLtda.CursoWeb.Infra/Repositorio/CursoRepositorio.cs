using MarlonLtda.CursoWeb.Dominio.Entidades;
using MarlonLtda.CursoWeb.Infra.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MarlonLtda.CursoWeb.Infra.Repositorio
{
    public class CursoRepositorio:ConexaoDb, ICursoRepositorio
    {
        private readonly SqlConnection _conexao;
        public CursoRepositorio(IConfiguration Configuration):base(Configuration)
        {
            _conexao = IniciaConexao();
        }

        public bool Inserir(string nome, string professor)
        {
            bool retorno = false;
            SqlCommand query = new SqlCommand("insert into curso(nome, professor) values(@nome, @professor)", _conexao);
            _conexao.Open();
            SqlParameter parametroNome = new SqlParameter()
            {
                ParameterName = "nome",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Value = nome
            };
            SqlParameter parametroProfessor = new SqlParameter()
            {
                ParameterName = "professor",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Value = professor
            };
            query.Parameters.Add(parametroNome);
            query.Parameters.Add(parametroProfessor);
            if (query.ExecuteNonQuery() > 0)
                retorno = true;
            return retorno;
        }

        public IList<Curso> ListarCursos(string nome)
        {
            IList<Curso> cursos = new List<Curso>();
            SqlCommand query = new SqlCommand("select * from curso where nome=@nome", _conexao);
            _conexao.Open();
            SqlParameter parametroNome = new SqlParameter()
            {
                ParameterName = "nome",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Value = nome
            };
            query.Parameters.Add(parametroNome);
            SqlDataReader dados = query.ExecuteReader();
            while (dados.Read())
            {
                Curso curso = new Curso()
                {
                    Id = dados.GetInt32(dados.GetOrdinal("id")),
                    Nome = dados.GetString(dados.GetOrdinal("nome")),
                    Professor = dados.GetString(dados.GetOrdinal("professor"))
                };
                cursos.Add(curso);
            }
            return cursos;
        }
                    }
}
