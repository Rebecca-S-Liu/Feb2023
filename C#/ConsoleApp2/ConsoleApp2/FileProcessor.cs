namespace ConsoleApp2;

public class FileProcessor
{
    public void ProcessFile(string filename)
    {
        FileStream stream = null;

        try
        {
            stream = new FileStream(filename, FileMode.Open);

            // Do something with the file stream here
            stream.Close();
        }
        catch (IOException ex)
        {
            // Handle the exception here
        }
        finally
        {
            if (stream != null)
            {
                stream.Dispose();
            }
        }
    }

}