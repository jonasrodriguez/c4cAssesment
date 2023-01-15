public class FileContent {
    private Dictionary<string, string> content;

    private FileContent() {
        content = new Dictionary<string, string>();
    }

    public static FileContent Create() {
        return new FileContent();
    }

    public Dictionary<string, string> GetContent() {
        return content;
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
