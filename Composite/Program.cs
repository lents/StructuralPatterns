namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create individual files
            File file1 = new File("File1.txt");
            File file2 = new File("File2.txt");
            File file3 = new File("File3.txt");

            // Create folders and add files to them
            Folder folder1 = new Folder("Folder1");
            folder1.Add(file1);
            folder1.Add(file2);

            Folder folder2 = new Folder("Folder2");
            folder2.Add(file3);

            // Create a root folder and add subfolders
            Folder rootFolder = new Folder("RootFolder");
            rootFolder.Add(folder1);
            rootFolder.Add(folder2);

            // Display the file system structure
            rootFolder.Display("");
        }
    }
}
