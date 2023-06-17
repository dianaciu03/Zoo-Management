using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Statistics
    {
        StatisticsRepository StatisticsRepository;

        public Statistics() 
        {
            StatisticsRepository = new StatisticsRepository();
        }

        public int TotalEmployees()
        {
            return StatisticsRepository.TotalEmployees();
        }

        public int TotalAnimals()
        {
            return StatisticsRepository.TotalAnimals();
        }

        public int TotalSpecies()
        {
            return StatisticsRepository.TotalSpecies();
        }

        public int CurrentVisitors()
        {
            return StatisticsRepository.CurrentVisitors();
        }

        public int TotalVisitorsOnGivenDay(DateTime date)
        {
            return StatisticsRepository.TotalVisitorsOnGivenDay(date);
        }
    }
}
