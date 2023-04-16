using LanchesMAC_WEB_APP_.Models;

namespace LanchesMAC_WEB_APP_.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> Categorias { get; }
    }
}
