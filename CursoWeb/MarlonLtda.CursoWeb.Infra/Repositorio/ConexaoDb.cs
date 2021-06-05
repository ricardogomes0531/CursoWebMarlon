using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace MarlonLtda.CursoWeb.Infra.Repositorio
{
    public abstract class ConexaoDb
    {
        private readonly IConfiguration _configuration;
        public ConexaoDb(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }

        public SqlConnection IniciaConexao()
        {
            var conectionString = _configuration.GetSection("ConnectionString").GetSection("Database").Value;
            var conexao = new SqlConnection(conectionString);
            return conexao;
        }
    }
}
