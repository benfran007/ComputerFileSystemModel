using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFileSystemModel
{
    class Device
    {
        private string m_Name;
        private List<Directory> m_Directories;
        private List<File> m_Files;

        public Device(string name)
        {
            m_Name = name;
            m_Directories = new List<Directory>();
            m_Files = new List<File>();
        }

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public void AddDirectory(Directory directory)
        {
            if (m_Directories.Contains(directory))
            {
                Console.WriteLine("Directory already exists!");
                return;
            }
            m_Directories.Add(directory);
        }

        public void AddDirectories(List<Directory> directories)
        {
            if (directories == null)
            {
                return;
            }
            foreach (var directory in directories)
            {
                AddDirectory(directory);
            }
        }

        public void RemoveDirectory(Directory directory)
        {
            if (m_Directories.Remove(directory))
            {
            }
        }

        public void RemoveDirectories(List<Directory> directories)
        {
            if (directories == null)
            {
                return;
            }
            foreach (var directory in directories)
            {
                RemoveDirectory(directory);
            }
        }

        public void AddFile(File file)
        {
            if (m_Files.Contains(file))
            {
                Console.WriteLine("File already exists!");
                return;
            }
            m_Files.Add(file);
        }

        public void AddFiles(List<File> files)
        {
            if (files == null)
            {
                return;
            }
            foreach (var file in files)
            {
                AddFile(file);
            }
        }

        public void RemoveFile(File file)
        {
            if (m_Files.Remove(file))
            {
            }
        }

        public void RemoveFiles(List<File> files)
        {
            if (files == null)
            {
                return;
            }
            foreach (var file in files)
            {
                RemoveFile(file);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("\tDevice name: {0}\n\t\t==========\n\t\t==========\n", m_Name);
            foreach (var file in m_Files)
            {
                result.AppendLine("\t" + file.ToString());
            }

            foreach (var directory in m_Directories)
            {
                result.AppendLine("\t" + directory.ToString());
            }
            result.AppendFormat("\n\t\t==========\n\t\t===========\n");
            return result.ToString();
        }
    }
}
