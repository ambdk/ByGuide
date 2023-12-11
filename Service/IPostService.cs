using ByGuide.Models;

namespace ByGuide.Service
{
    public interface IPostService
    {
        void AddPost(Post post);
        void UpdatePost(Post post);
        Post DeletePost(int? id);
        Post GetPost(int Id);
        List<Post> GetPosts();
        IEnumerable<Post> TitleSearch(string title);
        
        
    }
}
