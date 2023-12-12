// By: Jesper Højlund
// Description: Handles the display of a single post. It uses IPostService to retrieve the 
// post details based on the provided id.

using ByGuide.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Post
{
    public class GetPostModel : PageModel
    {
        #region Instance Fields
        private IPostService _postService;
        #endregion

        #region Constructor
        public GetPostModel(IPostService postService)
        {
            _postService = postService;
        }
        #endregion

        #region Properties
        public Models.Post? Post { get; private set; }

        [BindProperty(SupportsGet = true)]
        public int PostId { get; set; }
        #endregion

        #region Methods
        public IActionResult OnGet()
        {
            Post = _postService.GetPost(PostId);

            if (Post == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
        #endregion
    }
}
