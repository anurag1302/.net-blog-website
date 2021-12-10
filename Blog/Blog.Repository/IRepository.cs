using Blog.Database.Domain;
using System.Collections.Generic;

namespace Blog.Repository
{
    public interface IRepository
    {
        Post GetPostById(int id);
        List<Post> GetAllPosts();
        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int id);
    }
}
