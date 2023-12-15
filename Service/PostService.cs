
// By: Jesper Højlund

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
        public PostService(JsonFilePostService jsonFilePostService)
        {
            JsonFilePostService = jsonFilePostService;
            _posts = JsonFilePostService.GetJsonPosts().ToList();
            //_posts = MockPosts.GetMockPosts();
        }
        #endregion

        #region Properties
        private JsonFilePostService JsonFilePostService { get; set; }
        #endregion

        #region Methods
        public void AddPost(Post post)
        {
            post.Id = GenerateUniqueId();
            _posts.Add(post);
            JsonFilePostService.SaveJsonPosts(_posts);
        }

        public Post GetPost(int id)
        {
            foreach (Post post in _posts)
            {
                if (post.Id == id)
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

                JsonFilePostService.SaveJsonPosts(_posts);
            }
        }
        
        public Post DeletePost(int? id)
        {
            Post? postToBeDeleted = null;
            foreach (Post post in _posts)
            {
                if (post.Id == id)
                {
                    postToBeDeleted = post;
                    break;
                }
            }

            if (postToBeDeleted != null)
            {
                _posts.Remove(postToBeDeleted);
                JsonFilePostService.SaveJsonPosts(_posts);
            }

            return postToBeDeleted;
        }
        #endregion

        #region Helper Methods
        private int GenerateUniqueId()
        {
            int maxId = 0;
            foreach (Post existingPost in _posts)
            {
                if (existingPost.Id.HasValue && existingPost.Id.Value > maxId)
                {
                    maxId = existingPost.Id.Value;
                }
            }
            return maxId + 1;
        }
        #endregion
    }
}