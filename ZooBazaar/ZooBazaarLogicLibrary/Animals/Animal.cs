﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLibrary.Enums;
namespace ZooBazaarLogicLibrary
{
    public class Animal
    {
        private int id;
        private string name;
        private GENDER gender;
        private string species;
        private int age;
        private ORIGINCONTINENT origin;
        private string description;
        private ENDANGERMENT endangerment;
        private int enclosure;

        public Animal(int id, string name, GENDER gender, string species, int age, ORIGINCONTINENT origin, string description, ENDANGERMENT endangerment, int enclosure)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.species = species;
            this.age = age;
            this.origin = origin;
            this.description = description;
            this.endangerment = endangerment;
            this.enclosure = enclosure;
        }

        public int Id { get { return id; } set { this.id = value; } }

        public string Name { get { return name; } set { this.name = value; } }

        public GENDER Gender { get { return gender; } set { this.gender = value; } }

        public string Species { get { return species; } set { this.species = value; } }

        public int Age { get { return age; } set { this.age = value; } }

        public ORIGINCONTINENT OriginContinent { get { return origin; } set { this.origin = value; } }

        public string Description { get { return description; } set { this.description = value; } }

        public ENDANGERMENT Endangerment { get { return endangerment; } set { this.endangerment = value; } }

        public int Enclosure { get { return enclosure; } set { this.enclosure = value; } }

        public override string ToString()
        {
            return $"{this.name} ({this.species} - {this.gender})";
        }

    }
}