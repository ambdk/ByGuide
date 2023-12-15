
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
        public void AddExperience(Experience experience)
        {
            experience.Id = GenerateUniqueId();
            _experiences.Add(experience);
        }

        public Experience GetExperience(int id)
        {
            foreach (Experience experience in _experiences)
            {
                if (experience.Id == id)
                {
                    return experience;
                }
            }

            return null;
        }

        public List<Experience> GetExperiences()
        {
            return _experiences;
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
        
        public void UpdateExperience(Experience experience)
        {
            if (experience != null)
            {
                foreach (Experience e in _experiences)
                {
                    if (e.Id == experience.Id)
                    {
                        e.Title = experience.Title;
                        e.Description = experience.Description;
                        e.Category = experience.Category;
                        e.AdmissionPrice = experience.AdmissionPrice;
                        e.Address = experience.Address;
                        e.ExternalLink = experience.ExternalLink;
                        e.HandicapAccesible = experience.HandicapAccesible;
                        e.ImageURL = experience.ImageURL;
                        e.OpeningHours = experience.OpeningHours;
                    }
                }
            }
        }

        public Experience DeleteExperience(int? id)
        {
            foreach (Experience experience in _experiences)
            {
                if (experience.Id == id)
                {
                    _experiences.Remove(experience);
                    return experience;
                }
            }

            return null;
        }
        #endregion

        #region Helper Methods
        private int GenerateUniqueId()
        {
            int maxId = 0;
            foreach (Experience existingExperience in _experiences)
            {
                if (existingExperience.Id.HasValue && existingExperience.Id.Value > maxId)
                {
                    maxId = existingExperience.Id.Value;
                }
            }
            return maxId + 1;
        }
        #endregion
    }
}