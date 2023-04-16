using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMAC_WEB_APP_.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "O Campo Nome da Categoria é obrigatório")]
        [MinLength(5, ErrorMessage = "O campo Nome da Categoria deve conter no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "O campo Nome da Categoria deve conter no máximo {1} caracteres.")]
        [Display(Name = "Nome da Categoria")]
        public string NomeCategoria { get; set; }

        [Required(ErrorMessage = "O Campo Descricão é obrigatório")]
        [MinLength(5, ErrorMessage = "O campo Descricão deve conter no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "O campo Descricão deve conter no máximo {1} caracteres.")]
        [Display(Name = "Descricão ")]
        public string Descricao { get; set; }

        public List<Item> Itens { get; set; }
    }
}
