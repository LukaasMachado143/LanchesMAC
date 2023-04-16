using LanchesMAC_WEB_APP_.Context;
using LanchesMAC_WEB_APP_.Models;
using LanchesMAC_WEB_APP_.Repositories.Interfaces;

namespace LanchesMAC_WEB_APP_.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository( AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
