public class FileReader : IReader {
    public Dictionary<string, string> ProcessFolderFiles(string path) {
        if (!Directory.Exists(path)) {
            return new Dictionary<string, string>();
        }
        
        Dictionary<string, string> content = new Dictionary<string, string>();
        string [] files = Directory.GetFiles(path);
        foreach(string filename in files) {
            ReadFile(filename, content);
        }
        return content;
    }

    private static void ReadFile(string path, Dictionary<string, string> content) {
        if (!File.Exists(path)) {
            return;
        }
        String filename = Path.GetFileName(path);
        String fileContent = File.ReadAllText(path);
        content.Add(filename, fileContent);
    }
}