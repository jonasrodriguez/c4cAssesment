public class FolderContent {

    private Dictionary<string, string> content;

    public FolderContent(Dictionary<string, string> content) {
        this.content = content;
    }

    public Dictionary<string, string> GetContent() {
        return content;
    }

    public bool IsEmpty() {
        return content.Count == 0;
    }

    public int Size() {
        return content.Count;
    }
}
