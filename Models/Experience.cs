
// By: Jesper Højlund

namespace ByGuide.Models
{
    public class Experience
    {
        #region Properties
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public int AdmissionPrice { get; set; }
        public string? Address { get; set; }
        public string? ExternalLink { get; set; }
        public bool HandicapAccesible { get; set; }
        public string? ImageURL { get; set; }
        public Dictionary<string, string>? OpeningHours { get; set; }
        #endregion

        #region Constructors
        public Experience()
        {
        }

        public Experience(int id, string? title, string? description, string? category, int admissionPrice, string? address, string? externalLink, bool handicapAccesible, string? imageURL, Dictionary<string, string>? openingHours)
        {
            Id = id;
            Title = title;
            Description = description;
            Category = category;
            AdmissionPrice = admissionPrice;
            Address = address;
            ExternalLink = externalLink;
            HandicapAccesible = handicapAccesible;
            ImageURL = imageURL;
            OpeningHours = openingHours;
        }
        #endregion
    }
}
