using LanchesMAC_WEB_APP_.Context;
using Microsoft.AspNetCore.Http.Features;

namespace LanchesMAC_WEB_APP_.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;
        public CarrinhoCompra(AppDbContext context) => _context = context;

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            session.SetString("CarrinhoId", carrinhoId);

            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };
        }   

    }
}
