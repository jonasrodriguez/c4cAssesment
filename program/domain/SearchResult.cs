public class SearchResult {
    public Dictionary<string, int> results {get;}

    public SearchResult() {
        results = new Dictionary<string, int>();
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

    public int Size() {
        return results.Count;
    }
}
