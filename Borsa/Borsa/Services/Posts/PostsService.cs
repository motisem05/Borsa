using Borsa.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Borsa.Services.Posts
{
    public class PostsService : IPostsService
    {
        private readonly AppDbContext _db;

        public PostsService(AppDbContext db)
        {
            _db = db;
        }

        async Task<Entities.Posts> IPostsService.Delete(int id)
        {
            var delete = await _db.Posts.FindAsync(id);
            _db.Posts.Remove(delete);
            _db.SaveChanges();
            return delete;
        }

        void IPostsService.DeleteAll()
        {
            foreach (var entity in _db.Posts)
                _db.Posts.Remove(entity);
                _db.SaveChanges();
                
        }

        async Task<List<Entities.Posts>> IPostsService.Get()
        {
            var Posts = await _db.Posts.ToListAsync();
            return Posts;
            
        }

        public async Task<Entities.Posts> Get(int id)
        {
            var Post = await _db.Posts.FindAsync(id);
            return Post;
        }

        async Task<Entities.Posts> IPostsService.Insert(PostsModel Post)
        {
            var post = new Entities.Posts
            {
                Id = Post.Id,
                UserId = Post.UserId,
                Title = Post.Title,
                Content = Post.Content,
                Date = DateTime.Now
            };
            _db.Posts.AddAsync(post);
            await _db.SaveChangesAsync();
            return post;
        }

       async Task<Entities.Posts> IPostsService.Update(PostsModel Post)
        {
            var oldPost = await _db.Posts.FindAsync(Post.Id);
            if (oldPost ==  null) {
                return null; 
            }
            if (Post == null)
            {
                return null;
            }
                var post = new Entities.Posts
                {
                    Id = Post.Id,
                    UserId = Post.UserId,
                    Title = Post.Title,
                    Content = Post.Content,
                    LastModified = DateTime.Now

                };
                _db.Posts.Entry(oldPost).CurrentValues.SetValues(post);
                await _db.SaveChangesAsync();
                return post;

        }
    }
}
