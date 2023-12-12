// By: Jesper Højlund
// Description: Defines an interface for post management services in the
// ByGuide application. It declares methods for adding, updating, deleting, and retrieving
// Post objects, as well as a title search functionality. This interface is key for
// implementing consistent post handling across different service implementations.

using ByGuide.Models;

namespace ByGuide.Service
{
    public interface IPostService
    {
        #region Methods
        void AddPost(Post post);
        void UpdatePost(Post post);
        Post DeletePost(int? id);
        Post GetPost(int Id);
        List<Post> GetPosts();
        IEnumerable<Post> TitleSearch(string title);
        #endregion



    }
}
