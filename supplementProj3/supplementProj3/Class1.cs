namespace supplementProj3;
using System.IO;
using System;
using System.Text;
public class supplementProj3
{
  /// <summary>
  /// Creates an ASCII file with given content
  /// </summary>
  /// <param name="file">the path of the file to create</param>
  /// <param name="cont">the content to write to the file</param>
   public static void CreateAFile(string file, string cont){
    
    File.WriteAllText(file, cont);
   }

   /// <summary>
   /// Creates an Binary file with given content
   /// </summary>
   /// <param name="file">the path of the file to create</param>
   /// <param name="cont">the content to write the file in bytes</param>
   public static void CreateBFile(string file, byte[] cont){
    File.WriteAllBytes(file,cont);
   }

   /// <summary>
   /// Reading an ASCII file from given text
   /// </summary>
   /// <param name="file">The path of the file given</param>
   /// <returns> Text pass from file</returns>
   public static string ReadingASCII(string file){

    return File.ReadAllText(file);
   }

   /// <summary>
   /// Reading an Binary file from given text in byte
   /// </summary>
   /// <param name="file"> The pathe of the file given</param>
   /// <returns> Text pass from file in bytes</returns>
   public static byte[] ReadingBinary(string file){

    return File.ReadAllBytes(file);
   }

   /// <summary>
   /// Compare two files
   /// </summary>
   public static void comparingFile(){

    int[] numbers = {10, 100, 1000, 10000,1000000};
    foreach (int num in numbers){

        string cont = new string('A', num);
        byte[] BinaryCont = Encoding.UTF8.GetBytes(cont);


        string ASCII = $"ascii_{num}.txt";
        string Binary = $"binary_{num}.bin";

        supplementProj3.CreateAFile(ASCII, cont);
        supplementProj3.CreateBFile(Binary, BinaryCont);

        long asciiSize = new FileInfo(ASCII).Length;
        long binarySize = new FileInfo(Binary).Length;

        Console.WriteLine($"Size {num}: ASCII = {asciiSize} bytes, Binary = {binarySize} bytes");
    }
   }
}
