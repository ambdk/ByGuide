
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
        #endregion
    }
}