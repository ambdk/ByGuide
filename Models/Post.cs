
namespace ByGuide.Models
{
	public class Post
	{
		#region Default Constructor
		public Post()
		{
		}
		#endregion

		#region Constructor
		public Post(int id, string title, string description, string category, string address, string? imageURL = null)
		{
            Id = id;
            Title = title;
			Description = description;
			Category = category;
			Address = address;
			ImageURL = imageURL;
		}
		#endregion

		#region Properties
		public int? Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? Category { get; set; }
		public string? Address { get; set; }
		public string? ImageURL { get; set; }
		#endregion
	}
}
