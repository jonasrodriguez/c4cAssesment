using System.Text.RegularExpressions;

public class TextSearch : ISearch {

    public Dictionary<string, int> ProcessSearch(string searchValue, Dictionary<string, string> fileContent) {
        Dictionary<string, int> matchesList = new Dictionary<string, int>();
        string pattern = String.Format(@"{0}", searchValue);        
        foreach(var file in fileContent) {            
            int matches = CountMatches(pattern, file.Value);
            if (matches > 0 ) {
                matchesList.Add(file.Key, matches);
            }
        }
        return matchesList;
    }

    private static int CountMatches(string pattern, string content) {
        return Regex.Matches(content, pattern, RegexOptions.IgnoreCase).Count;
    }
}