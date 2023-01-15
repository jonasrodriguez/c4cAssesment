namespace test;

public class FileReaderTest {

    private static readonly string FILE_PATH = "./resources" ;
    private static readonly string WRONG_PATH = "./resources2" ;

    [Fact]
    public void ProcessFolderFilesShould_returnFilesOnPath_AndContent() {
        FileReader reader = new FileReader();
        var content = reader.ProcessFolderFiles(FILE_PATH);
        Assert.Equal(2, content.Count);

        string [] files = Directory.GetFiles(FILE_PATH);
        foreach(string f in files) {
            string filename = Path.GetFileName(f);
            String fileContent = File.ReadAllText(f);
            Assert.True(content.ContainsKey (filename));
            Assert.Equal(fileContent, content[filename]);
        }
    }    

    [Fact]
    public void ProcessFolderFilesShould_returnEmptyList_whenPathNotExist() {
        FileReader reader = new FileReader();
        var content = reader.ProcessFolderFiles(WRONG_PATH);
        Assert.Empty(content);
    }
}