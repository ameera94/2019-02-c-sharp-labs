using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_36_ASPDOTNETIIS.Models
{
    public class Pet
    {
        private string name;
        private string owner;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Owner { get => owner; set => owner = value; }
        public int Age { get => age; set => age = value; }
    }
}