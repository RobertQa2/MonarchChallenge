using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace MonarchsChallenge;

public class Monarch
{
    private const string Space = " ";
    private const string Dash = "-";

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nm")]
    public string Name { get; set; }

    public string FirstName => Name.Split(Space, StringSplitOptions.RemoveEmptyEntries).First(); 
    //There are cases where two names are separated by dash

    [JsonPropertyName("cty")] 
    public string Country { get; set; }

    [JsonPropertyName("hse")]
    public string House { get; set; }

    [JsonPropertyName("yrs")] 
    public string Years { get; set; }
    
    public int RulingLength
    {
        get
        {
            if (Years.Contains(Dash) is false)
            {
                return 1;
            }

            var splitYears = Years.Split(Dash, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (splitYears.Length < 2)
            {
                return DateTime.Now.Year - splitYears.First();
            }
            return splitYears.Last() - splitYears.First();
        }
    }
}

/*
Code suggestions: 
- Monarchs lived before our era. Attempting to call the test by specifying a negative value and 
  adding BC to the end of the year failed to generate a valid case. This applies to the cases of a monarch
  living only in BC, as well as in BC and AC.
- In the case of a one year living monarch, I gave two the same date. 
  The expected result is one year of reign, I received zero.
*/