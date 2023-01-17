public class Assesment {

	public void Start(string path) {
		IProvider reader = new FileProvider();
        var content = reader.ProcessContent(path);
		FolderContent folderContent = new FolderContent(content);
		Console.WriteLine("{0} file/s read in directory {1}", folderContent.Size(), path);
        if (!folderContent.IsEmpty()) {
		    ProcessSearchInput(folderContent);
        }
	}

	private void ProcessSearchInput(FolderContent folderContent) {
		while(true) {
			Console.Write("Input search: ");
			string? searchValue = Console.ReadLine();
            if (searchValue != null) {
                ManageSearch(folderContent, searchValue);
            }
            Console.WriteLine("***************");
		}
	}

    private void ManageSearch(FolderContent folderContent, string searchValue) {
        ISearch search = new TextSearch();
        var results = search.ProcessSearch(searchValue, folderContent.GetContent());
        printResults(results);
    }

    private void printResults(List<KeyValuePair<string, int>> results) {
        if (results.Count == 0) {
            Console.WriteLine("No matches found");
            return;
        }
        for (int i = 0; i < 10 && i < results.Count; i++) {
            Console.WriteLine("{0} -> {1} occurrences", results[i].Key, results[i].Value);
        }
    }     
}