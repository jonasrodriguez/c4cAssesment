public class FileProvider : IProvider {
    public Dictionary<string, string> ProcessContent(string path) {
        Dictionary<string, string> content = new Dictionary<string, string>();
        if (!Directory.Exists(path)) {
            return content;
        }
        
        string [] files = Directory.GetFiles(path);
        foreach(string filename in files) {
            ReadFile(filename, content);
        }
        return content;
    }

    private void ReadFile(string path, Dictionary<string, string> content) {
        if (!File.Exists(path)) {
            return;
        }
        String filename = Path.GetFileName(path);
        String fileContent = File.ReadAllText(path);
        content.Add(filename, fileContent);
    }
}