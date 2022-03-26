namespace EstacaoRecarga.Dominio.Interfaces.Repositorios
{
    public interface IBaseRepositorio<T> where T : class
    {
        void Adicionar(T obj);
        T RecuperarPorId(Guid id);
        void Atualizar(T obj);
        void Excluir(T obj);
        IReadOnlyList<T> Listar();
    }
}
