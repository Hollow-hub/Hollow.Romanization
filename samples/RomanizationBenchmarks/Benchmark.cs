namespace Hollow.RomanizationBenchmarks;

using BenchmarkDotNet.Attributes;

using Hollow.Romanization;

[RPlotExporter]
[MemoryDiagnoser]
public class Benchmark
{
  [Params("Μητσος", "Μήτσος", "ΜΗΤΣΟΣ", "ΜΗτΣος", "ΜήτΣΟς", "Σαλιγκάρι", "γείτονας", "αιώρα", "συΐτης")]
  public string input;

  [Benchmark]
  public string BenchmarkRomanizeString() => input.RomanizeGreek();
}
