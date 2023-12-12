// By: Jesper Højlund
// Simple static class to be used in razorviews to ensure and validate categories.

namespace ByGuide.Service
{
    public static class Categories
    {
        public static readonly List<string> AllowedCategories = new List<string>
        {
            "Kultur og Historie",
            "Natur og Rekreation",
            "Mad og Drikke",
            "Begivenheder og Aktiviteter",
            "Shopping og Handel"
        };
    }
}
