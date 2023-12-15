
// By: Jesper Højlund

using ByGuide.MockData;
using ByGuide.Models;

namespace ByGuide.Service
{
    public class ExperienceService : IExperienceService
    {
        #region Instance Fields
        private List<Experience> _experiences;
        #endregion

        #region Constructor
        public ExperienceService()
        {
            _experiences = MockExperiences.GetMockExperiences();
        }
        #endregion

        #region Methods
        public List<Experience> GetItems()
        {
            return _experiences;
        }

        public void AddExperience(Experience experience)
        {
            _experiences.Add(experience);
        }

        public IEnumerable<Experience> Search(string str)
        {
            List<Experience> searchResults = new List<Experience>();
            foreach (Experience experience in _experiences)
            {
                if (string.IsNullOrEmpty(str) ||
                    experience.Title.ToLower().Contains(str.ToLower()) ||
                    experience.Description.ToLower().Contains(str.ToLower()))
                {
                    searchResults.Add(experience);
                }
            }

            return searchResults;
        }

        public IEnumerable<Experience> Filter(int MaxPrice, int minPrice = 0, string? category = null)
        {
            List<Experience> filterList = new List<Experience>();
            foreach (Experience experience in _experiences)
            {
                bool priceCondition = (minPrice == 0 && experience.AdmissionPrice <= MaxPrice) ||
                    (MaxPrice == 0 && experience.AdmissionPrice >= minPrice) ||
                    (experience.AdmissionPrice >= minPrice && experience.AdmissionPrice <= MaxPrice);

                bool categoryCondition = string.IsNullOrEmpty(category) ||
                    experience.Category == category;

                if (priceCondition && categoryCondition)
                {
                    filterList.Add(experience);
                }
            }

            return filterList;
        }
        #endregion
    }
}