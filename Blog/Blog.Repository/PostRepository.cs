using Blog.Database;
using Blog.Database.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public class PostRepository : IRepository
    {
        private readonly AppDbContext _context;

        public PostRepository(AppDbContext context)
        {
            _context = context;
        }
        public async void AddPost(Post post)
        {
            _context.Posts.Add(post);
            await SaveChangesAsync();
        }

        public async void DeletePost(int id)
        {
            _context.Posts.Remove(GetPostById(id));
            await SaveChangesAsync();
        }

        public List<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public Post GetPostById(int id)
        {
            return _context.Posts.Where(x => x.Id == id).FirstOrDefault();
        }

        public async void UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
