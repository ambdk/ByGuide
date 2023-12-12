// By: Jesper Højlund
// Description: This file contains the PostService class, responsible for managing
// Post objects in the ByGuide application. It handles adding, updating, deleting,
// and retrieving posts, and integrates with JsonFilePostService for JSON-based data
// storage and retrieval.


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
            _posts.Add(post);
            JsonFilePostService.SaveJsonPosts(_posts);
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
        #endregion
    }
}