
// By: Jesper Højlund

using ByGuide.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Experience
{
    public class CreateExperienceModel : PageModel
    {
        #region Instance Fields
        private IExperienceService _experienceService;
        #endregion

        #region Constructor
        public CreateExperienceModel(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        #endregion
        [BindProperty]
        public Models.Experience Experience { get; set; }
        #region Properties

        #endregion

        #region Methods
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Converts the openingshours from the razor view, into a dict so it follows the model class.
            var openingHours = new Dictionary<string, string>();
            foreach (var day in new[] { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag", "Søndag" })
            {
                string? hours = Request.Form["OpeningHours[" + day + "]"];
                if (!string.IsNullOrEmpty(hours))
                {
                    openingHours.Add(day, hours);
                }
            }

            Experience.OpeningHours = openingHours;

            _experienceService.AddExperience(Experience);
            return RedirectToPage("GetAllExperiences");
        }
        #endregion

    }
}
