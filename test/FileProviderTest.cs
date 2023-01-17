namespace test;

public class FileReaderTest {

    private static readonly string FILE_PATH = "./resources" ;
    private static readonly string WRONG_PATH = "./resources2" ;

    [Fact]
    public void ProcessFolderFilesShould_returnFilesOnPath_AndContent() {
        FileProvider reader = new FileProvider();
        var content = reader.ProcessContent(FILE_PATH);
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
        FileProvider reader = new FileProvider();
        var content = reader.ProcessContent(WRONG_PATH);
        Assert.Empty(content);
    }
}