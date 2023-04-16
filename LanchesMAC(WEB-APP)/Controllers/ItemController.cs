using LanchesMAC_WEB_APP_.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMAC_WEB_APP_.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        public ItemController(IItemRepository itemRepository) => _itemRepository = itemRepository;

        public IActionResult List()
        {
            var itensRecuperados = _itemRepository.GetAllItens;
            return View(itensRecuperados);
        }
    }
}
