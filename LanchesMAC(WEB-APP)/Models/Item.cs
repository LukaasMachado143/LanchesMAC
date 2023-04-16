namespace LanchesMAC_WEB_APP_.Models
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string NomeItem { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsItemPreferido { get; set; }
        public bool EmEstoque { get; set; }

        public Guid CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set;}

    }
}
