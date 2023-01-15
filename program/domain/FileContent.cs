public class FileContent {
    public Dictionary<string, string> content {get;}

    public FileContent() {
        content = new Dictionary<string, string>();
    }

    public void AddContent(string filename, string fileContent) {
        content.Add(filename, fileContent);
    }   

    public void AddContent(Dictionary<string, string> newContent) {
        foreach(var item in newContent) {
            content.Add(item.Key, item.Value);
        }
    }

    public bool IsEmpty() {
        return content.Count == 0;
    }

    public int Size() {
        return content.Count;
    }
}
