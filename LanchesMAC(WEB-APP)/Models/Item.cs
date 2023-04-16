using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMAC_WEB_APP_.Models
{
    [Table("Itens")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required(ErrorMessage ="O Campo Nome do Item é obrigatório")]
        [MinLength(5, ErrorMessage ="O campo Nome do Item deve conter no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "O campo Nome do Item deve conter no máximo {1} caracteres.")]
        [Display(Name ="Nome do Item")]
        public string NomeItem { get; set; }

        [Required(ErrorMessage = "O Campo Descricão Curta é obrigatório")]
        [MinLength(5, ErrorMessage = "O campo Descricão Curta deve conter no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "O campo Descricão Curta deve conter no máximo {1} caracteres.")]
        [Display(Name = "Descricão Curta ")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "O Campo Descricão Detalhada é obrigatório")]
        [MinLength(5, ErrorMessage = "O campo Descricão Detalhada deve conter no mínimo {1} caracteres.")]
        [MaxLength(300, ErrorMessage = "O campo Descricão Detalhada deve conter no máximo {1} caracteres.")]
        [Display(Name = "Descricão Detalhada")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O Campo Preco do Item é obrigatório")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preco do Item deve estar entre 1 e 999.99 dinheiros.")]
        [Display(Name = "Preco do Item ")]
        public decimal Preco { get; set; }

        [Display(Name ="Caminho da Imagem em tamanho normal.")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem em tamanho pequeno.")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Este item é prefereido ?")]
        public bool IsItemPreferido { get; set; }

        [Display(Name = "Este item existe no estoque ?")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set;}

    }
}
