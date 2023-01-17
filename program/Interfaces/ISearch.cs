interface ISearch {
    List<KeyValuePair<string, int>> ProcessSearch(string searchValue, Dictionary<string, string> fileContent);
}
