using ByGuide.MockData;
using ByGuide.Models;

namespace ByGuide.Service
{
    public class PostService : IPostService
    {
        #region Instance Fields
        private List<Post> _posts;
        #endregion

        #region Constructor
        public PostService()
        {
            _posts = MockPosts.GetMockPosts();
        }
        #endregion

        #region Methods
        public List<Post> GetPosts()
        {
            return _posts;
        }

        public void AddPost(Post post)
        {
            _posts.Add(post);
        }
        #endregion
    }
}
