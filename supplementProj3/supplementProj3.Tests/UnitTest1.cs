namespace supplementProj3.Tests;
using Xunit;
using System.IO;
public class supplementProj3Test
{
   [Fact]
    public void CreateAsciiFile_CreatesFileWithCorrectContent()
    {
        string filePath = "test_ascii.txt";
        string content = "Hello, World!";
        supplementProj3.CreateAFile(filePath, content);

        Assert.True(File.Exists(filePath));
        Assert.Equal(content, File.ReadAllText(filePath));

        File.Delete(filePath);
    } 

    [Fact]
public void CreateBinaryFile_CreatesFileWithCorrectContent()
{
    string filePath = "test_binary.bin";
    byte[] content = { 1, 2, 3, 4, 5 };
    supplementProj3.CreateBFile(filePath, content);

    Assert.True(File.Exists(filePath));
    Assert.Equal(content, File.ReadAllBytes(filePath));

    File.Delete(filePath); 
}


}

