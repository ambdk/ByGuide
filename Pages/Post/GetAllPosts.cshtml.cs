using ByGuide.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ByGuide.Pages.Post
{
    public class GetAllPostsModel : PageModel
    {
        #region Instance Fields
        private IPostService _postService;
        #endregion

        #region Constructor
        public GetAllPostsModel(IPostService postService)
        {
            _postService = postService;
        }
        #endregion

        #region Properties
        public List<Models.Post>? Posts { get; private set; }
        #endregion

        #region Methods
        public void OnGet()
        {
            Posts = _postService.GetPosts();
        }
        #endregion
    }
}
