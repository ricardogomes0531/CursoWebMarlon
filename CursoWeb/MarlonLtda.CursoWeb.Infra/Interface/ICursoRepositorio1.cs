using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MarlonLtda.CursoWeb.Infra.Interface
{
    public interface ICursoRepositorio
    {
        bool Inserir(string nome, string professor);
                    }
}
