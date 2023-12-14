
// By: Jesper Højlund

using ByGuide.MockData;
using ByGuide.Models;
using ByGuide.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Experience
{
    public class GetAllExperiencesModel : PageModel
    {
        #region Instance Fields
        private IExperienceService _experienceService;
        #endregion

        public GetAllExperiencesModel(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        #region Properties
        public List<Models.Experience>? Experiences { get; private set; }
        #endregion

        #region Methods
        public void OnGet()
        {
            Experiences = _experienceService.GetItems();
        }
        #endregion
    }
}