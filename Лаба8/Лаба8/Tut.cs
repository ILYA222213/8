using System;

namespace Tut
{
    public class Tut
    {
        public string name;
        public string adres;
        public string amount_of_workers;
        public string slogan;

        public Tut(string name, string adres, string amount_of_workers, string slogan)
        {
            this.name = name;
            this.adres = adres;
            this.amount_of_workers = amount_of_workers;
            this.slogan = slogan;
        }
    }
}
