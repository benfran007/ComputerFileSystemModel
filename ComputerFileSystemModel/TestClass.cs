using System;
using System.Text;

namespace ComputerFileSystemModel
{
    class TestClass
    {
        static void Main(string[] args)
        {
            var fileSystem = new ComputerFileSystem("Benjamin Francis");
            var flashDrive = new Device("Flash");
            var hardDrive = new Device("Hard disk");
            fileSystem.AddDevice(flashDrive);
            fileSystem.AddDevice(hardDrive);

            Console.WriteLine("First Dance");
            Console.WriteLine(fileSystem);

            var directoryInFlash = new Directory("My Directory in Flash");
            var galleryDirectoryInDirectory = new Directory("Directory in another directory in Flash");

            var schoolReport = new TextFile("School Report") { Content = "School sucks, wanna get done soon!!!" };
            var gameData = new BinaryFile("Game Binary Date") { Content = Encoding.Unicode.GetBytes("г")};

            directoryInFlash.AddFile(schoolReport);
            galleryDirectoryInDirectory.AddFile(gameData);
            directoryInFlash.AddDirectory(galleryDirectoryInDirectory);

            flashDrive.AddDirectory(directoryInFlash);

            Console.WriteLine("Second Tango");
            Console.WriteLine(fileSystem);

            fileSystem.RemoveDevice(hardDrive);
            directoryInFlash.RemoveDirectory(galleryDirectoryInDirectory);
            schoolReport.Content = "Okay, School is better now.";

            Console.WriteLine("Third Revival");
            Console.WriteLine(fileSystem);
        }
    }
}
