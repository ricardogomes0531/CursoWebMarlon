using MarlonLtda.CursoWeb.Infra.Interface;
using MarlonLtda.CursoWeb.Infra.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarlonLtda.CursoWeb.Infra.Config
{
     public static class ExtensaoInfra
    {
        public static IServiceCollection AdicionarDependenciaInfra(this IServiceCollection servico)
        {
            servico.AddScoped<ICursoRepositorio, CursoRepositorio>();
            return servico;
        }
    }
}
