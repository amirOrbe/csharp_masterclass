using System;

namespace Section_9
{
	 class Radio : ElectricalDevice
	{
        public Radio(bool isOn, string brand):base(isOn, brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening the Radio :)");
            }
            else
            {
                Console.WriteLine("Radio is switched off :(");
            }
        }
    }

}

