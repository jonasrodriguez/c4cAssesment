namespace test;

public class SortResultsTest {
    private static readonly Dictionary<string, int> SEARCH_RESULTS = new Dictionary<string, int>() {
        { "file1", 1 },
        { "file2", 2 },
        { "file3", 3 },
        { "file4", 4 },
        { "file5", 5 }
    };

    private static readonly Dictionary<string, int> SEARCH_RESULTS_EQUAL = new Dictionary<string, int>() {
        { "file1", 2 },
        { "file2", 2 }
    };

    [Fact]
    public void ProcessSortingShould_returnSortedList() {
        SortResults sort = new SortResults();
        var sortedResults = sort.ProcessSorting(SEARCH_RESULTS);
        Assert.Equal(5, sortedResults.Count);
        Assert.Equal(5, sortedResults.First().Value);
        Assert.Equal(1, sortedResults.Last().Value);
    }

    [Fact]
    public void ProcessSortingShould_returnSortedSameValue() {
        SortResults sort = new SortResults();
        var sortedResults = sort.ProcessSorting(SEARCH_RESULTS_EQUAL);
        Assert.Equal(2, sortedResults.Count);
        Assert.Equal(2, sortedResults.First().Value);
        Assert.Equal(2, sortedResults.Last().Value);
    }
}