using System;

namespace ComputerFileSystemModel
{
    abstract class File
    {
        private string m_Name;
        private DateTime m_DateOfCreation;
        protected DateTime m_DateOfLastChange;

        public File(string name)
        {
            m_Name = name;
            m_DateOfCreation = DateTime.Now;
            m_DateOfLastChange = DateTime.Now;
        }

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public DateTime DateOfCreation
        {
            get { return m_DateOfCreation; }
        }

        public DateTime DateOfLastChange
        {
            get { return m_DateOfLastChange; }
        }

        public override string ToString()
        {
            string result = string.Format("\tFileName: {0}\n\tDate of Creation: {1}\n\tDate of Last Change: {2}",
                m_Name, m_DateOfCreation, m_DateOfLastChange);
            return result;
        }
    }
}
