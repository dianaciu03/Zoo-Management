﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class ZooTaskDTO
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime TaskDateTime { get; private set; }
        public int EstimatedDuration { get; private set; }
        public string Status { get; private set; }
        public string Species { get; private set; }
        public string EnclosureArea { get; private set; }
        public int EnclosureNumber { get; private set; }
        public int? AnimalID { get; set; }
        public string Repetitive { get; set; }

        public ZooTaskDTO(int iD, string name, string description, DateTime taskDateTime, int estimatedDuration, string species, string enclosureArea, int enclosureNumber, string status)
        {
            this.ID = iD;
            this.Name = name;
            this.Description = description;
            this.TaskDateTime = taskDateTime;
            this.EstimatedDuration = estimatedDuration;
            this.Status = "Not started";
            this.Species = species;
            this.EnclosureArea = enclosureArea;
            this.EnclosureNumber = enclosureNumber;
            this.Status = status;
        }
        public ZooTaskDTO(string name, string description, DateTime taskDateTime, int estimatedDuration, string species, string enclosureArea, int enclosureNumber, string status)
        {
            this.Name = name;
            this.Description = description;
            this.TaskDateTime = taskDateTime;
            this.EstimatedDuration = estimatedDuration;
            this.Status = "Not started";
            this.Species = species;
            this.EnclosureArea = enclosureArea;
            this.EnclosureNumber = enclosureNumber;
            this.Status = status;
        }
        public ZooTaskDTO(int iD, string name, string description, DateTime taskDateTime, int estimatedDuration, string species, string enclosureArea, int enclosureNumber, string status, int? AnimalID, string? repetitive)
        {
            this.ID = iD;
            this.Name = name;
            this.Description = description;
            this.TaskDateTime = taskDateTime;
            this.EstimatedDuration = estimatedDuration;
            this.Status = "Not started";
            this.Species = species;
            this.EnclosureArea = enclosureArea;
            this.EnclosureNumber = enclosureNumber;
            this.Status = status;
            this.AnimalID = AnimalID;
            this.Repetitive = repetitive;

        }
        public ZooTaskDTO(string name, string description, DateTime taskDateTime, int estimatedDuration, string species, string enclosureArea, int enclosureNumber, string status, int? AnimalID, string? repetitive)
        { 
            this.Name = name;
            this.Description = description;
            this.TaskDateTime = taskDateTime;
            this.EstimatedDuration = estimatedDuration;
            this.Status = "Not started";
            this.Species = species;
            this.EnclosureArea = enclosureArea;
            this.EnclosureNumber = enclosureNumber;
            this.Status = status;
            this.AnimalID = AnimalID;
            this.Repetitive = repetitive;
        }

    }
}
