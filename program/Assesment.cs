public class Assesment {

    private FileContent fileContent;
    private SearchResult searchResult;

    public Assesment() {
        fileContent = FileContent.Create();
        searchResult = SearchResult.Create();
    }

	public void Start(string path) {
		IReader reader = new FileReader();
        var newContent = reader.ProcessFolderFiles(path);
		fileContent.AddContent(newContent);
		Console.WriteLine("{0} file/s read in directory {1}", fileContent.Size(), path);
        if (!fileContent.IsEmpty()) {
		    ProcessSearchInput();
        }
	}

	private void ProcessSearchInput() {
		while(true) {
			Console.Write("Input search: ");
			string? searchValue = Console.ReadLine();
            if (searchValue != null) {
                ManageSearch(searchValue);
            }
            searchResult.ClearContent();
            Console.WriteLine("***************");
		}
	}

    private void ManageSearch(string searchValue) {
        ISearch search = new TextSearch();
        var results = search.ProcessSearch(searchValue, fileContent.GetContent());
        searchResult.AddContent(results);
        ManageSorting();
    }

    private void ManageSorting() {
        ISort sorting = new SortResults();
        if (searchResult.IsEmpty()) {
            Console.WriteLine("No matches found");
            return;
        }
        var sortedResults = sorting.ProcessSorting(searchResult.GetResults());
        foreach(var result in sortedResults) {
            Console.WriteLine("{0} -> {1} occurrences", result.Key, result.Value);
        }        
    }        
}