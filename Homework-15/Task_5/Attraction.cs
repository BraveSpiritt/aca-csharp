using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Attraction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Attraction(string name, string description, string category)
        {
            Name = name;
            Description = description;
            Category = category;
        }
        public override string ToString()
        {
            return $"{Name} - {Category}: {Description}";
        }
    }
}
