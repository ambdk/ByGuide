// By: Jesper Højlund
// Description: The Post class represents a post entity with properties for ID, title,
// description, category, address, and image URL. It includes validation annotations
// to ensure required fields are correctly populated, and a range check for the ID.
// This class serves as the data structure for post-related operations within the
// application.

using System.ComponentModel.DataAnnotations;

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
		[Display(Name = "Post Id")]
		[Required(ErrorMessage = "Der skal angives et ID til en post")]
		[Range(typeof(int), "1", "10000", ErrorMessage = "Id skal være mellem (1) og (2)")]
		public int? Id { get; set; }

		[Display(Name = "Titel")]
		[Required(ErrorMessage = "Indlægget skal have en titel")]
		public string? Title { get; set; }

		[Display(Name = "Beskrivelse")]
		[Required(ErrorMessage = "Der skal være en beskrivelse")]
		public string? Description { get; set; }

		[Display(Name = "Kategori")]
		[Required(ErrorMessage = "Der skal angives en kategori")]
		public string? Category { get; set; }

		[Display(Name = "Adresse")]
		[Required(ErrorMessage = "Angiv venligst en adresse eller lokation")]
		public string? Address { get; set; }

		[Display(Name = "Billed URL")]
		public string? ImageURL { get; set; }
		#endregion
	}
}
