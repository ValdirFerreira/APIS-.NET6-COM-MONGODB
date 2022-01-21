namespace WebApiMongoDB.Models
{
    public class ProdutoDatabaseSettings
    {
        public string ConnectionString { get; set; } = null;
        public string DatabaseName { get; set; } = null;
        public string ProdutoCollectionName { get; set; } = null;
    }
}
