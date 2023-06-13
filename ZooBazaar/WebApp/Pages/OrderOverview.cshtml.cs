using BusinessLogic.Tickets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Text.Json;

namespace WebApp.Pages
{
    public class OrderOverviewModel : PageModel
    {
        public void OnGet()
        {
            if (TempData.ContainsKey("Order"))
            {
                TicketOrder order = JsonSerializer.Deserialize<TicketOrder>(TempData["Order"].ToString())!;
            }
        }
    }
}
