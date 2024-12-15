namespace Adilob.Benchmarks.Products
{
	internal interface IProductRepository
	{
		Product? GetProduct(Guid id);
		IEnumerable<Product> GetProducts();
	}
}
