/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте на диске 50 директорий с именами от Folder_0
до Folder_50, после чего вывести информацию на консоль о каждой из директорий,
затем удалите их.
*/

var directory = Directory.CreateDirectory(@"C:\TestFolders");

CreateFolders("Folders_");
DeleteFolders();

void CreateFolders(string name)
{
    if (directory.Exists)
    {
        Console.WriteLine("Создание папок");
        Console.WriteLine(new string('-', 40));
        for (int i = 0; i <= 50; i++)
        {
            DirectoryInfo subDir = directory.CreateSubdirectory(name + i);
            Console.WriteLine($"Имя: {subDir.Name} | Дата и время создания: {subDir.CreationTime}");
        }
        
    }
}
void DeleteFolders()
{
    if (directory.Exists)
    {
        directory.Delete(true);
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Все папки удалены");
    }   
}


