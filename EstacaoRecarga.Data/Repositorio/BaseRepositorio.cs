using EstacaoRecarga.Data.Config;
using EstacaoRecarga.Dominio.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace EstacaoRecarga.Data.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepositorio<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<EstacaoRecargaDbContext> _optionsBuilder;

        public BaseRepositorio()
        {
            _optionsBuilder = new DbContextOptions<EstacaoRecargaDbContext>();
        }

        public void Adicionar(T obj)
        {
            using var db = new EstacaoRecargaDbContext(_optionsBuilder);
            db.Set<T>().Add(obj);
            db.SaveChanges();
        }

        public void Atualizar(T obj)
        {
            using var db = new EstacaoRecargaDbContext(_optionsBuilder);
            db.Set<T>().Update(obj);
            db.SaveChanges();
        }

        public void Excluir(T obj)
        {
            using var db = new EstacaoRecargaDbContext(_optionsBuilder);
            db.Set<T>().Remove(obj);
            db.SaveChanges();
        }

        public IReadOnlyList<T> Listar()
        {
            using var db = new EstacaoRecargaDbContext(_optionsBuilder);
            return db.Set<T>().AsNoTracking().ToList();
        }

        public T RecuperarPorId(Guid id)
        {
            using var db = new EstacaoRecargaDbContext(_optionsBuilder);
            return db.Set<T>().Find(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
