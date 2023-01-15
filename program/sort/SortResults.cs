public class SortResults : ISort {

    public List<KeyValuePair<string, int>>  ProcessSorting(Dictionary<string, int> searchResults) {
        return SortByValueOnlyTopTen(searchResults);
    }

    private static List<KeyValuePair<string, int>> SortByValueOnlyTopTen(Dictionary<string, int> searchResults) {
        var list = searchResults.ToList();
        list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
        return list;
    }
}