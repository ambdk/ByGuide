using ByGuide.Models;

namespace ByGuide.Service
{
    public interface IPostService
    {
        List<Post> GetPosts();
        void AddPost(Post post);
    }
}
