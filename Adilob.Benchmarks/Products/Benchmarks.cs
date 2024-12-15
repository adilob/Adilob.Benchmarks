using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Adilob.Benchmarks.Products
{
	[SimpleJob(RunStrategy.ColdStart, iterationCount: 5)]
	[MemoryDiagnoser]
	public class Benchmarks
	{
		[Benchmark]
		public Product? FirstMethod()
		{
			var productRepository = new ProductRepository();
			var productList = productRepository.GetProducts();

			var product = productList.First(p => p.Color == "Red");
			return product;
		}

		[Benchmark]
		public Product? FirstOrDefaultMethod()
		{
			var productRepository = new ProductRepository();
			var productList = productRepository.GetProducts();

			var product = productList.FirstOrDefault(p => p.Color == "Red");
			return product;
		}
	}
}
