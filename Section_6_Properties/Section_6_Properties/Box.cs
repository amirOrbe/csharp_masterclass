using System;
using System.Collections.Generic;
using System.Text;

namespace Section_6_Properties
{
	public class Box
	{
        //member variable
		private int  lenght = 3;
        private int height;
        public int width;
        private int volume;

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if(height < 0) { throw new Exception("Height should be higher than 0"); }
                height = value;
            }
        }

        public int Volume
        {
            get
            {
                return this.lenght * this.height * this.width;
            }
        }

        public void SetLength(int lenght)
        {
            if (lenght < 0)
            {
                throw new Exception("Lenght should be higher than 0");
            }
            this.lenght = lenght;
        }

        public int GetLength()
        {
            return this.lenght;
        }

        public int GetVolume()
        {
            return this.lenght * this.height * this.width; 
        }

        public void DisplayInfo()
        {
            volume = lenght * height * width;
            Console.WriteLine($"Lenght is {lenght} and height {height} and width {width} so the volume is {volume}");
            Console.Read();
        }

        public int FrontSurface
        {
            get
            {
                return height * lenght;
            }
        }
    }
}

