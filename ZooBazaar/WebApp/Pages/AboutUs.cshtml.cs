using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Pages
{
    public class AboutUsModel : PageModel
    {
        Statistics statistics = new Statistics();

        [BindProperty]
        public Statistics Stats { get; set; }
        public void OnGet()
        {
        }

        public int GetTotalAnimals()
        {
            return statistics.TotalAnimals();
        }

        public int GetTotalSpecies()
        {
            return statistics.TotalSpecies();
        }

        public int GetCurrentVisitors()
        {
            return statistics.CurrentVisitors();
        }

        public int GetTotalEmployees()
        {
            return statistics.TotalEmployees();
        }
    }
}
