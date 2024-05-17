namespace Hollow.RomanizationTests;

using Hollow.Romanization;

public class GreekTranscriptionTest
{
  [Fact]
  public void Lowercase()
  {
    var input = "μητσος";

    var result = input.RomanizeGreek();

    Assert.Equal("mitsos", result);
  }

  [Fact]
  public void Lowercase_with_accent()
  {
    var input = "μήτσος";

    var result = input.RomanizeGreek();

    Assert.Equal("mitsos", result);
  }

  [Fact]
  public void Uppercase()
  {
    var input = "ΜΗΤΣΟΣ";

    var result = input.RomanizeGreek();

    Assert.Equal("MITSOS", result);
  }

  [Fact]
  public void Mixedcase()
  {
    var input = "ΜΗτΣος";

    var result = input.RomanizeGreek();

    Assert.Equal("MItSos", result);
  }

  [Fact]
  public void Mixedcase_with_accent()
  {
    var input = "ΜήτΣΟς";

    var result = input.RomanizeGreek();

    Assert.Equal("MitSOs", result);
  }

  [Fact]
  public void Diphthong()
  {
    var input = "Σαλιγκάρι";

    var result = input.RomanizeGreek();

    Assert.Equal("Saligkari", result);
  }

  [Fact]
  public void Diphthong_with_accent()
  {
    var input = "γείτονας";

    var result = input.RomanizeGreek();

    Assert.Equal("geitonas", result);
  }

  [Fact]
  public void The_first_two_letters_consists_of_Diphthong()
  {
    var input = "αιώρα";

    var result = input.RomanizeGreek();

    Assert.Equal("aiora", result);
  }

  [Fact]
  public void Dieresis()
  {
    var input = "συΐτης";

    var result = input.RomanizeGreek();

    Assert.Equal("syitis", result);
  }
}
