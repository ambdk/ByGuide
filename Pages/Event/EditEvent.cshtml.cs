using ByGuide.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Event
{
	public class EditEventModel : PageModel
	{

		#region Instance Fields
		private IEventService _eventService;
		#endregion

		#region Constructor
		public EditEventModel(IEventService eventService)
		{
			_eventService = eventService;
		}
		#endregion

		#region Properties
		[BindProperty]
		public Models.Event Event { get; set; }
		#endregion

		#region Methods
		public IActionResult OnGet(string name)
		{
			Event = _eventService.GetEvent(name);
			if (Event == null)
			{
				return RedirectToPage("/NotFound");
			}

			return Page();
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_eventService.UpdateEvent(Event);
			return RedirectToPage("GetAllEvents");
		}
		#endregion
	}
}