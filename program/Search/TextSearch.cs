using System.Text.RegularExpressions;

public class TextSearch : ISearch {

    public List<KeyValuePair<string, int>> ProcessSearch(string searchValue, Dictionary<string, string> fileContent) {
        var matchesList = new List<KeyValuePair<string, int>>();
        string pattern = String.Format(@"{0}", searchValue);        
        foreach(var file in fileContent) {            
            int matches = CountMatches(pattern, file.Value);
            if (matches > 0 ) {
                matchesList.Add(new KeyValuePair<string, int>(file.Key, matches));
            }
        }
        sortList(matchesList);
        return matchesList;
    }

    private int CountMatches(string pattern, string content) {
        return Regex.Matches(content, pattern, RegexOptions.IgnoreCase).Count;
    }

    private void sortList(List<KeyValuePair<string, int>> list) {
        list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
    }
}