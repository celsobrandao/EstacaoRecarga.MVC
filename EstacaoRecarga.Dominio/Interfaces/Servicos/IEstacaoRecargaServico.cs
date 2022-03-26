using EstacaoRecargaModelo = EstacaoRecarga.Dominio.Entidades.EstacaoRecarga;

namespace EstacaoRecarga.Dominio.Interfaces.Servicos
{
    public interface IEstacaoRecargaServico
    {
        IReadOnlyList<EstacaoRecargaModelo> ListarTodos();
        void Adicionar(EstacaoRecargaModelo estacaoRecarga);
        EstacaoRecargaModelo RecuperarPorId(Guid id);
        void Atualizar(EstacaoRecargaModelo estacaoRecarga);
        void Excluir(EstacaoRecargaModelo estacaoRecarga);
    }
}
