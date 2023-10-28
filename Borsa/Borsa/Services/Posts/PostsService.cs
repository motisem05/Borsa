using Borsa.ViewModels;

namespace Borsa.Services.Posts
{
    public class PostsService : IPostsService
    {
        private readonly AppDbContext _context;

        public PostsService(AppDbContext context)
        {
            _context = context;
        }

        Task<Entities.Posts> IPostsService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<Entities.Posts> IPostsService.DeleteAll()
        {
            throw new NotImplementedException();
        }

        Task<Entities.Posts> IPostsService.Get()
        {
            throw new NotImplementedException();
        }

        public async Task<Entities.Posts> Get(int id)
        {
            var Post = await _context.Posts.FindAsync(id);
            return Post;
        }

        Task<Entities.Posts> IPostsService.Insert(PostsModel Post)
        {
            throw new NotImplementedException();
        }

        Task<Entities.Posts> IPostsService.Update(PostsModel Post)
        {
            throw new NotImplementedException();
        }
    }
}
