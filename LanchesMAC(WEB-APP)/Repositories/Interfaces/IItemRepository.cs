using LanchesMAC_WEB_APP_.Models;

namespace LanchesMAC_WEB_APP_.Repositories.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItens { get; }
        IEnumerable<Item> ItensPreferidos { get; }
        Item GetItemById(int id);
    }
}
