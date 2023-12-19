using System.ComponentModel.DataAnnotations;

namespace ByGuide.Models
{
	public class Event
	{

		public Event()
		{
		}
        // Constructor
        public Event(string name, decimal price, List<DateTime> datetimeList, Uri externalLink, bool handicapAccessible)
        {
            Name = name;
            Price = price;
            DatetimeList = datetimeList;
            ExternalLink = externalLink;
            HandicapAccessible = handicapAccessible;

        }

        [Display(Name = "Pris for begivenheden")]
		[Required(ErrorMessage = "Begivenheden skal have en pris")]
		[Range(typeof(decimal), "0.01", "1000000", ErrorMessage = "Prisen skal være mellem (0.01) og (1000000)")]
		public decimal Price { get; set; }

		[Display(Name = "Dato og tid for begivenheden")]
		[Required(ErrorMessage = "Begivenheden skal have en dato og tid")]
		public List<DateTime> DatetimeList { get; set; }

		[Display(Name = "Ekstern link for begivenheden")]
		[Required(ErrorMessage = "Begivenheden skal have et eksternt link")]
		[Url(ErrorMessage = "Indtast en gyldig URL")]
		public Uri ExternalLink { get; set; }

		[Display(Name = "Handicap-tilgængelig for begivenheden")]
		[Required(ErrorMessage = "Angiv om begivenheden er handicap-tilgængelig")]
		public bool HandicapAccessible { get; set; }

		public string Name { get; internal set; }

	}
}
