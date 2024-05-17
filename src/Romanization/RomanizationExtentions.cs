namespace Hollow.Romanization;

using System.Collections.Frozen;
using System.Diagnostics.Contracts;
using System.Text;

public static class RomanizationExtentions
{
  private static readonly FrozenDictionary<string, string> ELOT743Mapping = new Dictionary<string, string>()
  {
    { "Α", "A" },
    { "Β", "V" },
    { "Γ", "G" },
    { "Δ", "D" },
    { "Ε", "E" },
    { "Ζ", "Z" },
    { "Η", "I" },
    { "Θ", "Th" },
    { "Ι", "I" },
    { "Κ", "K" },
    { "Λ", "L" },
    { "Μ", "M" },
    { "Ν", "N" },
    { "Ξ", "X" },
    { "Ο", "O" },
    { "Π", "P" },
    { "Ρ", "R" },
    { "Σ", "S" },
    { "Τ", "T" },
    { "Υ", "Y" },
    { "Φ", "F" },
    { "Χ", "Ch" },
    { "Ψ", "Ps" },
    { "Ω", "O" },
    { "α", "a" },
    { "β", "v" },
    { "γ", "g" },
    { "δ", "d" },
    { "ε", "e" },
    { "ζ", "z" },
    { "η", "i" },
    { "θ", "th" },
    { "ι", "i" },
    { "κ", "k" },
    { "λ", "l" },
    { "μ", "m" },
    { "ν", "n" },
    { "ξ", "x" },
    { "ο", "o" },
    { "π", "p" },
    { "ρ", "r" },
    { "ς", "s" },
    { "σ", "s" },
    { "τ", "t" },
    { "υ", "y" },
    { "φ", "f" },
    { "χ", "ch" },
    { "ψ", "ps" },
    { "ω", "o" },
    { "αι", "ai" },
    { "αυ", "av" },
    { "γγ", "ng" },
    { "γκ", "gk" },
    { "γξ", "nx" },
    { "γχ", "nch" },
    { "ει", "ei" },
    { "ευ", "ev" },
    { "ηυ", "iv" },
    { "μπ", "b" },
    { "ντ", "nt" },
    { "οι", "oi" },
    { "ου", "ou" },
    { "υι", "yi" },
    { "ωυ", "oy" },
    { "ά", "a" },
    { "έ", "e" },
    { "ή", "i" },
    { "ί", "i" },
    { "ό", "o" },
    { "ύ", "y" },
    { "ώ", "o" },
    { "ΐ", "i" },
    { "ΰ", "y" },
    { "Αί", "Ai" },
    { "Αύ", "Av" },
    { "Εί", "Ei" },
    { "Εύ", "Ev" },
    { "Ηύ", "Iv" },
    { "Οί", "Oi" },
    { "Ού", "Ou" },
    { "Υί", "Yi" },
    { "αί", "ai" },
    { "αύ", "av" },
    { "εί", "ei" },
    { "εύ", "ev" },
    { "ηύ", "iv" },
    { "οί", "oi" },
    { "ού", "ou" },
    { "υί", "yi" },
  }.ToFrozenDictionary();

  /// <summary>
  /// Transcripts greek letters to latin letters.
  /// </summary>
  /// <param name="input">The string to Romanize.</param>
  /// <returns>Returns the transcripted string.</returns>
  /// <exception cref="ArgumentNullException">When <paramref name="input"/> is null.</exception>
  [Pure]
  public static string RomanizeGreek(this string input)
  {
    ArgumentNullException.ThrowIfNull(input);
    var result = new StringBuilder();
    for (var i = 0; i < input.Length; i++)
    {
      if (i < input.Length - 1 && ELOT743Mapping.TryGetValue(input.Substring(i, 2), out var transliteratedDiphthong))
      {
        result.Append(transliteratedDiphthong);
        i++;
      }
      else if (ELOT743Mapping.TryGetValue(input[i].ToString(), out var transliterated))
      {
        result.Append(transliterated);
      }
      else
      {
        result.Append(input[i]);
      }
    }

    return result.ToString();
  }
}
