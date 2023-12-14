
// By: Jesper Højlund

using ByGuide.MockData;
using ByGuide.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Experience
{
    public class GetAllExperiencesModel : PageModel
    {
        #region Properties
        public List<Models.Experience>? Experiences { get; private set; }
        #endregion

        #region Methods
        public void OnGet()
        {
            Experiences = MockExperiences.GetMockExperiences();
        }
        #endregion
    }
}