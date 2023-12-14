
// By: Jesper Højlund

using ByGuide.Models;

namespace ByGuide.Service
{
    public interface IExperienceService
    {
        #region Methods
        List<Experience> GetItems();
        #endregion
    }
}
