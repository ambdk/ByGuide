using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TuristInfoV1.Services;

namespace TuristInfoV1.Pages.Tursit
{
	public class GetAllTuristsModel : PageModel
	{
		#region Instance Fields
		private ITuristService _turistService;
		#endregion

		#region Constructor
		public GetAllTuristsModel(ITuristService turistService)
		{
			_turistService = turistService;
		}
		#endregion

		#region Properties
		public List<Models.Turist>? Turists { get; private set; }

		[BindProperty]
		public string SearchString { get; set; }
		#endregion

		#region Methods
		public void OnGet()
		{
			Turists = _turistService.GetTurists();
		}

		public IActionResult OnPostTitleSearch()
		{
			Turists = _turistService.TuristSearch(SearchString).ToList();
			return Page();
		}
		#endregion
	}
}
