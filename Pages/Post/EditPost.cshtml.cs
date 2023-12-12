// By: Jesper Højlund
// Description: This class provides the functionality for editing a post. It loads the
// post details for editing and handles post updates on form submission, leveraging
// IPostService. If the post is not found, it redirects to a "NotFound" page.

using ByGuide.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Post
{
    public class EditPostModel : PageModel
    {
        #region Instance Fields
        private IPostService _postService;
        #endregion

        #region Constructor
        public EditPostModel(IPostService postService)
        {
            _postService = postService;
        }
        #endregion

        #region Properties
        [BindProperty]
        public Models.Post Post { get; set; }
        #endregion

        #region Methods
        public IActionResult OnGet(int id)
        {
            Post = _postService.GetPost(id);
            if (Post == null)
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

            _postService.UpdatePost(Post);
            return RedirectToPage("GetAllPosts");
        }
        #endregion
    }
}
