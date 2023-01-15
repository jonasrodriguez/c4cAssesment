namespace test;

public class TextSearchTest {
    private static readonly Dictionary<string, string> FILE_CONTENT = new Dictionary<string, string>() {
        { "file1", "catcatcatdogcat" },
        { "file2", "birdbirdcatbird" }
    };

    [Fact]
    public void ProcessSearchShould_returnNumberOfMatches() {
        TextSearch search = new TextSearch();
        var results = search.ProcessSearch("cat", FILE_CONTENT);
        Assert.Equal(2, results.Count);
        Assert.Equal(4, results["file1"]);
        Assert.Equal(1, results["file2"]);
    }

    [Fact]
    public void ProcessSearchShould_NotReturnFile_WhenNoMatches() {
        TextSearch search = new TextSearch();
        var results = search.ProcessSearch("dog", FILE_CONTENT);
        Assert.Single(results);
        Assert.Equal(1, results["file1"]);
        Assert.False(results.ContainsKey("file2"));
    }

    [Fact]
    public void ProcessSearchShould_returnEmpty_WhenNoMatches() {
        TextSearch search = new TextSearch();
        var results = search.ProcessSearch("cow", FILE_CONTENT);
        Assert.Empty(results);
    }
}