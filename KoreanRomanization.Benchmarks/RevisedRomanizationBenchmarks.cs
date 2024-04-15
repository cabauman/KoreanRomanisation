using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace KoreanRomanization.Benchmarks;

[MemoryDiagnoser]
public class RevisedRomanizationBenchmark
{
    private RevisedRomanization romanization;

    [GlobalSetup]
    public void Setup()
    {
        romanization = new RevisedRomanization();
    }

    [Benchmark]
    public string BenchmarkRomanization()
    {
        return romanization.RomanizeText("안녕");
    }
}
