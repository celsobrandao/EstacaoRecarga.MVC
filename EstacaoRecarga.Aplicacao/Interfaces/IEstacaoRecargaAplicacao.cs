using EstacaoRecargaModelo = EstacaoRecarga.Dominio.Entidades.EstacaoRecarga;

namespace EstacaoRecarga.Aplicacao.Interfaces
{
    public interface IEstacaoRecargaAplicacao
    {
        IReadOnlyList<EstacaoRecargaModelo> ListarTodos();
        void Adicionar(EstacaoRecargaModelo estacaoRecarga);
        EstacaoRecargaModelo RecuperarPorId(Guid id);
        void Atualizar(EstacaoRecargaModelo estacaoRecarga);
        void Excluir(EstacaoRecargaModelo estacaoRecarga);
    }
}