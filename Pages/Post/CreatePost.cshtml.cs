// By: Jesper Højlund
// Description: Model for creating new posts. It facilitates the creation of a post,
// handling form submission and validation. Upon successful submission, it adds the new
// post using IPostService and redirects to the "GetAllPosts" page.

using ByGuide.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Post
{
    public class CreatePostModel : PageModel
    {
        #region Instance Fields
        private IPostService _postService;
        #endregion

        #region Constructor
        public CreatePostModel(IPostService postService)
        {
            _postService = postService;
        }
        #endregion

        #region Properties
        [BindProperty]
        public Models.Post Post { get; set; }
        #endregion

        #region Methods
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _postService.AddPost(Post);
            return RedirectToPage("GetAllPosts");
        }
        #endregion
    }
}
