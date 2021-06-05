using Microsoft.Extensions.DependencyInjection;

namespace MarlonLtda.CursoWeb.Aplicacao.Config
{
    public static class ExtensaoServico
    {
        public static IServiceCollection AdicionarServico(this IServiceCollection service)
        {
            return service;
        }
    }
}
