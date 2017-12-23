using System;
using System.Text;
using System.Collections.Generic;

namespace ComputerFileSystemModel
{
    class Directory
    {
        private string m_Name;
        private List<Directory> m_Directories;
        private List<File> m_Files;
        private DateTime m_DateOfLastChange;

        public Directory(string name)
        {
            m_Name = name;
            m_Directories = new List<Directory>();
            m_Files = new List<File>();
            m_DateOfLastChange = DateTime.Now;
        }

        public DateTime DateOfLastChange
        {
            get { return m_DateOfLastChange; }
        }

        public void AddDirectory(Directory directory)
        {
            if (m_Directories.Contains(directory))
            {
                Console.WriteLine("Directory already exists!");
                return;
            }
            m_Directories.Add(directory);
            m_DateOfLastChange = DateTime.Now;
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
                m_DateOfLastChange = DateTime.Now;
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
            m_DateOfLastChange = DateTime.Now;
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
                m_DateOfLastChange = DateTime.Now;
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
            result.AppendFormat("\tName of Directory: {0}\n\tDate of last change: {1}\n\t\t**********\n\t\t**********\n", m_Name, m_DateOfLastChange);
            foreach (var file in m_Files)
            {
                result.AppendLine("\t" + file.ToString());
            }

            foreach (var directory in m_Directories)
            {
                result.AppendLine("\t" + directory.ToString());
            }
            return result.ToString();
        }
    }
}
