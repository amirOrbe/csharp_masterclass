using System;
namespace Section_9
{
    internal class Tv : ElectricalDevice
    {
        public Tv(bool isOn, string brand) : base(isOn, brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV :)");
            }
            else
            {
                Console.WriteLine("TV is switched off :(");
            }
        }
    }
}