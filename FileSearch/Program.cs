/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите приложение для поиска заданного файла на диске. Добавьте код,
использующий класс FileStream и позволяющий просматривать файл в текстовом окне. В
заключение добавьте возможность сжатия найденного файла.
*/
using System.IO.Compression;

Console.WriteLine("Введите путь к файлу:");
string path = Console.ReadLine(); //"C:/FileInfoTest/"; 

Console.WriteLine("Введите имя и расширение файла:");
string name = Console.ReadLine(); //"Test.txt"; 

string fileName = path + name;

var filesFound = Directory.GetFiles(path, name);

if (filesFound.Contains(fileName))
    ShowFileInfo(fileName);
else
    Console.WriteLine("Файл не найден");

Console.WriteLine("Выберите действие: \n1. Сжать файл 2. Завершить программу");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        CompressFile();
    break;
    case 2:
        Environment.Exit(0);
        break;
}
void CompressFile()
{
    string compressedFile = "C:/FileInfoTest/Test.zip";

    using FileStream targetStream = File.Create(compressedFile);

    using GZipStream gZipStream = new GZipStream(targetStream, CompressionLevel.Optimal);

    Console.WriteLine("Файл успешно сжат");
}
void ShowFileInfo(string fileName)
{
    using (FileStream fstream = File.OpenRead(fileName))
    {
        string fileText = File.ReadAllText(fileName);
        Console.WriteLine("Содержимое файла:");
        Console.WriteLine(fileText);
    }
}