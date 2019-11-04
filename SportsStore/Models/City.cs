using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.Models
{
    class City
    {
        public string Postalcode { get; }
        public string Name { get; }

        public City(string postalcode, string name)
        {
            Postalcode = postalcode;
            Name = name;
        }
    }
}
