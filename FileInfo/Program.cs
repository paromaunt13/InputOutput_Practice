/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте файл, запишите в него произвольные данные и
закройте файл. Затем снова откройте этот файл, прочитайте из него данные и выведете
их на консоль.
*/

Directory.CreateDirectory(@"C:\FileInfoTest");

string path = @"C:\FileInfoTest\Test.txt";
var file = new FileInfo(path);

var fileCreate = file.Create();
fileCreate.Close();

File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

FileDataCreate(file);
ShowFileInfo(file);

void FileDataCreate(FileInfo file)
{
    var writer = file.CreateText();

    writer.WriteLine("Файл успешно создан");
    writer.WriteLine($"Дата и время создания: {file.CreationTime}");
    writer.Close();
}
void ShowFileInfo(FileInfo file)
{
    string fileText = File.ReadAllText(file.FullName);
    Console.WriteLine(fileText);
}

