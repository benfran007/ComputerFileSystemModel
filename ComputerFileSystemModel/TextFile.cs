using System;
using System.Text;

namespace ComputerFileSystemModel
{
    class TextFile: File
    {
        private string m_Content;

        public TextFile(string name) : base(name) { }

        public string Content
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
            string result = base.ToString() + string.Format("\n\t\t----------\n\tText File Contents: {0}\n\t\t----------\n",
                m_Content);
            return result;
        }
    }
}
