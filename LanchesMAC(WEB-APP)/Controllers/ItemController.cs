using LanchesMAC_WEB_APP_.Repositories.Interfaces;
using LanchesMAC_WEB_APP_.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMAC_WEB_APP_.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        public ItemController(IItemRepository itemRepository) => _itemRepository = itemRepository;

        public IActionResult List()
        {
            var ItemListViewModel = new ItemListViewModel();
            ItemListViewModel.Itens = _itemRepository.GetAllItens;
            ItemListViewModel.CategoriaAtual = "Categoria Atual";
            return View(ItemListViewModel);
        }
    }
}
