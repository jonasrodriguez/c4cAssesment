public class SearchResult {
    private Dictionary<string, int> results;

    private SearchResult() {
        results = new Dictionary<string, int>();
    }

    public static SearchResult Create() {
        return new SearchResult();
    }

    public Dictionary<string, int> GetResults() {
        return results;
    }

    public void AddContent(Dictionary<string, int> newContent) {
        foreach(var content in newContent) {
            results.Add(content.Key, content.Value);
        }
    }

    public void ClearContent() {
        results.Clear();
    }

    public bool IsEmpty() {
        return results.Count == 0;
    }
}
