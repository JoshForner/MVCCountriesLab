using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryListView
    {
        public List<Country> countries { get; set; }
        public CountryListView(List<Country> countries)
        {
            this.countries = countries;
        }

        public void Display()
        {
            for (int i = 0; i < countries.Count; i++)
            {
                Country c = countries[i];
                Console.WriteLine($"{i}. {c.Name}");
            }
        }
    }
}
