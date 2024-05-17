namespace Hollow.RomanizationBenchmarks;

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;

public static class Program
{
  public static void Main()
  {
    var config = DefaultConfig.Instance
      .AddJob(Job
        .MediumRun
        .WithLaunchCount(1)
        .WithToolchain(InProcessEmitToolchain.Instance));
    _ = BenchmarkRunner.Run<Benchmark>(config);
  }
}
