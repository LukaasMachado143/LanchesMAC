using LanchesMAC_WEB_APP_.Models;

namespace LanchesMAC_WEB_APP_.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Itens { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
