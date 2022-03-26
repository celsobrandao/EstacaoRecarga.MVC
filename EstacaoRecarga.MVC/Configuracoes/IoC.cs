using EstacaoRecarga.Aplicacao.Interfaces;
using EstacaoRecarga.Aplicacao.Services;
using EstacaoRecarga.Data.Repositorio;
using EstacaoRecarga.Dominio.Interfaces.Repositorios;
using EstacaoRecarga.Dominio.Interfaces.Servicos;
using EstacaoRecarga.Dominio.Servicos;

namespace EstacaoRecarga.MVC.Configuracoes
{
    public static class IoC
    {
        public static void Configurar(this IServiceCollection services)
        {
            services.AddSingleton<IEstacaoRecargaAplicacao, EstacaoRecargaAplicacao>();
            services.AddSingleton<IEstacaoRecargaServico, EstacaoRecargaServico>();
            services.AddSingleton<IEstacaoRecargaRepositorio, EstacaoRecargaRepositorio>();
        }
    }
}
