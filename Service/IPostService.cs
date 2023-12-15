﻿
// By: Jesper Højlund

using ByGuide.Models;

namespace ByGuide.Service
{
    public interface IPostService
    {
        #region Methods
        void AddPost(Post post);
        Post GetPost(int Id);
        List<Post> GetPosts();
        IEnumerable<Post> TitleSearch(string title);
        void UpdatePost(Post post);
        Post DeletePost(int? id);
        #endregion
    }
}
