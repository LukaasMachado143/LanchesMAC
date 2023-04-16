using LanchesMAC_WEB_APP_.Context;
using LanchesMAC_WEB_APP_.Models;
using LanchesMAC_WEB_APP_.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMAC_WEB_APP_.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;
        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Item> Itens => _context.Itens.Include(c => c.Categoria);

        public IEnumerable<Item> ItensPreferidos => _context.Itens.
                                                    Where(x => x.IsItemPreferido).
                                                    Include(c => c.Categoria);

        public Item GetItemById(int id)
        {
            var itemEncontrado = _context.Itens.FirstOrDefault(i => i.ItemId == id);
            return itemEncontrado;
        }
    }
}
