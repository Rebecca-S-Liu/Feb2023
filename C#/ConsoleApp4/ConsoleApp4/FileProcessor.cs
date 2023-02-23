using System.IO;

namespace ConsoleApp4;

public class FileProcessor
{
    public void ProcessFile(string filename)
    {
        FileStream fileStream = null;
        try
        {
            //Open the file stream
            fileStream = new FileStream("filename.txt", FileMode.Open);

            //perform some operations
            //...

            fileStream.Close();

        }
        catch (IOException ex)
        {
            //handle exception
        }
        finally
        {
            if (fileStream != null)
            {
                fileStream.Dispose();
            }
        }
    }   
}