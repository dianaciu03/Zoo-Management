using BusinessLogic.Animals;
using BusinessLogic.Employees;
using DataAccess;
using DataAccess.AnimalInterfaces;
using DataAccess.AnimalRepositories;
using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TaskManagement
    {
        private List<ZooTask> tasks;
        TaskRepository taskRepository = new TaskRepository();
        AnimalRepository animalRepository = new AnimalRepository();
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public TaskManagement() 
        {
            //tasks = new List<ZooTask>();
        }

        public void ScheduleTask(string name, string enclosureArea, int enclosureNo, string description, DateTime taskDateTime, int taskLength, string specie, Animal? animal, string? repetitive)
        {

            ZooTask newTask = new ZooTask()
            {
                Name = name,
                Description = description,
                EnclosureArea = enclosureArea,
                EnclosureNumber = enclosureNo,
                Status = "Not started",
                TaskDateTime = taskDateTime,
                EstimatedDuration = taskLength,
                Species = specie,
                Animal = animal,
                Repetitive = repetitive
            };
            if (animal != null)
            {
                ZooTaskDTO zooTaskDTO = new ZooTaskDTO(newTask.Name, newTask.Description, newTask.TaskDateTime, newTask.EstimatedDuration, newTask.Species, newTask.EnclosureArea, newTask.EnclosureNumber, newTask.Status, newTask.Animal.Id, newTask.Repetitive);
                taskRepository.AddTask(zooTaskDTO);
            }
            else
            {
                ZooTaskDTO zooTaskDTO = new ZooTaskDTO(newTask.Name, newTask.Description, newTask.TaskDateTime, newTask.EstimatedDuration, newTask.Species, newTask.EnclosureArea, newTask.EnclosureNumber, newTask.Status, null, newTask.Repetitive);
                taskRepository.AddTask(zooTaskDTO);
            }
        }
    
        public void ScheduleTaskDaily(string name, string enclosureArea, int enclosureNo, string description, DateTime taskDateTime, int taskLength, string specie, Animal? animal, string repetitive)
        {

            ZooTask newTask = new ZooTask()
            {
                Name = name,
                Description = description,
                EnclosureArea = enclosureArea,
                EnclosureNumber = enclosureNo,
                Status = "Not started",
                TaskDateTime = taskDateTime,
                EstimatedDuration = taskLength,
                Species = specie,
                Animal = animal,
                Repetitive = repetitive
            };
            for (int index = 0; index < 7; index++)
            {
                if (animal != null)
                {
                    ZooTaskDTO zooTaskDTO = new ZooTaskDTO(newTask.Name, newTask.Description, newTask.TaskDateTime, newTask.EstimatedDuration, newTask.Species, newTask.EnclosureArea, newTask.EnclosureNumber, newTask.Status, newTask.Animal.Id, newTask.Repetitive);
                    taskRepository.AddTask(zooTaskDTO);
                }
                else
                {
                    ZooTaskDTO zooTaskDTO = new ZooTaskDTO(newTask.Name, newTask.Description, newTask.TaskDateTime, newTask.EstimatedDuration, newTask.Species, newTask.EnclosureArea, newTask.EnclosureNumber, newTask.Status, null, newTask.Repetitive);
                    taskRepository.AddTask(zooTaskDTO);
                }

                newTask.TaskDateTime = newTask.TaskDateTime.AddDays(1);
            }

        }

        public void RemoveTaskByID(int id)
        {
            tasks.RemoveAt(tasks.FindIndex(f => f.ID == id));
/*            foreach (ZooTask task in tasks)
            {
                if (task.ID == id && task.Status == "Not started")
                {
                    tasks.Remove(task);
                }
            }*/
        }

        
        public Employee[] GetTaskEmployees(int taskID)
        {
            List<Employee> employees = new List<Employee>();
            EmployeeDTO[] employeeDTOs = employeeRepository.GetEmployeesByTask(taskID);
            foreach (EmployeeDTO employeeDTO in employeeDTOs)
            {
                Employee employee = EmployeeEntityMapping.ToEmployee(employeeDTO);
                employees.Add(employee);
            }

            return employees.ToArray();
        }

        public ZooTask[] GetTasks()
        {
            List<ZooTask> foundTasks = new List<ZooTask>();
            foreach(ZooTaskDTO taskDto in taskRepository.GetAllTasks())
            {
                if (taskDto.AnimalID == null)
                {
                    ZooTask task = new ZooTask(
                        taskDto.ID,
                        taskDto.Name,
                        taskDto.Description,
                        taskDto.EnclosureArea,
                        taskDto.EnclosureNumber,
                        taskDto.TaskDateTime,
                        taskDto.EstimatedDuration,
                        taskDto.Status,
                        taskDto.Species,
                        null
                    );
                    foundTasks.Add(task);
                }
                else
                {
                    ZooTask task = new ZooTask(
                        taskDto.ID,
                        taskDto.Name,
                        taskDto.Description,
                        taskDto.EnclosureArea,
                        taskDto.EnclosureNumber,
                        taskDto.TaskDateTime,
                        taskDto.EstimatedDuration,
                        taskDto.Status,
                        taskDto.Species,
                        AnimalEntityMapping.DTOToAnimal(animalRepository.GetAnimalByID((int)taskDto.AnimalID)!)
                    );
                    foundTasks.Add(task );
                }
            }

            return foundTasks.ToArray();
        }

        public ZooTask[] GetRepetitiveTasks(string repetitiveness)
        {
            List<ZooTask> foundTasks = new List<ZooTask>();

            switch (repetitiveness) 
            {
                case "Daily":
                    foreach (ZooTaskDTO taskdto in taskRepository.GetDailyTasks())
                    {
                        if (taskdto.AnimalID == null)
                            foundTasks.Add(new ZooTask(taskdto.ID,
                                                       taskdto.Name,
                                                       taskdto.Description,
                                                       taskdto.EnclosureArea,
                                                       taskdto.EnclosureNumber,
                                                       taskdto.TaskDateTime,
                                                       taskdto.EstimatedDuration,
                                                       taskdto.Status,
                                                       taskdto.Species,
                                                       null,
                                                       taskdto.Repetitive));
                        else
                            foundTasks.Add(new ZooTask(taskdto.ID,
                                                       taskdto.Name,
                                                       taskdto.Description,
                                                       taskdto.EnclosureArea,
                                                       taskdto.EnclosureNumber,
                                                       taskdto.TaskDateTime,
                                                       taskdto.EstimatedDuration,
                                                       taskdto.Status,
                                                       taskdto.Species,
                                                       animalRepository.GetAnimalByID((int)taskdto.AnimalID)!.DTOToAnimal(),
                                                       taskdto.Repetitive));
                    }
                    break;
                case "Weekly":
                    foreach (ZooTaskDTO taskdto in taskRepository.GetWeeklyTasks())
                    {
                        if (taskdto.AnimalID == null)
                            foundTasks.Add(new ZooTask(taskdto.ID,
                                                       taskdto.Name,
                                                       taskdto.Description,
                                                       taskdto.EnclosureArea,
                                                       taskdto.EnclosureNumber,
                                                       taskdto.TaskDateTime,
                                                       taskdto.EstimatedDuration,
                                                       taskdto.Status,
                                                       taskdto.Species,
                                                       null,
                                                       taskdto.Repetitive));
                        else
                            foundTasks.Add(new ZooTask(taskdto.ID,
                                                       taskdto.Name,
                                                       taskdto.Description,
                                                       taskdto.EnclosureArea,
                                                       taskdto.EnclosureNumber,
                                                       taskdto.TaskDateTime,
                                                       taskdto.EstimatedDuration,
                                                       taskdto.Status,
                                                       taskdto.Species,
                                                       animalRepository.GetAnimalByID((int)taskdto.AnimalID)!.DTOToAnimal(),
                                                       taskdto.Repetitive));
                    }
                    break;
            }
            return foundTasks.ToArray();


        }

        public ZooTask GetTask(int id)
        {
            ZooTaskDTO taskDto = taskRepository.GetTask(id);

            Animal? animal = null;
            if (taskDto.AnimalID != null)
                animal = animalRepository.GetAnimalByID((int)taskDto.AnimalID)!.DTOToAnimal();
            ZooTask task = new ZooTask(taskDto.ID, taskDto.Name, taskDto.Description, taskDto.EnclosureArea, taskDto.EnclosureNumber, taskDto.TaskDateTime, taskDto.EstimatedDuration, taskDto.Status, taskDto.Species, animal);
            return task;
        }

        public ZooTask[] GetTasksByCaretaker(int employeeID, DateTime taskDate)
        {
            List<ZooTask> foundTasks = new List<ZooTask>();
            foreach (ZooTask task in tasks)
            {
                if (task.GetAssignedEmployee(employeeID) != null && taskDate.Date == task.TaskDateTime.Date)
                {
                    foundTasks.Add(task);
                }
            }
            return foundTasks.ToArray();
        }

        public ZooTask[] GetTasksByCaretaker(int employeeID)
        {
            List<ZooTask> foundTasks = new List<ZooTask>();
            foreach (ZooTaskDTO taskDto in taskRepository.GetTasksByCaretaker(employeeID))
            {
                Animal? animal;
                if (taskDto.AnimalID == null)
                    animal = null;
                else
                    animal = AnimalEntityMapping.DTOToAnimal(animalRepository.GetAnimalByID((int)taskDto.AnimalID));

                ZooTask task = new ZooTask(taskDto.ID, taskDto.Name, taskDto.Description, taskDto.EnclosureArea, taskDto.EnclosureNumber, taskDto.TaskDateTime, taskDto.EstimatedDuration, taskDto.Status, taskDto.Species, animal); 

                foundTasks.Add(task);
            }
            return foundTasks.ToArray();
        }
        public bool CheckEmployeeAvailability(ZooTask task, Employee employee)
        {
            // taskStartHour, taskEndHour is task times that New/existing which does not have caretakers assigned.
            int newTaskStartHour = task.TaskDateTime.Hour;
            int newTaskStartDay = task.TaskDateTime.DayOfYear;
            int newTaskEndHour = newTaskStartHour + (int)task.EstimatedDuration;

            ZooTask[] employeeTasks = GetTasksByCaretaker(employee.ID);
            foreach (ZooTask empTask in employeeTasks)
            {
                if (newTaskStartDay != empTask.TaskDateTime.DayOfYear)
                    continue;

                if (empTask.TaskDateTime.Hour < newTaskStartHour)
                {
                    if (empTask.TaskDateTime.Hour + empTask.EstimatedDuration > newTaskStartHour)
                        return false;
                }
                else if (empTask.TaskDateTime.Hour == newTaskEndHour)
                {
                    if (empTask.TaskDateTime.Minute + empTask.EstimatedDuration <= newTaskStartHour * 60)
                    {
                        return false;
                    }
                }
                else if (empTask.TaskDateTime.Hour >= newTaskEndHour)
                {
                    continue;
                }
                else return false;
            }
            return true;
        }
        public void UpdateTaskStatus(int taskId, string status)
        {
            taskRepository.UpdateTaskStatus(status, taskId);
        }

        public void AssignEmployee(ZooTask task, Employee employee)
        {
            if (task.Status == "Not started")
                taskRepository.AssignEmployee(employee.ID, task.ID);
        }
        public void RemoveTask(int taskId)
        {
            taskRepository.RemoveTask(taskId);
        }

        public void RescheduleTasks(ZooTask[] repetitiveTasks, DateTime weekStartDay, int counter)
        {
            foreach (ZooTask task in repetitiveTasks)
            {
                
                if (task.Repetitive == "Daily")
                {
                    int taskHour = task.TaskDateTime.Hour;
                    int taskMinute = task.TaskDateTime.Minute;
                    task.TaskDateTime = new DateTime(weekStartDay.Year, weekStartDay.Month, weekStartDay.Day, taskHour, taskMinute, 0);
                    ScheduleTaskDaily(task.Name, task.EnclosureArea, task.EnclosureNumber, task.Description, task.TaskDateTime, task.EstimatedDuration, task.Species, task.Animal, task.Repetitive);
                }
                else if (task.Repetitive == "Weekly")
                {
                    task.TaskDateTime = task.TaskDateTime.AddDays(7 * (counter));
                    ScheduleTask(task.Name, task.EnclosureArea, task.EnclosureNumber, task.Description, task.TaskDateTime, task.EstimatedDuration, task.Species, task.Animal, task.Repetitive);
                }
            }
        }


        public void CompleteTask(ZooTask task)
        {
            task.Status = "Finished";
        }
    }
}
