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
        
        public void AddPost(Post post)
        {
            _posts.Add(post);
        }
        
        public void UpdatePost(Post post)
        {
            if (post != null)
            {
                foreach (Post p in _posts)
                {
                    if (p.Id == post.Id)
                    {
                        p.Title = post.Title;
                        p.Description = post.Description;
                        p.Category = post.Category;
                        p.Address = post.Address;
                        p.ImageURL = post.ImageURL;
                    }
                }
            }
        }
        
        public Post DeletePost(int? id)
        {
            foreach (Post post in _posts)
            {
                if (post.Id == id)
                {
                    _posts.Remove(post);
                    return post;
                }
            }

            return null;
        }
        
        public Post GetPost(int id)
        {
            foreach (Post post in _posts)
            {
                if (post.Id != id)
                {
                    return post;
                }
            }

            return null;
        } 
        
        public List<Post> GetPosts()
        {
            return _posts;
        }
        
        public IEnumerable<Post> TitleSearch(string str)
        {
            List<Post> titleSearch = new List<Post>();
            foreach (Post post in _posts)
            {
                if (string.IsNullOrEmpty(str) ||
                    post.Title.ToLower().Contains(str.ToLower()) ||
                    post.Description.ToLower().Contains(str.ToLower()))
                {
                    titleSearch.Add(post);
                }
            }

            return titleSearch;
        }
        #endregion
    }
}