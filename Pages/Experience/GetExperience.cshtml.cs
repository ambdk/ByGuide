
// By: Jesper Højlund

using ByGuide.Models;
using ByGuide.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Experience
{
    public class GetExperienceModel : PageModel
    {
        #region Instance Fields
        private IExperienceService _experienceService;
        #endregion

        #region Constructor
        public GetExperienceModel(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        #endregion

        #region Properties
        public Models.Experience? Experience { get; private set; }

        [BindProperty(SupportsGet = true)]
        public int ExperienceId { get; set; }
        #endregion

        #region Methods
        public IActionResult OnGet(int experienceId)
        {
            ExperienceId = experienceId;
            Experience = _experienceService.GetExperience(ExperienceId);

            if (Experience == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
        #endregion
    }
}
