namespace Test.Helpers
{
  public class FileUtil
  {
        public static void AddLine(string FilePath,object? Text)
        {
        string readText = System.IO.File.ReadAllText(FilePath);
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            writer.Write(readText);
            writer.Write(Text);
            writer.Write(Environment.NewLine);
        }
        }
  }
}