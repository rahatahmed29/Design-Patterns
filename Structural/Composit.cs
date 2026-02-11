public interface IFileSystemItem
{
    int GetSize();
    void Display(string indent);
}
public class File : IFileSystemItem
{
    int _size;
    string _name;
    public File(string name,int size)
    {
        _size=size;
        _name=name;
    }
    public int GetSize()
    {
        return _size;
    }
    public void Display(string indent)
    {
        Console.WriteLine($"{indent}- File: {_name} ({_size} KB)");
    }
}
public class Folder : IFileSystemItem
{
    string _name;
    List<IFileSystemItem>items=new List<IFileSystemItem>();
    public Folder(string name)
    {
        _name=name;
    }
    public void Add(IFileSystemItem file)
    {
        items.Add(file);
    }
    public int GetSize()
    {
        int totalSize=0;
        foreach(var item in items)
        {
            totalSize+=item.GetSize();
            
        }
        return totalSize;
    }
    public void Display(string indent)
    {
        Console.WriteLine($"{indent}+ Folder: {_name}");
        foreach(var item in items)
        {
            item.Display(indent+" ");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        File file1= new File("Resume.pdf",120);
        File file2= new File("Photo.jpg",110);
        Folder document=new Folder("Documents");
        document.Add(file1);
        document.Add(file2);
        Folder root=new Folder("Root");
        root.Add(document);
                root.Add(new File("Readme.txt",50));


       root.Display("");
       Console.WriteLine("Total Size: "+root.GetSize()+" KB");
        
    }
}
