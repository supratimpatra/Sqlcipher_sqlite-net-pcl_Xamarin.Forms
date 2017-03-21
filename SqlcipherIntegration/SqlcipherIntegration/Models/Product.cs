using SQLite;
namespace SqlcipherIntegration.Models
{
    public class Product
    {
        [PrimaryKey]
        public string ProductId { get; set; }
        [NotNull]
        public string Description { get; set; }
    }
}
