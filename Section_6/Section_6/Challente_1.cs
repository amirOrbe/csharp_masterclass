using System;

namespace Challenge_1
{
    public class Phone
    {
        private string company;
        private string model;
        private string releaseDay;
        public Phone()
        {
            this.company = "unknown";
            this.model = "unknown";
            this.releaseDay = "unknown";
        }

        public Phone(string company, string model)
        {
            this.company = company;
            this.model = model;
            this.releaseDay = "unknown";
        }

        public Phone(string company, string model, string releaseDay)
        {
            this.company = company;
            this.model = model;
            this.releaseDay = releaseDay;
        }

        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", model, company, releaseDay);
        }
    }
}