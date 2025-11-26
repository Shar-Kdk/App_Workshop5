using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop5
{
    internal class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
        }

        public void ShowAllDeviceDetails()
        {
            foreach (var device in devices)
            {
                device.ShowInfo();

                if (device is Laptop lap)
                    lap.TurnOnBattery();

                if (device is Smartphone phone)
                    phone.EnableCamera();

                Console.WriteLine();
            }
        }
    }
}
