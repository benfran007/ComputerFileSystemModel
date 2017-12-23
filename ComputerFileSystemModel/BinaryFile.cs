using System;
using System.Text;

namespace ComputerFileSystemModel
{
    class BinaryFile: File
    {
        private byte[] m_Content;

        public BinaryFile(string name) : base(name) { }

        public byte[] Content
        {
            get { return m_Content; }
            set
            {
                m_Content = value;
                m_DateOfLastChange = DateTime.Now;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append("\n\t\t----------\nBinary File Contents: \t");
            
            foreach (var item in m_Content)
            {
                result.Append(item);
            }
            result.Append("\n\t\t----------\n");
            return result.ToString();
        }
    }
}
