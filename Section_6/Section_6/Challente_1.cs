using System;

namespace Challenge_1
{
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;


        public Phone()
        {
            this.Company = "unknown";
            this.Model = "unknown";
            this.ReleaseDay = "unknown";
        }

        public Phone(string company, string model)
        {
            this.Company = company;
            this.Model = model;
            this.ReleaseDay = "unknown";
        }

        public Phone(string company, string model, string releaseDay)
        {
            this.Company = company;
            this.Model = model;
            this.ReleaseDay = releaseDay;
        }

        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }

    }

}