using System;
using System.Text;
using System.Collections.Generic;

namespace ComputerFileSystemModel
{
    class ComputerFileSystem
    {
        private string m_Name;
        private List<Device> m_Devices;

        public ComputerFileSystem(string name)
        {
            m_Name = name;
            m_Devices = new List<Device>();
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public void AddDevice(Device device)
        {
            if (m_Devices.Contains(device))
            {
                Console.WriteLine("Device already added.");
                return;
            }
            m_Devices.Add(device);
        }

        public void RemoveDevice(Device device)
        {
            m_Devices.Remove(device);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("\tFile system name: {0}\n\t\t**********\n\t\t**********\n", m_Name);
            foreach (var device in m_Devices)
            {
                result.AppendLine("\t" + device.ToString());
            }
            result.AppendFormat("\n\t\t**********\n\t\t**********\n");
            return result.ToString();
        }
    }
}
