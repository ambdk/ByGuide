
// By: Jesper Højlund

using ByGuide.Models;

namespace ByGuide.Service
{
    public interface IExperienceService
    {
        #region Methods
        List<Experience> GetItems();
        void AddExperience(Experience experience);
        IEnumerable<Experience> Search(string str);
        IEnumerable<Experience> Filter(int maxPrice, int minPrice = 0,string? category = null);
        #endregion
    }
}
