using EstacaoRecarga.Aplicacao.Interfaces;
using EstacaoRecarga.Dominio.Interfaces.Servicos;
using EstacaoRecargaModelo = EstacaoRecarga.Dominio.Entidades.EstacaoRecarga;

namespace EstacaoRecarga.Aplicacao.Services
{
    public class EstacaoRecargaAplicacao : IEstacaoRecargaAplicacao
    {
        private readonly IEstacaoRecargaServico _estacaoRecargaService;

        public EstacaoRecargaAplicacao(IEstacaoRecargaServico estacaoRecargaService)
        {
            _estacaoRecargaService = estacaoRecargaService;
        }

        public IReadOnlyList<EstacaoRecargaModelo> ListarTodos()
        {
            return _estacaoRecargaService.ListarTodos();
        }
        public void Adicionar(EstacaoRecargaModelo estacaoRecarga)
        {
            _estacaoRecargaService.Adicionar(estacaoRecarga);
        }

        public void Atualizar(EstacaoRecargaModelo estacaoRecarga)
        {
            _estacaoRecargaService.Atualizar(estacaoRecarga);
        }

        public void Excluir(EstacaoRecargaModelo estacaoRecarga)
        {
            _estacaoRecargaService.Excluir(estacaoRecarga);
        }

        public EstacaoRecargaModelo RecuperarPorId(Guid id)
        {
            return _estacaoRecargaService.RecuperarPorId(id);
        }
    }
}