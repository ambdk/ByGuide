using ByGuide.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Post
{
    public class DeletePostModel : PageModel
    {
        #region Instance Fields
        private IPostService _postService;
        #endregion

        #region Constructor
        public DeletePostModel(IPostService postService)
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
            Models.Post deletedPost = _postService.DeletePost(Post.Id);
            if (deletedPost == null)
            {
                return RedirectToPage("/NotFound");
            }

            return RedirectToPage("GetAllPosts");
        }
        #endregion
    }
}
