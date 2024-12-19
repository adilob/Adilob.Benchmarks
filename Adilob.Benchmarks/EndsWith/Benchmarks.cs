using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Adilob.Benchmarks.EndsWith
{
	[SimpleJob(RunStrategy.ColdStart, iterationCount: 5)]
	public class Benchmarks
	{
		[Benchmark(Baseline = true)]
		public bool EndsWithStringValue()
		{
			var testString = "adilo";
			return testString.EndsWith("S");
		}

		[Benchmark]
		public bool EndsWithCharValue()
		{
			var testString = "adilo";
			return testString.EndsWith('s');
		}
	}
}
