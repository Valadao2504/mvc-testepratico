using System.Data.Entity;


namespace mvc.Models
{
    public class contexto : DbContext
    {
        public DbSet<produto> Produto { get; set; }
        public DbSet<categoriaproduto> Categoria { get; set; }

    }
}

