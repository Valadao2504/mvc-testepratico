using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Ativo { get; set; }
        public string Perecivel { get; set; }
        public int CategoriaId { get; set; }
    }
}
