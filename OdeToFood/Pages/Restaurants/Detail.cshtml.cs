using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurantData restauranData;

        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData restauranData)
        {
            this.restauranData = restauranData;
        }

        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restauranData.GetRestaurantById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}