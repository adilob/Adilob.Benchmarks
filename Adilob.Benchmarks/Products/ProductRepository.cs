namespace Adilob.Benchmarks.Products
{
	public class ProductRepository : IProductRepository
	{
		private readonly List<Product> _products = new List<Product>
		{
			new Product
			{
				Id = Guid.NewGuid(),
				Name = "Product 1",
				Description = "Description 1",
				Price = 100,
				Color = "Red",
				Size = "M"
			},
			new Product
			{
				Id = Guid.NewGuid(),
				Name = "Product 2",
				Description = "Description 2",
				Price = 200,
				Color = "Blue",
				Size = "L"
			},
			new Product
			{
				Id = Guid.NewGuid(),
				Name = "Product 3",
				Description = "Description 3",
				Price = 300,
				Color = "Green",
				Size = "XL"
			}
		};

		public Product? GetProduct(Guid id) => _products.FirstOrDefault(p => p.Id == id);

		public IEnumerable<Product> GetProducts()
		{
			return _products;
		}
	}
}
