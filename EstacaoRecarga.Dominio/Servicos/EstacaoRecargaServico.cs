using EstacaoRecarga.Dominio.Interfaces.Repositorios;
using EstacaoRecarga.Dominio.Interfaces.Servicos;
using EstacaoRecargaModelo = EstacaoRecarga.Dominio.Entidades.EstacaoRecarga;

namespace EstacaoRecarga.Dominio.Servicos
{
    public class EstacaoRecargaServico : IEstacaoRecargaServico
    {
        private readonly IEstacaoRecargaRepositorio _repository;

        public EstacaoRecargaServico(IEstacaoRecargaRepositorio repository)
        {
            _repository = repository;
        }

        public void Adicionar(EstacaoRecargaModelo estacaoRecarga)
        {
            _repository.Adicionar(estacaoRecarga);
        }

        public void Atualizar(EstacaoRecargaModelo estacaoRecarga)
        {
            _repository.Atualizar(estacaoRecarga);
        }

        public void Excluir(EstacaoRecargaModelo estacaoRecarga)
        {
            _repository.Excluir(estacaoRecarga);
        }

        public IReadOnlyList<EstacaoRecargaModelo> ListarTodos()
        {
            return _repository.Listar();
        }

        public EstacaoRecargaModelo RecuperarPorId(Guid id)
        {
            return _repository.RecuperarPorId(id);
        }
    }
}
