using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLibrary.Animals;

namespace ZooBazaarLogicLibrary
{
    public class Animal
    {
        private int id;
        private string name;
        private string gender;
        private string species;
        private DateTime birthday;
        private ORIGINCONTINENT origin;
        private string description;
        private ENDANGERMENT endangerment;
        private int enclosure;
        private string availability;

        public Transfer Transfer { get; set; }

        public Animal(int id, string name, string gender, string species, DateTime birthday, ORIGINCONTINENT origin, string description, ENDANGERMENT endangerment, int enclosure)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.species = species;
            this.birthday = birthday;
            this.origin = origin;
            this.description = description;
            this.endangerment = endangerment;
            this.enclosure = enclosure;
        }

        public Animal(int id, string name, string gender, string species, DateTime birthday, ORIGINCONTINENT origin, string description, ENDANGERMENT endangerment, int enclosure, string availability)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.species = species;
            this.birthday = birthday;
            this.origin = origin;
            this.description = description;
            this.endangerment = endangerment;
            this.enclosure = enclosure;
            this.availability = availability;
        }

        public int Id { get { return id; } set { this.id = value; } }

        public string Name { get { return name; } set { this.name = value; } }

        public string Gender { get { return gender; } set { this.gender = value; } }

        public string Species { get { return species; } set { this.species = value; } }

        public DateTime Birthday { get { return birthday; } set { this.birthday = value; } }

        public ORIGINCONTINENT OriginContinent { get { return origin; } set { this.origin = value; } }

        public string Description { get { return description; } set { this.description = value; } }

        public ENDANGERMENT Endangerment { get { return endangerment; } set { this.endangerment = value; } }

        public int Enclosure { get { return enclosure; } set { this.enclosure = value; } }

        public string Availability { get { return availability; } set { this.availability = value; } }

        public int GetAge()
        {
            int age = DateTime.Now.Year - birthday.Year;
            return age;
        }

        public override string ToString()
        {
            return $"{this.name} ({this.species} - {this.gender})";
        }

        public string GetAnimalDetails()
        {
            string info = $"{this.name} ({this.species} - {this.gender})\nAge: {GetAge()}\nBirthday: {birthday}\nOrigin continent: {origin}, enclosure: {enclosure}\nEndangerment level: {endangerment}\n\nTransfer details: ";
            if (availability == "Available")
            {
                info += "Animal is currently available in the zoo";
            }
            else
                info += $"Animal is currently transferred to another zoo\nZoo name: {Transfer.ZooName}\nZoo address: {Transfer.ZooAdress}\nStart date: {Transfer.StartDate}\nEnd date: {Transfer.EndDate}\nComments: {Transfer.Description}";
            return info;
        }

    }
}
