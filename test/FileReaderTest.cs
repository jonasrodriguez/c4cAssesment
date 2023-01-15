namespace test;

public class FileReaderTest {

    private static readonly string FILE_PATH = "./resources" ;

    [Fact]
    public void ProcessFolderFilesShould_returnEmptyList_whenPathNotExist() {
        string path = Directory.GetCurrentDirectory();

        FileReader reader = new FileReader();
        var content = reader.ProcessFolderFiles(FILE_PATH);
        Assert.Empty(content);
    }

}