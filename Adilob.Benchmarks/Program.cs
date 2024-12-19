using BenchmarkDotNet.Running;

namespace Adilob.Benchmarks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BenchmarkProducts().Wait();
		}

		static async Task BenchmarkProducts()
		{
			BenchmarkRunner.Run<Products.Benchmarks>();
			BenchmarkRunner.Run<EndsWith.Benchmarks>();
		}
	}
}
