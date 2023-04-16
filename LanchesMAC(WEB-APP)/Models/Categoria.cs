namespace LanchesMAC_WEB_APP_.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        public string NomeCategoria { get; set; }
        public string Descricao { get; set; }

        public List<Item> Itens { get; set; }
    }
}
