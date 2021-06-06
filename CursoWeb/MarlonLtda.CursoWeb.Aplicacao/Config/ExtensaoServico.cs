using MarlonLtda.CursoWeb.Aplicacao.Interface;
using MarlonLtda.CursoWeb.Aplicacao.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace MarlonLtda.CursoWeb.Aplicacao.Config
{
    public static class ExtensaoServico
    {
        public static IServiceCollection AdicionarServico(this IServiceCollection service)
        {
            service.AddScoped<ICursoServico, CursoServico>();
                        return service;
        }
    }
}
